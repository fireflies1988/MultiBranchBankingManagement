
namespace BankingManagement
{
    partial class OpenAccountForm
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenAccountForm));
            this.groupControlAccountInfo = new DevExpress.XtraEditors.GroupControl();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataSet = new BankingManagement.AccountDataSet();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemOpenAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFinish = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBranchID = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.taiKhoanTableAdapter = new BankingManagement.AccountDataSetTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new BankingManagement.AccountDataSetTableAdapters.TableAdapterManager();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new BankingManagement.AccountDataSetTableAdapters.KhachHangTableAdapter();
            this.groupControlCustomer = new DevExpress.XtraEditors.GroupControl();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dateTimePickerOpenDate = new System.Windows.Forms.DateTimePicker();
            cMNDLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAccountInfo)).BeginInit();
            this.groupControlAccountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCustomer)).BeginInit();
            this.groupControlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(31, 44);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(46, 17);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(31, 110);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(84, 17);
            sOTKLabel.TabIndex = 2;
            sOTKLabel.Text = "Số tài khoản";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(32, 176);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(45, 17);
            sODULabel.TabIndex = 4;
            sODULabel.Text = "Số dư";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(495, 44);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(89, 17);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "Mã chi nhánh";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Location = new System.Drawing.Point(495, 110);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(64, 17);
            nGAYMOTKLabel.TabIndex = 8;
            nGAYMOTKLabel.Text = "Ngày mở";
            // 
            // groupControlAccountInfo
            // 
            this.groupControlAccountInfo.Controls.Add(this.dateTimePickerOpenDate);
            this.groupControlAccountInfo.Controls.Add(this.label9);
            this.groupControlAccountInfo.Controls.Add(this.label8);
            this.groupControlAccountInfo.Controls.Add(nGAYMOTKLabel);
            this.groupControlAccountInfo.Controls.Add(mACNLabel);
            this.groupControlAccountInfo.Controls.Add(this.textBoxBranchID);
            this.groupControlAccountInfo.Controls.Add(sODULabel);
            this.groupControlAccountInfo.Controls.Add(this.textBoxBalance);
            this.groupControlAccountInfo.Controls.Add(sOTKLabel);
            this.groupControlAccountInfo.Controls.Add(this.textBoxAccountNumber);
            this.groupControlAccountInfo.Controls.Add(cMNDLabel);
            this.groupControlAccountInfo.Controls.Add(this.textBoxCMND);
            this.groupControlAccountInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlAccountInfo.Location = new System.Drawing.Point(0, 395);
            this.groupControlAccountInfo.Name = "groupControlAccountInfo";
            this.groupControlAccountInfo.Size = new System.Drawing.Size(1149, 247);
            this.groupControlAccountInfo.TabIndex = 4;
            this.groupControlAccountInfo.Text = "Thông tin tài khoản";
            this.groupControlAccountInfo.Visible = false;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.accountDataSet;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemFinish,
            this.barButtonItemCancel,
            this.barButtonItemOpenAccount,
            this.barButtonItemRefresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.BarAppearance.Normal.Options.UseFont = true;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemOpenAccount, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemFinish, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItemOpenAccount
            // 
            this.barButtonItemOpenAccount.Caption = "Mở tài khoản mới";
            this.barButtonItemOpenAccount.Id = 2;
            this.barButtonItemOpenAccount.ImageOptions.Image = global::BankingManagement.Properties.Resources.account__1_;
            this.barButtonItemOpenAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemOpenAccount.ImageOptions.LargeImage")));
            this.barButtonItemOpenAccount.Name = "barButtonItemOpenAccount";
            this.barButtonItemOpenAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOpenAccount_ItemClick);
            // 
            // barButtonItemFinish
            // 
            this.barButtonItemFinish.Caption = "Hoàn tất";
            this.barButtonItemFinish.Id = 0;
            this.barButtonItemFinish.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemFinish.ImageOptions.SvgImage")));
            this.barButtonItemFinish.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.barButtonItemFinish.Name = "barButtonItemFinish";
            this.barButtonItemFinish.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItemFinish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFinish_ItemClick);
            // 
            // barButtonItemCancel
            // 
            this.barButtonItemCancel.Caption = "Hủy";
            this.barButtonItemCancel.Id = 1;
            this.barButtonItemCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemCancel.ImageOptions.SvgImage")));
            this.barButtonItemCancel.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.barButtonItemCancel.Name = "barButtonItemCancel";
            this.barButtonItemCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItemCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancel_ItemClick);
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Refresh";
            this.barButtonItemRefresh.Id = 3;
            this.barButtonItemRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemRefresh.ImageOptions.SvgImage")));
            this.barButtonItemRefresh.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            this.barButtonItemRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemRefresh_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1149, 71);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 642);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1149, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 71);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 571);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1149, 71);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 571);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(73, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "*";
            this.toolTip1.SetToolTip(this.label9, "Không được để trống");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(110, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "*";
            this.toolTip1.SetToolTip(this.label8, "Không được để trống");
            // 
            // textBoxBranchID
            // 
            this.textBoxBranchID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBindingSource, "MACN", true));
            this.textBoxBranchID.Location = new System.Drawing.Point(498, 64);
            this.textBoxBranchID.Name = "textBoxBranchID";
            this.textBoxBranchID.ReadOnly = true;
            this.textBoxBranchID.Size = new System.Drawing.Size(404, 23);
            this.textBoxBranchID.TabIndex = 7;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBindingSource, "SODU", true));
            this.textBoxBalance.Location = new System.Drawing.Point(34, 196);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(222, 23);
            this.textBoxBalance.TabIndex = 5;
            this.textBoxBalance.Text = "0";
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBindingSource, "SOTK", true));
            this.textBoxAccountNumber.Location = new System.Drawing.Point(34, 130);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(354, 23);
            this.textBoxAccountNumber.TabIndex = 3;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBindingSource, "CMND", true));
            this.textBoxCMND.Location = new System.Drawing.Point(34, 64);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.ReadOnly = true;
            this.textBoxCMND.Size = new System.Drawing.Size(354, 23);
            this.textBoxCMND.TabIndex = 1;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = BankingManagement.AccountDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.accountDataSet;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // groupControlCustomer
            // 
            this.groupControlCustomer.Controls.Add(this.khachHangGridControl);
            this.groupControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlCustomer.Location = new System.Drawing.Point(0, 71);
            this.groupControlCustomer.Name = "groupControlCustomer";
            this.groupControlCustomer.Size = new System.Drawing.Size(1149, 324);
            this.groupControlCustomer.TabIndex = 9;
            this.groupControlCustomer.Text = "Khách hàng";
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.khachHangBindingSource;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHangGridControl.Location = new System.Drawing.Point(2, 28);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.MenuManager = this.barManager1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1145, 294);
            this.khachHangGridControl.TabIndex = 0;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colMACN});
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 94;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 25;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            this.colMACN.Width = 94;
            // 
            // dateTimePickerOpenDate
            // 
            this.dateTimePickerOpenDate.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dateTimePickerOpenDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taiKhoanBindingSource, "NGAYMOTK", true));
            this.dateTimePickerOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOpenDate.Location = new System.Drawing.Point(498, 130);
            this.dateTimePickerOpenDate.Name = "dateTimePickerOpenDate";
            this.dateTimePickerOpenDate.Size = new System.Drawing.Size(346, 23);
            this.dateTimePickerOpenDate.TabIndex = 26;
            this.dateTimePickerOpenDate.Value = new System.DateTime(2021, 11, 28, 0, 10, 26, 0);
            // 
            // OpenAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1149, 662);
            this.Controls.Add(this.groupControlCustomer);
            this.Controls.Add(this.groupControlAccountInfo);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "OpenAccountForm";
            this.Text = "Mở tài khoản";
            this.Load += new System.EventHandler(this.OpenAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAccountInfo)).EndInit();
            this.groupControlAccountInfo.ResumeLayout(false);
            this.groupControlAccountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCustomer)).EndInit();
            this.groupControlCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemFinish;
        private DevExpress.XtraEditors.GroupControl groupControlAccountInfo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancel;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private AccountDataSet accountDataSet;
        private AccountDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private AccountDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxBranchID;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.TextBox textBoxCMND;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private AccountDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControlCustomer;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraBars.BarButtonItem barButtonItemOpenAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOpenDate;
    }
}