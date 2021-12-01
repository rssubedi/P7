
namespace Builder
{
    partial class FormModifyRequirement
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
            this.mdfyReq = new System.Windows.Forms.Button();
            this.cncl = new System.Windows.Forms.Button();
            this.statBox = new System.Windows.Forms.RichTextBox();
            this.featsList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mdfyReq
            // 
            this.mdfyReq.Location = new System.Drawing.Point(348, 368);
            this.mdfyReq.Margin = new System.Windows.Forms.Padding(2);
            this.mdfyReq.Name = "mdfyReq";
            this.mdfyReq.Size = new System.Drawing.Size(133, 38);
            this.mdfyReq.TabIndex = 11;
            this.mdfyReq.Text = "Modify Requirement";
            this.mdfyReq.UseVisualStyleBackColor = true;
            // 
            // cncl
            // 
            this.cncl.Location = new System.Drawing.Point(206, 368);
            this.cncl.Margin = new System.Windows.Forms.Padding(2);
            this.cncl.Name = "cncl";
            this.cncl.Size = new System.Drawing.Size(127, 38);
            this.cncl.TabIndex = 10;
            this.cncl.Text = "Cancel";
            this.cncl.UseVisualStyleBackColor = true;
            // 
            // statBox
            // 
            this.statBox.Location = new System.Drawing.Point(108, 84);
            this.statBox.Margin = new System.Windows.Forms.Padding(2);
            this.statBox.Name = "statBox";
            this.statBox.Size = new System.Drawing.Size(470, 269);
            this.statBox.TabIndex = 9;
            this.statBox.Text = "";
            // 
            // featsList
            // 
            this.featsList.FormattingEnabled = true;
            this.featsList.Location = new System.Drawing.Point(108, 46);
            this.featsList.Margin = new System.Windows.Forms.Padding(2);
            this.featsList.Name = "featsList";
            this.featsList.Size = new System.Drawing.Size(470, 21);
            this.featsList.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Statement :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Feature :";
            // 
            // FormModifyRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.mdfyReq);
            this.Controls.Add(this.cncl);
            this.Controls.Add(this.statBox);
            this.Controls.Add(this.featsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModifyRequirement";
            this.Text = "Modify Requirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mdfyReq;
        private System.Windows.Forms.Button cncl;
        private System.Windows.Forms.RichTextBox statBox;
        private System.Windows.Forms.ComboBox featsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}