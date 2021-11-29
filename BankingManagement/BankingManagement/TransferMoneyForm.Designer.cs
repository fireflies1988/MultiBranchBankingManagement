
namespace BankingManagement
{
    partial class TransferMoneyForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelAccountOwner1 = new System.Windows.Forms.Panel();
            this.textBoxTransferor = new System.Windows.Forms.TextBox();
            this.textBoxTransferorID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTransferorAccountNumber = new System.Windows.Forms.TextBox();
            this.pictureBoxCheck1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelAccountOwner2 = new System.Windows.Forms.Panel();
            this.textBoxBeneficiary = new System.Windows.Forms.TextBox();
            this.textBoxBeneficiaryID = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxCheck2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBeneficiaryAccountNumber = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.dateTimePickerTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            label2 = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelAccountOwner1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panelAccountOwner2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEmployeeID);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.textBoxEmployeeName);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân viên giao dịch";
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeID.Location = new System.Drawing.Point(25, 62);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.ReadOnly = true;
            this.textBoxEmployeeID.Size = new System.Drawing.Size(442, 28);
            this.textBoxEmployeeID.TabIndex = 9;
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
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(25, 130);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.ReadOnly = true;
            this.textBoxEmployeeName.Size = new System.Drawing.Size(442, 28);
            this.textBoxEmployeeName.TabIndex = 3;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelAccountOwner1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 247);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đơn vị chuyển tiền";
            // 
            // panelAccountOwner1
            // 
            this.panelAccountOwner1.Controls.Add(this.textBoxTransferor);
            this.panelAccountOwner1.Controls.Add(label6);
            this.panelAccountOwner1.Controls.Add(this.textBoxTransferorID);
            this.panelAccountOwner1.Controls.Add(label3);
            this.panelAccountOwner1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAccountOwner1.Location = new System.Drawing.Point(3, 103);
            this.panelAccountOwner1.Name = "panelAccountOwner1";
            this.panelAccountOwner1.Size = new System.Drawing.Size(514, 141);
            this.panelAccountOwner1.TabIndex = 8;
            this.panelAccountOwner1.Visible = false;
            // 
            // textBoxTransferor
            // 
            this.textBoxTransferor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransferor.Location = new System.Drawing.Point(25, 99);
            this.textBoxTransferor.Name = "textBoxTransferor";
            this.textBoxTransferor.ReadOnly = true;
            this.textBoxTransferor.Size = new System.Drawing.Size(439, 28);
            this.textBoxTransferor.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(21, 72);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(110, 21);
            label6.TabIndex = 11;
            label6.Text = "Người chuyển";
            // 
            // textBoxTransferorID
            // 
            this.textBoxTransferorID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransferorID.Location = new System.Drawing.Point(25, 30);
            this.textBoxTransferorID.Name = "textBoxTransferorID";
            this.textBoxTransferorID.ReadOnly = true;
            this.textBoxTransferorID.Size = new System.Drawing.Size(439, 28);
            this.textBoxTransferorID.TabIndex = 10;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxCheck1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(sOTKLabel);
            this.panel2.Controls.Add(this.textBoxTransferorAccountNumber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 216);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(171, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "*";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(18, 10);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(158, 21);
            sOTKLabel.TabIndex = 2;
            sOTKLabel.Text = "Số tài khoản chuyển";
            // 
            // textBoxTransferorAccountNumber
            // 
            this.textBoxTransferorAccountNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTransferorAccountNumber.Location = new System.Drawing.Point(22, 37);
            this.textBoxTransferorAccountNumber.Name = "textBoxTransferorAccountNumber";
            this.textBoxTransferorAccountNumber.Size = new System.Drawing.Size(442, 28);
            this.textBoxTransferorAccountNumber.TabIndex = 3;
            this.textBoxTransferorAccountNumber.Validated += new System.EventHandler(this.textBoxTransferorAccountNumber_Validated);
            // 
            // pictureBoxCheck1
            // 
            this.pictureBoxCheck1.Image = global::BankingManagement.Properties.Resources.check;
            this.pictureBoxCheck1.Location = new System.Drawing.Point(470, 37);
            this.pictureBoxCheck1.Name = "pictureBoxCheck1";
            this.pictureBoxCheck1.Size = new System.Drawing.Size(31, 28);
            this.pictureBoxCheck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheck1.TabIndex = 9;
            this.pictureBoxCheck1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxCheck1, "Xác thực thành công");
            this.pictureBoxCheck1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.panelAccountOwner2);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(580, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 244);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đơn vị thụ hưởng";
            // 
            // panelAccountOwner2
            // 
            this.panelAccountOwner2.Controls.Add(this.textBoxBeneficiary);
            this.panelAccountOwner2.Controls.Add(label9);
            this.panelAccountOwner2.Controls.Add(this.textBoxBeneficiaryID);
            this.panelAccountOwner2.Controls.Add(label10);
            this.panelAccountOwner2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAccountOwner2.Location = new System.Drawing.Point(3, 99);
            this.panelAccountOwner2.Name = "panelAccountOwner2";
            this.panelAccountOwner2.Size = new System.Drawing.Size(514, 142);
            this.panelAccountOwner2.TabIndex = 8;
            this.panelAccountOwner2.Visible = false;
            // 
            // textBoxBeneficiary
            // 
            this.textBoxBeneficiary.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBeneficiary.Location = new System.Drawing.Point(25, 99);
            this.textBoxBeneficiary.Name = "textBoxBeneficiary";
            this.textBoxBeneficiary.ReadOnly = true;
            this.textBoxBeneficiary.Size = new System.Drawing.Size(439, 28);
            this.textBoxBeneficiary.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(21, 72);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(94, 21);
            label9.TabIndex = 11;
            label9.Text = "Người nhận";
            // 
            // textBoxBeneficiaryID
            // 
            this.textBoxBeneficiaryID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBeneficiaryID.Location = new System.Drawing.Point(25, 30);
            this.textBoxBeneficiaryID.Name = "textBoxBeneficiaryID";
            this.textBoxBeneficiaryID.ReadOnly = true;
            this.textBoxBeneficiaryID.Size = new System.Drawing.Size(439, 28);
            this.textBoxBeneficiaryID.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(21, 3);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(56, 21);
            label10.TabIndex = 9;
            label10.Text = "CMND";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBoxCheck2);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(label12);
            this.panel5.Controls.Add(this.textBoxBeneficiaryAccountNumber);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(514, 213);
            this.panel5.TabIndex = 8;
            // 
            // pictureBoxCheck2
            // 
            this.pictureBoxCheck2.Image = global::BankingManagement.Properties.Resources.check;
            this.pictureBoxCheck2.Location = new System.Drawing.Point(470, 37);
            this.pictureBoxCheck2.Name = "pictureBoxCheck2";
            this.pictureBoxCheck2.Size = new System.Drawing.Size(31, 28);
            this.pictureBoxCheck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCheck2.TabIndex = 9;
            this.pictureBoxCheck2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxCheck2, "Xác thực thành công");
            this.pictureBoxCheck2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(156, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(18, 10);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(142, 21);
            label12.TabIndex = 2;
            label12.Text = "Số tài khoản nhận";
            // 
            // textBoxBeneficiaryAccountNumber
            // 
            this.textBoxBeneficiaryAccountNumber.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBeneficiaryAccountNumber.Location = new System.Drawing.Point(22, 37);
            this.textBoxBeneficiaryAccountNumber.Name = "textBoxBeneficiaryAccountNumber";
            this.textBoxBeneficiaryAccountNumber.Size = new System.Drawing.Size(442, 28);
            this.textBoxBeneficiaryAccountNumber.TabIndex = 3;
            this.textBoxBeneficiaryAccountNumber.Validated += new System.EventHandler(this.textBoxBeneficiaryAccountNumber_Validated);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(580, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 185);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chuyển tiền";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxAmount);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(label8);
            this.panel1.Controls.Add(this.dateTimePickerTransactionDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 154);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(76, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "*";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(25, 34);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(439, 28);
            this.textBoxAmount.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(21, 75);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(118, 21);
            label7.TabIndex = 6;
            label7.Text = "Ngày giao dịch";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(21, 7);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(61, 21);
            label8.TabIndex = 4;
            label8.Text = "Số tiền";
            // 
            // dateTimePickerTransactionDate
            // 
            this.dateTimePickerTransactionDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionDate.Location = new System.Drawing.Point(25, 102);
            this.dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            this.dateTimePickerTransactionDate.Size = new System.Drawing.Size(439, 28);
            this.dateTimePickerTransactionDate.TabIndex = 7;
            this.dateTimePickerTransactionDate.Value = new System.DateTime(2021, 10, 12, 18, 7, 7, 0);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(392, 495);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(370, 48);
            this.buttonConfirm.TabIndex = 12;
            this.buttonConfirm.Text = "Xác nhận";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TransferMoneyForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1151, 751);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TransferMoneyForm";
            this.Text = "Chuyển tiền";
            this.Load += new System.EventHandler(this.TransferMoneyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelAccountOwner1.ResumeLayout(false);
            this.panelAccountOwner1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panelAccountOwner2.ResumeLayout(false);
            this.panelAccountOwner2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheck2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelAccountOwner1;
        private System.Windows.Forms.TextBox textBoxTransferor;
        private System.Windows.Forms.TextBox textBoxTransferorID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxCheck1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTransferorAccountNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panelAccountOwner2;
        private System.Windows.Forms.TextBox textBoxBeneficiary;
        private System.Windows.Forms.TextBox textBoxBeneficiaryID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxCheck2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBeneficiaryAccountNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionDate;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}