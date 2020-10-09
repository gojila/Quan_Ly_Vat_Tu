using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Vat_Tu.DoanhThu
{
    public partial class frmQuanLyDoanhThu : Form
    {
        public frmQuanLyDoanhThu()
        {
            InitializeComponent();
            blbiTheoHangHoa_ItemClick(this, null);
        }

        private ucTheoHangHoa _ucTheoHangHoa;
        private ucTheoKhachHang _ucTheoKhachHang;
        private ucTheoNhanVien _ucTheoNhanVien;
        private ucTheoTongHop _ucTheoTongHop;

        private void blbiTheoHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucTheoHangHoa == null)
            {
                _ucTheoHangHoa = new ucTheoHangHoa();
                _ucTheoHangHoa.Closed += _uc_Closed;
            }
            _ucTheoHangHoa.Dock = DockStyle.Fill;

            plMain.Controls.Add(_ucTheoHangHoa);
            plMain.Text = @"Doanh Thu Theo Hàng Hóa";
        }

        void _uc_Closed(object sender)
        {
            this.Close();
        }

        private void blbiTheoKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucTheoKhachHang == null)
            {
                _ucTheoKhachHang = new ucTheoKhachHang();
                _ucTheoKhachHang.Closed += _uc_Closed;
            }
            _ucTheoKhachHang.Dock = DockStyle.Fill;

            plMain.Controls.Add(_ucTheoKhachHang);
            plMain.Text = @"Doanh Thu Theo Khách Hàng";
        }

        private void blbiTongHop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucTheoTongHop == null)
            {
                _ucTheoTongHop = new ucTheoTongHop();
                _ucTheoTongHop.Closed += _uc_Closed;
            }
            _ucTheoTongHop.Dock = DockStyle.Fill;

            plMain.Controls.Add(_ucTheoTongHop);
            plMain.Text = @"Doanh Thu Tổng Hợp";
        }

        private void blbiTheoNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            plMain.Controls.Clear();
            if (_ucTheoNhanVien == null)
            {
                _ucTheoNhanVien = new ucTheoNhanVien();
                _ucTheoNhanVien.Closed += _uc_Closed;
            }
            _ucTheoNhanVien.Dock = DockStyle.Fill;

            plMain.Controls.Add(_ucTheoNhanVien);
            plMain.Text = @"Doanh Thu Theo Nhân Viên";
        }

        
    }
}
