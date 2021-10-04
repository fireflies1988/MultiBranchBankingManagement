
namespace BankingManagement
{
    partial class CustomerForm
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
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemModify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.groupControlInformation = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.dateEditDateOfIssue = new DevExpress.XtraEditors.DateEdit();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new BankingManagement.CustomerDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.textBoxBranchID = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFamilyName = new System.Windows.Forms.TextBox();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khachHangTableAdapter = new BankingManagement.CustomerDataSetTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new BankingManagement.CustomerDataSetTableAdapters.TableAdapterManager();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInformation)).BeginInit();
            this.groupControlInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOfIssue.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOfIssue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(495, 227);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(66, 17);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Ngày cấp";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(495, 102);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(33, 17);
            pHAILabel.TabIndex = 13;
            pHAILabel.Text = "Phái";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(495, 41);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(89, 17);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "Mã chi nhánh";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(26, 227);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(34, 17);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "SĐT";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(26, 166);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(48, 17);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(285, 102);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(31, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(26, 102);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(25, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(26, 41);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(46, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "CMND";
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
            this.barButtonItemAdd,
            this.barButtonItemModify,
            this.barButtonItemDelete,
            this.barButtonItemUndo,
            this.barButtonItemSave,
            this.barButtonItemCancel,
            this.barButtonItemRefresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemModify, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItemAdd
            // 
            this.barButtonItemAdd.Caption = "Thêm";
            this.barButtonItemAdd.Id = 0;
            this.barButtonItemAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemAdd.ImageOptions.SvgImage")));
            this.barButtonItemAdd.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.barButtonItemAdd.Name = "barButtonItemAdd";
            this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
            // 
            // barButtonItemModify
            // 
            this.barButtonItemModify.Caption = "Sửa";
            this.barButtonItemModify.Id = 1;
            this.barButtonItemModify.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemModify.ImageOptions.SvgImage")));
            this.barButtonItemModify.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.barButtonItemModify.Name = "barButtonItemModify";
            this.barButtonItemModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemModify_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Xóa";
            this.barButtonItemDelete.Id = 2;
            this.barButtonItemDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemDelete.ImageOptions.SvgImage")));
            this.barButtonItemDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
            // 
            // barButtonItemUndo
            // 
            this.barButtonItemUndo.Caption = "Hoàn tác";
            this.barButtonItemUndo.Enabled = false;
            this.barButtonItemUndo.Id = 3;
            this.barButtonItemUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemUndo.ImageOptions.SvgImage")));
            this.barButtonItemUndo.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.barButtonItemUndo.Name = "barButtonItemUndo";
            this.barButtonItemUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUndo_ItemClick);
            // 
            // barButtonItemSave
            // 
            this.barButtonItemSave.Caption = "Lưu";
            this.barButtonItemSave.Id = 4;
            this.barButtonItemSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemSave.ImageOptions.SvgImage")));
            this.barButtonItemSave.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.barButtonItemSave.Name = "barButtonItemSave";
            this.barButtonItemSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSave_ItemClick);
            // 
            // barButtonItemCancel
            // 
            this.barButtonItemCancel.Caption = "Hủy";
            this.barButtonItemCancel.Id = 5;
            this.barButtonItemCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemCancel.ImageOptions.SvgImage")));
            this.barButtonItemCancel.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.barButtonItemCancel.Name = "barButtonItemCancel";
            this.barButtonItemCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItemCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancel_ItemClick);
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Refresh";
            this.barButtonItemRefresh.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1192, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 724);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1192, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 663);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1192, 61);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 663);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.comboBoxBranch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 61);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1192, 62);
            this.panelControl1.TabIndex = 5;
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(12, 15);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(322, 32);
            this.comboBoxBranch.TabIndex = 0;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // groupControlInformation
            // 
            this.groupControlInformation.Controls.Add(this.label5);
            this.groupControlInformation.Controls.Add(this.dateEditDateOfIssue);
            this.groupControlInformation.Controls.Add(this.label4);
            this.groupControlInformation.Controls.Add(this.label3);
            this.groupControlInformation.Controls.Add(this.label2);
            this.groupControlInformation.Controls.Add(this.label1);
            this.groupControlInformation.Controls.Add(trangThaiXoaLabel);
            this.groupControlInformation.Controls.Add(pHAILabel);
            this.groupControlInformation.Controls.Add(this.comboBoxSex);
            this.groupControlInformation.Controls.Add(mACNLabel);
            this.groupControlInformation.Controls.Add(this.textBoxBranchID);
            this.groupControlInformation.Controls.Add(sODTLabel);
            this.groupControlInformation.Controls.Add(this.textBoxPhoneNumber);
            this.groupControlInformation.Controls.Add(dIACHILabel);
            this.groupControlInformation.Controls.Add(this.textBoxAddress);
            this.groupControlInformation.Controls.Add(tENLabel);
            this.groupControlInformation.Controls.Add(this.textBoxName);
            this.groupControlInformation.Controls.Add(hOLabel);
            this.groupControlInformation.Controls.Add(this.textBoxFamilyName);
            this.groupControlInformation.Controls.Add(mANVLabel);
            this.groupControlInformation.Controls.Add(this.textBoxCMND);
            this.groupControlInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlInformation.Enabled = false;
            this.groupControlInformation.Location = new System.Drawing.Point(0, 426);
            this.groupControlInformation.Name = "groupControlInformation";
            this.groupControlInformation.Size = new System.Drawing.Size(1192, 298);
            this.groupControlInformation.TabIndex = 11;
            this.groupControlInformation.Text = "Thông tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(556, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "*";
            // 
            // dateEditDateOfIssue
            // 
            this.dateEditDateOfIssue.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "NGAYCAP", true));
            this.dateEditDateOfIssue.EditValue = null;
            this.dateEditDateOfIssue.Location = new System.Drawing.Point(498, 248);
            this.dateEditDateOfIssue.MenuManager = this.barManager1;
            this.dateEditDateOfIssue.Name = "dateEditDateOfIssue";
            this.dateEditDateOfIssue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDateOfIssue.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDateOfIssue.Size = new System.Drawing.Size(179, 22);
            this.dateEditDateOfIssue.TabIndex = 20;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(73, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(313, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(50, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "*";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "PHAI", true));
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxSex.Location = new System.Drawing.Point(498, 122);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(179, 24);
            this.comboBoxSex.TabIndex = 14;
            // 
            // textBoxBranchID
            // 
            this.textBoxBranchID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "MACN", true));
            this.textBoxBranchID.Location = new System.Drawing.Point(498, 61);
            this.textBoxBranchID.Name = "textBoxBranchID";
            this.textBoxBranchID.ReadOnly = true;
            this.textBoxBranchID.Size = new System.Drawing.Size(368, 23);
            this.textBoxBranchID.TabIndex = 13;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "SODT", true));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(29, 247);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(246, 23);
            this.textBoxPhoneNumber.TabIndex = 11;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "DIACHI", true));
            this.textBoxAddress.Location = new System.Drawing.Point(29, 186);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(837, 23);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "TEN", true));
            this.textBoxName.Location = new System.Drawing.Point(288, 122);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxFamilyName
            // 
            this.textBoxFamilyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "HO", true));
            this.textBoxFamilyName.Location = new System.Drawing.Point(29, 122);
            this.textBoxFamilyName.Name = "textBoxFamilyName";
            this.textBoxFamilyName.Size = new System.Drawing.Size(246, 23);
            this.textBoxFamilyName.TabIndex = 3;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "CMND", true));
            this.textBoxCMND.Location = new System.Drawing.Point(29, 61);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Size = new System.Drawing.Size(359, 23);
            this.textBoxCMND.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.khachHangGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1192, 303);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "Khách hàng";
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.khachHangBindingSource;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHangGridControl.Location = new System.Drawing.Point(2, 28);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.MenuManager = this.barManager1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1188, 273);
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
            this.colSODT,
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
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 94;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.UpdateOrder = BankingManagement.CustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 744);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControlInformation);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CustomerForm";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInformation)).EndInit();
            this.groupControlInformation.ResumeLayout(false);
            this.groupControlInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOfIssue.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOfIssue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
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
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemModify;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUndo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancel;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private DevExpress.XtraEditors.GroupControl groupControlInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.TextBox textBoxBranchID;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFamilyName;
        private System.Windows.Forms.TextBox textBoxCMND;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private CustomerDataSet customerDataSet;
        private CustomerDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private CustomerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dateEditDateOfIssue;
    }
}