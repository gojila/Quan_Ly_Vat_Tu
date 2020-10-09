namespace Quan_Ly_Vat_Tu.HangHoa
{
    partial class frmHangHoa_Them_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa_Them_Sua));
            this.kHUVUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKhachHang = new Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHang();
            this.kHU_VUCTableAdapter = new Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHangTableAdapters.KHU_VUCTableAdapter();
            this.nHOMHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsHangHoa = new Quan_Ly_Vat_Tu.HangHoa.DS.dsHangHoa();
            this.nHOM_HANGTableAdapter = new Quan_Ly_Vat_Tu.HangHoa.DS.dsHangHoaTableAdapters.NHOM_HANGTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtNhomHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMa_Nhom_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen_Nhom_Hang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.txtTenHangHoa = new DevExpress.XtraEditors.TextEdit();
            this.txtDonVi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHangHoa = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.nHOMHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhomHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHangHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            // nHOMHANGBindingSource
            // 
            this.nHOMHANGBindingSource.DataMember = "NHOM_HANG";
            this.nHOMHANGBindingSource.DataSource = this.dsHangHoa;
            // 
            // dsHangHoa
            // 
            this.dsHangHoa.DataSetName = "dsHangHoa";
            this.dsHangHoa.EnforceConstraints = false;
            this.dsHangHoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHOM_HANGTableAdapter
            // 
            this.nHOM_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtNhomHang);
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Controls.Add(this.txtTenHangHoa);
            this.layoutControl1.Controls.Add(this.txtDonVi);
            this.layoutControl1.Controls.Add(this.txtMaHangHoa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(571, 205);
            this.layoutControl1.TabIndex = 38;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtNhomHang
            // 
            this.txtNhomHang.EditValue = "";
            this.txtNhomHang.Location = new System.Drawing.Point(360, 7);
            this.txtNhomHang.Name = "txtNhomHang";
            this.txtNhomHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNhomHang.Properties.DataSource = this.nHOMHANGBindingSource;
            this.txtNhomHang.Properties.DisplayMember = "Ten_Nhom_Hang";
            this.txtNhomHang.Properties.NullText = "";
            this.txtNhomHang.Properties.NullValuePrompt = "Nhóm Hàng";
            this.txtNhomHang.Properties.PopupView = this.gridView1;
            this.txtNhomHang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtNhomHang.Properties.ValueMember = "Id";
            this.txtNhomHang.Size = new System.Drawing.Size(204, 20);
            this.txtNhomHang.StyleController = this.layoutControl1;
            this.txtNhomHang.TabIndex = 9;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMa_Nhom_Hang,
            this.colTen_Nhom_Hang});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // colMa_Nhom_Hang
            // 
            this.colMa_Nhom_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colMa_Nhom_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMa_Nhom_Hang.Caption = "Mã Nhóm Hàng";
            this.colMa_Nhom_Hang.FieldName = "Ma_Nhom_Hang";
            this.colMa_Nhom_Hang.Name = "colMa_Nhom_Hang";
            this.colMa_Nhom_Hang.OptionsColumn.ReadOnly = true;
            this.colMa_Nhom_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMa_Nhom_Hang.Visible = true;
            this.colMa_Nhom_Hang.VisibleIndex = 0;
            // 
            // colTen_Nhom_Hang
            // 
            this.colTen_Nhom_Hang.AppearanceHeader.Options.UseTextOptions = true;
            this.colTen_Nhom_Hang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTen_Nhom_Hang.Caption = "Tên Nhóm Hàng";
            this.colTen_Nhom_Hang.FieldName = "Ten_Nhom_Hang";
            this.colTen_Nhom_Hang.Name = "colTen_Nhom_Hang";
            this.colTen_Nhom_Hang.OptionsColumn.ReadOnly = true;
            this.colTen_Nhom_Hang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTen_Nhom_Hang.Visible = true;
            this.colTen_Nhom_Hang.VisibleIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(80, 55);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.NullValuePrompt = "Ghi Chú";
            this.txtGhiChu.Size = new System.Drawing.Size(484, 143);
            this.txtGhiChu.StyleController = this.layoutControl1;
            this.txtGhiChu.TabIndex = 8;
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Location = new System.Drawing.Point(80, 31);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Properties.NullValuePrompt = "Tên Vật Tư";
            this.txtTenHangHoa.Size = new System.Drawing.Size(203, 20);
            this.txtTenHangHoa.StyleController = this.layoutControl1;
            this.txtTenHangHoa.TabIndex = 6;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(360, 31);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Properties.NullValuePrompt = "Đơn Vị";
            this.txtDonVi.Size = new System.Drawing.Size(204, 20);
            this.txtDonVi.StyleController = this.layoutControl1;
            this.txtDonVi.TabIndex = 5;
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Location = new System.Drawing.Point(80, 7);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Properties.NullValuePrompt = "Mã Vật Tư";
            this.txtMaHangHoa.Size = new System.Drawing.Size(203, 20);
            this.txtMaHangHoa.StyleController = this.layoutControl1;
            this.txtMaHangHoa.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(571, 205);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AllowHtmlStringInCaption = true;
            this.layoutControlItem3.Control = this.txtTenHangHoa;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem3.Text = "Tên Vật Tư <color=red>(*)</color>";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtGhiChu;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(561, 147);
            this.layoutControlItem5.Text = "Ghi Chú";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtNhomHang;
            this.layoutControlItem4.Location = new System.Drawing.Point(280, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(281, 24);
            this.layoutControlItem4.Text = "Nhóm Hàng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDonVi;
            this.layoutControlItem2.Location = new System.Drawing.Point(280, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(281, 24);
            this.layoutControlItem2.Text = "Đơn Vị ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AllowHtmlStringInCaption = true;
            this.layoutControlItem1.Control = this.txtMaHangHoa;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem1.Text = "Mã Vật Tư <color=red>(*)</color>";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 13);
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
            this.barDockControlTop.Size = new System.Drawing.Size(571, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 205);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(571, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 205);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(571, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 205);
            // 
            // frmHangHoa_Them_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 231);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHangHoa_Them_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vật Tư";
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNhomHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHangHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHang dsKhachHang;
        private System.Windows.Forms.BindingSource kHUVUCBindingSource;
        private Quan_Ly_Vat_Tu.KhachHang.DS.dsKhachHangTableAdapters.KHU_VUCTableAdapter kHU_VUCTableAdapter;
        private Quan_Ly_Vat_Tu.HangHoa.DS.dsHangHoa dsHangHoa;
        private System.Windows.Forms.BindingSource nHOMHANGBindingSource;
        private Quan_Ly_Vat_Tu.HangHoa.DS.dsHangHoaTableAdapters.NHOM_HANGTableAdapter nHOM_HANGTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GridLookUpEdit txtNhomHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.MemoEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtTenHangHoa;
        private DevExpress.XtraEditors.TextEdit txtDonVi;
        private DevExpress.XtraEditors.TextEdit txtMaHangHoa;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbiLuu;
        private DevExpress.XtraBars.BarButtonItem bbiHuy;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMa_Nhom_Hang;
        private DevExpress.XtraGrid.Columns.GridColumn colTen_Nhom_Hang;
    }
}