
namespace BankingManagement
{
    partial class ListOfAccountsOpenedForm
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
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(29, 22);
            this.comboBoxBranch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(432, 32);
            this.comboBoxBranch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(29, 103);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(204, 32);
            this.dateTimePickerFrom.TabIndex = 3;
            this.dateTimePickerFrom.Value = new System.DateTime(2021, 11, 28, 0, 0, 0, 0);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(257, 103);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(204, 32);
            this.dateTimePickerTo.TabIndex = 5;
            this.dateTimePickerTo.Value = new System.DateTime(2021, 11, 28, 18, 33, 59, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến";
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(29, 170);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(184, 41);
            this.buttonPreview.TabIndex = 6;
            this.buttonPreview.Text = "Xem";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // ListOfAccountsOpenedForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(778, 398);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBranch);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ListOfAccountsOpenedForm";
            this.Text = "Thống kê các tài được mở";
            this.Load += new System.EventHandler(this.ListOfAccountsOpenedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPreview;
    }
}