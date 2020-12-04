namespace GithubIssueMover
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSourceToken = new System.Windows.Forms.TextBox();
            this.txtSourceOwner = new System.Windows.Forms.TextBox();
            this.txtSourceName = new System.Windows.Forms.TextBox();
            this.txtSourceUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTargetToken = new System.Windows.Forms.TextBox();
            this.txtTargetOwner = new System.Windows.Forms.TextBox();
            this.txtTargetName = new System.Windows.Forms.TextBox();
            this.txtTargetUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.chkCopyMilestones = new System.Windows.Forms.CheckBox();
            this.chkCopyLabels = new System.Windows.Forms.CheckBox();
            this.chkDeleteExistingLabels = new System.Windows.Forms.CheckBox();
            this.chkCopyIssues = new System.Windows.Forms.CheckBox();
            this.chkCreateOriginalShortcut = new System.Windows.Forms.CheckBox();
            this.chkCloseMoved = new System.Windows.Forms.CheckBox();
            this.chkMoveCommentlessOnly = new System.Windows.Forms.CheckBox();
            this.chkMoveOpenOnly = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start moving";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSourceToken);
            this.groupBox1.Controls.Add(this.txtSourceOwner);
            this.groupBox1.Controls.Add(this.txtSourceName);
            this.groupBox1.Controls.Add(this.txtSourceUrl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Repository";
            // 
            // txtSourceToken
            // 
            this.txtSourceToken.Location = new System.Drawing.Point(80, 107);
            this.txtSourceToken.Name = "txtSourceToken";
            this.txtSourceToken.Size = new System.Drawing.Size(287, 20);
            this.txtSourceToken.TabIndex = 7;
            // 
            // txtSourceOwner
            // 
            this.txtSourceOwner.Location = new System.Drawing.Point(80, 80);
            this.txtSourceOwner.Name = "txtSourceOwner";
            this.txtSourceOwner.Size = new System.Drawing.Size(287, 20);
            this.txtSourceOwner.TabIndex = 6;
            // 
            // txtSourceName
            // 
            this.txtSourceName.Location = new System.Drawing.Point(80, 53);
            this.txtSourceName.Name = "txtSourceName";
            this.txtSourceName.Size = new System.Drawing.Size(287, 20);
            this.txtSourceName.TabIndex = 5;
            // 
            // txtSourceUrl
            // 
            this.txtSourceUrl.Location = new System.Drawing.Point(80, 25);
            this.txtSourceUrl.Name = "txtSourceUrl";
            this.txtSourceUrl.Size = new System.Drawing.Size(287, 20);
            this.txtSourceUrl.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTargetToken);
            this.groupBox2.Controls.Add(this.txtTargetOwner);
            this.groupBox2.Controls.Add(this.txtTargetName);
            this.groupBox2.Controls.Add(this.txtTargetUrl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(391, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 142);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target Repository";
            // 
            // txtTargetToken
            // 
            this.txtTargetToken.Location = new System.Drawing.Point(77, 107);
            this.txtTargetToken.Name = "txtTargetToken";
            this.txtTargetToken.Size = new System.Drawing.Size(314, 20);
            this.txtTargetToken.TabIndex = 4;
            // 
            // txtTargetOwner
            // 
            this.txtTargetOwner.Location = new System.Drawing.Point(77, 79);
            this.txtTargetOwner.Name = "txtTargetOwner";
            this.txtTargetOwner.Size = new System.Drawing.Size(314, 20);
            this.txtTargetOwner.TabIndex = 10;
            // 
            // txtTargetName
            // 
            this.txtTargetName.Location = new System.Drawing.Point(77, 53);
            this.txtTargetName.Name = "txtTargetName";
            this.txtTargetName.Size = new System.Drawing.Size(314, 20);
            this.txtTargetName.TabIndex = 9;
            // 
            // txtTargetUrl
            // 
            this.txtTargetUrl.Location = new System.Drawing.Point(77, 26);
            this.txtTargetUrl.Name = "txtTargetUrl";
            this.txtTargetUrl.Size = new System.Drawing.Size(314, 20);
            this.txtTargetUrl.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Token";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Owner";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "URL";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkCopyMilestones
            // 
            this.chkCopyMilestones.AutoSize = true;
            this.chkCopyMilestones.Location = new System.Drawing.Point(13, 161);
            this.chkCopyMilestones.Name = "chkCopyMilestones";
            this.chkCopyMilestones.Size = new System.Drawing.Size(103, 17);
            this.chkCopyMilestones.TabIndex = 5;
            this.chkCopyMilestones.Text = "Copy Milestones";
            this.chkCopyMilestones.UseVisualStyleBackColor = true;
            // 
            // chkCopyLabels
            // 
            this.chkCopyLabels.AutoSize = true;
            this.chkCopyLabels.Location = new System.Drawing.Point(12, 185);
            this.chkCopyLabels.Name = "chkCopyLabels";
            this.chkCopyLabels.Size = new System.Drawing.Size(84, 17);
            this.chkCopyLabels.TabIndex = 6;
            this.chkCopyLabels.Text = "Copy Labels";
            this.chkCopyLabels.UseVisualStyleBackColor = true;
            // 
            // chkDeleteExistingLabels
            // 
            this.chkDeleteExistingLabels.AutoSize = true;
            this.chkDeleteExistingLabels.Location = new System.Drawing.Point(12, 209);
            this.chkDeleteExistingLabels.Name = "chkDeleteExistingLabels";
            this.chkDeleteExistingLabels.Size = new System.Drawing.Size(165, 17);
            this.chkDeleteExistingLabels.TabIndex = 7;
            this.chkDeleteExistingLabels.Text = "Delete existing labels (Target)";
            this.chkDeleteExistingLabels.UseVisualStyleBackColor = true;
            // 
            // chkCopyIssues
            // 
            this.chkCopyIssues.AutoSize = true;
            this.chkCopyIssues.Location = new System.Drawing.Point(12, 233);
            this.chkCopyIssues.Name = "chkCopyIssues";
            this.chkCopyIssues.Size = new System.Drawing.Size(83, 17);
            this.chkCopyIssues.TabIndex = 8;
            this.chkCopyIssues.Text = "Copy Issues";
            this.chkCopyIssues.UseVisualStyleBackColor = true;
            // 
            // chkCreateOriginalShortcut
            // 
            this.chkCreateOriginalShortcut.AutoSize = true;
            this.chkCreateOriginalShortcut.Location = new System.Drawing.Point(12, 257);
            this.chkCreateOriginalShortcut.Name = "chkCreateOriginalShortcut";
            this.chkCreateOriginalShortcut.Size = new System.Drawing.Size(239, 17);
            this.chkCreateOriginalShortcut.TabIndex = 9;
            this.chkCreateOriginalShortcut.Text = "Create shortcut to original issue (as comment)";
            this.chkCreateOriginalShortcut.UseVisualStyleBackColor = true;
            // 
            // chkCloseMoved
            // 
            this.chkCloseMoved.AutoSize = true;
            this.chkCloseMoved.Location = new System.Drawing.Point(12, 281);
            this.chkCloseMoved.Name = "chkCloseMoved";
            this.chkCloseMoved.Size = new System.Drawing.Size(119, 17);
            this.chkCloseMoved.TabIndex = 10;
            this.chkCloseMoved.Text = "Close moved issues";
            this.chkCloseMoved.UseVisualStyleBackColor = true;
            // 
            // chkMoveCommentlessOnly
            // 
            this.chkMoveCommentlessOnly.AutoSize = true;
            this.chkMoveCommentlessOnly.Location = new System.Drawing.Point(13, 305);
            this.chkMoveCommentlessOnly.Name = "chkMoveCommentlessOnly";
            this.chkMoveCommentlessOnly.Size = new System.Drawing.Size(196, 17);
            this.chkMoveCommentlessOnly.TabIndex = 11;
            this.chkMoveCommentlessOnly.Text = "Only move issues without comments";
            this.chkMoveCommentlessOnly.UseVisualStyleBackColor = true;
            // 
            // chkMoveOpenOnly
            // 
            this.chkMoveOpenOnly.AutoSize = true;
            this.chkMoveOpenOnly.Location = new System.Drawing.Point(12, 329);
            this.chkMoveOpenOnly.Name = "chkMoveOpenOnly";
            this.chkMoveOpenOnly.Size = new System.Drawing.Size(135, 17);
            this.chkMoveOpenOnly.TabIndex = 12;
            this.chkMoveOpenOnly.Text = "Only move open issues";
            this.chkMoveOpenOnly.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkMoveOpenOnly);
            this.Controls.Add(this.chkMoveCommentlessOnly);
            this.Controls.Add(this.chkCloseMoved);
            this.Controls.Add(this.chkCreateOriginalShortcut);
            this.Controls.Add(this.chkCopyIssues);
            this.Controls.Add(this.chkDeleteExistingLabels);
            this.Controls.Add(this.chkCopyLabels);
            this.Controls.Add(this.chkCopyMilestones);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Github Issue Mover";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSourceToken;
        private System.Windows.Forms.TextBox txtSourceOwner;
        private System.Windows.Forms.TextBox txtSourceName;
        private System.Windows.Forms.TextBox txtSourceUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtTargetToken;
        private System.Windows.Forms.TextBox txtTargetOwner;
        private System.Windows.Forms.TextBox txtTargetName;
        private System.Windows.Forms.TextBox txtTargetUrl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkCopyMilestones;
        private System.Windows.Forms.CheckBox chkCopyLabels;
        private System.Windows.Forms.CheckBox chkDeleteExistingLabels;
        private System.Windows.Forms.CheckBox chkCopyIssues;
        private System.Windows.Forms.CheckBox chkCreateOriginalShortcut;
        private System.Windows.Forms.CheckBox chkCloseMoved;
        private System.Windows.Forms.CheckBox chkMoveCommentlessOnly;
        private System.Windows.Forms.CheckBox chkMoveOpenOnly;
    }
}

