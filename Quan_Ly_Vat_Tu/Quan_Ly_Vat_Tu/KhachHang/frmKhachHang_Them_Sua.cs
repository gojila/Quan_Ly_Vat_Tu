using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Quan_Ly_Vat_Tu.Bussiness;
using Quan_Ly_Vat_Tu.Bussiness;

namespace Quan_Ly_Vat_Tu.KhachHang
{
    public partial class frmKhachHang_Them_Sua : Form
    {
        public delegate void ReloadEventHander(object sender);

        public event ReloadEventHander Reload;
        private void RaiseReloadEventHander()
        {
            if (Reload != null)
            {
                Reload(this);
            }
        }

        public delegate void SendDataEventHander(object sender, KHACH_HANG khachHang);

        public event SendDataEventHander SendData;
        private void RaiseSendDataEventHander(KHACH_HANG khachHang)
        {
            if (SendData != null)
            {
                SendData(this, khachHang);
            }
        }

        Data_QLKDataContext db = new Data_QLKDataContext(SqlHelper.ConnectionString);
        string tinh_trang = "them";
        long Id;
        public frmKhachHang_Them_Sua()
        {
            InitializeComponent();
            Khu_Vuc();
            tinh_trang = "them";

            txtMaKhachHang.Text = SqlHelper.GenCode("KHACH_HANG", "Ma_Khach_Hang", "KH", 5);
        }

        public frmKhachHang_Them_Sua(long Id)
        {
            InitializeComponent();
            this.Id = Id;
            Khu_Vuc();
            tinh_trang = "sua";

            var kh = (from k in db.KHACH_HANGs
                     where k.Id == Id
                      select k).FirstOrDefault();

            txtMaKhachHang.Text = kh.Ma_Khach_Hang;
            txtTenKhachHang.Text = kh.Ten_Khach_Hang;
            txtKhuVuc.EditValue = kh.Khu_Vuc_Id;
            txtDiaChi.Text = kh.Dia_Chi;
            txtMaSoThue.Text = kh.Ma_So_Thue;
            txtDienThoai.Text = kh.Dien_Thoai;
            txtFax.Text = kh.Fax;
            txtEmail.Text = kh.Email;
            txtDiDong.Text = kh.Di_Dong;
            txtWebsite.Text = kh.Website;
            txtNguoiLienHe.Text = kh.Nguoi_Lien_He;
            txtTaiKhoanNganHang.Text = kh.Tai_Khoan_Ngan_Hang;
            txtTenNganHang.Text = kh.Ten_Ngan_Hang;
            txtGhiChu.Text = kh.Ghi_Chu;
        }

        void Khu_Vuc()
        {
            kHU_VUCTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            kHU_VUCTableAdapter.ClearBeforeFill = true;
            kHU_VUCTableAdapter.Fill(dsKhachHang.KHU_VUC);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show(this, "Mã khách hàng không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtTenKhachHang.Text))
            {
                MessageBox.Show(this, "Tên khách hàng không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void bbiLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!Check())
                {
                    return;
                }
                if (tinh_trang == "them")
                {
                    KHACH_HANG kh = new KHACH_HANG();

                    kh.Ma_Khach_Hang = txtMaKhachHang.Text;
                    kh.Ten_Khach_Hang = txtTenKhachHang.Text;
                    kh.Khu_Vuc_Id = string.IsNullOrEmpty(txtKhuVuc.Text) ? 0 : Convert.ToInt64(txtKhuVuc.EditValue);
                    kh.Dia_Chi = txtDiaChi.Text;
                    kh.Ma_So_Thue = txtMaSoThue.Text;

                    kh.Dien_Thoai = txtDienThoai.Text;
                    kh.Fax = txtFax.Text;
                    kh.Email = txtEmail.Text;
                    kh.Di_Dong = txtDiDong.Text;
                    kh.Website = txtWebsite.Text;

                    kh.Nguoi_Lien_He = txtNguoiLienHe.Text;
                    kh.Tai_Khoan_Ngan_Hang = txtTaiKhoanNganHang.Text;
                    kh.Ten_Ngan_Hang = txtTenNganHang.Text;
                    kh.Ghi_Chu = txtGhiChu.Text;
                    kh.IsDeleted = false;

                    kh.CreatedDate = DateTime.Now;

                    db.KHACH_HANGs.InsertOnSubmit(kh);
                    db.SubmitChanges();
                    RaiseSendDataEventHander(kh);
                }
                else
                {
                    var kh = (from k in db.KHACH_HANGs
                              where k.Id == this.Id
                              select k).FirstOrDefault();

                    kh.Ma_Khach_Hang = txtMaKhachHang.Text;
                    kh.Ten_Khach_Hang = txtTenKhachHang.Text;
                    kh.Khu_Vuc_Id = string.IsNullOrEmpty(txtKhuVuc.Text) ? 0 : Convert.ToInt64(txtKhuVuc.EditValue);
                    kh.Dia_Chi = txtDiaChi.Text;
                    kh.Ma_So_Thue = txtMaSoThue.Text;

                    kh.Dien_Thoai = txtDienThoai.Text;
                    kh.Fax = txtFax.Text;
                    kh.Email = txtEmail.Text;
                    kh.Di_Dong = txtDiDong.Text;
                    kh.Website = txtWebsite.Text;

                    kh.Nguoi_Lien_He = txtNguoiLienHe.Text;
                    kh.Tai_Khoan_Ngan_Hang = txtTaiKhoanNganHang.Text;
                    kh.Ten_Ngan_Hang = txtTenNganHang.Text;
                    kh.Ghi_Chu = txtGhiChu.Text;

                    kh.ModifiedDate = DateTime.Now;
                    db.SubmitChanges();
                    RaiseSendDataEventHander(kh);
                }

                RaiseReloadEventHander();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbiHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
