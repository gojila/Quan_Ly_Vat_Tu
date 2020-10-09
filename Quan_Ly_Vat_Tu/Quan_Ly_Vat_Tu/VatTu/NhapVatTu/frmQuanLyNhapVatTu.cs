using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Vat_Tu.VatTu.NhapVatTu
{
    public partial class frmQuanLyNhapVatTu : Form
    {
        public int loai = 1; //1: nhap kho, 2: xuat kho
        public frmQuanLyNhapVatTu()
        {
            InitializeComponent();   
        }

        public void SetLoai(int loai) 
        {
            this.loai = loai;
            this.Text = String.Format("Quản Lý {0} Vật Tư", (loai == 1 ? "Nhập" : "Xuất"));
            bbiLapPhieuNhapKho.Caption = String.Format("Lập Phiếu {0} Vật Tư", (loai == 1 ? "Nhập" : "Xuất"));
        }

        private void bbiLapPhieuNhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapVatTu frm = new frmNhapVatTu(loai); //1: nhap, 2: xuat
            frm.Reload += Reload;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        void Reload(object sender)
        {
            if (_ucDanhSachNhapVatTu != null)
            {
                _ucDanhSachNhapVatTu.Reload();
            }
            if (_ucChiTietNhapVatTu != null)
            {
                _ucChiTietNhapVatTu.Reload();
            }
        }

        private ucDanhSachNhapVatTu _ucDanhSachNhapVatTu;
        private void bbiDanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucDanhSachNhapVatTu == null)
            {
                _ucDanhSachNhapVatTu = new ucDanhSachNhapVatTu();
                _ucDanhSachNhapVatTu.loai = this.loai;
                _ucDanhSachNhapVatTu.Dock = DockStyle.Fill;
                plMain.Controls.Add(_ucDanhSachNhapVatTu);
                _ucDanhSachNhapVatTu.BestFit();
            }
            else
            {
                _ucDanhSachNhapVatTu.Dock = DockStyle.Fill;
                plMain.Controls.Add(_ucDanhSachNhapVatTu);
            }
            plMain.Text = String.Format("Chứng Từ {0}", (loai == 1 ? "Nhập Kho" : "Xuất Kho"));
        }

        private ucChiTietNhapVatTu _ucChiTietNhapVatTu;
        private void bbiChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucChiTietNhapVatTu == null)
            {
                _ucChiTietNhapVatTu = new ucChiTietNhapVatTu();
                _ucChiTietNhapVatTu.Dock = DockStyle.Fill;
                plMain.Controls.Add(_ucChiTietNhapVatTu);
                _ucChiTietNhapVatTu.BestFit();
            }
            else
            {
                _ucChiTietNhapVatTu.Dock = DockStyle.Fill;
                plMain.Controls.Add(_ucChiTietNhapVatTu);
            }
            plMain.Text = String.Format("Chi Tiết {0}", (loai == 1 ? "Nhập Kho" : "Xuất Kho"));
        }

        private void frmQuanLyNhapVatTu_Load(object sender, EventArgs e)
        {
            bbiDanhSach_ItemClick(this, null);
        }
    }
}
