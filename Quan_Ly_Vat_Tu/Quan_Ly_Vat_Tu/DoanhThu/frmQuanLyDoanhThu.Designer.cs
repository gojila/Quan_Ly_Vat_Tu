namespace Quan_Ly_Vat_Tu.DoanhThu
{
    partial class frmQuanLyDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDoanhThu));
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.blbiTheoHangHoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiTheoKhachHang = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiTheoNhanVien = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiTongHop = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img = new DevExpress.Utils.ImageCollection(this.components);
            this.plMain = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).BeginInit();
            this.SuspendLayout();
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
            this.blbiTheoHangHoa,
            this.blbiTheoKhachHang,
            this.blbiTongHop,
            this.blbiTheoNhanVien});
            this.bm.LargeImages = this.img;
            this.bm.MainMenu = this.bar2;
            this.bm.MaxItemId = 12;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.blbiTheoHangHoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.blbiTheoKhachHang),
            new DevExpress.XtraBars.LinkPersistInfo(this.blbiTheoNhanVien),
            new DevExpress.XtraBars.LinkPersistInfo(this.blbiTongHop)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // blbiTheoHangHoa
            // 
            this.blbiTheoHangHoa.Caption = "Theo Hàng Hóa";
            this.blbiTheoHangHoa.Id = 8;
            this.blbiTheoHangHoa.LargeImageIndex = 5;
            this.blbiTheoHangHoa.Name = "blbiTheoHangHoa";
            this.blbiTheoHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiTheoHangHoa_ItemClick);
            // 
            // blbiTheoKhachHang
            // 
            this.blbiTheoKhachHang.Caption = "Theo Khách Hàng";
            this.blbiTheoKhachHang.Id = 9;
            this.blbiTheoKhachHang.LargeImageIndex = 11;
            this.blbiTheoKhachHang.Name = "blbiTheoKhachHang";
            this.blbiTheoKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiTheoKhachHang_ItemClick);
            // 
            // blbiTheoNhanVien
            // 
            this.blbiTheoNhanVien.Caption = "Theo Nhân Viên";
            this.blbiTheoNhanVien.Id = 11;
            this.blbiTheoNhanVien.LargeImageIndex = 10;
            this.blbiTheoNhanVien.Name = "blbiTheoNhanVien";
            this.blbiTheoNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiTheoNhanVien_ItemClick);
            // 
            // blbiTongHop
            // 
            this.blbiTongHop.Caption = "Tổng Hợp";
            this.blbiTongHop.Id = 10;
            this.blbiTongHop.LargeImageIndex = 1;
            this.blbiTongHop.Name = "blbiTongHop";
            this.blbiTongHop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiTongHop_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1073, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 627);
            this.barDockControlBottom.Size = new System.Drawing.Size(1073, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 585);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1073, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 585);
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            this.img.Images.SetKeyName(0, "archive.png");
            this.img.Images.SetKeyName(1, "applications.png");
            this.img.Images.SetKeyName(2, "edit.png");
            this.img.Images.SetKeyName(3, "6_barcode_box.gif");
            this.img.Images.SetKeyName(4, "1438776229_product.png");
            this.img.Images.SetKeyName(5, "1438776525_deliverables.png");
            this.img.Images.SetKeyName(6, "1438776535_Box_Empty.png");
            this.img.Images.SetKeyName(7, "1438776543_package-x-generic.png");
            this.img.Images.SetKeyName(8, "file-complete-icon.png");
            this.img.Images.SetKeyName(9, "general_options.png");
            this.img.Images.SetKeyName(10, "Group-icon.png");
            this.img.Images.SetKeyName(11, "users-icon.png");
            // 
            // plMain
            // 
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 42);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1073, 585);
            this.plMain.TabIndex = 4;
            // 
            // frmQuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 627);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQuanLyDoanhThu";
            this.Text = "Doanh Thu";
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection img;
        private DevExpress.XtraEditors.GroupControl plMain;
        private DevExpress.XtraBars.BarLargeButtonItem blbiTheoHangHoa;
        private DevExpress.XtraBars.BarLargeButtonItem blbiTheoKhachHang;
        private DevExpress.XtraBars.BarLargeButtonItem blbiTongHop;
        private DevExpress.XtraBars.BarLargeButtonItem blbiTheoNhanVien;

    }
}