using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubIssueMover
{
    public static class IssueMover
    {
        private static GitHubClient GetGitHubClient(string repoUrl, string header, string token)
        {
            Uri _uri = new Uri(repoUrl);
            var client = new GitHubClient(new ProductHeaderValue(header), _uri);
            client.Credentials = new Credentials(token);

            return client;
        }

        public static async void StartMoving()
        {
            var settings = Properties.Settings.Default;

            if (settings.CopyMilestones)
                await MoveMilestones();

            if (settings.CopyLabels)
                await MoveLabels();

            if (settings.CopyIssues)
                await MoveIssues();
        }

        public static async Task MoveMilestones()
        {
            var settings = Properties.Settings.Default;
            var client = GetGitHubClient(settings.SourceUrl, settings.SourceName, settings.SourceToken);
            var targetClient = GetGitHubClient(settings.TargetUrl, settings.TargetName, settings.TargetToken);
            var milestones = await client.Issue.Milestone.GetAllForRepository(settings.SourceOwner, settings.SourceName, new MilestoneRequest { State = ItemStateFilter.All });
            var targetMilestones = await targetClient.Issue.Milestone.GetAllForRepository(settings.TargetOwner, settings.TargetName, new MilestoneRequest { State = ItemStateFilter.All });

            foreach (var milestone in milestones)
            {
                var target = targetMilestones.Where(x => x.Title == milestone.Title).FirstOrDefault();

                if (target == null) 
                {
                    var newMilestone = new NewMilestone(milestone.Title);
                    newMilestone.Description = milestone.Description;
                    newMilestone.DueOn = milestone.DueOn;
                    newMilestone.State = milestone.State.Value;

                    var itask = targetClient.Issue.Milestone.Create(settings.TargetOwner, settings.TargetName, newMilestone);
                    _ = await itask;
                }
            }
        }

        public static async Task MoveLabels()
        {
            var settings = Properties.Settings.Default;
            var client = GetGitHubClient(settings.SourceUrl, settings.SourceName, settings.SourceToken);
            var targetClient = GetGitHubClient(settings.TargetUrl, settings.TargetName, settings.TargetToken);

            var labels = await client.Issue.Labels.GetAllForRepository(settings.SourceOwner, settings.SourceName);
            var targetLabels = await targetClient.Issue.Labels.GetAllForRepository(settings.TargetOwner, settings.TargetName);

            if (settings.DeleteExistingLabels)
            {
                // TODO: Delete all labels of target repo
            }

            foreach (var label in labels)
            {
                var target = targetLabels.Where(x => x.Name == label.Name).FirstOrDefault();

                if (target == null)
                {
                    var newLabel = new NewLabel(label.Name, label.Color);
                    newLabel.Description = label.Description;
                    
                    var itask = targetClient.Issue.Labels.Create(settings.TargetOwner, settings.TargetName, newLabel);
                    _ = await itask;
                }
            }
        }

        public static async Task MoveIssues()
        {
            var settings = Properties.Settings.Default;
            var client = GetGitHubClient(settings.SourceUrl, settings.SourceName, settings.SourceToken);
            var targetClient = GetGitHubClient(settings.TargetUrl, settings.TargetName, settings.TargetToken);

            var issues = await client.Issue.GetAllForRepository(
                settings.SourceOwner,
                settings.SourceName,
                new RepositoryIssueRequest { State = ItemStateFilter.All },
                new ApiOptions { PageSize = 100 }
            );

            foreach (var issue in issues)
            {
                var newIssue = new NewIssue(issue.Title);
                newIssue.Body = issue.Body;

                // Assingees
                foreach (var assingee in issue.Assignees)
                {
                    newIssue.Assignees.Add(assingee.Login); 
                }
                
                // Labels
                foreach (var label in issue.Labels)
                {
                    newIssue.Labels.Add(label.Name);
                }
                
                // Milestone
                if (issue.Milestone != null)
                    newIssue.Milestone = issue.Milestone.Number;

                var itask = targetClient.Issue.Create(settings.TargetOwner, settings.TargetName, newIssue);
                var currentIssue = await itask;

                // Resolution
                var issueUpdate = currentIssue.ToUpdate();
                issueUpdate.State = issue.State.Value;
                await targetClient.Issue.Update(settings.TargetOwner, settings.TargetName, currentIssue.Number, issueUpdate);

                // Add original issue url as comment
                if (settings.CreateOriginalShortcut)
                {
                    var ctask = targetClient.Issue.Comment.Create(settings.TargetOwner, settings.TargetName, currentIssue.Number, "Original Issue: " + issue.HtmlUrl);
                    _ = await ctask;
                }
            }
        }
    }
}
