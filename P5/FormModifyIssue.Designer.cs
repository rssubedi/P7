
namespace Builder
{
    partial class FormModifyIssue
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
            this.issStatus = new System.Windows.Forms.ComboBox();
            this.disc = new System.Windows.Forms.ComboBox();
            this.discDate = new System.Windows.Forms.DateTimePicker();
            this.cnclMdfy = new System.Windows.Forms.Button();
            this.mdfyIssue = new System.Windows.Forms.Button();
            this.initDesc = new System.Windows.Forms.RichTextBox();
            this.issComp = new System.Windows.Forms.TextBox();
            this.issueTitle = new System.Windows.Forms.TextBox();
            this.issueID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // issStatus
            // 
            this.issStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.issStatus.FormattingEnabled = true;
            this.issStatus.Location = new System.Drawing.Point(114, 191);
            this.issStatus.Margin = new System.Windows.Forms.Padding(2);
            this.issStatus.Name = "issStatus";
            this.issStatus.Size = new System.Drawing.Size(279, 21);
            this.issStatus.TabIndex = 34;
            // 
            // disc
            // 
            this.disc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disc.FormattingEnabled = true;
            this.disc.Location = new System.Drawing.Point(116, 135);
            this.disc.Margin = new System.Windows.Forms.Padding(2);
            this.disc.MaxDropDownItems = 50;
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(277, 21);
            this.disc.TabIndex = 33;
            // 
            // discDate
            // 
            this.discDate.CustomFormat = "hh:mm:ss tt d MMM yyyy";
            this.discDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.discDate.Location = new System.Drawing.Point(116, 109);
            this.discDate.Margin = new System.Windows.Forms.Padding(2);
            this.discDate.Name = "discDate";
            this.discDate.Size = new System.Drawing.Size(277, 20);
            this.discDate.TabIndex = 32;
            this.discDate.Value = new System.DateTime(2021, 11, 30, 21, 54, 12, 0);
            // 
            // cnclMdfy
            // 
            this.cnclMdfy.Location = new System.Drawing.Point(140, 437);
            this.cnclMdfy.Margin = new System.Windows.Forms.Padding(2);
            this.cnclMdfy.Name = "cnclMdfy";
            this.cnclMdfy.Size = new System.Drawing.Size(103, 37);
            this.cnclMdfy.TabIndex = 31;
            this.cnclMdfy.Text = "Cancel";
            this.cnclMdfy.UseVisualStyleBackColor = true;
            // 
            // mdfyIssue
            // 
            this.mdfyIssue.Location = new System.Drawing.Point(259, 437);
            this.mdfyIssue.Margin = new System.Windows.Forms.Padding(2);
            this.mdfyIssue.Name = "mdfyIssue";
            this.mdfyIssue.Size = new System.Drawing.Size(88, 37);
            this.mdfyIssue.TabIndex = 30;
            this.mdfyIssue.Text = "Modify Issue";
            this.mdfyIssue.UseVisualStyleBackColor = true;
            // 
            // initDesc
            // 
            this.initDesc.Location = new System.Drawing.Point(116, 246);
            this.initDesc.Margin = new System.Windows.Forms.Padding(2);
            this.initDesc.Name = "initDesc";
            this.initDesc.Size = new System.Drawing.Size(277, 174);
            this.initDesc.TabIndex = 29;
            this.initDesc.Text = "";
            // 
            // issComp
            // 
            this.issComp.Location = new System.Drawing.Point(116, 163);
            this.issComp.Margin = new System.Windows.Forms.Padding(2);
            this.issComp.Name = "issComp";
            this.issComp.Size = new System.Drawing.Size(277, 20);
            this.issComp.TabIndex = 28;
            // 
            // issueTitle
            // 
            this.issueTitle.Location = new System.Drawing.Point(116, 85);
            this.issueTitle.Margin = new System.Windows.Forms.Padding(2);
            this.issueTitle.Name = "issueTitle";
            this.issueTitle.Size = new System.Drawing.Size(277, 20);
            this.issueTitle.TabIndex = 27;
            // 
            // issueID
            // 
            this.issueID.Location = new System.Drawing.Point(116, 50);
            this.issueID.Margin = new System.Windows.Forms.Padding(2);
            this.issueID.Name = "issueID";
            this.issueID.ReadOnly = true;
            this.issueID.Size = new System.Drawing.Size(277, 20);
            this.issueID.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Initial Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Component";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Discoverer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Discovery Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id";
            // 
            // FormModifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 492);
            this.Controls.Add(this.issStatus);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.discDate);
            this.Controls.Add(this.cnclMdfy);
            this.Controls.Add(this.mdfyIssue);
            this.Controls.Add(this.initDesc);
            this.Controls.Add(this.issComp);
            this.Controls.Add(this.issueTitle);
            this.Controls.Add(this.issueID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModifyIssue";
            this.Text = "Modify Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox issStatus;
        private System.Windows.Forms.ComboBox disc;
        private System.Windows.Forms.DateTimePicker discDate;
        private System.Windows.Forms.Button cnclMdfy;
        private System.Windows.Forms.Button mdfyIssue;
        private System.Windows.Forms.RichTextBox initDesc;
        private System.Windows.Forms.TextBox issComp;
        private System.Windows.Forms.TextBox issueTitle;
        private System.Windows.Forms.TextBox issueID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}