
namespace Builder
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IssueByDisc_list = new System.Windows.Forms.TextBox();
            this.issueByMonth_List = new System.Windows.Forms.TextBox();
            this.clsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IbM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numIssue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IssueByDisc_list
            // 
            this.IssueByDisc_list.Location = new System.Drawing.Point(40, 391);
            this.IssueByDisc_list.Multiline = true;
            this.IssueByDisc_list.Name = "IssueByDisc_list";
            this.IssueByDisc_list.ReadOnly = true;
            this.IssueByDisc_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IssueByDisc_list.Size = new System.Drawing.Size(316, 193);
            this.IssueByDisc_list.TabIndex = 17;
            // 
            // issueByMonth_List
            // 
            this.issueByMonth_List.Location = new System.Drawing.Point(40, 130);
            this.issueByMonth_List.Multiline = true;
            this.issueByMonth_List.Name = "issueByMonth_List";
            this.issueByMonth_List.ReadOnly = true;
            this.issueByMonth_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.issueByMonth_List.ShortcutsEnabled = false;
            this.issueByMonth_List.Size = new System.Drawing.Size(316, 194);
            this.issueByMonth_List.TabIndex = 16;
            // 
            // clsButton
            // 
            this.clsButton.Location = new System.Drawing.Point(133, 590);
            this.clsButton.Name = "clsButton";
            this.clsButton.Size = new System.Drawing.Size(138, 40);
            this.clsButton.TabIndex = 15;
            this.clsButton.Text = "Close";
            this.clsButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Issues by Discoverer";
            // 
            // IbM
            // 
            this.IbM.AutoSize = true;
            this.IbM.Location = new System.Drawing.Point(151, 97);
            this.IbM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IbM.Name = "IbM";
            this.IbM.Size = new System.Drawing.Size(84, 13);
            this.IbM.TabIndex = 13;
            this.IbM.Text = "Issues by Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Number of Issues";
            // 
            // numIssue
            // 
            this.numIssue.AutoSize = true;
            this.numIssue.Location = new System.Drawing.Point(337, 45);
            this.numIssue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numIssue.Name = "numIssue";
            this.numIssue.Size = new System.Drawing.Size(19, 13);
            this.numIssue.TabIndex = 18;
            this.numIssue.Text = "__";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 656);
            this.Controls.Add(this.numIssue);
            this.Controls.Add(this.IssueByDisc_list);
            this.Controls.Add(this.issueByMonth_List);
            this.Controls.Add(this.clsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IbM);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IssueByDisc_list;
        private System.Windows.Forms.TextBox issueByMonth_List;
        private System.Windows.Forms.Button clsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IbM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numIssue;
    }
}