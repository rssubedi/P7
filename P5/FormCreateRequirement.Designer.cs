
namespace Builder
{
    partial class FormCreateRequirement
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
            this.selFeat = new System.Windows.Forms.ComboBox();
            this.CrtReq = new System.Windows.Forms.Button();
            this.cnclReqCrt = new System.Windows.Forms.Button();
            this.statMentBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selFeat
            // 
            this.selFeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selFeat.FormattingEnabled = true;
            this.selFeat.Location = new System.Drawing.Point(110, 30);
            this.selFeat.Margin = new System.Windows.Forms.Padding(2);
            this.selFeat.MaxDropDownItems = 80;
            this.selFeat.Name = "selFeat";
            this.selFeat.Size = new System.Drawing.Size(544, 21);
            this.selFeat.TabIndex = 12;
            // 
            // CrtReq
            // 
            this.CrtReq.Location = new System.Drawing.Point(369, 332);
            this.CrtReq.Margin = new System.Windows.Forms.Padding(2);
            this.CrtReq.Name = "CrtReq";
            this.CrtReq.Size = new System.Drawing.Size(130, 42);
            this.CrtReq.TabIndex = 11;
            this.CrtReq.Text = "Create Requirement";
            this.CrtReq.UseVisualStyleBackColor = true;
            // 
            // cnclReqCrt
            // 
            this.cnclReqCrt.Location = new System.Drawing.Point(202, 332);
            this.cnclReqCrt.Margin = new System.Windows.Forms.Padding(2);
            this.cnclReqCrt.Name = "cnclReqCrt";
            this.cnclReqCrt.Size = new System.Drawing.Size(125, 42);
            this.cnclReqCrt.TabIndex = 10;
            this.cnclReqCrt.Text = "Cancel";
            this.cnclReqCrt.UseVisualStyleBackColor = true;
            // 
            // statMentBox
            // 
            this.statMentBox.Location = new System.Drawing.Point(110, 76);
            this.statMentBox.Margin = new System.Windows.Forms.Padding(2);
            this.statMentBox.Name = "statMentBox";
            this.statMentBox.Size = new System.Drawing.Size(544, 243);
            this.statMentBox.TabIndex = 9;
            this.statMentBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Statement :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Feature : ";
            // 
            // FormCreateRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.selFeat);
            this.Controls.Add(this.CrtReq);
            this.Controls.Add(this.cnclReqCrt);
            this.Controls.Add(this.statMentBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateRequirement";
            this.Text = "Create Requirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selFeat;
        private System.Windows.Forms.Button CrtReq;
        private System.Windows.Forms.Button cnclReqCrt;
        private System.Windows.Forms.RichTextBox statMentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}