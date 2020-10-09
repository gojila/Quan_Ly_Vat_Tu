namespace Quan_Ly_Vat_Tu.KhuVuc
{
    partial class frmKhuVuc_Them_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhuVuc_Them_Sua));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.txtTenKhuVuc = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhuVuc = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhuVuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhuVuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Controls.Add(this.txtTenKhuVuc);
            this.layoutControl1.Controls.Add(this.txtMaKhuVuc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(418, 201);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(87, 55);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.NullValuePrompt = "Ghi Chú";
            this.txtGhiChu.Size = new System.Drawing.Size(324, 139);
            this.txtGhiChu.StyleController = this.layoutControl1;
            this.txtGhiChu.TabIndex = 2;
            // 
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.Location = new System.Drawing.Point(87, 31);
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.Properties.NullValuePrompt = "Tên Khu Vực";
            this.txtTenKhuVuc.Size = new System.Drawing.Size(324, 20);
            this.txtTenKhuVuc.StyleController = this.layoutControl1;
            this.txtTenKhuVuc.TabIndex = 1;
            // 
            // txtMaKhuVuc
            // 
            this.txtMaKhuVuc.Location = new System.Drawing.Point(87, 7);
            this.txtMaKhuVuc.Name = "txtMaKhuVuc";
            this.txtMaKhuVuc.Properties.NullValuePrompt = "Mã Khu Vực";
            this.txtMaKhuVuc.Size = new System.Drawing.Size(324, 20);
            this.txtMaKhuVuc.StyleController = this.layoutControl1;
            this.txtMaKhuVuc.TabIndex = 0;
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
            this.Root.Size = new System.Drawing.Size(418, 201);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AllowHtmlStringInCaption = true;
            this.layoutControlItem1.Control = this.txtMaKhuVuc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(408, 24);
            this.layoutControlItem1.Text = "Mã Khu Vực <color=red>(*)</color>";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AllowHtmlStringInCaption = true;
            this.layoutControlItem2.Control = this.txtTenKhuVuc;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(408, 24);
            this.layoutControlItem2.Text = "Tên Khu Vực <color=red>(*)</color>";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtGhiChu;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(408, 143);
            this.layoutControlItem3.Text = "Ghi Chú";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
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
            this.barDockControlTop.Size = new System.Drawing.Size(418, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 201);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(418, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 201);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(418, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 201);
            // 
            // frmKhuVuc_Them_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 227);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhuVuc_Them_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khu Vực";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhuVuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhuVuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtTenKhuVuc;
        private DevExpress.XtraEditors.TextEdit txtMaKhuVuc;
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