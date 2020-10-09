using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Vat_Tu.NhapKho
{
    public partial class frmQuanLyNhapKho : Form
    {
        public frmQuanLyNhapKho()
        {
            InitializeComponent();
            bbiDanhSach_ItemClick(this, null);
        }

        private void bbiLapPhieuNhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapKho frm = new frmNhapKho();
            frm.Reload += Reload;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        void Reload(object sender)
        {
            if (_ucDanhSach != null)
            {
                _ucDanhSach.Reload();
            }
            if (_ucChiTiet != null)
            {
                _ucChiTiet.Reload();
            }
        }

        private ucDanhSach _ucDanhSach;
        private void bbiDanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucDanhSach == null)
            {
                _ucDanhSach = new ucDanhSach();
                _ucDanhSach.Dock = DockStyle.Fill;
                plMain.Controls.Add(_ucDanhSach);
                _ucDanhSach.BestFit();
            }
            else
            {
                _ucDanhSach.Dock = DockStyle.Fill;
                plMain.Controls.Add(_ucDanhSach);
            }
            plMain.Text = @"Chứng Từ Nhập Kho";
        }

        private ucChiTiet _ucChiTiet;
        private void bbiChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucChiTiet == null)
            {
                _ucChiTiet = new ucChiTiet();
                _ucChiTiet.Dock = DockStyle.Fill;
                plMain.Controls.Add(_ucChiTiet);
                _ucChiTiet.BestFit();
            }
            else
            {
                _ucChiTiet.Dock = DockStyle.Fill;
                plMain.Controls.Add(_ucChiTiet);
            }
            
            plMain.Text = @"Chi Tiết Nhập Kho";
        }
    }
}
