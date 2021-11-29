
namespace BankingManagement
{
    partial class AccountStatementForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountStatementForm));
            this.buttonPreview = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAccountNumber = new System.Windows.Forms.ComboBox();
            this.simpleButtonRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.accountDataSet = new BankingManagement.AccountDataSet();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new BankingManagement.AccountDataSetTableAdapters.TaiKhoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(29, 170);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(184, 41);
            this.buttonPreview.TabIndex = 12;
            this.buttonPreview.Text = "Xem";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(257, 103);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(204, 32);
            this.dateTimePickerTo.TabIndex = 11;
            this.dateTimePickerTo.Value = new System.DateTime(2021, 11, 28, 18, 33, 59, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đến";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(29, 103);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(204, 32);
            this.dateTimePickerFrom.TabIndex = 9;
            this.dateTimePickerFrom.Value = new System.DateTime(2021, 11, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ";
            // 
            // comboBoxAccountNumber
            // 
            this.comboBoxAccountNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAccountNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAccountNumber.DataSource = this.taiKhoanBindingSource;
            this.comboBoxAccountNumber.DisplayMember = "SOTK";
            this.comboBoxAccountNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAccountNumber.FormattingEnabled = true;
            this.comboBoxAccountNumber.Location = new System.Drawing.Point(29, 22);
            this.comboBoxAccountNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxAccountNumber.Name = "comboBoxAccountNumber";
            this.comboBoxAccountNumber.Size = new System.Drawing.Size(432, 32);
            this.comboBoxAccountNumber.TabIndex = 7;
            // 
            // simpleButtonRefresh
            // 
            this.simpleButtonRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonRefresh.ImageOptions.SvgImage")));
            this.simpleButtonRefresh.Location = new System.Drawing.Point(469, 18);
            this.simpleButtonRefresh.Name = "simpleButtonRefresh";
            this.simpleButtonRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButtonRefresh.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonRefresh.Size = new System.Drawing.Size(46, 36);
            this.simpleButtonRefresh.TabIndex = 16;
            this.simpleButtonRefresh.Click += new System.EventHandler(this.simpleButtonRefresh_Click);
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.accountDataSet;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // AccountStatementForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(794, 584);
            this.Controls.Add(this.simpleButtonRefresh);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAccountNumber);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AccountStatementForm";
            this.Text = "Sao kê giao dịch";
            this.Load += new System.EventHandler(this.AccountStatementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAccountNumber;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRefresh;
        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private AccountDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
    }
}