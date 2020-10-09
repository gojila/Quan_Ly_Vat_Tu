namespace Quan_Ly_Vat_Tu
{
    partial class frmXuatNhapTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatNhapTon));
            this.img = new DevExpress.Utils.ImageCollection(this.components);
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiXem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtKhoHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.kHOHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKho = new Quan_Ly_Vat_Tu.Kho.DS.dsKho();
            this.txtKhoHang_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Kho1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_Dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThu_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dtDen = new DevExpress.XtraEditors.DateEdit();
            this.dtTu = new DevExpress.XtraEditors.DateEdit();
            this.cbChonNgay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.xuatNhapTonTheoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsXuatNhapTon = new Quan_Ly_Vat_Tu.XuatNhapTon.DataSet.dsXuatNhapTon();
            this.gbList = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colMa_Hang_Hoa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTen_Hang = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLo_Vat_Tu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSerial_No = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDon_Vi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMa_Kho_Hang = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTen_Kho = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTen_Nhom_Hang = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colThanh_Tien_Dau_Ky = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rptMayTinh = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colThanh_Tien_Nhap_Trong_Ky = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colThanh_Tien_Xuat_Trong_Ky = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colThanh_Tien_Cuoi_Ky = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNhom_Hang = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSo_Luong_Dau_Ky = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSo_Luong_Nhap_Trong_Ky = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSo_Luong_Xuat_Trong_Ky = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSo_Luong_Cuoi_Ky = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.kHO_HANGTableAdapter = new Quan_Ly_Vat_Tu.Kho.DS.dsKhoTableAdapters.KHO_HANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoHang_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuatNhapTonTheoNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsXuatNhapTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            this.img.Images.SetKeyName(0, "abort.png");
            this.img.Images.SetKeyName(1, "about.png");
            this.img.Images.SetKeyName(2, "accept.png");
            this.img.Images.SetKeyName(3, "add.png");
            this.img.Images.SetKeyName(4, "application.png");
            this.img.Images.SetKeyName(5, "apply.png");
            this.img.Images.SetKeyName(6, "attention.png");
            this.img.Images.SetKeyName(7, "back.png");
            this.img.Images.SetKeyName(8, "cancel.png");
            this.img.Images.SetKeyName(9, "circulation.png");
            this.img.Images.SetKeyName(10, "close.png");
            this.img.Images.SetKeyName(11, "create.png");
            this.img.Images.SetKeyName(12, "cut.png");
            this.img.Images.SetKeyName(13, "danger.png");
            this.img.Images.SetKeyName(14, "delete.png");
            this.img.Images.SetKeyName(15, "down.png");
            this.img.Images.SetKeyName(16, "erase.png");
            this.img.Images.SetKeyName(17, "error.png");
            this.img.Images.SetKeyName(18, "forward.png");
            this.img.Images.SetKeyName(19, "help.png");
            this.img.Images.SetKeyName(20, "info.png");
            this.img.Images.SetKeyName(21, "information.png");
            this.img.Images.SetKeyName(22, "logout.png");
            this.img.Images.SetKeyName(23, "minus.png");
            this.img.Images.SetKeyName(24, "move.png");
            this.img.Images.SetKeyName(25, "next.png");
            this.img.Images.SetKeyName(26, "no entry.png");
            this.img.Images.SetKeyName(27, "no.png");
            this.img.Images.SetKeyName(28, "OK.png");
            this.img.Images.SetKeyName(29, "options.png");
            this.img.Images.SetKeyName(30, "plus.png");
            this.img.Images.SetKeyName(31, "previous.png");
            this.img.Images.SetKeyName(32, "problem.png");
            this.img.Images.SetKeyName(33, "question.png");
            this.img.Images.SetKeyName(34, "redo.png");
            this.img.Images.SetKeyName(35, "refresh.png");
            this.img.Images.SetKeyName(36, "remove.png");
            this.img.Images.SetKeyName(37, "renew.png");
            this.img.Images.SetKeyName(38, "repeat.png");
            this.img.Images.SetKeyName(39, "run.png");
            this.img.Images.SetKeyName(40, "save.png");
            this.img.Images.SetKeyName(41, "search.png");
            this.img.Images.SetKeyName(42, "settings.png");
            this.img.Images.SetKeyName(43, "stop.png");
            this.img.Images.SetKeyName(44, "switch.png");
            this.img.Images.SetKeyName(45, "sync.png");
            this.img.Images.SetKeyName(46, "system.png");
            this.img.Images.SetKeyName(47, "turn off.png");
            this.img.Images.SetKeyName(48, "undo.png");
            this.img.Images.SetKeyName(49, "up.png");
            this.img.Images.SetKeyName(50, "update.png");
            this.img.Images.SetKeyName(51, "view.png");
            this.img.Images.SetKeyName(52, "warning.png");
            this.img.Images.SetKeyName(53, "yes.png");
            this.img.Images.SetKeyName(54, "document-excel-icon.png");
            this.img.Images.SetKeyName(55, "Excel-icon (1).png");
            this.img.Images.SetKeyName(56, "Excel-icon (2).png");
            this.img.Images.SetKeyName(57, "Excel-icon.png");
            // 
            // bm
            // 
            this.bm.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.bm.DockControls.Add(this.barDockControlTop);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
            this.bm.Form = this;
            this.bm.Images = this.img;
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiXem,
            this.bbiSua,
            this.bbiXoa,
            this.bbiDong,
            this.bbiXuatExcel});
            this.bm.LargeImages = this.img;
            this.bm.MainMenu = this.bar2;
            this.bm.MaxItemId = 13;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(49, 160);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXem, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.bbiSua, false),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.bbiXoa, false),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiXuatExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDong)});
            this.bar2.OptionsBar.AllowDelete = true;
            this.bar2.OptionsBar.DrawSizeGrip = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiXem
            // 
            this.bbiXem.Caption = "Xem";
            this.bbiXem.Id = 0;
            this.bbiXem.ImageOptions.ImageIndex = 35;
            this.bbiXem.Name = "bbiXem";
            this.bbiXem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiXem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXem_ItemClick);
            // 
            // bbiSua
            // 
            this.bbiSua.Caption = "Sửa";
            this.bbiSua.Id = 1;
            this.bbiSua.ImageOptions.ImageIndex = 29;
            this.bbiSua.Name = "bbiSua";
            this.bbiSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiSua.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bbiXoa
            // 
            this.bbiXoa.Caption = "Xóa";
            this.bbiXoa.Id = 2;
            this.bbiXoa.ImageOptions.ImageIndex = 16;
            this.bbiXoa.Name = "bbiXoa";
            this.bbiXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bbiXuatExcel
            // 
            this.bbiXuatExcel.Caption = "Xuất Excel";
            this.bbiXuatExcel.Id = 12;
            this.bbiXuatExcel.ImageOptions.ImageIndex = 55;
            this.bbiXuatExcel.Name = "bbiXuatExcel";
            this.bbiXuatExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXuatExcel_ItemClick);
            // 
            // bbiDong
            // 
            this.bbiDong.Caption = "Đóng";
            this.bbiDong.Id = 6;
            this.bbiDong.ImageOptions.ImageIndex = 10;
            this.bbiDong.Name = "bbiDong";
            this.bbiDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bm;
            this.barDockControlTop.Size = new System.Drawing.Size(1102, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 416);
            this.barDockControlBottom.Manager = this.bm;
            this.barDockControlBottom.Size = new System.Drawing.Size(1102, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.bm;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 392);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1102, 24);
            this.barDockControlRight.Manager = this.bm;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 392);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtKhoHang);
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Controls.Add(this.dtDen);
            this.layoutControl1.Controls.Add(this.dtTu);
            this.layoutControl1.Controls.Add(this.cbChonNgay);
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1102, 392);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtKhoHang
            // 
            this.txtKhoHang.EditValue = "";
            this.txtKhoHang.Location = new System.Drawing.Point(55, 2);
            this.txtKhoHang.MenuManager = this.bm;
            this.txtKhoHang.Name = "txtKhoHang";
            this.txtKhoHang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtKhoHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKhoHang.Properties.DataSource = this.kHOHANGBindingSource;
            this.txtKhoHang.Properties.DisplayMember = "Ten_Kho";
            this.txtKhoHang.Properties.NullText = "";
            this.txtKhoHang.Properties.NullValuePrompt = "(Kho Hàng)";
            this.txtKhoHang.Properties.PopupView = this.txtKhoHang_View;
            this.txtKhoHang.Properties.ValueMember = "Ma_Kho";
            this.txtKhoHang.Size = new System.Drawing.Size(121, 20);
            this.txtKhoHang.StyleController = this.layoutControl1;
            this.txtKhoHang.TabIndex = 9;
            this.txtKhoHang.EditValueChanged += new System.EventHandler(this.txtKhoHang_EditValueChanged);
            // 
            // kHOHANGBindingSource
            // 
            this.kHOHANGBindingSource.DataMember = "KHO_HANG";
            this.kHOHANGBindingSource.DataSource = this.dsKho;
            // 
            // dsKho
            // 
            this.dsKho.DataSetName = "dsKho";
            this.dsKho.EnforceConstraints = false;
            this.dsKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtKhoHang_View
            // 
            this.txtKhoHang_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Kho,
            this.colTen_Kho1,
            this.colDia_Chi,
            this.colEmail,
            this.colDien_Thoai,
            this.colFax,
            this.colDi_Dong,
            this.colThu_Kho,
            this.colGhi_Chu});
            this.txtKhoHang_View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtKhoHang_View.Name = "txtKhoHang_View";
            this.txtKhoHang_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtKhoHang_View.OptionsView.ShowAutoFilterRow = true;
            this.txtKhoHang_View.OptionsView.ShowGroupPanel = false;
            // 
            // colMa_Kho
            // 
            this.colMa_Kho.Caption = "Mã Kho";
            this.colMa_Kho.FieldName = "Ma_Kho";
            this.colMa_Kho.Name = "colMa_Kho";
            this.colMa_Kho.OptionsColumn.ReadOnly = true;
            this.colMa_Kho.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa_Kho.Visible = true;
            this.colMa_Kho.VisibleIndex = 0;
            // 
            // colTen_Kho1
            // 
            this.colTen_Kho1.Caption = "Tên Kho";
            this.colTen_Kho1.FieldName = "Ten_Kho";
            this.colTen_Kho1.Name = "colTen_Kho1";
            this.colTen_Kho1.OptionsColumn.ReadOnly = true;
            this.colTen_Kho1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Kho1.Visible = true;
            this.colTen_Kho1.VisibleIndex = 1;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.Caption = "Địa Chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.OptionsColumn.ReadOnly = true;
            this.colDia_Chi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colDien_Thoai
            // 
            this.colDien_Thoai.Caption = "Điện Thoại";
            this.colDien_Thoai.FieldName = "Dien_Thoai";
            this.colDien_Thoai.Name = "colDien_Thoai";
            this.colDien_Thoai.OptionsColumn.ReadOnly = true;
            this.colDien_Thoai.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDien_Thoai.Visible = true;
            this.colDien_Thoai.VisibleIndex = 4;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.ReadOnly = true;
            this.colFax.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 5;
            // 
            // colDi_Dong
            // 
            this.colDi_Dong.Caption = "Di Động";
            this.colDi_Dong.FieldName = "Di_Dong";
            this.colDi_Dong.Name = "colDi_Dong";
            this.colDi_Dong.OptionsColumn.ReadOnly = true;
            this.colDi_Dong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDi_Dong.Visible = true;
            this.colDi_Dong.VisibleIndex = 6;
            // 
            // colThu_Kho
            // 
            this.colThu_Kho.Caption = "Thủ Kho";
            this.colThu_Kho.FieldName = "Thu_Kho";
            this.colThu_Kho.Name = "colThu_Kho";
            this.colThu_Kho.OptionsColumn.ReadOnly = true;
            this.colThu_Kho.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colThu_Kho.Visible = true;
            this.colThu_Kho.VisibleIndex = 7;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.Caption = "Ghi Chú";
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.OptionsColumn.ReadOnly = true;
            this.colGhi_Chu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 8;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Location = new System.Drawing.Point(613, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(487, 20);
            this.layoutControl2.TabIndex = 8;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(487, 20);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // dtDen
            // 
            this.dtDen.EditValue = null;
            this.dtDen.Location = new System.Drawing.Point(523, 2);
            this.dtDen.MenuManager = this.bm;
            this.dtDen.Name = "dtDen";
            this.dtDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtDen.Size = new System.Drawing.Size(86, 20);
            this.dtDen.StyleController = this.layoutControl1;
            this.dtDen.TabIndex = 7;
            // 
            // dtTu
            // 
            this.dtTu.EditValue = null;
            this.dtTu.Location = new System.Drawing.Point(383, 2);
            this.dtTu.MenuManager = this.bm;
            this.dtTu.Name = "dtTu";
            this.dtTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtTu.Size = new System.Drawing.Size(83, 20);
            this.dtTu.StyleController = this.layoutControl1;
            this.dtTu.TabIndex = 6;
            // 
            // cbChonNgay
            // 
            this.cbChonNgay.Location = new System.Drawing.Point(235, 2);
            this.cbChonNgay.MenuManager = this.bm;
            this.cbChonNgay.Name = "cbChonNgay";
            this.cbChonNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonNgay.Properties.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbChonNgay.Size = new System.Drawing.Size(91, 20);
            this.cbChonNgay.StyleController = this.layoutControl1;
            this.cbChonNgay.TabIndex = 5;
            this.cbChonNgay.SelectedIndexChanged += new System.EventHandler(this.cbChonNgay_SelectedIndexChanged);
            // 
            // gcList
            // 
            this.gcList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcList.DataSource = this.xuatNhapTonTheoNgayBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 26);
            this.gcList.MainView = this.gbList;
            this.gcList.MenuManager = this.bm;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rptMayTinh});
            this.gcList.Size = new System.Drawing.Size(1098, 364);
            this.gcList.TabIndex = 4;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // xuatNhapTonTheoNgayBindingSource
            // 
            this.xuatNhapTonTheoNgayBindingSource.DataMember = "Xuat_Nhap_Ton_Theo_Ngay";
            this.xuatNhapTonTheoNgayBindingSource.DataSource = this.dsXuatNhapTon;
            // 
            // dsXuatNhapTon
            // 
            this.dsXuatNhapTon.DataSetName = "dsXuatNhapTon";
            this.dsXuatNhapTon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gbList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Red;
            this.gbList.Appearance.GroupRow.Options.UseFont = true;
            this.gbList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gbList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand5,
            this.gridBand4});
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colMa_Hang_Hoa,
            this.colTen_Hang,
            this.colDon_Vi,
            this.colMa_Kho_Hang,
            this.colTen_Kho,
            this.colSo_Luong_Dau_Ky,
            this.colSo_Luong_Nhap_Trong_Ky,
            this.colSo_Luong_Xuat_Trong_Ky,
            this.colSo_Luong_Cuoi_Ky,
            this.colThanh_Tien_Dau_Ky,
            this.colThanh_Tien_Nhap_Trong_Ky,
            this.colThanh_Tien_Xuat_Trong_Ky,
            this.colThanh_Tien_Cuoi_Ky,
            this.colNhom_Hang,
            this.colTen_Nhom_Hang,
            this.colLo_Vat_Tu,
            this.colSerial_No});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupCount = 1;
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để nhóm dữ liệu";
            this.gbList.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong_Dau_Ky", this.colSo_Luong_Dau_Ky, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong_Nhap_Trong_Ky", this.colSo_Luong_Nhap_Trong_Ky, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong_Xuat_Trong_Ky", this.colSo_Luong_Xuat_Trong_Ky, "{0:##,##0.###}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong_Cuoi_Ky", this.colSo_Luong_Cuoi_Ky, "{0:##,##0.###}")});
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AutoExpandAllGroups = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTen_Kho, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Columns.Add(this.colMa_Hang_Hoa);
            this.gridBand1.Columns.Add(this.colTen_Hang);
            this.gridBand1.Columns.Add(this.colLo_Vat_Tu);
            this.gridBand1.Columns.Add(this.colSerial_No);
            this.gridBand1.Columns.Add(this.colDon_Vi);
            this.gridBand1.Columns.Add(this.colMa_Kho_Hang);
            this.gridBand1.Columns.Add(this.colTen_Kho);
            this.gridBand1.Columns.Add(this.colTen_Nhom_Hang);
            this.gridBand1.Columns.Add(this.colThanh_Tien_Dau_Ky);
            this.gridBand1.Columns.Add(this.colThanh_Tien_Nhap_Trong_Ky);
            this.gridBand1.Columns.Add(this.colThanh_Tien_Xuat_Trong_Ky);
            this.gridBand1.Columns.Add(this.colThanh_Tien_Cuoi_Ky);
            this.gridBand1.Columns.Add(this.colNhom_Hang);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 539;
            // 
            // colMa_Hang_Hoa
            // 
            this.colMa_Hang_Hoa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_Hang_Hoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_Hang_Hoa.Caption = "Mã Vật Tư";
            this.colMa_Hang_Hoa.FieldName = "Ma_Hang";
            this.colMa_Hang_Hoa.Name = "colMa_Hang_Hoa";
            this.colMa_Hang_Hoa.OptionsColumn.ReadOnly = true;
            this.colMa_Hang_Hoa.Visible = true;
            this.colMa_Hang_Hoa.Width = 89;
            // 
            // colTen_Hang
            // 
            this.colTen_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Hang.Caption = "Tên Vật Tư";
            this.colTen_Hang.FieldName = "Ten_Hang";
            this.colTen_Hang.Name = "colTen_Hang";
            this.colTen_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Hang.Visible = true;
            // 
            // colLo_Vat_Tu
            // 
            this.colLo_Vat_Tu.AppearanceHeader.Options.UseTextOptions = true;
            this.colLo_Vat_Tu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLo_Vat_Tu.Caption = "Lô Vật Tư";
            this.colLo_Vat_Tu.FieldName = "Lo_Vat_Tu";
            this.colLo_Vat_Tu.Name = "colLo_Vat_Tu";
            this.colLo_Vat_Tu.Visible = true;
            // 
            // colSerial_No
            // 
            this.colSerial_No.AppearanceHeader.Options.UseTextOptions = true;
            this.colSerial_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSerial_No.Caption = "Serial No";
            this.colSerial_No.FieldName = "Serial_No";
            this.colSerial_No.Name = "colSerial_No";
            this.colSerial_No.Visible = true;
            // 
            // colDon_Vi
            // 
            this.colDon_Vi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDon_Vi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDon_Vi.Caption = "Đơn Vị";
            this.colDon_Vi.FieldName = "Don_Vi";
            this.colDon_Vi.Name = "colDon_Vi";
            this.colDon_Vi.OptionsColumn.ReadOnly = true;
            this.colDon_Vi.Visible = true;
            // 
            // colMa_Kho_Hang
            // 
            this.colMa_Kho_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_Kho_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_Kho_Hang.Caption = "Mã Kho";
            this.colMa_Kho_Hang.FieldName = "Ma_Kho";
            this.colMa_Kho_Hang.Name = "colMa_Kho_Hang";
            this.colMa_Kho_Hang.OptionsColumn.ReadOnly = true;
            this.colMa_Kho_Hang.Visible = true;
            // 
            // colTen_Kho
            // 
            this.colTen_Kho.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Kho.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Kho.Caption = "Kho Hàng";
            this.colTen_Kho.FieldName = "Ten_Kho";
            this.colTen_Kho.Name = "colTen_Kho";
            this.colTen_Kho.OptionsColumn.ReadOnly = true;
            this.colTen_Kho.Visible = true;
            // 
            // colTen_Nhom_Hang
            // 
            this.colTen_Nhom_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Nhom_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Nhom_Hang.Caption = "Nhóm Hàng";
            this.colTen_Nhom_Hang.FieldName = "Ten_Nhom_Hang";
            this.colTen_Nhom_Hang.Name = "colTen_Nhom_Hang";
            this.colTen_Nhom_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Nhom_Hang.Width = 101;
            // 
            // colThanh_Tien_Dau_Ky
            // 
            this.colThanh_Tien_Dau_Ky.AppearanceHeader.Options.UseTextOptions = true;
            this.colThanh_Tien_Dau_Ky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThanh_Tien_Dau_Ky.ColumnEdit = this.rptMayTinh;
            this.colThanh_Tien_Dau_Ky.FieldName = "Thanh_Tien_Dau_Ky";
            this.colThanh_Tien_Dau_Ky.Name = "colThanh_Tien_Dau_Ky";
            this.colThanh_Tien_Dau_Ky.OptionsColumn.ReadOnly = true;
            this.colThanh_Tien_Dau_Ky.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Thanh_Tien_Dau_Ky", "{0:##,##0.###}")});
            // 
            // rptMayTinh
            // 
            this.rptMayTinh.AutoHeight = false;
            this.rptMayTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptMayTinh.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rptMayTinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rptMayTinh.EditFormat.FormatString = "{0:##,##0.###}";
            this.rptMayTinh.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rptMayTinh.Name = "rptMayTinh";
            // 
            // colThanh_Tien_Nhap_Trong_Ky
            // 
            this.colThanh_Tien_Nhap_Trong_Ky.AppearanceHeader.Options.UseTextOptions = true;
            this.colThanh_Tien_Nhap_Trong_Ky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThanh_Tien_Nhap_Trong_Ky.ColumnEdit = this.rptMayTinh;
            this.colThanh_Tien_Nhap_Trong_Ky.FieldName = "Thanh_Tien_Nhap_Trong_Ky";
            this.colThanh_Tien_Nhap_Trong_Ky.Name = "colThanh_Tien_Nhap_Trong_Ky";
            this.colThanh_Tien_Nhap_Trong_Ky.OptionsColumn.ReadOnly = true;
            this.colThanh_Tien_Nhap_Trong_Ky.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Thanh_Tien_Nhap_Trong_Ky", "{0:##,##0.###}")});
            this.colThanh_Tien_Nhap_Trong_Ky.Width = 161;
            // 
            // colThanh_Tien_Xuat_Trong_Ky
            // 
            this.colThanh_Tien_Xuat_Trong_Ky.AppearanceHeader.Options.UseTextOptions = true;
            this.colThanh_Tien_Xuat_Trong_Ky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThanh_Tien_Xuat_Trong_Ky.ColumnEdit = this.rptMayTinh;
            this.colThanh_Tien_Xuat_Trong_Ky.FieldName = "Thanh_Tien_Xuat_Trong_Ky";
            this.colThanh_Tien_Xuat_Trong_Ky.Name = "colThanh_Tien_Xuat_Trong_Ky";
            this.colThanh_Tien_Xuat_Trong_Ky.OptionsColumn.ReadOnly = true;
            this.colThanh_Tien_Xuat_Trong_Ky.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Thanh_Tien_Xuat_Trong_Ky", "{0:##,##0.###}")});
            this.colThanh_Tien_Xuat_Trong_Ky.Width = 158;
            // 
            // colThanh_Tien_Cuoi_Ky
            // 
            this.colThanh_Tien_Cuoi_Ky.AppearanceHeader.Options.UseTextOptions = true;
            this.colThanh_Tien_Cuoi_Ky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThanh_Tien_Cuoi_Ky.ColumnEdit = this.rptMayTinh;
            this.colThanh_Tien_Cuoi_Ky.FieldName = "Thanh_Tien_Cuoi_Ky";
            this.colThanh_Tien_Cuoi_Ky.Name = "colThanh_Tien_Cuoi_Ky";
            this.colThanh_Tien_Cuoi_Ky.OptionsColumn.ReadOnly = true;
            this.colThanh_Tien_Cuoi_Ky.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Thanh_Tien_Cuoi_Ky", "{0:##,##0.###}")});
            this.colThanh_Tien_Cuoi_Ky.Width = 123;
            // 
            // colNhom_Hang
            // 
            this.colNhom_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colNhom_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNhom_Hang.FieldName = "Nhom_Hang";
            this.colNhom_Hang.Name = "colNhom_Hang";
            this.colNhom_Hang.OptionsColumn.ReadOnly = true;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Đầu Kỳ";
            this.gridBand2.Columns.Add(this.colSo_Luong_Dau_Ky);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 109;
            // 
            // colSo_Luong_Dau_Ky
            // 
            this.colSo_Luong_Dau_Ky.AppearanceHeader.Options.UseTextOptions = true;
            this.colSo_Luong_Dau_Ky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSo_Luong_Dau_Ky.Caption = "Số Lượng";
            this.colSo_Luong_Dau_Ky.ColumnEdit = this.rptMayTinh;
            this.colSo_Luong_Dau_Ky.FieldName = "So_Luong_Dau_Ky";
            this.colSo_Luong_Dau_Ky.Name = "colSo_Luong_Dau_Ky";
            this.colSo_Luong_Dau_Ky.OptionsColumn.ReadOnly = true;
            this.colSo_Luong_Dau_Ky.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong_Dau_Ky", "{0:##,##0.###}")});
            this.colSo_Luong_Dau_Ky.Visible = true;
            this.colSo_Luong_Dau_Ky.Width = 109;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Nhập Trong Kỳ";
            this.gridBand3.Columns.Add(this.colSo_Luong_Nhap_Trong_Ky);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 149;
            // 
            // colSo_Luong_Nhap_Trong_Ky
            // 
            this.colSo_Luong_Nhap_Trong_Ky.AppearanceHeader.Options.UseTextOptions = true;
            this.colSo_Luong_Nhap_Trong_Ky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSo_Luong_Nhap_Trong_Ky.Caption = "Số Lượng";
            this.colSo_Luong_Nhap_Trong_Ky.ColumnEdit = this.rptMayTinh;
            this.colSo_Luong_Nhap_Trong_Ky.FieldName = "So_Luong_Nhap_Trong_Ky";
            this.colSo_Luong_Nhap_Trong_Ky.Name = "colSo_Luong_Nhap_Trong_Ky";
            this.colSo_Luong_Nhap_Trong_Ky.OptionsColumn.ReadOnly = true;
            this.colSo_Luong_Nhap_Trong_Ky.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong_Nhap_Trong_Ky", "{0:##,##0.###}")});
            this.colSo_Luong_Nhap_Trong_Ky.Visible = true;
            this.colSo_Luong_Nhap_Trong_Ky.Width = 149;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Xuất Trong Kỳ";
            this.gridBand5.Columns.Add(this.colSo_Luong_Xuat_Trong_Ky);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 3;
            this.gridBand5.Width = 146;
            // 
            // colSo_Luong_Xuat_Trong_Ky
            // 
            this.colSo_Luong_Xuat_Trong_Ky.AppearanceHeader.Options.UseTextOptions = true;
            this.colSo_Luong_Xuat_Trong_Ky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSo_Luong_Xuat_Trong_Ky.Caption = "Số Lượng";
            this.colSo_Luong_Xuat_Trong_Ky.ColumnEdit = this.rptMayTinh;
            this.colSo_Luong_Xuat_Trong_Ky.FieldName = "So_Luong_Xuat_Trong_Ky";
            this.colSo_Luong_Xuat_Trong_Ky.Name = "colSo_Luong_Xuat_Trong_Ky";
            this.colSo_Luong_Xuat_Trong_Ky.OptionsColumn.ReadOnly = true;
            this.colSo_Luong_Xuat_Trong_Ky.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong_Xuat_Trong_Ky", "{0:##,##0.###}")});
            this.colSo_Luong_Xuat_Trong_Ky.Visible = true;
            this.colSo_Luong_Xuat_Trong_Ky.Width = 146;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Cuối Kỳ";
            this.gridBand4.Columns.Add(this.colSo_Luong_Cuoi_Ky);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 4;
            this.gridBand4.Width = 111;
            // 
            // colSo_Luong_Cuoi_Ky
            // 
            this.colSo_Luong_Cuoi_Ky.AppearanceHeader.Options.UseTextOptions = true;
            this.colSo_Luong_Cuoi_Ky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSo_Luong_Cuoi_Ky.Caption = "Số Lượng";
            this.colSo_Luong_Cuoi_Ky.ColumnEdit = this.rptMayTinh;
            this.colSo_Luong_Cuoi_Ky.FieldName = "So_Luong_Cuoi_Ky";
            this.colSo_Luong_Cuoi_Ky.Name = "colSo_Luong_Cuoi_Ky";
            this.colSo_Luong_Cuoi_Ky.OptionsColumn.ReadOnly = true;
            this.colSo_Luong_Cuoi_Ky.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong_Cuoi_Ky", "{0:##,##0.###}")});
            this.colSo_Luong_Cuoi_Ky.Visible = true;
            this.colSo_Luong_Cuoi_Ky.Width = 111;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1102, 392);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1102, 368);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbChonNgay;
            this.layoutControlItem2.CustomizationFormText = "Tùy Chọn:";
            this.layoutControlItem2.Location = new System.Drawing.Point(178, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(109, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(150, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Tùy Chọn:";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dtTu;
            this.layoutControlItem3.CustomizationFormText = "Từ";
            this.layoutControlItem3.Location = new System.Drawing.Point(328, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(78, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(140, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Từ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtDen;
            this.layoutControlItem4.CustomizationFormText = "Đến";
            this.layoutControlItem4.Location = new System.Drawing.Point(468, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(78, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(143, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Đến";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(50, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.layoutControl2;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(611, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(491, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtKhoHang;
            this.layoutControlItem6.CustomizationFormText = "Kho Hàng:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(178, 24);
            this.layoutControlItem6.Text = "Kho Hàng:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(50, 13);
            // 
            // kHO_HANGTableAdapter
            // 
            this.kHO_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmXuatNhapTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 416);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXuatNhapTon";
            this.Text = "Xuất Nhập Tồn";
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoHang_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuatNhapTonTheoNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsXuatNhapTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.ImageCollection img;
        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbiXem;
        private DevExpress.XtraBars.BarButtonItem bbiSua;
        private DevExpress.XtraBars.BarButtonItem bbiXoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiDong;
        private DevExpress.XtraEditors.ComboBoxEdit cbChonNgay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit dtDen;
        private DevExpress.XtraEditors.DateEdit dtTu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource xuatNhapTonTheoNgayBindingSource;
        private XuatNhapTon.DataSet.dsXuatNhapTon dsXuatNhapTon;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rptMayTinh;
        private DevExpress.XtraBars.BarButtonItem bbiXuatExcel;
        private DevExpress.XtraEditors.GridLookUpEdit txtKhoHang;
        private DevExpress.XtraGrid.Views.Grid.GridView txtKhoHang_View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private Kho.DS.dsKho dsKho;
        private System.Windows.Forms.BindingSource kHOHANGBindingSource;
        private Kho.DS.dsKhoTableAdapters.KHO_HANGTableAdapter kHO_HANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Kho1;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Thoai;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_Dong;
        private DevExpress.XtraGrid.Columns.GridColumn colThu_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gbList;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMa_Hang_Hoa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTen_Hang;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDon_Vi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMa_Kho_Hang;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTen_Kho;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTen_Nhom_Hang;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colThanh_Tien_Dau_Ky;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colThanh_Tien_Nhap_Trong_Ky;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colThanh_Tien_Xuat_Trong_Ky;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colThanh_Tien_Cuoi_Ky;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNhom_Hang;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSo_Luong_Dau_Ky;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSo_Luong_Nhap_Trong_Ky;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSo_Luong_Xuat_Trong_Ky;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSo_Luong_Cuoi_Ky;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLo_Vat_Tu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSerial_No;
    }
}

