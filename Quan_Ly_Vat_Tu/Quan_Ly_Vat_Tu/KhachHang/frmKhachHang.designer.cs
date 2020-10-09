namespace Quan_Ly_Vat_Tu.KhachHang
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.img = new DevExpress.Utils.ImageCollection(this.components);
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiThem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXem = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKhachHang = new Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHang();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Khach_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Khach_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_So_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_Dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoi_Lien_He = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNickYM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNickSky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTai_Khoan_Ngan_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Ngan_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Khu_Vuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Khu_Vuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.kHACH_HANGTableAdapter = new Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHangTableAdapters.KHACH_HANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.bbiThem});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiThem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXem),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDong)});
            this.bar2.OptionsBar.AllowDelete = true;
            this.bar2.OptionsBar.DrawSizeGrip = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiThem
            // 
            this.bbiThem.Caption = "Thêm";
            this.bbiThem.Id = 12;
            this.bbiThem.ImageOptions.ImageIndex = 11;
            this.bbiThem.Name = "bbiThem";
            this.bbiThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThem_ItemClick);
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
            this.bbiSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSua_ItemClick);
            // 
            // bbiXoa
            // 
            this.bbiXoa.Caption = "Xóa";
            this.bbiXoa.Id = 2;
            this.bbiXoa.ImageOptions.ImageIndex = 16;
            this.bbiXoa.Name = "bbiXoa";
            this.bbiXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXoa_ItemClick);
            // 
            // bbiDong
            // 
            this.bbiDong.Caption = "Đóng";
            this.bbiDong.Id = 6;
            this.bbiDong.ImageOptions.ImageIndex = 10;
            this.bbiDong.Name = "bbiDong";
            this.bbiDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDong_ItemClick);
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
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1102, 392);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcList
            // 
            this.gcList.DataSource = this.kHACHHANGBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.MainView = this.gbList;
            this.gcList.MenuManager = this.bm;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(1098, 388);
            this.gcList.TabIndex = 4;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACH_HANG";
            this.kHACHHANGBindingSource.DataSource = this.dsKhachHang;
            // 
            // dsKhachHang
            // 
            this.dsKhachHang.DataSetName = "dsKhachHang";
            this.dsKhachHang.EnforceConstraints = false;
            this.dsKhachHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Khach_Hang,
            this.colTen_Khach_Hang,
            this.colDia_Chi,
            this.colMa_So_Thue,
            this.colDien_Thoai,
            this.colFax,
            this.colEmail,
            this.colDi_Dong,
            this.colWebsite,
            this.colNguoi_Lien_He,
            this.colNickYM,
            this.colNickSky,
            this.colTai_Khoan_Ngan_Hang,
            this.colTen_Ngan_Hang,
            this.colGhi_Chu,
            this.colTen_Khu_Vuc,
            this.colCreatedDate,
            this.colId,
            this.colMa_Khu_Vuc,
            this.colModifiedDate});
            this.gbList.GridControl = this.gcList;
            this.gbList.GroupPanelText = "Kéo cột và thả vào đây để nhóm dữ liệu";
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsSelection.MultiSelect = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.ShowAutoFilterRow = true;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            // 
            // colMa_Khach_Hang
            // 
            this.colMa_Khach_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_Khach_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_Khach_Hang.Caption = "Mã Khách Hàng";
            this.colMa_Khach_Hang.FieldName = "Ma_Khach_Hang";
            this.colMa_Khach_Hang.Name = "colMa_Khach_Hang";
            this.colMa_Khach_Hang.OptionsColumn.ReadOnly = true;
            this.colMa_Khach_Hang.Visible = true;
            this.colMa_Khach_Hang.VisibleIndex = 0;
            this.colMa_Khach_Hang.Width = 97;
            // 
            // colTen_Khach_Hang
            // 
            this.colTen_Khach_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Khach_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Khach_Hang.Caption = "Tên Khách Hàng";
            this.colTen_Khach_Hang.FieldName = "Ten_Khach_Hang";
            this.colTen_Khach_Hang.Name = "colTen_Khach_Hang";
            this.colTen_Khach_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Khach_Hang.Visible = true;
            this.colTen_Khach_Hang.VisibleIndex = 1;
            this.colTen_Khach_Hang.Width = 169;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDia_Chi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDia_Chi.Caption = "Địa Chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.OptionsColumn.ReadOnly = true;
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 2;
            this.colDia_Chi.Width = 208;
            // 
            // colMa_So_Thue
            // 
            this.colMa_So_Thue.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_So_Thue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_So_Thue.Caption = "Mã Số Thuế";
            this.colMa_So_Thue.FieldName = "Ma_So_Thue";
            this.colMa_So_Thue.Name = "colMa_So_Thue";
            this.colMa_So_Thue.OptionsColumn.ReadOnly = true;
            this.colMa_So_Thue.Visible = true;
            this.colMa_So_Thue.VisibleIndex = 5;
            this.colMa_So_Thue.Width = 79;
            // 
            // colDien_Thoai
            // 
            this.colDien_Thoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colDien_Thoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDien_Thoai.Caption = "Điện Thoại";
            this.colDien_Thoai.FieldName = "Dien_Thoai";
            this.colDien_Thoai.Name = "colDien_Thoai";
            this.colDien_Thoai.OptionsColumn.ReadOnly = true;
            this.colDien_Thoai.Visible = true;
            this.colDien_Thoai.VisibleIndex = 6;
            // 
            // colFax
            // 
            this.colFax.AppearanceHeader.Options.UseTextOptions = true;
            this.colFax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.ReadOnly = true;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 8;
            // 
            // colDi_Dong
            // 
            this.colDi_Dong.AppearanceHeader.Options.UseTextOptions = true;
            this.colDi_Dong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDi_Dong.Caption = "Di Động";
            this.colDi_Dong.FieldName = "Di_Dong";
            this.colDi_Dong.Name = "colDi_Dong";
            this.colDi_Dong.OptionsColumn.ReadOnly = true;
            this.colDi_Dong.Visible = true;
            this.colDi_Dong.VisibleIndex = 9;
            // 
            // colWebsite
            // 
            this.colWebsite.AppearanceHeader.Options.UseTextOptions = true;
            this.colWebsite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWebsite.Caption = "Website";
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.OptionsColumn.ReadOnly = true;
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 10;
            // 
            // colNguoi_Lien_He
            // 
            this.colNguoi_Lien_He.AppearanceHeader.Options.UseTextOptions = true;
            this.colNguoi_Lien_He.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNguoi_Lien_He.Caption = "Người Liên Hệ";
            this.colNguoi_Lien_He.FieldName = "Nguoi_Lien_He";
            this.colNguoi_Lien_He.Name = "colNguoi_Lien_He";
            this.colNguoi_Lien_He.OptionsColumn.ReadOnly = true;
            this.colNguoi_Lien_He.Visible = true;
            this.colNguoi_Lien_He.VisibleIndex = 11;
            this.colNguoi_Lien_He.Width = 134;
            // 
            // colNickYM
            // 
            this.colNickYM.AppearanceHeader.Options.UseTextOptions = true;
            this.colNickYM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNickYM.Caption = "Nick Yahoo";
            this.colNickYM.FieldName = "NickYM";
            this.colNickYM.Name = "colNickYM";
            this.colNickYM.OptionsColumn.ReadOnly = true;
            this.colNickYM.Width = 101;
            // 
            // colNickSky
            // 
            this.colNickSky.AppearanceHeader.Options.UseTextOptions = true;
            this.colNickSky.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNickSky.Caption = "Nick Skype";
            this.colNickSky.FieldName = "NickSky";
            this.colNickSky.Name = "colNickSky";
            this.colNickSky.OptionsColumn.ReadOnly = true;
            // 
            // colTai_Khoan_Ngan_Hang
            // 
            this.colTai_Khoan_Ngan_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTai_Khoan_Ngan_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTai_Khoan_Ngan_Hang.Caption = "Tài Khoản Ngân Hàng";
            this.colTai_Khoan_Ngan_Hang.FieldName = "Tai_Khoan_Ngan_Hang";
            this.colTai_Khoan_Ngan_Hang.Name = "colTai_Khoan_Ngan_Hang";
            this.colTai_Khoan_Ngan_Hang.OptionsColumn.ReadOnly = true;
            this.colTai_Khoan_Ngan_Hang.Visible = true;
            this.colTai_Khoan_Ngan_Hang.VisibleIndex = 12;
            this.colTai_Khoan_Ngan_Hang.Width = 126;
            // 
            // colTen_Ngan_Hang
            // 
            this.colTen_Ngan_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Ngan_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Ngan_Hang.Caption = "Tên Ngân Hàng";
            this.colTen_Ngan_Hang.FieldName = "Ten_Ngan_Hang";
            this.colTen_Ngan_Hang.Name = "colTen_Ngan_Hang";
            this.colTen_Ngan_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Ngan_Hang.Visible = true;
            this.colTen_Ngan_Hang.VisibleIndex = 13;
            this.colTen_Ngan_Hang.Width = 97;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhi_Chu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhi_Chu.Caption = "Ghi Chú";
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.OptionsColumn.ReadOnly = true;
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 14;
            this.colGhi_Chu.Width = 168;
            // 
            // colTen_Khu_Vuc
            // 
            this.colTen_Khu_Vuc.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Khu_Vuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Khu_Vuc.Caption = "Khu Vực";
            this.colTen_Khu_Vuc.FieldName = "Ten_Khu_Vuc";
            this.colTen_Khu_Vuc.Name = "colTen_Khu_Vuc";
            this.colTen_Khu_Vuc.OptionsColumn.ReadOnly = true;
            this.colTen_Khu_Vuc.Visible = true;
            this.colTen_Khu_Vuc.VisibleIndex = 4;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colCreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCreatedDate.Caption = "Ngày Tạo";
            this.colCreatedDate.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.colCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.OptionsColumn.ReadOnly = true;
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 15;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // colMa_Khu_Vuc
            // 
            this.colMa_Khu_Vuc.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_Khu_Vuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_Khu_Vuc.Caption = "Mã Khu Vực";
            this.colMa_Khu_Vuc.FieldName = "Ma_Khu_Vuc";
            this.colMa_Khu_Vuc.Name = "colMa_Khu_Vuc";
            this.colMa_Khu_Vuc.OptionsColumn.ReadOnly = true;
            this.colMa_Khu_Vuc.Visible = true;
            this.colMa_Khu_Vuc.VisibleIndex = 3;
            this.colMa_Khu_Vuc.Width = 79;
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifiedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifiedDate.Caption = "Ngày Sửa";
            this.colModifiedDate.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.colModifiedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            this.colModifiedDate.OptionsColumn.ReadOnly = true;
            this.colModifiedDate.Visible = true;
            this.colModifiedDate.VisibleIndex = 16;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1102, 392);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1102, 392);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // kHACH_HANGTableAdapter
            // 
            this.kHACH_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmKhachHang
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
            this.Name = "frmKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.KhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem bbiDong;
        private DevExpress.XtraBars.BarButtonItem bbiThem;
        private Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHang dsKhachHang;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHangTableAdapters.KHACH_HANGTableAdapter kHACH_HANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Khach_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Khach_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_So_Thue;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Thoai;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_Dong;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoi_Lien_He;
        private DevExpress.XtraGrid.Columns.GridColumn colNickYM;
        private DevExpress.XtraGrid.Columns.GridColumn colNickSky;
        private DevExpress.XtraGrid.Columns.GridColumn colTai_Khoan_Ngan_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Ngan_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Khu_Vuc;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Khu_Vuc;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
    }
}

