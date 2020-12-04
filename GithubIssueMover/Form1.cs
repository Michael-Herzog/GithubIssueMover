using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubIssueMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IssueMover.StartMoving();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSourceUrl.DataBindings.Add("Text", Properties.Settings.Default, "SourceUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSourceName.DataBindings.Add("Text", Properties.Settings.Default, "SourceName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSourceOwner.DataBindings.Add("Text", Properties.Settings.Default, "SourceOwner", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSourceToken.DataBindings.Add("Text", Properties.Settings.Default, "SourceToken", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTargetUrl.DataBindings.Add("Text", Properties.Settings.Default, "TargetUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTargetName.DataBindings.Add("Text", Properties.Settings.Default, "TargetName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTargetOwner.DataBindings.Add("Text", Properties.Settings.Default, "TargetOwner", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTargetToken.DataBindings.Add("Text", Properties.Settings.Default, "TargetToken", true, DataSourceUpdateMode.OnPropertyChanged);

            chkCopyMilestones.DataBindings.Add("Checked", Properties.Settings.Default, "CopyMilestones", true, DataSourceUpdateMode.OnPropertyChanged);
            chkCopyIssues.DataBindings.Add("Checked", Properties.Settings.Default, "CopyIssues", true, DataSourceUpdateMode.OnPropertyChanged);
            chkCopyLabels.DataBindings.Add("Checked", Properties.Settings.Default, "CopyLabels", true, DataSourceUpdateMode.OnPropertyChanged);
            chkCreateOriginalShortcut.DataBindings.Add("Checked", Properties.Settings.Default, "CreateOriginalShortcut", true, DataSourceUpdateMode.OnPropertyChanged);
            chkDeleteExistingLabels.DataBindings.Add("Checked", Properties.Settings.Default, "DeleteExistingLabels", true, DataSourceUpdateMode.OnPropertyChanged);
            chkCloseMoved.DataBindings.Add("Checked", Properties.Settings.Default, "CloseMovedIssues", true, DataSourceUpdateMode.OnPropertyChanged);
            chkMoveCommentlessOnly.DataBindings.Add("Checked", Properties.Settings.Default, "MoveCommentlessIssuesOnly", true, DataSourceUpdateMode.OnPropertyChanged);
            chkMoveOpenOnly.DataBindings.Add("Checked", Properties.Settings.Default, "MoveOpenOnly", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
