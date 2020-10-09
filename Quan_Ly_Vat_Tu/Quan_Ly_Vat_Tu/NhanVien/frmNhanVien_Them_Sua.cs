using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Filtering.Templates;
using Newtonsoft.Json;
using Quan_Ly_Vat_Tu.Bussiness;

namespace Quan_Ly_Vat_Tu.NhanVien
{
    public partial class frmNhanVien_Them_Sua : Form
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

        public delegate void SendDataEventHander(object sender, NHAN_VIEN nhanVien);

        public event SendDataEventHander SendData;
        private void RaiseSendDataEventHander(NHAN_VIEN nhanVien)
        {
            if (SendData != null)
            {
                SendData(this, nhanVien);
            }
        }

        Data_QLKDataContext db = new Data_QLKDataContext(SqlHelper.ConnectionString);
        string tinh_trang = "them";
        long Id;
        public frmNhanVien_Them_Sua()
        {
            InitializeComponent();
            tinh_trang = "them";

            txtMaNhanVien.Text = SqlHelper.GenCode("NHAN_VIEN", "Ma_Nhan_Vien", "NV", 5);
        }

        public frmNhanVien_Them_Sua(long Id)
        {
            InitializeComponent();
            this.Id = Id;
            tinh_trang = "sua";

            var nhanvien = (from nv in db.NHAN_VIENs
                            where nv.Id == Id
                            select nv).FirstOrDefault();

            txtMaNhanVien.Text = nhanvien.Ma_Nhan_Vien;
            txtHoTen.Text = nhanvien.Ho_Ten;
            txtDiaChi.Text = nhanvien.Dia_Chi;
            txtNamSinh.Text = nhanvien.Nam_Sinh;
            txtDienThoai.Text = nhanvien.Dien_Thoai;

            txtNgayVaoLam.Text = nhanvien.Ngay_Vao_Lam;
            txtChucVu.Text = nhanvien.Chuc_Vu;
            txtBoPhan.Text = nhanvien.Bo_Phan;
            txtGhiChu.Text = nhanvien.Ghi_Chu;
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show(this, "Mã nhân viên không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show(this, "Họ tên không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void bbiHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
                    NHAN_VIEN nhanvien = new NHAN_VIEN();
                    
                    nhanvien.Ma_Nhan_Vien = txtMaNhanVien.Text;
                    nhanvien.Ho_Ten = txtHoTen.Text;
                    nhanvien.Dia_Chi = txtDiaChi.Text;
                    nhanvien.Nam_Sinh = txtNamSinh.Text;
                    nhanvien.Dien_Thoai = txtDienThoai.Text;

                    nhanvien.Ngay_Vao_Lam = txtNgayVaoLam.Text;
                    nhanvien.Chuc_Vu = txtChucVu.Text;
                    nhanvien.Bo_Phan = txtBoPhan.Text;
                    nhanvien.Ghi_Chu = txtGhiChu.Text;
                    nhanvien.IsDeleted = false;

                    nhanvien.CreatedDate = DateTime.Now;

                    db.NHAN_VIENs.InsertOnSubmit(nhanvien);
                    db.SubmitChanges();
                    RaiseSendDataEventHander(nhanvien);
                }
                else
                {
                    var nhanvien = (from nv in db.NHAN_VIENs
                                    where nv.Id == this.Id
                                    select nv).FirstOrDefault();

                    nhanvien.Ma_Nhan_Vien = txtMaNhanVien.Text;
                    nhanvien.Ho_Ten = txtHoTen.Text;
                    nhanvien.Dia_Chi = txtDiaChi.Text;
                    nhanvien.Nam_Sinh = txtNamSinh.Text;
                    nhanvien.Dien_Thoai = txtDienThoai.Text;

                    nhanvien.Ngay_Vao_Lam = txtNgayVaoLam.Text;
                    nhanvien.Chuc_Vu = txtChucVu.Text;
                    nhanvien.Bo_Phan = txtBoPhan.Text;
                    nhanvien.Ghi_Chu = txtGhiChu.Text;
                    nhanvien.ModifiedDate = DateTime.Now;

                    db.SubmitChanges();
                    RaiseSendDataEventHander(nhanvien);
                }

                RaiseReloadEventHander();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
