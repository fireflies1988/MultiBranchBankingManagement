
namespace BankingManagement
{
    partial class ListOfCustomersByBranchForm
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
            this.buttonPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(25, 22);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(360, 32);
            this.comboBoxBranch.TabIndex = 1;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(25, 81);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(171, 38);
            this.buttonPreview.TabIndex = 2;
            this.buttonPreview.Text = "Xem";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // ListOfCustomersByBranchForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 453);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.comboBoxBranch);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ListOfCustomersByBranchForm";
            this.Text = "Danh sách khách hàng theo chi nhánh";
            this.Load += new System.EventHandler(this.ListOfCustomersByBranchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Button buttonPreview;
    }
}