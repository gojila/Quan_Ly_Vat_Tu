namespace Quan_Ly_Vat_Tu.Kho
{
    partial class NhomHang_Them_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomHang_Them_Sua));
            this.kHUVUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKhachHang = new Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHang();
            this.kHU_VUCTableAdapter = new Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHangTableAdapters.KHU_VUCTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.txtTenNhomHang = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhomHang = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbiLuu = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhomHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhomHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // kHUVUCBindingSource
            // 
            this.kHUVUCBindingSource.DataMember = "KHU_VUC";
            this.kHUVUCBindingSource.DataSource = this.dsKhachHang;
            // 
            // dsKhachHang
            // 
            this.dsKhachHang.DataSetName = "dsKhachHang";
            this.dsKhachHang.EnforceConstraints = false;
            this.dsKhachHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHU_VUCTableAdapter
            // 
            this.kHU_VUCTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Controls.Add(this.txtTenNhomHang);
            this.layoutControl1.Controls.Add(this.txtMaNhomHang);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(362, 167);
            this.layoutControl1.TabIndex = 37;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(103, 55);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(252, 105);
            this.txtGhiChu.StyleController = this.layoutControl1;
            this.txtGhiChu.TabIndex = 6;
            // 
            // txtTenNhomHang
            // 
            this.txtTenNhomHang.Location = new System.Drawing.Point(103, 31);
            this.txtTenNhomHang.Name = "txtTenNhomHang";
            this.txtTenNhomHang.Size = new System.Drawing.Size(252, 20);
            this.txtTenNhomHang.StyleController = this.layoutControl1;
            this.txtTenNhomHang.TabIndex = 5;
            // 
            // txtMaNhomHang
            // 
            this.txtMaNhomHang.Location = new System.Drawing.Point(103, 7);
            this.txtMaNhomHang.Name = "txtMaNhomHang";
            this.txtMaNhomHang.Size = new System.Drawing.Size(252, 20);
            this.txtMaNhomHang.StyleController = this.layoutControl1;
            this.txtMaNhomHang.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(362, 167);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AllowHtmlStringInCaption = true;
            this.layoutControlItem1.Control = this.txtMaNhomHang;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(352, 24);
            this.layoutControlItem1.Text = "Mã Nhóm Hàng <color=red>(*)</color>";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AllowHtmlStringInCaption = true;
            this.layoutControlItem2.Control = this.txtTenNhomHang;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(352, 24);
            this.layoutControlItem2.Text = "Tên Nhóm Hàng <color=red>(*)</color>";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtGhiChu;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(352, 109);
            this.layoutControlItem3.Text = "Ghi Chú";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiLuu,
            this.bbiHuy});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbiLuu
            // 
            this.bbiLuu.Caption = "Lưu";
            this.bbiLuu.Id = 0;
            this.bbiLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiLuu.ImageOptions.Image")));
            this.bbiLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiLuu.ImageOptions.LargeImage")));
            this.bbiLuu.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.bbiLuu.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiLuu.Name = "bbiLuu";
            this.bbiLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLuu_ItemClick);
            // 
            // bbiHuy
            // 
            this.bbiHuy.Caption = "Hủy";
            this.bbiHuy.Id = 1;
            this.bbiHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiHuy.ImageOptions.Image")));
            this.bbiHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiHuy.ImageOptions.LargeImage")));
            this.bbiHuy.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.bbiHuy.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiHuy.Name = "bbiHuy";
            this.bbiHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHuy_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(362, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 167);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(362, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 167);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(362, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 167);
            // 
            // NhomHang_Them_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 193);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhomHang_Them_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhomHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhomHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHang dsKhachHang;
        private System.Windows.Forms.BindingSource kHUVUCBindingSource;
        private Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHangTableAdapters.KHU_VUCTableAdapter kHU_VUCTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtTenNhomHang;
        private DevExpress.XtraEditors.TextEdit txtMaNhomHang;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbiLuu;
        private DevExpress.XtraBars.BarButtonItem bbiHuy;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}