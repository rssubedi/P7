
namespace Builder
{
    partial class FormSelectFeatureRemove
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
            this.selFeatToRem = new System.Windows.Forms.Button();
            this.cnclRem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.featureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selFeatToRem
            // 
            this.selFeatToRem.Location = new System.Drawing.Point(347, 393);
            this.selFeatToRem.Margin = new System.Windows.Forms.Padding(2);
            this.selFeatToRem.Name = "selFeatToRem";
            this.selFeatToRem.Size = new System.Drawing.Size(147, 46);
            this.selFeatToRem.TabIndex = 5;
            this.selFeatToRem.Text = "Select Feature";
            this.selFeatToRem.UseVisualStyleBackColor = true;
            // 
            // cnclRem
            // 
            this.cnclRem.Location = new System.Drawing.Point(162, 393);
            this.cnclRem.Margin = new System.Windows.Forms.Padding(2);
            this.cnclRem.Name = "cnclRem";
            this.cnclRem.Size = new System.Drawing.Size(143, 46);
            this.cnclRem.TabIndex = 4;
            this.cnclRem.Text = "Cancel";
            this.cnclRem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.featureId,
            this.featTitle});
            this.dataGridView1.Location = new System.Drawing.Point(31, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(623, 355);
            this.dataGridView1.TabIndex = 3;
            // 
            // featureId
            // 
            this.featureId.HeaderText = "Id";
            this.featureId.MinimumWidth = 6;
            this.featureId.Name = "featureId";
            this.featureId.ReadOnly = true;
            this.featureId.Width = 60;
            // 
            // featTitle
            // 
            this.featTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.featTitle.HeaderText = "Feature";
            this.featTitle.MinimumWidth = 6;
            this.featTitle.Name = "featTitle";
            this.featTitle.ReadOnly = true;
            this.featTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormSelectFeatureRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.selFeatToRem);
            this.Controls.Add(this.cnclRem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSelectFeatureRemove";
            this.Text = "Select Feature";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selFeatToRem;
        private System.Windows.Forms.Button cnclRem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn featTitle;
    }
}