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
//using System.Data.Linq;
using Quan_Ly_Vat_Tu.Bussiness;

namespace Quan_Ly_Vat_Tu.CuaHang
{
    public partial class frmCuaHang_Them_Sua : Form
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

        public frmCuaHang_Them_Sua()
        {
            InitializeComponent();
            tinh_trang = "them";

            txtMaCuaHang.Text = SqlHelper.GenCode("CUA_HANG", "Ma_Cua_Hang", "CH", 1);
        }

        public frmCuaHang_Them_Sua(string ma)
        {
            InitializeComponent();
            tinh_trang = "sua";

            var cuahang = (from ch in db.CUA_HANGs
                           where ch.Ma_Cua_Hang == ma
                           select ch).FirstOrDefault();

            txtMaCuaHang.Text = cuahang.Ma_Cua_Hang;
            txtTenCuaHang.Text = cuahang.Ten_Cua_Hang;
            txtDiaChi.Text = cuahang.Dia_Chi;
            txtMaSoThue.Text = cuahang.Ma_So_Thue;
            txtDienThoai.Text = cuahang.Dien_Thoai;
            txtEmail.Text = cuahang.Email;
            txtFax.Text = cuahang.Fax;
            txtDiDong.Text = cuahang.Di_Dong;
            txtQuanLy.Text = cuahang.Quan_Ly;
            txtGhiChu.Text = cuahang.Ghi_Chu;

            if(cuahang.Anh != null)
            {
                byte[] imageBytes = cuahang.Anh.ToArray();
                if (imageBytes != null)
                {
                    var ms = new MemoryStream(imageBytes);
                    var image = Image.FromStream(ms);
                    picAnh.Image = (Image)image.Clone();
                }
            }

            //picAnh.Image = (Image)cuahang.Anh.ToArray();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                return;
            }

            try
            {
                if (tinh_trang == "them")
                {
                    CUA_HANG cuahang = new CUA_HANG();

                    cuahang.Ma_Cua_Hang = txtMaCuaHang.Text;
                    cuahang.Ten_Cua_Hang = txtTenCuaHang.Text;
                    cuahang.Dia_Chi = txtDiaChi.Text;
                    cuahang.Ma_So_Thue = txtMaSoThue.Text;
                    cuahang.Dien_Thoai = txtDienThoai.Text;
                    cuahang.Email = txtEmail.Text;
                    cuahang.Fax = txtFax.Text;
                    cuahang.Di_Dong = txtDiDong.Text;
                    cuahang.Quan_Ly = txtQuanLy.Text;
                    cuahang.Ghi_Chu = txtGhiChu.Text;

                    if (picAnh.Image != null)
                    {
                        Image anh = picAnh.Image;
                        MemoryStream ms = new MemoryStream();
                        anh.Save(ms, anh.RawFormat);
                        byte[] anh_Bytes = ms.GetBuffer();
                        ms.Close();

                        cuahang.Anh = anh_Bytes;
                    }

                    db.CUA_HANGs.InsertOnSubmit(cuahang);
                }
                else
                {
                    var cuahang = (from ch in db.CUA_HANGs
                                    where ch.Ma_Cua_Hang == txtMaCuaHang.Text
                                    select ch).FirstOrDefault();

                    cuahang.Ma_Cua_Hang = txtMaCuaHang.Text;
                    cuahang.Ten_Cua_Hang = txtTenCuaHang.Text;
                    cuahang.Dia_Chi = txtDiaChi.Text;
                    cuahang.Ma_So_Thue = txtMaSoThue.Text;
                    cuahang.Dien_Thoai = txtDienThoai.Text;
                    cuahang.Email = txtEmail.Text;
                    cuahang.Fax = txtFax.Text;
                    cuahang.Di_Dong = txtDiDong.Text;
                    cuahang.Quan_Ly = txtQuanLy.Text;
                    cuahang.Ghi_Chu = txtGhiChu.Text;

                    if (picAnh.Image != null)
                    {
                        Image anh = picAnh.Image;
                        MemoryStream ms = new MemoryStream();
                        anh.Save(ms, anh.RawFormat);
                        byte[] anh_Bytes = ms.GetBuffer();
                        ms.Close();

                        cuahang.Anh = anh_Bytes;
                    }
                    else 
                    {
                        cuahang.Anh = null;
                    }
                }

                db.SubmitChanges();
                RaiseReloadEventHander();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(txtMaCuaHang.Text))
            {
                MessageBox.Show("Mã cửa hàng không được bỏ trống.");
                return false;
            }

            if (string.IsNullOrEmpty(txtTenCuaHang.Text))
            {
                MessageBox.Show("Tên cửa hàng không được bỏ trống.");
                return false;
            }

            return true;
        }
    }
}
