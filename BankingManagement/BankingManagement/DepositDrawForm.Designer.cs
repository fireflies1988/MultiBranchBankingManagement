
namespace BankingManagement
{
    partial class DepositWithdrawForm
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nGAYGDLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.panelAccountOwner = new System.Windows.Forms.Panel();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxAccountOwner = new System.Windows.Forms.TextBox();
            this.pictureBoxCheck = new System.Windows.Forms.PictureBox();
            sOTKLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nGAYGDLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAccountOwner.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(21, 82);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(101, 21);
            sOTKLabel.TabIndex = 2;
            sOTKLabel.Text = "Số tài khoản";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENLabel.Location = new System.Drawing.Point(21, 7);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(61, 21);
            sOTIENLabel.TabIndex = 4;
            sOTIENLabel.Text = "Số tiền";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(21, 38);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(108, 21);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(21, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 21);
            label2.TabIndex = 2;
            label2.Text = "Tên nhân viên";
            // 
            // nGAYGDLabel
            // 
            nGAYGDLabel.AutoSize = true;
            nGAYGDLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYGDLabel.Location = new System.Drawing.Point(21, 75);
            nGAYGDLabel.Name = "nGAYGDLabel";
            nGAYGDLabel.Size = new System.Drawing.Size(118, 21);
            nGAYGDLabel.TabIndex = 6;
            nGAYGDLabel.Text = "Ngày giao dịch";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(21, 3);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 21);
            label3.TabIndex = 9;
            label3.Text = "CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại giao dịch";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(25, 39);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(442, 29);
            this.comboBoxType.TabIndex = 2;
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccountNumber.Location = new System.Drawing.Point(25, 109);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(442, 28);
            this.textBoxAccountNumber.TabIndex = 3;
            this.textBoxAccountNumber.Validated += new System.EventHandler(this.textBoxAccountNumber_Validated);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(25, 34);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(442, 28);
            this.textBoxAmount.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEmployeeID);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.textBoxEmployeeName);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân viên giao dịch";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeID.Location = new System.Drawing.Point(25, 62);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.ReadOnly = true;
            this.textBoxEmployeeID.Size = new System.Drawing.Size(445, 28);
            this.textBoxEmployeeID.TabIndex = 9;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(28, 133);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.ReadOnly = true;
            this.textBoxEmployeeName.Size = new System.Drawing.Size(442, 28);
            this.textBoxEmployeeName.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panelAccountOwner);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 460);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giao dịch";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxAmount);
            this.panel3.Controls.Add(nGAYGDLabel);
            this.panel3.Controls.Add(sOTIENLabel);
            this.panel3.Controls.Add(this.dateTimePickerTransactionDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 152);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(76, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "*";
            this.toolTip1.SetToolTip(this.label5, "Không được bỏ trống");
            // 
            // dateTimePickerTransactionDate
            // 
            this.dateTimePickerTransactionDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionDate.Location = new System.Drawing.Point(25, 102);
            this.dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            this.dateTimePickerTransactionDate.Size = new System.Drawing.Size(442, 28);
            this.dateTimePickerTransactionDate.TabIndex = 7;
            this.dateTimePickerTransactionDate.Value = new System.DateTime(2021, 10, 12, 18, 7, 7, 0);
            // 
            // panelAccountOwner
            // 
            this.panelAccountOwner.AutoSize = true;
            this.panelAccountOwner.Controls.Add(this.textBoxAccountOwner);
            this.panelAccountOwner.Controls.Add(label6);
            this.panelAccountOwner.Controls.Add(this.textBoxCMND);
            this.panelAccountOwner.Controls.Add(label3);
            this.panelAccountOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccountOwner.Location = new System.Drawing.Point(3, 175);
            this.panelAccountOwner.Name = "panelAccountOwner";
            this.panelAccountOwner.Size = new System.Drawing.Size(514, 130);
            this.panelAccountOwner.TabIndex = 8;
            this.panelAccountOwner.Visible = false;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCMND.Location = new System.Drawing.Point(25, 30);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.ReadOnly = true;
            this.textBoxCMND.Size = new System.Drawing.Size(442, 28);
            this.textBoxCMND.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxCheck);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxType);
            this.panel2.Controls.Add(sOTKLabel);
            this.panel2.Controls.Add(this.textBoxAccountNumber);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 147);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(116, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "*";
            this.toolTip1.SetToolTip(this.label4, "Không được bỏ trống");
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(107, 687);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(370, 48);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Xác nhận";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // textBoxAccountOwner
            // 
            this.textBoxAccountOwner.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccountOwner.Location = new System.Drawing.Point(25, 99);
            this.textBoxAccountOwner.Name = "textBoxAccountOwner";
            this.textBoxAccountOwner.ReadOnly = true;
            this.textBoxAccountOwner.Size = new System.Drawing.Size(442, 28);
            this.textBoxAccountOwner.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(21, 72);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(111, 21);
            label6.TabIndex = 11;
            label6.Text = "Chủ tài khoản";
            // 
            // pictureBoxCheck
            // 
            this.pictureBoxCheck.Image = global::BankingManagement.Properties.Resources.check;
            this.pictureBoxCheck.Location = new System.Drawing.Point(473, 109);
            this.pictureBoxCheck.Name = "pictureBoxCheck";
            this.pictureBoxCheck.Size = new System.Drawing.Size(31, 28);
            this.pictureBoxCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheck.TabIndex = 9;
            this.pictureBoxCheck.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxCheck, "Xác thực thành công");
            this.pictureBoxCheck.Visible = false;
            // 
            // DepositWithdrawForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1188, 762);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DepositWithdrawForm";
            this.Text = "Gởi rút tiền";
            this.Load += new System.EventHandler(this.DepositWithdrawForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelAccountOwner.ResumeLayout(false);
            this.panelAccountOwner.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionDate;
        private System.Windows.Forms.Panel panelAccountOwner;
        private System.Windows.Forms.TextBox textBoxCMND;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBoxCheck;
        private System.Windows.Forms.TextBox textBoxAccountOwner;
    }
}