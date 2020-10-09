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
//using ConvertDB;

namespace Quan_Ly_Vat_Tu.KhuVuc
{
    public partial class frmKhuVuc_Them_Sua : Form
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
        long Id = 0;
        public frmKhuVuc_Them_Sua()
        {
            InitializeComponent();
            tinh_trang = "them";

            txtMaKhuVuc.Text = SqlHelper.GenCode("KHU_VUC", "Ma_Khu_Vuc", "KV", 1);
        }

        public frmKhuVuc_Them_Sua(long Id)
        {
            InitializeComponent();

            this.Id = Id;

            var kv = (from k in db.KHU_VUCs
                      where k.Id == Id //&& !k.IsDeleted.Value
                      select k).FirstOrDefault();
            if (kv == null)
            {
                MessageBox.Show(this, "Không tìm thấy khu vực này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtMaKhuVuc.Text = kv.Ma_Khu_Vuc;
            txtTenKhuVuc.Text = kv.Ten_Khu_Vuc;
            txtGhiChu.Text = kv.Ghi_Chu;

            tinh_trang = "sua";
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(txtMaKhuVuc.Text))
            {
                MessageBox.Show("Mã khu vực không được bỏ trống.");
                return false;
            }

            if (string.IsNullOrEmpty(txtTenKhuVuc.Text))
            {
                MessageBox.Show("Tên khu vực không được bỏ trống.");
                return false;
            }

            return true;
        }

        private void bbiLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Check())
            {
                return;
            }

            try
            {
                if (tinh_trang == "them")
                {
                    KHU_VUC kv = new KHU_VUC();
                    
                    kv.Ma_Khu_Vuc = txtMaKhuVuc.Text;
                    kv.Ten_Khu_Vuc = txtTenKhuVuc.Text;
                    kv.Ghi_Chu = txtGhiChu.Text;
                    kv.IsDeleted = false;
                    kv.CreatedDate = DateTime.Now;

                    db.KHU_VUCs.InsertOnSubmit(kv);
                }
                else
                {
                    var kv = (from k in db.KHU_VUCs
                              where k.Id == Id
                              select k).FirstOrDefault();

                    kv.Ma_Khu_Vuc = txtMaKhuVuc.Text;
                    kv.Ten_Khu_Vuc = txtTenKhuVuc.Text;
                    kv.Ghi_Chu = txtGhiChu.Text;
                    kv.ModifiedDate = DateTime.Now;
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

        private void bbiHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
