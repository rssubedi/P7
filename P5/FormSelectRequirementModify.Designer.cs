
namespace Builder
{
    partial class FormSelectRequirementModify
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
            this.cncl = new System.Windows.Forms.Button();
            this.selReq = new System.Windows.Forms.Button();
            this.reqList = new System.Windows.Forms.DataGridView();
            this.reqId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqStatement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.featureList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reqList)).BeginInit();
            this.SuspendLayout();
            // 
            // cncl
            // 
            this.cncl.Location = new System.Drawing.Point(224, 393);
            this.cncl.Margin = new System.Windows.Forms.Padding(2);
            this.cncl.Name = "cncl";
            this.cncl.Size = new System.Drawing.Size(122, 46);
            this.cncl.TabIndex = 11;
            this.cncl.Text = "Cancel";
            this.cncl.UseVisualStyleBackColor = true;
            // 
            // selReq
            // 
            this.selReq.Location = new System.Drawing.Point(385, 393);
            this.selReq.Margin = new System.Windows.Forms.Padding(2);
            this.selReq.Name = "selReq";
            this.selReq.Size = new System.Drawing.Size(143, 46);
            this.selReq.TabIndex = 10;
            this.selReq.Text = "Select Requirement";
            this.selReq.UseVisualStyleBackColor = true;
            // 
            // reqList
            // 
            this.reqList.AllowUserToAddRows = false;
            this.reqList.AllowUserToDeleteRows = false;
            this.reqList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reqList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqId,
            this.reqStatement});
            this.reqList.Location = new System.Drawing.Point(126, 68);
            this.reqList.Margin = new System.Windows.Forms.Padding(2);
            this.reqList.MultiSelect = false;
            this.reqList.Name = "reqList";
            this.reqList.ReadOnly = true;
            this.reqList.RowHeadersWidth = 51;
            this.reqList.RowTemplate.Height = 24;
            this.reqList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reqList.Size = new System.Drawing.Size(513, 309);
            this.reqList.TabIndex = 9;
            // 
            // reqId
            // 
            this.reqId.HeaderText = "Id";
            this.reqId.MinimumWidth = 6;
            this.reqId.Name = "reqId";
            this.reqId.ReadOnly = true;
            this.reqId.Width = 60;
            // 
            // reqStatement
            // 
            this.reqStatement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reqStatement.HeaderText = "Requirement";
            this.reqStatement.MinimumWidth = 6;
            this.reqStatement.Name = "reqStatement";
            this.reqStatement.ReadOnly = true;
            this.reqStatement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Requirements :";
            // 
            // featureList
            // 
            this.featureList.FormattingEnabled = true;
            this.featureList.Location = new System.Drawing.Point(126, 28);
            this.featureList.Margin = new System.Windows.Forms.Padding(2);
            this.featureList.Name = "featureList";
            this.featureList.Size = new System.Drawing.Size(514, 21);
            this.featureList.TabIndex = 7;
            this.featureList.Text = "< Make Selection >";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Feature :";
            // 
            // FormSelectRequirementModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.cncl);
            this.Controls.Add(this.selReq);
            this.Controls.Add(this.reqList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.featureList);
            this.Controls.Add(this.label1);
            this.Name = "FormSelectRequirementModify";
            this.Text = "Select Requirement";
            ((System.ComponentModel.ISupportInitialize)(this.reqList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cncl;
        private System.Windows.Forms.Button selReq;
        private System.Windows.Forms.DataGridView reqList;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqId;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqStatement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox featureList;
        private System.Windows.Forms.Label label1;
    }
}