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

namespace Quan_Ly_Vat_Tu.Kho
{
    public partial class frmKhoHang_Them_Sua : Form
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

        public delegate void SendDataEventHander(object sender, KHO_HANG khoHang);

        public event SendDataEventHander SendData;
        private void RaiseSendDataEventHander(KHO_HANG khoHang)
        {
            if (SendData != null)
            {
                SendData(this, khoHang);
            }
        }

        Data_QLKDataContext db = new Data_QLKDataContext(SqlHelper.ConnectionString);
        string tinh_trang = "them";
        long Id;
        public frmKhoHang_Them_Sua()
        {
            InitializeComponent();
            tinh_trang = "them";

            txtMaKho.Text = SqlHelper.GenCode("KHO_HANG", "Ma_Kho", "K", 5);
        }

        public frmKhoHang_Them_Sua(long Id)
        {
            InitializeComponent();
            this.Id = Id;
            tinh_trang = "sua";

            var kho = (from k in db.KHO_HANGs
                       where k.Id == Id
                       select k).FirstOrDefault();

            txtMaKho.Text = kho.Ma_Kho;
            txtTenKho.Text = kho.Ten_Kho;
            txtDiaChi.Text = kho.Dia_Chi;
            txtDienThoai.Text = kho.Dien_Thoai;
            txtFax.Text = kho.Fax;

            txtEmail.Text = kho.Email;
            txtDiDong.Text = kho.Di_Dong;
            txtThuKho.Text = kho.Thu_Kho;
            txtGhiChu.Text = kho.Ghi_Chu;
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(txtMaKho.Text))
            {
                MessageBox.Show(this, "Mã kho không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtTenKho.Text))
            {
                MessageBox.Show(this, "Tên kho không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    KHO_HANG kho = new KHO_HANG();
                    
                    kho.Ma_Kho = txtMaKho.Text;
                    kho.Ten_Kho = txtTenKho.Text;
                    kho.Dia_Chi = txtDiaChi.Text;
                    kho.Email = txtEmail.Text;
                    kho.Dien_Thoai = txtDienThoai.Text;

                    kho.Fax = txtFax.Text;
                    kho.Di_Dong = txtDiDong.Text;
                    kho.Thu_Kho = txtThuKho.Text;
                    kho.Ghi_Chu = txtGhiChu.Text;
                    kho.CreatedDate = DateTime.Now;

                    kho.IsDeleted = false;

                    db.KHO_HANGs.InsertOnSubmit(kho);
                    db.SubmitChanges();
                    RaiseSendDataEventHander(kho);
                }
                else
                {
                    var kho = (from k in db.KHO_HANGs
                               where k.Ma_Kho == txtMaKho.Text
                               select k).FirstOrDefault();

                    kho.Ma_Kho = txtMaKho.Text;
                    kho.Ten_Kho = txtTenKho.Text;
                    kho.Dia_Chi = txtDiaChi.Text;
                    kho.Email = txtEmail.Text;
                    kho.Dien_Thoai = txtDienThoai.Text;

                    kho.Fax = txtFax.Text;
                    kho.Di_Dong = txtDiDong.Text;
                    kho.Thu_Kho = txtThuKho.Text;
                    kho.Ghi_Chu = txtGhiChu.Text;
                    kho.ModifiedDate = DateTime.Now;
                    db.SubmitChanges();
                    RaiseSendDataEventHander(kho);
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
