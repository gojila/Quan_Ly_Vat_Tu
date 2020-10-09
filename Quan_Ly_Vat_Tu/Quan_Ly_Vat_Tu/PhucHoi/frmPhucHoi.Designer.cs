namespace Quan_Ly_Vat_Tu.PhucHoi
{
    partial class frmPhucHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhucHoi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnThucHien = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.txtCoSoDuLieu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTapTin = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoSoDuLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTapTin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(160, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(130, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Phục hồi dữ liệu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên tập tin:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 66);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Cơ sở dữ liệu:";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(304, 89);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(75, 23);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(385, 89);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtCoSoDuLieu
            // 
            this.txtCoSoDuLieu.Location = new System.Drawing.Point(84, 63);
            this.txtCoSoDuLieu.Name = "txtCoSoDuLieu";
            this.txtCoSoDuLieu.Size = new System.Drawing.Size(375, 20);
            this.txtCoSoDuLieu.TabIndex = 6;
            // 
            // txtTenTapTin
            // 
            this.txtTenTapTin.Location = new System.Drawing.Point(84, 37);
            this.txtTenTapTin.Name = "txtTenTapTin";
            this.txtTenTapTin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtTenTapTin.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtTenTapTin_Properties_ButtonClick);
            this.txtTenTapTin.Size = new System.Drawing.Size(375, 20);
            this.txtTenTapTin.TabIndex = 7;
            // 
            // frmPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 124);
            this.Controls.Add(this.txtTenTapTin);
            this.Controls.Add(this.txtCoSoDuLieu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhucHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phục hồi dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.txtCoSoDuLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTapTin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnThucHien;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.TextEdit txtCoSoDuLieu;
        private DevExpress.XtraEditors.ButtonEdit txtTenTapTin;
    }
}