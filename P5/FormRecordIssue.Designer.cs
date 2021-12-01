
namespace Builder
{
    partial class FormRecordIssue
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
            this.crtIssue = new System.Windows.Forms.Button();
            this.cnclCreate = new System.Windows.Forms.Button();
            this.initDesc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statuses = new System.Windows.Forms.ComboBox();
            this.comp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.discoverers = new System.Windows.Forms.ComboBox();
            this.disc_dateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Iss_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crtIssue
            // 
            this.crtIssue.Location = new System.Drawing.Point(249, 510);
            this.crtIssue.Margin = new System.Windows.Forms.Padding(2);
            this.crtIssue.Name = "crtIssue";
            this.crtIssue.Size = new System.Drawing.Size(115, 47);
            this.crtIssue.TabIndex = 34;
            this.crtIssue.Text = "Create Issue";
            this.crtIssue.UseVisualStyleBackColor = true;
            // 
            // cnclCreate
            // 
            this.cnclCreate.Location = new System.Drawing.Point(97, 510);
            this.cnclCreate.Margin = new System.Windows.Forms.Padding(2);
            this.cnclCreate.Name = "cnclCreate";
            this.cnclCreate.Size = new System.Drawing.Size(128, 47);
            this.cnclCreate.TabIndex = 33;
            this.cnclCreate.Text = "Cancel";
            this.cnclCreate.UseVisualStyleBackColor = true;
            // 
            // initDesc
            // 
            this.initDesc.Location = new System.Drawing.Point(77, 277);
            this.initDesc.Margin = new System.Windows.Forms.Padding(2);
            this.initDesc.Name = "initDesc";
            this.initDesc.Size = new System.Drawing.Size(332, 210);
            this.initDesc.TabIndex = 32;
            this.initDesc.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Initial Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Status";
            // 
            // statuses
            // 
            this.statuses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statuses.FormattingEnabled = true;
            this.statuses.Location = new System.Drawing.Point(136, 217);
            this.statuses.Margin = new System.Windows.Forms.Padding(2);
            this.statuses.Name = "statuses";
            this.statuses.Size = new System.Drawing.Size(273, 21);
            this.statuses.TabIndex = 29;
            // 
            // comp
            // 
            this.comp.Location = new System.Drawing.Point(136, 180);
            this.comp.Margin = new System.Windows.Forms.Padding(2);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(273, 20);
            this.comp.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Component";
            // 
            // discoverers
            // 
            this.discoverers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discoverers.FormattingEnabled = true;
            this.discoverers.IntegralHeight = false;
            this.discoverers.Location = new System.Drawing.Point(136, 145);
            this.discoverers.Margin = new System.Windows.Forms.Padding(2);
            this.discoverers.MaxDropDownItems = 50;
            this.discoverers.Name = "discoverers";
            this.discoverers.Size = new System.Drawing.Size(273, 21);
            this.discoverers.TabIndex = 26;
            // 
            // disc_dateTime
            // 
            this.disc_dateTime.CustomFormat = "hh:mm:ss tt d MMM yyyy";
            this.disc_dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.disc_dateTime.Location = new System.Drawing.Point(136, 110);
            this.disc_dateTime.Margin = new System.Windows.Forms.Padding(2);
            this.disc_dateTime.MaxDate = new System.DateTime(2021, 11, 30, 0, 0, 0, 0);
            this.disc_dateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.disc_dateTime.Name = "disc_dateTime";
            this.disc_dateTime.Size = new System.Drawing.Size(273, 20);
            this.disc_dateTime.TabIndex = 25;
            this.disc_dateTime.Value = new System.DateTime(2021, 11, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Discoverer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Discovery Date";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(136, 81);
            this.titleBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(273, 20);
            this.titleBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Title";
            // 
            // Iss_Id
            // 
            this.Iss_Id.Location = new System.Drawing.Point(136, 50);
            this.Iss_Id.Margin = new System.Windows.Forms.Padding(2);
            this.Iss_Id.Name = "Iss_Id";
            this.Iss_Id.ReadOnly = true;
            this.Iss_Id.Size = new System.Drawing.Size(273, 20);
            this.Iss_Id.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id";
            // 
            // FormRecordIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 579);
            this.Controls.Add(this.crtIssue);
            this.Controls.Add(this.cnclCreate);
            this.Controls.Add(this.initDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statuses);
            this.Controls.Add(this.comp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.discoverers);
            this.Controls.Add(this.disc_dateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Iss_Id);
            this.Controls.Add(this.label1);
            this.Name = "FormRecordIssue";
            this.Text = "Record Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crtIssue;
        private System.Windows.Forms.Button cnclCreate;
        private System.Windows.Forms.RichTextBox initDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox statuses;
        private System.Windows.Forms.TextBox comp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox discoverers;
        private System.Windows.Forms.DateTimePicker disc_dateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Iss_Id;
        private System.Windows.Forms.Label label1;
    }
}