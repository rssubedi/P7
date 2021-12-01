
namespace Builder
{
    partial class FormCreateFeature
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
            this.CreateFeat = new System.Windows.Forms.Button();
            this.cnclFeat = new System.Windows.Forms.Button();
            this.newFeatTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateFeat
            // 
            this.CreateFeat.Location = new System.Drawing.Point(367, 108);
            this.CreateFeat.Name = "CreateFeat";
            this.CreateFeat.Size = new System.Drawing.Size(147, 39);
            this.CreateFeat.TabIndex = 7;
            this.CreateFeat.Text = "Create Feature";
            this.CreateFeat.UseVisualStyleBackColor = true;
            // 
            // cnclFeat
            // 
            this.cnclFeat.Location = new System.Drawing.Point(195, 108);
            this.cnclFeat.Name = "cnclFeat";
            this.cnclFeat.Size = new System.Drawing.Size(137, 39);
            this.cnclFeat.TabIndex = 6;
            this.cnclFeat.Text = "Cancel";
            this.cnclFeat.UseVisualStyleBackColor = true;
            // 
            // newFeatTitle
            // 
            this.newFeatTitle.Location = new System.Drawing.Point(94, 50);
            this.newFeatTitle.Name = "newFeatTitle";
            this.newFeatTitle.Size = new System.Drawing.Size(505, 20);
            this.newFeatTitle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title :";
            // 
            // FormCreateFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 195);
            this.Controls.Add(this.CreateFeat);
            this.Controls.Add(this.cnclFeat);
            this.Controls.Add(this.newFeatTitle);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateFeature";
            this.Text = "Create Feature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateFeat;
        private System.Windows.Forms.Button cnclFeat;
        private System.Windows.Forms.TextBox newFeatTitle;
        private System.Windows.Forms.Label label1;
    }
}