namespace Quan_Ly_Vat_Tu.NhapKho
{
    partial class frmNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapKho));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtThanhToan = new DevExpress.XtraEditors.CalcEdit();
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbiTaoMoi = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLuu = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img = new DevExpress.Utils.ImageCollection(this.components);
            this.bbiXoa = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoaTatCa = new DevExpress.XtraBars.BarButtonItem();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtNhanVien = new DevExpress.XtraEditors.GridLookUpEdit();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNhanVien = new Quan_Ly_Vat_Tu.NhanVien.DataSet.dsNhanVien();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Nhan_Vien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNam_Sinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Thoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay_Vao_Lam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuc_Vu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBo_Phan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCua_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Cua_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtChietKhauPhanTram = new DevExpress.XtraEditors.CalcEdit();
            this.txtChietKhauThanhTien = new DevExpress.XtraEditors.CalcEdit();
            this.txtVATThanhTien = new DevExpress.XtraEditors.CalcEdit();
            this.txtVATPhanTram = new DevExpress.XtraEditors.CalcEdit();
            this.txtThanhTien = new DevExpress.XtraEditors.CalcEdit();
            this.txtLyDo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtKhachHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKhachHang = new Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHang();
            this.txtKhachHang_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Khach_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Khach_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDia_Chi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDien_Thoai1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_So_Thue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoi_Lien_He = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTai_Khoan_Ngan_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Khu_Vuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Ngan_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_Dong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMaChungTu = new DevExpress.XtraEditors.TextEdit();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.cHUNGTUCHITIETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNhapKho = new Quan_Ly_Vat_Tu.NhapKho.DS.dsNhapKho();
            this.gbList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Chi_Tiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Chung_Tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Hang_Hoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptHangHoa = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHangHoa = new Quan_Ly_Vat_Tu.HangHoa.DS.dsHangHoa();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Hang1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDon_Vi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia_Nhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia_Xuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoai_Chung_Tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Kho_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptKhoHang = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.kHOHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKho = new Quan_Ly_Vat_Tu.Kho.DS.dsKho();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Luong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptMayTinh = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colDon_Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanh_Tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhi_Chu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSo_Thu_Tu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDon_Vi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rptTenHangHoa = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa_Hang1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Hang2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDon_Vi2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia_Nhap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia_Xuat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtHinhThucThuChi = new DevExpress.XtraEditors.GridLookUpEdit();
            this.hinhThucThuChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHinhThuc = new Quan_Ly_Vat_Tu.DataSet.dsHinhThuc();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtHinhThucCongNo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.hinhThucThanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.kHACH_HANGTableAdapter = new Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHangTableAdapters.KHACH_HANGTableAdapter();
            this.cHUNG_TU_CHI_TIETTableAdapter = new Quan_Ly_Vat_Tu.NhapKho.DS.dsNhapKhoTableAdapters.CHUNG_TU_CHI_TIETTableAdapter();
            this.hANG_HOATableAdapter = new Quan_Ly_Vat_Tu.HangHoa.DS.dsHangHoaTableAdapters.HANG_HOATableAdapter();
            this.kHO_HANGTableAdapter = new Quan_Ly_Vat_Tu.Kho.DS.dsKhoTableAdapters.KHO_HANGTableAdapter();
            this.pm = new DevExpress.XtraBars.PopupMenu(this.components);
            this.nhan_VienTableAdapter = new Quan_Ly_Vat_Tu.NhanVien.DataSet.dsNhanVienTableAdapters.Nhan_VienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhToan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChietKhauPhanTram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChietKhauThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVATThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVATPhanTram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHoaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachHang_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChungTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGTUCHITIETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptKhoHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptMayTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptTenHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHinhThucThuChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucThuChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHinhThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHinhThucCongNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucThanhToanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtThanhToan);
            this.layoutControl1.Controls.Add(this.txtDiaChi);
            this.layoutControl1.Controls.Add(this.txtNhanVien);
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Controls.Add(this.txtChietKhauPhanTram);
            this.layoutControl1.Controls.Add(this.txtChietKhauThanhTien);
            this.layoutControl1.Controls.Add(this.txtVATThanhTien);
            this.layoutControl1.Controls.Add(this.txtVATPhanTram);
            this.layoutControl1.Controls.Add(this.txtThanhTien);
            this.layoutControl1.Controls.Add(this.txtLyDo);
            this.layoutControl1.Controls.Add(this.txtMaHoaDon);
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Controls.Add(this.txtNgay);
            this.layoutControl1.Controls.Add(this.txtKhachHang);
            this.layoutControl1.Controls.Add(this.txtMaChungTu);
            this.layoutControl1.Controls.Add(this.gcList);
            this.layoutControl1.Controls.Add(this.txtHinhThucThuChi);
            this.layoutControl1.Controls.Add(this.txtHinhThucCongNo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1091, 612);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtThanhToan.Location = new System.Drawing.Point(797, 590);
            this.txtThanhToan.MenuManager = this.bm;
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtThanhToan.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtThanhToan.Properties.Appearance.Options.UseFont = true;
            this.txtThanhToan.Properties.Appearance.Options.UseForeColor = true;
            this.txtThanhToan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtThanhToan.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtThanhToan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtThanhToan.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtThanhToan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtThanhToan.Size = new System.Drawing.Size(292, 20);
            this.txtThanhToan.StyleController = this.layoutControl1;
            this.txtThanhToan.TabIndex = 21;
            // 
            // bm
            // 
            this.bm.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.bm.DockControls.Add(this.barDockControlTop);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
            this.bm.Form = this;
            this.bm.Images = this.img;
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiTaoMoi,
            this.bbiLuu,
            this.bbiDong,
            this.bbiXoa,
            this.bbiXoaTatCa});
            this.bm.LargeImages = this.img;
            this.bm.MaxItemId = 5;
            this.bm.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarItemHorzIndent = 20;
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTaoMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDong)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbiTaoMoi
            // 
            this.bbiTaoMoi.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bbiTaoMoi.Caption = "Tạo Mới";
            this.bbiTaoMoi.Id = 0;
            this.bbiTaoMoi.ImageIndex = 1;
            this.bbiTaoMoi.Name = "bbiTaoMoi";
            this.bbiTaoMoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiTaoMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTaoMoi_ItemClick);
            // 
            // bbiLuu
            // 
            this.bbiLuu.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bbiLuu.Caption = "Lưu";
            this.bbiLuu.Id = 1;
            this.bbiLuu.ImageIndex = 4;
            this.bbiLuu.Name = "bbiLuu";
            this.bbiLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLuu_ItemClick);
            // 
            // bbiDong
            // 
            this.bbiDong.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bbiDong.Caption = "Đóng";
            this.bbiDong.Id = 2;
            this.bbiDong.ImageIndex = 7;
            this.bbiDong.Name = "bbiDong";
            this.bbiDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1091, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 612);
            this.barDockControlBottom.Size = new System.Drawing.Size(1091, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 612);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1091, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 612);
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            this.img.Images.SetKeyName(0, "add.png");
            this.img.Images.SetKeyName(1, "create.png");
            this.img.Images.SetKeyName(2, "plus.png");
            this.img.Images.SetKeyName(3, "accept.png");
            this.img.Images.SetKeyName(4, "apply.png");
            this.img.Images.SetKeyName(5, "OK.png");
            this.img.Images.SetKeyName(6, "yes.png");
            this.img.Images.SetKeyName(7, "cancel.png");
            this.img.Images.SetKeyName(8, "close.png");
            this.img.Images.SetKeyName(9, "no.png");
            this.img.Images.SetKeyName(10, "stop.png");
            this.img.Images.SetKeyName(11, "turn off.png");
            this.img.Images.SetKeyName(12, "delete.png");
            this.img.Images.SetKeyName(13, "erase.png");
            // 
            // bbiXoa
            // 
            this.bbiXoa.Caption = "Xóa";
            this.bbiXoa.Id = 3;
            this.bbiXoa.ImageIndex = 13;
            this.bbiXoa.Name = "bbiXoa";
            this.bbiXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXoa_ItemClick);
            // 
            // bbiXoaTatCa
            // 
            this.bbiXoaTatCa.Caption = "Xóa tất cả";
            this.bbiXoaTatCa.Id = 4;
            this.bbiXoaTatCa.ImageIndex = 12;
            this.bbiXoaTatCa.Name = "bbiXoaTatCa";
            this.bbiXoaTatCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXoaTatCa_ItemClick);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(116, 26);
            this.txtDiaChi.MenuManager = this.bm;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(746, 20);
            this.txtDiaChi.StyleController = this.layoutControl1;
            this.txtDiaChi.TabIndex = 18;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(985, 74);
            this.txtNhanVien.MenuManager = this.bm;
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNhanVien.Properties.DataSource = this.nhanVienBindingSource;
            this.txtNhanVien.Properties.DisplayMember = "Ho_Ten";
            this.txtNhanVien.Properties.NullText = "";
            this.txtNhanVien.Properties.NullValuePrompt = "(Nhân Viên)";
            this.txtNhanVien.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNhanVien.Properties.ValueMember = "Ma_Nhan_Vien";
            this.txtNhanVien.Properties.View = this.gridView3;
            this.txtNhanVien.Size = new System.Drawing.Size(104, 20);
            this.txtNhanVien.StyleController = this.layoutControl1;
            this.txtNhanVien.TabIndex = 17;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "Nhan_Vien";
            this.nhanVienBindingSource.DataSource = this.dsNhanVien;
            // 
            // dsNhanVien
            // 
            this.dsNhanVien.DataSetName = "dsNhanVien";
            this.dsNhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Nhan_Vien,
            this.colHo_Ten,
            this.colDia_Chi1,
            this.colNam_Sinh,
            this.colDien_Thoai,
            this.colNgay_Vao_Lam,
            this.colChuc_Vu,
            this.colBo_Phan,
            this.colCua_Hang,
            this.colGhi_Chu2,
            this.colTen_Cua_Hang});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colMa_Nhan_Vien
            // 
            this.colMa_Nhan_Vien.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_Nhan_Vien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_Nhan_Vien.Caption = "Mã Nhân Viên";
            this.colMa_Nhan_Vien.FieldName = "Ma_Nhan_Vien";
            this.colMa_Nhan_Vien.Name = "colMa_Nhan_Vien";
            this.colMa_Nhan_Vien.OptionsColumn.ReadOnly = true;
            this.colMa_Nhan_Vien.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.colHo_Ten.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colHo_Ten.Visible = true;
            this.colHo_Ten.VisibleIndex = 1;
            // 
            // colDia_Chi1
            // 
            this.colDia_Chi1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDia_Chi1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDia_Chi1.Caption = "Địa Chỉ";
            this.colDia_Chi1.FieldName = "Dia_Chi";
            this.colDia_Chi1.Name = "colDia_Chi1";
            this.colDia_Chi1.OptionsColumn.ReadOnly = true;
            this.colDia_Chi1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDia_Chi1.Visible = true;
            this.colDia_Chi1.VisibleIndex = 2;
            // 
            // colNam_Sinh
            // 
            this.colNam_Sinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colNam_Sinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNam_Sinh.Caption = "Năm Sinh";
            this.colNam_Sinh.FieldName = "Nam_Sinh";
            this.colNam_Sinh.Name = "colNam_Sinh";
            this.colNam_Sinh.OptionsColumn.ReadOnly = true;
            this.colNam_Sinh.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.colDien_Thoai.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.colNgay_Vao_Lam.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNgay_Vao_Lam.Visible = true;
            this.colNgay_Vao_Lam.VisibleIndex = 5;
            // 
            // colChuc_Vu
            // 
            this.colChuc_Vu.AppearanceHeader.Options.UseTextOptions = true;
            this.colChuc_Vu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChuc_Vu.Caption = "Chức Vụ";
            this.colChuc_Vu.FieldName = "Chuc_Vu";
            this.colChuc_Vu.Name = "colChuc_Vu";
            this.colChuc_Vu.OptionsColumn.ReadOnly = true;
            this.colChuc_Vu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.colBo_Phan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colBo_Phan.Visible = true;
            this.colBo_Phan.VisibleIndex = 7;
            // 
            // colCua_Hang
            // 
            this.colCua_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colCua_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCua_Hang.Caption = "Cửa Hàng";
            this.colCua_Hang.FieldName = "Cua_Hang";
            this.colCua_Hang.Name = "colCua_Hang";
            this.colCua_Hang.OptionsColumn.ReadOnly = true;
            this.colCua_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colGhi_Chu2
            // 
            this.colGhi_Chu2.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhi_Chu2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhi_Chu2.Caption = "Ghi Chú";
            this.colGhi_Chu2.FieldName = "Ghi_Chu";
            this.colGhi_Chu2.Name = "colGhi_Chu2";
            this.colGhi_Chu2.OptionsColumn.ReadOnly = true;
            this.colGhi_Chu2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGhi_Chu2.Visible = true;
            this.colGhi_Chu2.VisibleIndex = 8;
            // 
            // colTen_Cua_Hang
            // 
            this.colTen_Cua_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Cua_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Cua_Hang.Caption = "Tên Cửa Hàng";
            this.colTen_Cua_Hang.FieldName = "Ten_Cua_Hang";
            this.colTen_Cua_Hang.Name = "colTen_Cua_Hang";
            this.colTen_Cua_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Cua_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Cua_Hang.Visible = true;
            this.colTen_Cua_Hang.VisibleIndex = 9;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Location = new System.Drawing.Point(2, 541);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(377, 69);
            this.layoutControl2.TabIndex = 16;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(377, 69);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // txtChietKhauPhanTram
            // 
            this.txtChietKhauPhanTram.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtChietKhauPhanTram.Location = new System.Drawing.Point(453, 541);
            this.txtChietKhauPhanTram.Name = "txtChietKhauPhanTram";
            this.txtChietKhauPhanTram.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtChietKhauPhanTram.Properties.Appearance.Options.UseFont = true;
            this.txtChietKhauPhanTram.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtChietKhauPhanTram.Properties.DisplayFormat.FormatString = "{0:##,##0.###} %";
            this.txtChietKhauPhanTram.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtChietKhauPhanTram.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtChietKhauPhanTram.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtChietKhauPhanTram.Size = new System.Drawing.Size(76, 20);
            this.txtChietKhauPhanTram.StyleController = this.layoutControl1;
            this.txtChietKhauPhanTram.TabIndex = 15;
            this.txtChietKhauPhanTram.EditValueChanged += new System.EventHandler(this.txtChietKhauPhanTram_EditValueChanged);
            // 
            // txtChietKhauThanhTien
            // 
            this.txtChietKhauThanhTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtChietKhauThanhTien.Location = new System.Drawing.Point(533, 541);
            this.txtChietKhauThanhTien.Name = "txtChietKhauThanhTien";
            this.txtChietKhauThanhTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtChietKhauThanhTien.Properties.Appearance.Options.UseFont = true;
            this.txtChietKhauThanhTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtChietKhauThanhTien.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtChietKhauThanhTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtChietKhauThanhTien.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtChietKhauThanhTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtChietKhauThanhTien.Properties.ReadOnly = true;
            this.txtChietKhauThanhTien.Size = new System.Drawing.Size(146, 20);
            this.txtChietKhauThanhTien.StyleController = this.layoutControl1;
            this.txtChietKhauThanhTien.TabIndex = 14;
            // 
            // txtVATThanhTien
            // 
            this.txtVATThanhTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtVATThanhTien.Location = new System.Drawing.Point(533, 566);
            this.txtVATThanhTien.Name = "txtVATThanhTien";
            this.txtVATThanhTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtVATThanhTien.Properties.Appearance.Options.UseFont = true;
            this.txtVATThanhTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVATThanhTien.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtVATThanhTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtVATThanhTien.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtVATThanhTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtVATThanhTien.Properties.ReadOnly = true;
            this.txtVATThanhTien.Size = new System.Drawing.Size(146, 20);
            this.txtVATThanhTien.StyleController = this.layoutControl1;
            this.txtVATThanhTien.TabIndex = 13;
            // 
            // txtVATPhanTram
            // 
            this.txtVATPhanTram.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtVATPhanTram.Location = new System.Drawing.Point(453, 566);
            this.txtVATPhanTram.Name = "txtVATPhanTram";
            this.txtVATPhanTram.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtVATPhanTram.Properties.Appearance.Options.UseFont = true;
            this.txtVATPhanTram.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVATPhanTram.Properties.DisplayFormat.FormatString = "{0:##,##0.###} %";
            this.txtVATPhanTram.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtVATPhanTram.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtVATPhanTram.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtVATPhanTram.Size = new System.Drawing.Size(76, 20);
            this.txtVATPhanTram.StyleController = this.layoutControl1;
            this.txtVATPhanTram.TabIndex = 12;
            this.txtVATPhanTram.EditValueChanged += new System.EventHandler(this.txtVATPhanTram_EditValueChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtThanhTien.Location = new System.Drawing.Point(453, 590);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtThanhTien.Properties.Appearance.Options.UseFont = true;
            this.txtThanhTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtThanhTien.Properties.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.txtThanhTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtThanhTien.Properties.EditFormat.FormatString = "{0:##,##0.###}";
            this.txtThanhTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtThanhTien.Size = new System.Drawing.Size(226, 20);
            this.txtThanhTien.StyleController = this.layoutControl1;
            this.txtThanhTien.TabIndex = 11;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(116, 50);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(746, 20);
            this.txtLyDo.StyleController = this.layoutControl1;
            this.txtLyDo.TabIndex = 10;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(985, 26);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(104, 20);
            this.txtMaHoaDon.StyleController = this.layoutControl1;
            this.txtMaHoaDon.TabIndex = 9;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(116, 74);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(746, 20);
            this.txtGhiChu.StyleController = this.layoutControl1;
            this.txtGhiChu.TabIndex = 8;
            // 
            // txtNgay
            // 
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(985, 50);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtNgay.Size = new System.Drawing.Size(104, 20);
            this.txtNgay.StyleController = this.layoutControl1;
            this.txtNgay.TabIndex = 7;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.EditValue = "";
            this.txtKhachHang.Location = new System.Drawing.Point(116, 2);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKhachHang.Properties.DataSource = this.kHACHHANGBindingSource;
            this.txtKhachHang.Properties.DisplayMember = "Ten_Khach_Hang";
            this.txtKhachHang.Properties.ImmediatePopup = true;
            this.txtKhachHang.Properties.NullText = "";
            this.txtKhachHang.Properties.NullValuePrompt = "(Khách hàng)";
            this.txtKhachHang.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtKhachHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtKhachHang.Properties.ValueMember = "Ma_Khach_Hang";
            this.txtKhachHang.Properties.View = this.txtKhachHang_View;
            this.txtKhachHang.Size = new System.Drawing.Size(746, 20);
            this.txtKhachHang.StyleController = this.layoutControl1;
            this.txtKhachHang.TabIndex = 6;
            this.txtKhachHang.EditValueChanged += new System.EventHandler(this.txtKhachHang_EditValueChanged);
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACH_HANG";
            this.kHACHHANGBindingSource.DataSource = this.dsKhachHang;
            // 
            // dsKhachHang
            // 
            this.dsKhachHang.DataSetName = "dsKhachHang";
            this.dsKhachHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtKhachHang_View
            // 
            this.txtKhachHang_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Khach_Hang,
            this.colTen_Khach_Hang,
            this.colDia_Chi,
            this.colGhi_Chu,
            this.colDien_Thoai1,
            this.colEmail,
            this.colFax,
            this.colMa_So_Thue,
            this.colNguoi_Lien_He,
            this.colTai_Khoan_Ngan_Hang,
            this.colTen_Khu_Vuc,
            this.colTen_Ngan_Hang,
            this.colWebsite,
            this.colDi_Dong});
            this.txtKhachHang_View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtKhachHang_View.Name = "txtKhachHang_View";
            this.txtKhachHang_View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtKhachHang_View.OptionsView.ShowAutoFilterRow = true;
            this.txtKhachHang_View.OptionsView.ShowGroupPanel = false;
            // 
            // colMa_Khach_Hang
            // 
            this.colMa_Khach_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_Khach_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_Khach_Hang.Caption = "Mã Khách Hàng";
            this.colMa_Khach_Hang.FieldName = "Ma_Khach_Hang";
            this.colMa_Khach_Hang.Name = "colMa_Khach_Hang";
            this.colMa_Khach_Hang.OptionsColumn.ReadOnly = true;
            this.colMa_Khach_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa_Khach_Hang.Visible = true;
            this.colMa_Khach_Hang.VisibleIndex = 0;
            this.colMa_Khach_Hang.Width = 94;
            // 
            // colTen_Khach_Hang
            // 
            this.colTen_Khach_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Khach_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Khach_Hang.Caption = "Tên Khách Hàng";
            this.colTen_Khach_Hang.FieldName = "Ten_Khach_Hang";
            this.colTen_Khach_Hang.Name = "colTen_Khach_Hang";
            this.colTen_Khach_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Khach_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Khach_Hang.Visible = true;
            this.colTen_Khach_Hang.VisibleIndex = 1;
            this.colTen_Khach_Hang.Width = 98;
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDia_Chi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDia_Chi.Caption = "Địa Chỉ";
            this.colDia_Chi.FieldName = "Dia_Chi";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.OptionsColumn.ReadOnly = true;
            this.colDia_Chi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDia_Chi.Visible = true;
            this.colDia_Chi.VisibleIndex = 2;
            this.colDia_Chi.Width = 73;
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhi_Chu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhi_Chu.Caption = "Ghi Chú";
            this.colGhi_Chu.FieldName = "Ghi_Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            this.colGhi_Chu.OptionsColumn.ReadOnly = true;
            this.colGhi_Chu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGhi_Chu.Visible = true;
            this.colGhi_Chu.VisibleIndex = 13;
            this.colGhi_Chu.Width = 73;
            // 
            // colDien_Thoai1
            // 
            this.colDien_Thoai1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDien_Thoai1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDien_Thoai1.Caption = "Điện Thoại";
            this.colDien_Thoai1.FieldName = "Dien_Thoai";
            this.colDien_Thoai1.Name = "colDien_Thoai1";
            this.colDien_Thoai1.OptionsColumn.ReadOnly = true;
            this.colDien_Thoai1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDien_Thoai1.Visible = true;
            this.colDien_Thoai1.VisibleIndex = 3;
            this.colDien_Thoai1.Width = 73;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 73;
            // 
            // colFax
            // 
            this.colFax.AppearanceHeader.Options.UseTextOptions = true;
            this.colFax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.ReadOnly = true;
            this.colFax.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 6;
            this.colFax.Width = 73;
            // 
            // colMa_So_Thue
            // 
            this.colMa_So_Thue.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_So_Thue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_So_Thue.Caption = "Mã Số Thuế";
            this.colMa_So_Thue.FieldName = "Ma_So_Thue";
            this.colMa_So_Thue.Name = "colMa_So_Thue";
            this.colMa_So_Thue.OptionsColumn.ReadOnly = true;
            this.colMa_So_Thue.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa_So_Thue.Visible = true;
            this.colMa_So_Thue.VisibleIndex = 8;
            this.colMa_So_Thue.Width = 73;
            // 
            // colNguoi_Lien_He
            // 
            this.colNguoi_Lien_He.AppearanceHeader.Options.UseTextOptions = true;
            this.colNguoi_Lien_He.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNguoi_Lien_He.Caption = "Liên Hệ";
            this.colNguoi_Lien_He.FieldName = "Nguoi_Lien_He";
            this.colNguoi_Lien_He.Name = "colNguoi_Lien_He";
            this.colNguoi_Lien_He.OptionsColumn.ReadOnly = true;
            this.colNguoi_Lien_He.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNguoi_Lien_He.Visible = true;
            this.colNguoi_Lien_He.VisibleIndex = 9;
            this.colNguoi_Lien_He.Width = 73;
            // 
            // colTai_Khoan_Ngan_Hang
            // 
            this.colTai_Khoan_Ngan_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTai_Khoan_Ngan_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTai_Khoan_Ngan_Hang.Caption = "Tài Khoản";
            this.colTai_Khoan_Ngan_Hang.FieldName = "Tai_Khoan_Ngan_Hang";
            this.colTai_Khoan_Ngan_Hang.Name = "colTai_Khoan_Ngan_Hang";
            this.colTai_Khoan_Ngan_Hang.OptionsColumn.ReadOnly = true;
            this.colTai_Khoan_Ngan_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTai_Khoan_Ngan_Hang.Visible = true;
            this.colTai_Khoan_Ngan_Hang.VisibleIndex = 10;
            this.colTai_Khoan_Ngan_Hang.Width = 73;
            // 
            // colTen_Khu_Vuc
            // 
            this.colTen_Khu_Vuc.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Khu_Vuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Khu_Vuc.Caption = "Khu Vực";
            this.colTen_Khu_Vuc.FieldName = "Ten_Khu_Vuc";
            this.colTen_Khu_Vuc.Name = "colTen_Khu_Vuc";
            this.colTen_Khu_Vuc.OptionsColumn.ReadOnly = true;
            this.colTen_Khu_Vuc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Khu_Vuc.Visible = true;
            this.colTen_Khu_Vuc.VisibleIndex = 12;
            this.colTen_Khu_Vuc.Width = 73;
            // 
            // colTen_Ngan_Hang
            // 
            this.colTen_Ngan_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Ngan_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Ngan_Hang.Caption = "Ngân Hàng";
            this.colTen_Ngan_Hang.FieldName = "Ten_Ngan_Hang";
            this.colTen_Ngan_Hang.Name = "colTen_Ngan_Hang";
            this.colTen_Ngan_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Ngan_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Ngan_Hang.Visible = true;
            this.colTen_Ngan_Hang.VisibleIndex = 11;
            this.colTen_Ngan_Hang.Width = 73;
            // 
            // colWebsite
            // 
            this.colWebsite.AppearanceHeader.Options.UseTextOptions = true;
            this.colWebsite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWebsite.Caption = "Website";
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.OptionsColumn.ReadOnly = true;
            this.colWebsite.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 7;
            this.colWebsite.Width = 73;
            // 
            // colDi_Dong
            // 
            this.colDi_Dong.AppearanceHeader.Options.UseTextOptions = true;
            this.colDi_Dong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDi_Dong.Caption = "Di Động";
            this.colDi_Dong.FieldName = "Di_Dong";
            this.colDi_Dong.Name = "colDi_Dong";
            this.colDi_Dong.OptionsColumn.ReadOnly = true;
            this.colDi_Dong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDi_Dong.Visible = true;
            this.colDi_Dong.VisibleIndex = 4;
            this.colDi_Dong.Width = 83;
            // 
            // txtMaChungTu
            // 
            this.txtMaChungTu.Location = new System.Drawing.Point(985, 2);
            this.txtMaChungTu.Name = "txtMaChungTu";
            this.txtMaChungTu.Size = new System.Drawing.Size(104, 20);
            this.txtMaChungTu.StyleController = this.layoutControl1;
            this.txtMaChungTu.TabIndex = 5;
            // 
            // gcList
            // 
            this.gcList.DataSource = this.cHUNGTUCHITIETBindingSource;
            this.gcList.Location = new System.Drawing.Point(2, 98);
            this.gcList.MainView = this.gbList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rptHangHoa,
            this.rptTenHangHoa,
            this.rptMayTinh,
            this.rptKhoHang});
            this.gcList.Size = new System.Drawing.Size(1087, 439);
            this.gcList.TabIndex = 4;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gbList});
            // 
            // cHUNGTUCHITIETBindingSource
            // 
            this.cHUNGTUCHITIETBindingSource.DataMember = "CHUNG_TU_CHI_TIET";
            this.cHUNGTUCHITIETBindingSource.DataSource = this.dsNhapKho;
            // 
            // dsNhapKho
            // 
            this.dsNhapKho.DataSetName = "dsNhapKho";
            this.dsNhapKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbList
            // 
            this.gbList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Chi_Tiet,
            this.colMa_Chung_Tu,
            this.colMa_Hang_Hoa,
            this.colLoai_Chung_Tu,
            this.colMa_Kho_Hang,
            this.colSo_Luong,
            this.colDon_Gia,
            this.colThanh_Tien,
            this.colGhi_Chu1,
            this.colSo_Thu_Tu,
            this.colDon_Vi,
            this.colTen_Hang});
            this.gbList.GridControl = this.gcList;
            this.gbList.IndicatorWidth = 40;
            this.gbList.Name = "gbList";
            this.gbList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gbList.OptionsCustomization.AllowFilter = false;
            this.gbList.OptionsCustomization.AllowGroup = false;
            this.gbList.OptionsCustomization.AllowRowSizing = true;
            this.gbList.OptionsCustomization.AllowSort = false;
            this.gbList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gbList.OptionsSelection.InvertSelection = true;
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.gbList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gbList.OptionsView.ShowFooter = true;
            this.gbList.OptionsView.ShowGroupPanel = false;
            this.gbList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gbList_CustomDrawRowIndicator);
            this.gbList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gbList_CellValueChanged);
            // 
            // colMa_Chi_Tiet
            // 
            this.colMa_Chi_Tiet.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colMa_Chi_Tiet.AppearanceCell.Options.UseFont = true;
            this.colMa_Chi_Tiet.FieldName = "Ma_Chi_Tiet";
            this.colMa_Chi_Tiet.Name = "colMa_Chi_Tiet";
            // 
            // colMa_Chung_Tu
            // 
            this.colMa_Chung_Tu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colMa_Chung_Tu.AppearanceCell.Options.UseFont = true;
            this.colMa_Chung_Tu.FieldName = "Ma_Chung_Tu";
            this.colMa_Chung_Tu.Name = "colMa_Chung_Tu";
            // 
            // colMa_Hang_Hoa
            // 
            this.colMa_Hang_Hoa.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colMa_Hang_Hoa.AppearanceCell.Options.UseFont = true;
            this.colMa_Hang_Hoa.Caption = "Hàng hóa";
            this.colMa_Hang_Hoa.ColumnEdit = this.rptHangHoa;
            this.colMa_Hang_Hoa.FieldName = "Ma_Hang_Hoa";
            this.colMa_Hang_Hoa.Name = "colMa_Hang_Hoa";
            this.colMa_Hang_Hoa.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colMa_Hang_Hoa.Visible = true;
            this.colMa_Hang_Hoa.VisibleIndex = 0;
            this.colMa_Hang_Hoa.Width = 124;
            // 
            // rptHangHoa
            // 
            this.rptHangHoa.AutoHeight = false;
            this.rptHangHoa.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rptHangHoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptHangHoa.DataSource = this.hANGHOABindingSource;
            this.rptHangHoa.DisplayMember = "Ma_Hang";
            this.rptHangHoa.ImmediatePopup = true;
            this.rptHangHoa.Name = "rptHangHoa";
            this.rptHangHoa.NullText = "(Mã Hàng Hóa)";
            this.rptHangHoa.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.rptHangHoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rptHangHoa.ValueMember = "Ma_Hang";
            this.rptHangHoa.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANG_HOA";
            this.hANGHOABindingSource.DataSource = this.dsHangHoa;
            // 
            // dsHangHoa
            // 
            this.dsHangHoa.DataSetName = "dsHangHoa";
            this.dsHangHoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Hang,
            this.colTen_Hang1,
            this.colDon_Vi1,
            this.colGia_Nhap,
            this.colGia_Xuat});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMa_Hang
            // 
            this.colMa_Hang.Caption = "Mã Hàng";
            this.colMa_Hang.FieldName = "Ma_Hang";
            this.colMa_Hang.Name = "colMa_Hang";
            this.colMa_Hang.OptionsColumn.ReadOnly = true;
            this.colMa_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa_Hang.Visible = true;
            this.colMa_Hang.VisibleIndex = 0;
            // 
            // colTen_Hang1
            // 
            this.colTen_Hang1.Caption = "Tên Hàng";
            this.colTen_Hang1.FieldName = "Ten_Hang";
            this.colTen_Hang1.Name = "colTen_Hang1";
            this.colTen_Hang1.OptionsColumn.ReadOnly = true;
            this.colTen_Hang1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Hang1.Visible = true;
            this.colTen_Hang1.VisibleIndex = 1;
            // 
            // colDon_Vi1
            // 
            this.colDon_Vi1.Caption = "Đơn Vị";
            this.colDon_Vi1.FieldName = "Don_Vi";
            this.colDon_Vi1.Name = "colDon_Vi1";
            this.colDon_Vi1.OptionsColumn.ReadOnly = true;
            this.colDon_Vi1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDon_Vi1.Visible = true;
            this.colDon_Vi1.VisibleIndex = 2;
            // 
            // colGia_Nhap
            // 
            this.colGia_Nhap.Caption = "Giá Nhập";
            this.colGia_Nhap.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colGia_Nhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGia_Nhap.FieldName = "Gia_Nhap";
            this.colGia_Nhap.Name = "colGia_Nhap";
            this.colGia_Nhap.OptionsColumn.ReadOnly = true;
            this.colGia_Nhap.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGia_Nhap.Visible = true;
            this.colGia_Nhap.VisibleIndex = 3;
            // 
            // colGia_Xuat
            // 
            this.colGia_Xuat.Caption = "Giá Xuất";
            this.colGia_Xuat.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colGia_Xuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGia_Xuat.FieldName = "Gia_Xuat";
            this.colGia_Xuat.Name = "colGia_Xuat";
            this.colGia_Xuat.OptionsColumn.ReadOnly = true;
            this.colGia_Xuat.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGia_Xuat.Visible = true;
            this.colGia_Xuat.VisibleIndex = 4;
            // 
            // colLoai_Chung_Tu
            // 
            this.colLoai_Chung_Tu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colLoai_Chung_Tu.AppearanceCell.Options.UseFont = true;
            this.colLoai_Chung_Tu.FieldName = "Loai_Chung_Tu";
            this.colLoai_Chung_Tu.Name = "colLoai_Chung_Tu";
            // 
            // colMa_Kho_Hang
            // 
            this.colMa_Kho_Hang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colMa_Kho_Hang.AppearanceCell.Options.UseFont = true;
            this.colMa_Kho_Hang.Caption = "Kho Hàng";
            this.colMa_Kho_Hang.ColumnEdit = this.rptKhoHang;
            this.colMa_Kho_Hang.FieldName = "Ma_Kho_Hang";
            this.colMa_Kho_Hang.Name = "colMa_Kho_Hang";
            this.colMa_Kho_Hang.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colMa_Kho_Hang.Visible = true;
            this.colMa_Kho_Hang.VisibleIndex = 2;
            this.colMa_Kho_Hang.Width = 104;
            // 
            // rptKhoHang
            // 
            this.rptKhoHang.AutoHeight = false;
            this.rptKhoHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptKhoHang.DataSource = this.kHOHANGBindingSource;
            this.rptKhoHang.DisplayMember = "Ten_Kho";
            this.rptKhoHang.Name = "rptKhoHang";
            this.rptKhoHang.NullText = "(Kho Hàng)";
            this.rptKhoHang.ValueMember = "Ma_Kho";
            this.rptKhoHang.View = this.gridView2;
            // 
            // kHOHANGBindingSource
            // 
            this.kHOHANGBindingSource.DataMember = "KHO_HANG";
            this.kHOHANGBindingSource.DataSource = this.dsKho;
            // 
            // dsKho
            // 
            this.dsKho.DataSetName = "dsKho";
            this.dsKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Kho,
            this.colTen_Kho});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // colTen_Kho
            // 
            this.colTen_Kho.Caption = "Tên Kho";
            this.colTen_Kho.FieldName = "Ten_Kho";
            this.colTen_Kho.Name = "colTen_Kho";
            this.colTen_Kho.OptionsColumn.ReadOnly = true;
            this.colTen_Kho.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Kho.Visible = true;
            this.colTen_Kho.VisibleIndex = 1;
            // 
            // colSo_Luong
            // 
            this.colSo_Luong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSo_Luong.AppearanceCell.Options.UseFont = true;
            this.colSo_Luong.Caption = "Số Lượng";
            this.colSo_Luong.ColumnEdit = this.rptMayTinh;
            this.colSo_Luong.FieldName = "So_Luong";
            this.colSo_Luong.Name = "colSo_Luong";
            this.colSo_Luong.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colSo_Luong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "So_Luong", "{0:##,##0.###}")});
            this.colSo_Luong.Visible = true;
            this.colSo_Luong.VisibleIndex = 4;
            this.colSo_Luong.Width = 99;
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
            this.rptMayTinh.NullText = "0";
            this.rptMayTinh.ShowCloseButton = true;
            // 
            // colDon_Gia
            // 
            this.colDon_Gia.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDon_Gia.AppearanceCell.Options.UseFont = true;
            this.colDon_Gia.Caption = "Đơn Giá";
            this.colDon_Gia.ColumnEdit = this.rptMayTinh;
            this.colDon_Gia.FieldName = "Don_Gia";
            this.colDon_Gia.Name = "colDon_Gia";
            this.colDon_Gia.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colDon_Gia.Visible = true;
            this.colDon_Gia.VisibleIndex = 5;
            this.colDon_Gia.Width = 109;
            // 
            // colThanh_Tien
            // 
            this.colThanh_Tien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colThanh_Tien.AppearanceCell.Options.UseFont = true;
            this.colThanh_Tien.Caption = "Thành Tiền";
            this.colThanh_Tien.ColumnEdit = this.rptMayTinh;
            this.colThanh_Tien.FieldName = "Thanh_Tien";
            this.colThanh_Tien.Name = "colThanh_Tien";
            this.colThanh_Tien.OptionsColumn.ReadOnly = true;
            this.colThanh_Tien.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colThanh_Tien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Thanh_Tien", "{0:##,##0.###}")});
            this.colThanh_Tien.Visible = true;
            this.colThanh_Tien.VisibleIndex = 6;
            this.colThanh_Tien.Width = 118;
            // 
            // colGhi_Chu1
            // 
            this.colGhi_Chu1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colGhi_Chu1.AppearanceCell.Options.UseFont = true;
            this.colGhi_Chu1.Caption = "Ghi Chú";
            this.colGhi_Chu1.FieldName = "Ghi_Chu";
            this.colGhi_Chu1.Name = "colGhi_Chu1";
            this.colGhi_Chu1.Visible = true;
            this.colGhi_Chu1.VisibleIndex = 7;
            this.colGhi_Chu1.Width = 236;
            // 
            // colSo_Thu_Tu
            // 
            this.colSo_Thu_Tu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colSo_Thu_Tu.AppearanceCell.Options.UseFont = true;
            this.colSo_Thu_Tu.FieldName = "So_Thu_Tu";
            this.colSo_Thu_Tu.Name = "colSo_Thu_Tu";
            // 
            // colDon_Vi
            // 
            this.colDon_Vi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDon_Vi.AppearanceCell.Options.UseFont = true;
            this.colDon_Vi.Caption = "Đơn Vị";
            this.colDon_Vi.FieldName = "Don_Vi";
            this.colDon_Vi.Name = "colDon_Vi";
            this.colDon_Vi.OptionsColumn.ReadOnly = true;
            this.colDon_Vi.Visible = true;
            this.colDon_Vi.VisibleIndex = 3;
            // 
            // colTen_Hang
            // 
            this.colTen_Hang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colTen_Hang.AppearanceCell.Options.UseFont = true;
            this.colTen_Hang.Caption = "Tên Hàng";
            this.colTen_Hang.ColumnEdit = this.rptTenHangHoa;
            this.colTen_Hang.FieldName = "Ten_Hang";
            this.colTen_Hang.Name = "colTen_Hang";
            this.colTen_Hang.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colTen_Hang.Visible = true;
            this.colTen_Hang.VisibleIndex = 1;
            this.colTen_Hang.Width = 235;
            // 
            // rptTenHangHoa
            // 
            this.rptTenHangHoa.AutoHeight = false;
            this.rptTenHangHoa.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rptTenHangHoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rptTenHangHoa.DataSource = this.hANGHOABindingSource;
            this.rptTenHangHoa.DisplayMember = "Ten_Hang";
            this.rptTenHangHoa.ImmediatePopup = true;
            this.rptTenHangHoa.Name = "rptTenHangHoa";
            this.rptTenHangHoa.NullText = "(Hàng hóa)";
            this.rptTenHangHoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.rptTenHangHoa.ValueMember = "Ma_Hang";
            this.rptTenHangHoa.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa_Hang1,
            this.colTen_Hang2,
            this.colDon_Vi2,
            this.colGia_Nhap1,
            this.colGia_Xuat1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMa_Hang1
            // 
            this.colMa_Hang1.Caption = "Mã Hàng";
            this.colMa_Hang1.FieldName = "Ma_Hang";
            this.colMa_Hang1.Name = "colMa_Hang1";
            this.colMa_Hang1.OptionsColumn.ReadOnly = true;
            this.colMa_Hang1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa_Hang1.Visible = true;
            this.colMa_Hang1.VisibleIndex = 0;
            // 
            // colTen_Hang2
            // 
            this.colTen_Hang2.Caption = "Tên Hàng";
            this.colTen_Hang2.FieldName = "Ten_Hang";
            this.colTen_Hang2.Name = "colTen_Hang2";
            this.colTen_Hang2.OptionsColumn.ReadOnly = true;
            this.colTen_Hang2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Hang2.Visible = true;
            this.colTen_Hang2.VisibleIndex = 1;
            // 
            // colDon_Vi2
            // 
            this.colDon_Vi2.Caption = "Đơn Vị";
            this.colDon_Vi2.FieldName = "Don_Vi";
            this.colDon_Vi2.Name = "colDon_Vi2";
            this.colDon_Vi2.OptionsColumn.ReadOnly = true;
            this.colDon_Vi2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDon_Vi2.Visible = true;
            this.colDon_Vi2.VisibleIndex = 2;
            // 
            // colGia_Nhap1
            // 
            this.colGia_Nhap1.Caption = "Giá Nhập";
            this.colGia_Nhap1.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colGia_Nhap1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGia_Nhap1.FieldName = "Gia_Nhap";
            this.colGia_Nhap1.Name = "colGia_Nhap1";
            this.colGia_Nhap1.OptionsColumn.ReadOnly = true;
            this.colGia_Nhap1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGia_Nhap1.Visible = true;
            this.colGia_Nhap1.VisibleIndex = 3;
            // 
            // colGia_Xuat1
            // 
            this.colGia_Xuat1.Caption = "Giá Xuất";
            this.colGia_Xuat1.DisplayFormat.FormatString = "{0:##,##0.###}";
            this.colGia_Xuat1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGia_Xuat1.FieldName = "Gia_Xuat";
            this.colGia_Xuat1.Name = "colGia_Xuat1";
            this.colGia_Xuat1.OptionsColumn.ReadOnly = true;
            this.colGia_Xuat1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGia_Xuat1.Visible = true;
            this.colGia_Xuat1.VisibleIndex = 4;
            // 
            // txtHinhThucThuChi
            // 
            this.txtHinhThucThuChi.EditValue = "Thu - Chi tiền theo chứng từ (áp dụng cho khách lẻ)";
            this.txtHinhThucThuChi.Location = new System.Drawing.Point(797, 541);
            this.txtHinhThucThuChi.MenuManager = this.bm;
            this.txtHinhThucThuChi.Name = "txtHinhThucThuChi";
            this.txtHinhThucThuChi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtHinhThucThuChi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHinhThucThuChi.Properties.DataSource = this.hinhThucThuChiBindingSource;
            this.txtHinhThucThuChi.Properties.DisplayMember = "Ten";
            this.txtHinhThucThuChi.Properties.NullText = "";
            this.txtHinhThucThuChi.Properties.PopupSizeable = false;
            this.txtHinhThucThuChi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtHinhThucThuChi.Properties.ValueMember = "Ma";
            this.txtHinhThucThuChi.Properties.View = this.gridLookUpEdit1View;
            this.txtHinhThucThuChi.Size = new System.Drawing.Size(292, 20);
            this.txtHinhThucThuChi.StyleController = this.layoutControl1;
            this.txtHinhThucThuChi.TabIndex = 19;
            // 
            // hinhThucThuChiBindingSource
            // 
            this.hinhThucThuChiBindingSource.DataMember = "Hinh_Thuc_Thu_Chi";
            this.hinhThucThuChiBindingSource.DataSource = this.dsHinhThuc;
            // 
            // dsHinhThuc
            // 
            this.dsHinhThuc.DataSetName = "dsHinhThuc";
            this.dsHinhThuc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa1,
            this.colTen1,
            this.colGhiChu1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMa1
            // 
            this.colMa1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa1.Caption = "Mã";
            this.colMa1.FieldName = "Ma";
            this.colMa1.Name = "colMa1";
            this.colMa1.OptionsColumn.ReadOnly = true;
            this.colMa1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa1.Visible = true;
            this.colMa1.VisibleIndex = 0;
            // 
            // colTen1
            // 
            this.colTen1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen1.Caption = "Tên";
            this.colTen1.FieldName = "Ten";
            this.colTen1.Name = "colTen1";
            this.colTen1.OptionsColumn.ReadOnly = true;
            this.colTen1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen1.Visible = true;
            this.colTen1.VisibleIndex = 1;
            // 
            // colGhiChu1
            // 
            this.colGhiChu1.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhiChu1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhiChu1.Caption = "Ghi  Chú";
            this.colGhiChu1.FieldName = "GhiChu";
            this.colGhiChu1.Name = "colGhiChu1";
            this.colGhiChu1.OptionsColumn.ReadOnly = true;
            this.colGhiChu1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGhiChu1.Visible = true;
            this.colGhiChu1.VisibleIndex = 2;
            // 
            // txtHinhThucCongNo
            // 
            this.txtHinhThucCongNo.EditValue = "Thanh toán ngay";
            this.txtHinhThucCongNo.Location = new System.Drawing.Point(797, 566);
            this.txtHinhThucCongNo.MenuManager = this.bm;
            this.txtHinhThucCongNo.Name = "txtHinhThucCongNo";
            this.txtHinhThucCongNo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txtHinhThucCongNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHinhThucCongNo.Properties.DataSource = this.hinhThucThanhToanBindingSource;
            this.txtHinhThucCongNo.Properties.DisplayMember = "Ten";
            this.txtHinhThucCongNo.Properties.NullText = "";
            this.txtHinhThucCongNo.Properties.PopupSizeable = false;
            this.txtHinhThucCongNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtHinhThucCongNo.Properties.ValueMember = "Ma";
            this.txtHinhThucCongNo.Properties.View = this.gridView4;
            this.txtHinhThucCongNo.Size = new System.Drawing.Size(292, 20);
            this.txtHinhThucCongNo.StyleController = this.layoutControl1;
            this.txtHinhThucCongNo.TabIndex = 20;
            // 
            // hinhThucThanhToanBindingSource
            // 
            this.hinhThucThanhToanBindingSource.DataMember = "Hinh_Thuc_Thanh_Toan";
            this.hinhThucThanhToanBindingSource.DataSource = this.dsHinhThuc;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMa,
            this.colTen,
            this.colGhiChu});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colMa
            // 
            this.colMa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa.Caption = "Mã";
            this.colMa.FieldName = "Ma";
            this.colMa.Name = "colMa";
            this.colMa.OptionsColumn.ReadOnly = true;
            this.colMa.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa.Visible = true;
            this.colMa.VisibleIndex = 0;
            // 
            // colTen
            // 
            this.colTen.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.ReadOnly = true;
            this.colTen.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.ReadOnly = true;
            this.colGhiChu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.splitterItem1,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem8,
            this.layoutControlItem12,
            this.layoutControlItem11,
            this.layoutControlItem17,
            this.layoutControlItem16,
            this.layoutControlItem18});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1091, 612);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcList;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1091, 443);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMaChungTu;
            this.layoutControlItem2.CustomizationFormText = "Mã Chứng Từ";
            this.layoutControlItem2.Location = new System.Drawing.Point(869, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(222, 24);
            this.layoutControlItem2.Text = "Mã Chứng Từ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtKhachHang;
            this.layoutControlItem3.CustomizationFormText = "Khách Hàng";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(864, 24);
            this.layoutControlItem3.Text = "Khách Hàng";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtNgay;
            this.layoutControlItem4.CustomizationFormText = "Ngày";
            this.layoutControlItem4.Location = new System.Drawing.Point(869, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(222, 24);
            this.layoutControlItem4.Text = "Ngày";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtGhiChu;
            this.layoutControlItem5.CustomizationFormText = "Ghi Chú";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(864, 24);
            this.layoutControlItem5.Text = "Ghi Chú";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtMaHoaDon;
            this.layoutControlItem6.CustomizationFormText = "Mã Hóa Đơn";
            this.layoutControlItem6.Location = new System.Drawing.Point(869, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(222, 24);
            this.layoutControlItem6.Text = "Mã Hóa Đơn";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtLyDo;
            this.layoutControlItem7.CustomizationFormText = "Lý Do";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(864, 24);
            this.layoutControlItem7.Text = "Lý Do";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(111, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(864, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 96);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem9.Control = this.txtVATPhanTram;
            this.layoutControlItem9.CustomizationFormText = "VAT";
            this.layoutControlItem9.Location = new System.Drawing.Point(381, 564);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(78, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(150, 24);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "VAT:";
            this.layoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(65, 13);
            this.layoutControlItem9.TextToControlDistance = 5;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtVATThanhTien;
            this.layoutControlItem10.CustomizationFormText = "layoutControlItem10";
            this.layoutControlItem10.Location = new System.Drawing.Point(531, 564);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(54, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(150, 24);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "layoutControlItem10";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextToControlDistance = 0;
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.layoutControl2;
            this.layoutControlItem13.CustomizationFormText = "layoutControlItem13";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 539);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(381, 73);
            this.layoutControlItem13.Text = "layoutControlItem13";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextToControlDistance = 0;
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.txtNhanVien;
            this.layoutControlItem14.CustomizationFormText = "Nhân Viên";
            this.layoutControlItem14.Location = new System.Drawing.Point(869, 72);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(222, 24);
            this.layoutControlItem14.Text = "Nhân Viên";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.txtDiaChi;
            this.layoutControlItem15.CustomizationFormText = "Địa Chỉ";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(864, 24);
            this.layoutControlItem15.Text = "Địa Chỉ";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.txtThanhTien;
            this.layoutControlItem8.CustomizationFormText = "Thành Tiền:";
            this.layoutControlItem8.Location = new System.Drawing.Point(381, 588);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(116, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "Thành Tiền:";
            this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(65, 13);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem12.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem12.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem12.Control = this.txtChietKhauPhanTram;
            this.layoutControlItem12.CustomizationFormText = "Chiết Khấu:";
            this.layoutControlItem12.Location = new System.Drawing.Point(381, 539);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(115, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(150, 25);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "Chiết Khấu:";
            this.layoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(65, 13);
            this.layoutControlItem12.TextToControlDistance = 5;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtChietKhauThanhTien;
            this.layoutControlItem11.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem11.Location = new System.Drawing.Point(531, 539);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(150, 24);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(54, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(150, 25);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "layoutControlItem11";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 0;
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem17.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem17.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem17.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem17.Control = this.txtHinhThucThuChi;
            this.layoutControlItem17.CustomizationFormText = "Hình Thức Thu - Chi:";
            this.layoutControlItem17.Location = new System.Drawing.Point(681, 539);
            this.layoutControlItem17.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(410, 25);
            this.layoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem17.Text = "Hình Thức Thu - Chi:";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem16.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem16.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem16.Control = this.txtHinhThucCongNo;
            this.layoutControlItem16.CustomizationFormText = "Hình Thức Công Nợ:";
            this.layoutControlItem16.Location = new System.Drawing.Point(681, 564);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(410, 24);
            this.layoutControlItem16.Text = "Hình Thức Công Nợ:";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem18.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem18.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem18.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem18.Control = this.txtThanhToan;
            this.layoutControlItem18.CustomizationFormText = "Thanh Toán:";
            this.layoutControlItem18.Location = new System.Drawing.Point(681, 588);
            this.layoutControlItem18.MaxSize = new System.Drawing.Size(410, 24);
            this.layoutControlItem18.MinSize = new System.Drawing.Size(185, 24);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(410, 24);
            this.layoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem18.Text = "Thanh Toán - Chi:";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(111, 13);
            // 
            // kHACH_HANGTableAdapter
            // 
            this.kHACH_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // cHUNG_TU_CHI_TIETTableAdapter
            // 
            this.cHUNG_TU_CHI_TIETTableAdapter.ClearBeforeFill = true;
            // 
            // hANG_HOATableAdapter
            // 
            this.hANG_HOATableAdapter.ClearBeforeFill = true;
            // 
            // kHO_HANGTableAdapter
            // 
            this.kHO_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // pm
            // 
            this.pm.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXoaTatCa)});
            this.pm.Manager = this.bm;
            this.pm.Name = "pm";
            // 
            // nhan_VienTableAdapter
            // 
            this.nhan_VienTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 641);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Kho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhToan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChietKhauPhanTram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChietKhauThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVATThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVATPhanTram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHoaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhachHang_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChungTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGTUCHITIETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptKhoHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptMayTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptTenHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHinhThucThuChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucThuChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHinhThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHinhThucCongNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhThucThanhToanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.GridLookUpEdit txtKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView txtKhachHang_View;
        private DevExpress.XtraEditors.TextEdit txtMaChungTu;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gbList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtLyDo;
        private DevExpress.XtraEditors.TextEdit txtMaHoaDon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraEditors.CalcEdit txtChietKhauPhanTram;
        private DevExpress.XtraEditors.CalcEdit txtChietKhauThanhTien;
        private DevExpress.XtraEditors.CalcEdit txtVATThanhTien;
        private DevExpress.XtraEditors.CalcEdit txtVATPhanTram;
        private DevExpress.XtraEditors.CalcEdit txtThanhTien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHang dsKhachHang;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHangTableAdapters.KHACH_HANGTableAdapter kHACH_HANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Khach_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Khach_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu;
        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbiTaoMoi;
        private DevExpress.XtraBars.BarButtonItem bbiLuu;
        private DevExpress.XtraBars.BarButtonItem bbiDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection img;
        private System.Windows.Forms.BindingSource cHUNGTUCHITIETBindingSource;
        private Quan_Ly_Vat_Tu.NhapKho.DS.dsNhapKho dsNhapKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Chi_Tiet;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Chung_Tu;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Hang_Hoa;
        private DevExpress.XtraGrid.Columns.GridColumn colLoai_Chung_Tu;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kho_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Luong;
        private DevExpress.XtraGrid.Columns.GridColumn colDon_Gia;
        private DevExpress.XtraGrid.Columns.GridColumn colThanh_Tien;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu1;
        private DevExpress.XtraGrid.Columns.GridColumn colSo_Thu_Tu;
        private Quan_Ly_Vat_Tu.NhapKho.DS.dsNhapKhoTableAdapters.CHUNG_TU_CHI_TIETTableAdapter cHUNG_TU_CHI_TIETTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDon_Vi;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Hang;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rptHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private Quan_Ly_Vat_Tu.HangHoa.DS.dsHangHoa dsHangHoa;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private Quan_Ly_Vat_Tu.HangHoa.DS.dsHangHoaTableAdapters.HANG_HOATableAdapter hANG_HOATableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Hang1;
        private DevExpress.XtraGrid.Columns.GridColumn colDon_Vi1;
        private DevExpress.XtraGrid.Columns.GridColumn colGia_Nhap;
        private DevExpress.XtraGrid.Columns.GridColumn colGia_Xuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rptTenHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Hang1;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Hang2;
        private DevExpress.XtraGrid.Columns.GridColumn colDon_Vi2;
        private DevExpress.XtraGrid.Columns.GridColumn colGia_Nhap1;
        private DevExpress.XtraGrid.Columns.GridColumn colGia_Xuat1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit rptMayTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rptKhoHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private Quan_Ly_Vat_Tu.Kho.DS.dsKho dsKho;
        private System.Windows.Forms.BindingSource kHOHANGBindingSource;
        private Quan_Ly_Vat_Tu.Kho.DS.dsKhoTableAdapters.KHO_HANGTableAdapter kHO_HANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Kho;
        private DevExpress.XtraBars.PopupMenu pm;
        private DevExpress.XtraBars.BarButtonItem bbiXoa;
        private DevExpress.XtraBars.BarButtonItem bbiXoaTatCa;
        private DevExpress.XtraEditors.GridLookUpEdit txtNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private NhanVien.DataSet.dsNhanVien dsNhanVien;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private NhanVien.DataSet.dsNhanVienTableAdapters.Nhan_VienTableAdapter nhan_VienTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nhan_Vien;
        private DevExpress.XtraGrid.Columns.GridColumn colHo_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn colDia_Chi1;
        private DevExpress.XtraGrid.Columns.GridColumn colNam_Sinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Thoai;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay_Vao_Lam;
        private DevExpress.XtraGrid.Columns.GridColumn colChuc_Vu;
        private DevExpress.XtraGrid.Columns.GridColumn colBo_Phan;
        private DevExpress.XtraGrid.Columns.GridColumn colCua_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colGhi_Chu2;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Cua_Hang;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraEditors.CalcEdit txtThanhToan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraGrid.Columns.GridColumn colDien_Thoai1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_So_Thue;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoi_Lien_He;
        private DevExpress.XtraGrid.Columns.GridColumn colTai_Khoan_Ngan_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Khu_Vuc;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Ngan_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_Dong;
        private DevExpress.XtraEditors.GridLookUpEdit txtHinhThucThuChi;
        private System.Windows.Forms.BindingSource hinhThucThuChiBindingSource;
        private DataSet.dsHinhThuc dsHinhThuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMa1;
        private DevExpress.XtraGrid.Columns.GridColumn colTen1;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu1;
        private DevExpress.XtraEditors.GridLookUpEdit txtHinhThucCongNo;
        private System.Windows.Forms.BindingSource hinhThucThanhToanBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
    }
}