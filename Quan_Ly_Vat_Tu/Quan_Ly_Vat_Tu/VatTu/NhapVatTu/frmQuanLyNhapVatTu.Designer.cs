namespace Quan_Ly_Vat_Tu.VatTu.NhapVatTu
{
    partial class frmQuanLyNhapVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhapVatTu));
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiLapPhieuNhapKho = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbiDanhSach = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbiChiTiet = new DevExpress.XtraBars.BarLargeButtonItem();
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
            this.bbiLapPhieuNhapKho,
            this.bbiDanhSach,
            this.bbiChiTiet});
            this.bm.LargeImages = this.img;
            this.bm.MainMenu = this.bar2;
            this.bm.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiLapPhieuNhapKho),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDanhSach),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiChiTiet)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiLapPhieuNhapKho
            // 
            this.bbiLapPhieuNhapKho.Caption = "Lập Phiếu Nhập Vật Tư";
            this.bbiLapPhieuNhapKho.Id = 0;
            this.bbiLapPhieuNhapKho.ImageOptions.LargeImageIndex = 0;
            this.bbiLapPhieuNhapKho.Name = "bbiLapPhieuNhapKho";
            this.bbiLapPhieuNhapKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLapPhieuNhapKho_ItemClick);
            // 
            // bbiDanhSach
            // 
            this.bbiDanhSach.Caption = "Danh Sách";
            this.bbiDanhSach.Id = 2;
            this.bbiDanhSach.ImageOptions.LargeImageIndex = 2;
            this.bbiDanhSach.Name = "bbiDanhSach";
            this.bbiDanhSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDanhSach_ItemClick);
            // 
            // bbiChiTiet
            // 
            this.bbiChiTiet.Caption = "Chi Tiết";
            this.bbiChiTiet.Id = 3;
            this.bbiChiTiet.ImageOptions.LargeImageIndex = 1;
            this.bbiChiTiet.Name = "bbiChiTiet";
            this.bbiChiTiet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChiTiet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bm;
            this.barDockControlTop.Size = new System.Drawing.Size(1073, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 627);
            this.barDockControlBottom.Manager = this.bm;
            this.barDockControlBottom.Size = new System.Drawing.Size(1073, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.bm;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 587);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1073, 40);
            this.barDockControlRight.Manager = this.bm;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 587);
            // 
            // img
            // 
            this.img.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img.ImageStream")));
            this.img.Images.SetKeyName(0, "archive.png");
            this.img.Images.SetKeyName(1, "applications.png");
            this.img.Images.SetKeyName(2, "edit.png");
            // 
            // plMain
            // 
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 40);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1073, 587);
            this.plMain.TabIndex = 4;
            // 
            // frmQuanLyNhapVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 627);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyNhapVatTu";
            this.Text = "Quản Lý Nhập Vật Tư";
            this.Load += new System.EventHandler(this.frmQuanLyNhapVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem bbiLapPhieuNhapKho;
        private DevExpress.XtraBars.BarLargeButtonItem bbiDanhSach;
        private DevExpress.XtraBars.BarLargeButtonItem bbiChiTiet;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection img;
        private DevExpress.XtraEditors.GroupControl plMain;

    }
}