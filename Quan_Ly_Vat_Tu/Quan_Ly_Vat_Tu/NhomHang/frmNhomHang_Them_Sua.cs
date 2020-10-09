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
    public partial class NhomHang_Them_Sua : Form
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

        Data_QLKDataContext db = new Data_QLKDataContext(SqlHelper.ConnectionString);
        string tinh_trang = "them";

        public NhomHang_Them_Sua()
        {
            InitializeComponent();
            tinh_trang = "them";

            txtMaNhomHang.Text = SqlHelper.GenCode("NHOM_HANG", "Ma_Nhom_Hang", "NH", 5);
        }

        public NhomHang_Them_Sua(long Id)
        {
            InitializeComponent();
            tinh_trang = "sua";

            var nh = (from n in db.NHOM_HANGs
                      where n.Id == Id
                      select n).FirstOrDefault();

            txtMaNhomHang.Text = nh.Ma_Nhom_Hang;
            txtTenNhomHang.Text = nh.Ten_Nhom_Hang;
            txtGhiChu.Text = nh.Ghi_Chu;
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(txtMaNhomHang.Text))
            {
                MessageBox.Show(this, "Mã nhóm hàng không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtTenNhomHang.Text))
            {
                MessageBox.Show(this, "Tên nhóm hàng không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    NHOM_HANG nh = new NHOM_HANG();

                    nh.Ma_Nhom_Hang = txtMaNhomHang.Text;
                    nh.Ten_Nhom_Hang = txtTenNhomHang.Text;
                    nh.Ghi_Chu = txtGhiChu.Text;
                    nh.IsDeleted = false;
                    nh.CreatedDate = DateTime.Now;

                    db.NHOM_HANGs.InsertOnSubmit(nh);
                }
                else
                {
                    var nh = (from n in db.NHOM_HANGs
                              where n.Ma_Nhom_Hang == txtMaNhomHang.Text
                              select n).FirstOrDefault();

                    nh.Ma_Nhom_Hang = txtMaNhomHang.Text;
                    nh.Ten_Nhom_Hang = txtTenNhomHang.Text;
                    nh.Ghi_Chu = txtGhiChu.Text;
                    nh.ModifiedDate = DateTime.Now;
                }

                db.SubmitChanges();
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
