
namespace BankingManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItemEmployeeID = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemEmployeeName = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemGroupName = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCreateLoginAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOpenAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemWithdrawDeposit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemTransfer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageTransaction = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barStaticItemEmployeeID,
            this.barStaticItemEmployeeName,
            this.barStaticItemGroupName,
            this.barButtonItemLogout,
            this.barButtonItemCreateLoginAccount,
            this.barButtonItemEmployee,
            this.barButtonItemCustomer,
            this.barButtonItemOpenAccount,
            this.barButtonItemWithdrawDeposit,
            this.barButtonItemTransfer,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 23;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage4,
            this.ribbonPageTransaction,
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1223, 193);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barStaticItemEmployeeID
            // 
            this.barStaticItemEmployeeID.Caption = "MANV";
            this.barStaticItemEmployeeID.Id = 5;
            this.barStaticItemEmployeeID.Name = "barStaticItemEmployeeID";
            // 
            // barStaticItemEmployeeName
            // 
            this.barStaticItemEmployeeName.Caption = "HOTEN";
            this.barStaticItemEmployeeName.Id = 6;
            this.barStaticItemEmployeeName.Name = "barStaticItemEmployeeName";
            // 
            // barStaticItemGroupName
            // 
            this.barStaticItemGroupName.Caption = "NHOM";
            this.barStaticItemGroupName.Id = 7;
            this.barStaticItemGroupName.Name = "barStaticItemGroupName";
            // 
            // barButtonItemLogout
            // 
            this.barButtonItemLogout.Caption = "Đăng xuất";
            this.barButtonItemLogout.Id = 9;
            this.barButtonItemLogout.ImageOptions.Image = global::BankingManagement.Properties.Resources.log_out;
            this.barButtonItemLogout.Name = "barButtonItemLogout";
            this.barButtonItemLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLogout_ItemClick);
            // 
            // barButtonItemCreateLoginAccount
            // 
            this.barButtonItemCreateLoginAccount.Caption = "Tạo tài khoản";
            this.barButtonItemCreateLoginAccount.Id = 12;
            this.barButtonItemCreateLoginAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemCreateLoginAccount.ImageOptions.Image")));
            this.barButtonItemCreateLoginAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCreateLoginAccount.ImageOptions.LargeImage")));
            this.barButtonItemCreateLoginAccount.Name = "barButtonItemCreateLoginAccount";
            this.barButtonItemCreateLoginAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonItemCreateLoginAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCreateLoginAccount_ItemClick);
            // 
            // barButtonItemEmployee
            // 
            this.barButtonItemEmployee.Caption = "Nhân viên";
            this.barButtonItemEmployee.Id = 13;
            this.barButtonItemEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemEmployee.ImageOptions.Image")));
            this.barButtonItemEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemEmployee.ImageOptions.LargeImage")));
            this.barButtonItemEmployee.Name = "barButtonItemEmployee";
            this.barButtonItemEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEmployee_ItemClick);
            // 
            // barButtonItemCustomer
            // 
            this.barButtonItemCustomer.Caption = "Khách hàng";
            this.barButtonItemCustomer.Id = 14;
            this.barButtonItemCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemCustomer.ImageOptions.Image")));
            this.barButtonItemCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCustomer.ImageOptions.LargeImage")));
            this.barButtonItemCustomer.Name = "barButtonItemCustomer";
            this.barButtonItemCustomer.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)));
            this.barButtonItemCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCustomer_ItemClick);
            // 
            // barButtonItemOpenAccount
            // 
            this.barButtonItemOpenAccount.Caption = "Mở tài khoản khách hàng";
            this.barButtonItemOpenAccount.Id = 15;
            this.barButtonItemOpenAccount.ImageOptions.Image = global::BankingManagement.Properties.Resources.atm_card;
            this.barButtonItemOpenAccount.Name = "barButtonItemOpenAccount";
            this.barButtonItemOpenAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemOpenAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpenAccount_ItemClick);
            // 
            // barButtonItemWithdrawDeposit
            // 
            this.barButtonItemWithdrawDeposit.Caption = "Gởi tiền Rút tiền";
            this.barButtonItemWithdrawDeposit.Id = 16;
            this.barButtonItemWithdrawDeposit.ImageOptions.Image = global::BankingManagement.Properties.Resources.deposit;
            this.barButtonItemWithdrawDeposit.Name = "barButtonItemWithdrawDeposit";
            this.barButtonItemWithdrawDeposit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemWithdrawDeposit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemWithdrawDeposit_ItemClick);
            // 
            // barButtonItemTransfer
            // 
            this.barButtonItemTransfer.Caption = "Chuyển tiền";
            this.barButtonItemTransfer.Id = 17;
            this.barButtonItemTransfer.ImageOptions.Image = global::BankingManagement.Properties.Resources.transfer_money;
            this.barButtonItemTransfer.Name = "barButtonItemTransfer";
            this.barButtonItemTransfer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemTransfer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemTransfer_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Sao kê giao dịch";
            this.barButtonItem6.Id = 18;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Danh sách các tài khoản mở";
            this.barButtonItem7.Id = 19;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Danh sách khách hàng theo chi nhánh";
            this.barButtonItem8.Id = 20;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Gởi tiền / Rút tiền";
            this.barButtonItem9.Id = 21;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 22;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemCreateLoginAccount);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemLogout);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Danh mục";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItemEmployee);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItemCustomer);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Cập nhật";
            // 
            // ribbonPageTransaction
            // 
            this.ribbonPageTransaction.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonPageTransaction.Name = "ribbonPageTransaction";
            this.ribbonPageTransaction.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemOpenAccount);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemWithdrawDeposit);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemTransfer);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Giao dịch";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Báo cáo";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItemEmployeeID);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItemEmployeeName);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItemGroupName);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 707);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1223, 30);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 737);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Ngân hàng ACB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLogout;
        private DevExpress.XtraBars.BarStaticItem barStaticItemEmployeeID;
        private DevExpress.XtraBars.BarStaticItem barStaticItemEmployeeName;
        private DevExpress.XtraBars.BarStaticItem barStaticItemGroupName;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCreateLoginAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEmployee;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCustomer;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItemWithdrawDeposit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemTransfer;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

