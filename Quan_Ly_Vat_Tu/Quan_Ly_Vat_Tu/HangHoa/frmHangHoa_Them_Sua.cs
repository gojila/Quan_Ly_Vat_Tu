using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quan_Ly_Vat_Tu.Bussiness;
using System.IO;
using Newtonsoft.Json;

namespace Quan_Ly_Vat_Tu.HangHoa
{
    public partial class frmHangHoa_Them_Sua : Form
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

        public delegate void SendDataEventHander(object sender, HANG_HOA hangHoa);

        public event SendDataEventHander SendData;
        private void RaiseSendDataEventHander(HANG_HOA hangHoa)
        {
            if (SendData != null)
            {
                SendData(this, hangHoa);
            }
        }

        Data_QLKDataContext db = new Data_QLKDataContext(SqlHelper.ConnectionString);
        string tinh_trang = "them";
        long Id;
        public frmHangHoa_Them_Sua()
        {
            InitializeComponent();
            Nhom_Hang();
            tinh_trang = "them";

            txtMaHangHoa.Text = SqlHelper.GenCode("HANG_HOA", "Ma_Hang", "HH", 5);
        }

        public frmHangHoa_Them_Sua(long Id)
        {
            InitializeComponent();
            this.Id = Id;
            Nhom_Hang();
            tinh_trang = "sua";

            var hh = (from h in db.HANG_HOAs
                      where h.Id == Id
                      select h).FirstOrDefault();

            txtMaHangHoa.Text = hh.Ma_Hang;
            txtTenHangHoa.Text = hh.Ten_Hang;
            txtNhomHang.EditValue = hh.Nhom_Hang_Id;
            txtDonVi.Text = hh.Don_Vi;
            txtGhiChu.Text = hh.Ghi_Chu;
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(txtMaHangHoa.Text))
            {
                MessageBox.Show(this, "Mã hàng không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtTenHangHoa.Text))
            {
                MessageBox.Show(this, "Tên hàng không được bỏ trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        void Nhom_Hang()
        {
            try 
            {
                nHOM_HANGTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                nHOM_HANGTableAdapter.ClearBeforeFill = true;
                nHOM_HANGTableAdapter.Fill(dsHangHoa.NHOM_HANG);
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
                    HANG_HOA hh = new HANG_HOA();
                    
                    hh.Ma_Hang = txtMaHangHoa.Text;
                    hh.Ten_Hang = txtTenHangHoa.Text;
                    hh.Nhom_Hang_Id = string.IsNullOrEmpty(txtNhomHang.Text) ? 0 : Convert.ToInt64(txtNhomHang.EditValue);
                    hh.Don_Vi = txtDonVi.Text;
                    hh.Ghi_Chu = txtGhiChu.Text;

                    hh.IsDeleted = false;
                    hh.CreatedDate = DateTime.Now;

                    db.HANG_HOAs.InsertOnSubmit(hh);
                    db.SubmitChanges();
                    RaiseSendDataEventHander(hh);
                }
                else
                {
                    var hh = (from h in db.HANG_HOAs
                              where h.Id == this.Id
                              select h).FirstOrDefault();

                    hh.Ma_Hang = txtMaHangHoa.Text;
                    hh.Ten_Hang = txtTenHangHoa.Text;
                    hh.Nhom_Hang_Id = string.IsNullOrEmpty(txtNhomHang.Text) ? 0 : Convert.ToInt64(txtNhomHang.EditValue);
                    hh.Don_Vi = txtDonVi.Text;
                    hh.Ghi_Chu = txtGhiChu.Text;

                    hh.ModifiedDate = DateTime.Now;

                    db.SubmitChanges();
                    RaiseSendDataEventHander(hh);
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
