namespace Quan_Ly_Vat_Tu.NhanVien
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
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
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNhanVien = new Quan_Ly_Vat_Tu.NhanVien.DataSet.dsNhanVien();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Nhan_Vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNam_Sinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Vao_Lam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuc_Vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBo_Phan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCua_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptVal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.nhan_VienTableAdapter = new Quan_Ly_Vat_Tu.NhanVien.DataSet.dsNhanVienTableAdapters.Nhan_VienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptVal)).BeginInit();
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
            this.gcList.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcList.DataSource = this.nhanVienBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.MainView = this.gbList;
            this.gcList.MenuManager = this.bm;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rptVal});
            this.gcList.Size = new System.Drawing.Size(1098, 388);
            this.gcList.TabIndex = 4;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "Nhan_Vien";
            this.nhanVienBindingSource.DataSource = this.dsNhanVien;
            // 
            // dsNhanVien
            // 
            this.dsNhanVien.DataSetName = "dsNhanVien";
            this.dsNhanVien.EnforceConstraints = false;
            this.dsNhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nhan_Vien,
            this.colHo_Ten,
            this.colDia_Chi,
            this.colNam_Sinh,
            this.colDien_Thoai,
            this.colNgay_Vao_Lam,
            this.colChuc_Vu,
            this.colBo_Phan,
            this.colCua_Hang,
            this.colGhi_Chu,
            this.colModifiedDate,
            this.colCreatedDate,
            this.colId});
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
            // colMa_Nhan_Vien
            // 
            this.colMa_Nhan_Vien.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_Nhan_Vien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_Nhan_Vien.Caption = "Mã Nhân Viên";
            this.colMa_Nhan_Vien.FieldName = "Ma_Nhan_Vien";
            this.colMa_Nhan_Vien.Name = "colMa_Nhan_Vien";
            this.colMa_Nhan_Vien.OptionsColumn.ReadOnly = true;
            this.colMa_Nhan_Vien.Visible = true;
            this.colMa_Nhan_Vien.VisibleIndex = 0;
            // 
            // colHo_Ten
            // 
            this.colHo_Ten.AppearanceHeader.Options.UseTextOptions = true;
            this.colHo_Ten.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHo_Ten.Caption = "Họ Tên";
            this.colHo_Ten.FieldName = "Ho_Ten";
            this.colHo_Ten.Name = "colHo_Ten";
            this.colHo_Ten.OptionsColumn.ReadOnly = true;
            this.colHo_Ten.Visible = true;
            this.colHo_Ten.VisibleIndex = 1;
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
            // 
            // colNam_Sinh
            // 
            this.colNam_Sinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colNam_Sinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNam_Sinh.Caption = "Năm Sinh";
            this.colNam_Sinh.FieldName = "Nam_Sinh";
            this.colNam_Sinh.Name = "colNam_Sinh";
            this.colNam_Sinh.OptionsColumn.ReadOnly = true;
            this.colNam_Sinh.Visible = true;
            this.colNam_Sinh.VisibleIndex = 3;
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
            this.colDien_Thoai.VisibleIndex = 4;
            // 
            // colNgay_Vao_Lam
            // 
            this.colNgay_Vao_Lam.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgay_Vao_Lam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgay_Vao_Lam.Caption = "Ngày Vào Làm";
            this.colNgay_Vao_Lam.FieldName = "Ngay_Vao_Lam";
            this.colNgay_Vao_Lam.Name = "colNgay_Vao_Lam";
            this.colNgay_Vao_Lam.OptionsColumn.ReadOnly = true;
            this.colNgay_Vao_Lam.Visible = true;
            this.colNgay_Vao_Lam.VisibleIndex = 5;
            this.colNgay_Vao_Lam.Width = 88;
            // 
            // colChuc_Vu
            // 
            this.colChuc_Vu.AppearanceHeader.Options.UseTextOptions = true;
            this.colChuc_Vu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChuc_Vu.Caption = "Chức Vụ";
            this.colChuc_Vu.FieldName = "Chuc_Vu";
            this.colChuc_Vu.Name = "colChuc_Vu";
            this.colChuc_Vu.OptionsColumn.ReadOnly = true;
            this.colChuc_Vu.Visible = true;
            this.colChuc_Vu.VisibleIndex = 6;
            // 
            // colBo_Phan
            // 
            this.colBo_Phan.AppearanceHeader.Options.UseTextOptions = true;
            this.colBo_Phan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBo_Phan.Caption = "Bộ Phận";
            this.colBo_Phan.FieldName = "Bo_Phan";
            this.colBo_Phan.Name = "colBo_Phan";
            this.colBo_Phan.OptionsColumn.ReadOnly = true;
            this.colBo_Phan.Visible = true;
            this.colBo_Phan.VisibleIndex = 7;
            // 
            // colCua_Hang
            // 
            this.colCua_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colCua_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCua_Hang.Caption = "Mã Cửa Hàng";
            this.colCua_Hang.FieldName = "Cua_Hang";
            this.colCua_Hang.Name = "colCua_Hang";
            this.colCua_Hang.OptionsColumn.ReadOnly = true;
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
            this.colGhi_Chu.VisibleIndex = 8;
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colModifiedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModifiedDate.Caption = "Ngày Sửa";
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            this.colModifiedDate.OptionsColumn.ReadOnly = true;
            this.colModifiedDate.Visible = true;
            this.colModifiedDate.VisibleIndex = 10;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colCreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCreatedDate.Caption = "Ngày Tạo";
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.OptionsColumn.ReadOnly = true;
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 9;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // rptVal
            // 
            this.rptVal.AutoHeight = false;
            this.rptVal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptVal.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.rptVal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rptVal.EditFormat.FormatString = "{0:##,##0.###}";
            this.rptVal.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rptVal.Name = "rptVal";
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
            // nhan_VienTableAdapter
            // 
            this.nhan_VienTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanVien
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
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptVal)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rptVal;
        private DataSet.dsNhanVien dsNhanVien;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DataSet.dsNhanVienTableAdapters.Nhan_VienTableAdapter nhan_VienTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nhan_Vien;
        private DevExpress.XtraGrid.Columns.GridColumn colHo_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colNam_Sinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Thoai;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Vao_Lam;
        private DevExpress.XtraGrid.Columns.GridColumn colChuc_Vu;
        private DevExpress.XtraGrid.Columns.GridColumn colBo_Phan;
        private DevExpress.XtraGrid.Columns.GridColumn colCua_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}

