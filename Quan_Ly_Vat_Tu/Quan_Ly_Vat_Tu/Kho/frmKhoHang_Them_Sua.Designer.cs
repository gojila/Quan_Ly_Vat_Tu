namespace Quan_Ly_Vat_Tu.Kho
{
    partial class frmKhoHang_Them_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoHang_Them_Sua));
            this.kHUVUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKhachHang = new Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHang();
            this.kHU_VUCTableAdapter = new Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHangTableAdapters.KHU_VUCTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbiLuu = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.txtThuKho = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtDiDong = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKho = new DevExpress.XtraEditors.TextEdit();
            this.txtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(713, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 355);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(713, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 355);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(713, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 355);
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(66, 7);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Properties.NullValuePrompt = "Mã Kho";
            this.txtMaKho.Size = new System.Drawing.Size(288, 20);
            this.txtMaKho.StyleController = this.layoutControl1;
            this.txtMaKho.TabIndex = 4;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Controls.Add(this.txtThuKho);
            this.layoutControl1.Controls.Add(this.txtEmail);
            this.layoutControl1.Controls.Add(this.txtDiDong);
            this.layoutControl1.Controls.Add(this.txtDiaChi);
            this.layoutControl1.Controls.Add(this.txtFax);
            this.layoutControl1.Controls.Add(this.txtTenKho);
            this.layoutControl1.Controls.Add(this.txtDienThoai);
            this.layoutControl1.Controls.Add(this.txtMaKho);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(713, 355);
            this.layoutControl1.TabIndex = 37;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(66, 103);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.NullValuePrompt = "Ghi Chú";
            this.txtGhiChu.Size = new System.Drawing.Size(640, 245);
            this.txtGhiChu.StyleController = this.layoutControl1;
            this.txtGhiChu.TabIndex = 12;
            // 
            // txtThuKho
            // 
            this.txtThuKho.Location = new System.Drawing.Point(417, 79);
            this.txtThuKho.Name = "txtThuKho";
            this.txtThuKho.Properties.NullValuePrompt = "Thủ Kho";
            this.txtThuKho.Size = new System.Drawing.Size(289, 20);
            this.txtThuKho.StyleController = this.layoutControl1;
            this.txtThuKho.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(66, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.NullValuePrompt = "Email";
            this.txtEmail.Size = new System.Drawing.Size(288, 20);
            this.txtEmail.StyleController = this.layoutControl1;
            this.txtEmail.TabIndex = 10;
            // 
            // txtDiDong
            // 
            this.txtDiDong.Location = new System.Drawing.Point(417, 55);
            this.txtDiDong.Name = "txtDiDong";
            this.txtDiDong.Properties.NullValuePrompt = "Di Động";
            this.txtDiDong.Size = new System.Drawing.Size(289, 20);
            this.txtDiDong.StyleController = this.layoutControl1;
            this.txtDiDong.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(66, 55);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.NullValuePrompt = "Địa Chỉ";
            this.txtDiaChi.Size = new System.Drawing.Size(288, 20);
            this.txtDiaChi.StyleController = this.layoutControl1;
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(417, 31);
            this.txtFax.Name = "txtFax";
            this.txtFax.Properties.NullValuePrompt = "Fax";
            this.txtFax.Size = new System.Drawing.Size(289, 20);
            this.txtFax.StyleController = this.layoutControl1;
            this.txtFax.TabIndex = 7;
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(66, 31);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Properties.NullValuePrompt = "Tên Kho";
            this.txtTenKho.Size = new System.Drawing.Size(288, 20);
            this.txtTenKho.StyleController = this.layoutControl1;
            this.txtTenKho.TabIndex = 6;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(417, 7);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Properties.NullValuePrompt = "Điện Thoại";
            this.txtDienThoai.Size = new System.Drawing.Size(289, 20);
            this.txtDienThoai.StyleController = this.layoutControl1;
            this.txtDienThoai.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(713, 355);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AllowHtmlStringInCaption = true;
            this.layoutControlItem1.Control = this.txtMaKho;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem1.Text = "Mã Kho <color=red>(*)</color>";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDienThoai;
            this.layoutControlItem2.Location = new System.Drawing.Point(351, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(352, 24);
            this.layoutControlItem2.Text = "Điện Thoại";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AllowHtmlStringInCaption = true;
            this.layoutControlItem3.Control = this.txtTenKho;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem3.Text = "Tên Kho <color=red>(*)</color>";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtFax;
            this.layoutControlItem4.Location = new System.Drawing.Point(351, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(352, 24);
            this.layoutControlItem4.Text = "Fax";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtDiaChi;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem5.Text = "Địa Chỉ";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtDiDong;
            this.layoutControlItem6.Location = new System.Drawing.Point(351, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(352, 24);
            this.layoutControlItem6.Text = "Di Động";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtEmail;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(351, 24);
            this.layoutControlItem7.Text = "Email";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtThuKho;
            this.layoutControlItem8.Location = new System.Drawing.Point(351, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(352, 24);
            this.layoutControlItem8.Text = "Thủ Kho";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtGhiChu;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(703, 249);
            this.layoutControlItem9.Text = "Ghi Chú";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(56, 13);
            // 
            // frmKhoHang_Them_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 381);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhoHang_Them_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHang dsKhachHang;
        private System.Windows.Forms.BindingSource kHUVUCBindingSource;
        private Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHangTableAdapters.KHU_VUCTableAdapter kHU_VUCTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbiLuu;
        private DevExpress.XtraBars.BarButtonItem bbiHuy;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtThuKho;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtDiDong;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.TextEdit txtTenKho;
        private DevExpress.XtraEditors.TextEdit txtDienThoai;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}