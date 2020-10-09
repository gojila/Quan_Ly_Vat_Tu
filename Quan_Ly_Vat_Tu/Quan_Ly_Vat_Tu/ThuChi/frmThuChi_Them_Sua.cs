using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quan_Ly_Vat_Tu.Bussiness;

namespace Quan_Ly_Vat_Tu.ThuChi
{
    public partial class frmThuChi_Them_Sua : Form
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

        public frmThuChi_Them_Sua()
        {
            InitializeComponent();
            tinh_trang = "them";
            Nap_Khach_Hang();
            Nap_Hinh_Thuc_Cong_No();
            Nap_Loa_Chung_Tu();
            txtMaChungTu.Text = SqlHelper.GenCode("THU_CHI", "Ma_Chung_Tu", "TT", 1);

            txtNgay.DateTime = DateTime.Now;
        }

        public frmThuChi_Them_Sua(string ma)
        {
            InitializeComponent();
            tinh_trang = "sua";
            Nap_Khach_Hang();
            Nap_Hinh_Thuc_Cong_No();
            Nap_Loa_Chung_Tu();

            var thuchi = (from tc in db.THU_CHIs
                          where tc.Ma_Chung_Tu == ma
                          select tc).FirstOrDefault();

            txtMaChungTu.Text = thuchi.Ma_Chung_Tu;
            txtNgay.DateTime = Convert.ToDateTime(thuchi.Ngay);
            txtKhachHang.EditValue = thuchi.Ma_Khach_Hang;
            txtDiaChi.Text = thuchi.Dia_Chi;
            txtSoTien.Value = thuchi.So_Tien ?? 0;
            txtLyDo.Text = thuchi.Ly_Do;
            txtChungTuBanHang.Text = thuchi.Chung_Tu_Ban_Hang;
            txtLoaiChungTu.EditValue = thuchi.Loai_Chung_Tu ?? 0;
            txtHinhThucCongNo.EditValue = thuchi.Hinh_Thuc_Cong_No ?? 0;
            txtGhiChu.Text = thuchi.Ghi_Chu;
        }

        public void Lap_Phieu(string loai)
        {
            if(loai == "Thu")
            {
                txtLoaiChungTu.EditValue = 3;
                txtHinhThucCongNo.EditValue = 2;
            }
            else if(loai == "Chi")
            {
                txtLoaiChungTu.EditValue = 4;
                txtHinhThucCongNo.EditValue = 1;
            }
        }

        public void Lap_Phieu(string loai, string machungtu)
        {
            var chung_tu = (from ct in db.CHUNG_TUs
                           where ct.Ma_Chung_Tu == machungtu
                           select ct).FirstOrDefault();
            if (chung_tu == null)
                return;

            var thu_chi_tang_giam_cong_no = 
                (
                from tc in db.THU_CHIs
                where tc.Chung_Tu_Ban_Hang == machungtu
                select tc.Hinh_Thuc_Cong_No == 1 ? tc.So_Tien : (tc.So_Tien * -1)
                ).Sum();

            txtKhachHang.EditValue = chung_tu.Ma_Khach_Hang;
            txtDiaChi.Text = chung_tu.Dia_Chi;
            txtChungTuBanHang.Text = chung_tu.Ma_Chung_Tu;
            txtSoTien.Value = Math.Abs(
                (chung_tu.Hinh_Thuc_Cong_No == 1 ? 
                (chung_tu.Thanh_Tien ?? 0) - (chung_tu.Thanh_Toan ?? 0) : 
                ((chung_tu.Thanh_Tien ?? 0) - (chung_tu.Thanh_Toan ?? 0)) * -1) + (thu_chi_tang_giam_cong_no ?? 0));

            if (loai == "Thu")
            {
                txtLoaiChungTu.EditValue = 3;
                txtHinhThucCongNo.EditValue = 2;
                txtLyDo.Text = "Thu tiền";
                
            }
            else if (loai == "Chi")
            {
                txtLoaiChungTu.EditValue = 4;
                txtHinhThucCongNo.EditValue = 1;
                txtLyDo.Text = "Chi tiền";
            }
        }

        public void Lap_Phieu_Tu_Dong(string machungtu)
        {
            string loai = "";

            var chung_tu = (from ct in db.CHUNG_TUs
                            where ct.Ma_Chung_Tu == machungtu
                            select ct).FirstOrDefault();
            if (chung_tu == null)
                return;

            var thu_chi_tang_giam_cong_no =
                (
                from tc in db.THU_CHIs
                where tc.Chung_Tu_Ban_Hang == machungtu
                select tc.Hinh_Thuc_Cong_No == 1 ? tc.So_Tien : (tc.So_Tien * -1)
                ).Sum();

            txtKhachHang.EditValue = chung_tu.Ma_Khach_Hang;
            txtDiaChi.Text = chung_tu.Dia_Chi;
            txtChungTuBanHang.Text = chung_tu.Ma_Chung_Tu;

            decimal so_tien = 0;
            so_tien = (chung_tu.Hinh_Thuc_Cong_No == 1 ?
                (chung_tu.Thanh_Tien ?? 0) - (chung_tu.Thanh_Toan ?? 0) :
                ((chung_tu.Thanh_Tien ?? 0) - (chung_tu.Thanh_Toan ?? 0)) * -1) + (thu_chi_tang_giam_cong_no ?? 0);
            
            loai = so_tien > 0 ? "Thu" : "Chi";
            
            txtSoTien.Value = Math.Abs(so_tien);

            //txtSoTien.Value = Math.Abs(
            //    (chung_tu.Hinh_Thuc_Cong_No == 1 ?
            //    (chung_tu.Thanh_Tien ?? 0) - (chung_tu.Thanh_Toan ?? 0) :
            //    ((chung_tu.Thanh_Tien ?? 0) - (chung_tu.Thanh_Toan ?? 0)) * -1) + (thu_chi_tang_giam_cong_no ?? 0));

            if (loai == "Thu")
            {
                txtLoaiChungTu.EditValue = 3;
                txtHinhThucCongNo.EditValue = 2;
                txtLyDo.Text = "Thu tiền";

            }
            else if (loai == "Chi")
            {
                txtLoaiChungTu.EditValue = 4;
                txtHinhThucCongNo.EditValue = 1;
                txtLyDo.Text = "Chi tiền";
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Kiem_Tra()
        {
            if (string.IsNullOrEmpty(txtKhachHang.Text) && txtHinhThucCongNo.EditValue.ToString() != "0")
            {
                MessageBox.Show("Chưa chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKhachHang.Focus();
                return false;
            }

            if (txtSoTien.Value == 0)
            {
                MessageBox.Show("Chưa nhập số tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTien.Focus();
                return false;
            }

            return true;
        }

        private void bbiDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Nap_Khach_Hang()
        {
            kHACH_HANGTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            kHACH_HANGTableAdapter.ClearBeforeFill = true;
            kHACH_HANGTableAdapter.Fill(dsKhachHang.KHACH_HANG);
        }

        private void txtKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKhachHang.Text))
            {
                DataRow _dataRow = txtKhachHang_View.GetFocusedDataRow();
                if (_dataRow != null)
                {
                    txtDiaChi.Text = _dataRow["Dia_Chi"].ToString();
                }
            }
        }

        private void bbiLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Kiem_Tra())
            {
                return;
            }

            try
            {
                if (tinh_trang == "them")
                {
                    THU_CHI thuchi = new THU_CHI();

                    thuchi.Ma_Chung_Tu = txtMaChungTu.Text;
                    thuchi.Ngay = txtNgay.DateTime;
                    thuchi.Ma_Khach_Hang = string.IsNullOrEmpty(txtKhachHang.Text) ? "" : txtKhachHang.EditValue.ToString();
                    thuchi.Ten_Khach_Hang = txtKhachHang.Text;
                    thuchi.Dia_Chi = txtDiaChi.Text;
                    thuchi.So_Tien = txtSoTien.Value;
                    thuchi.Ly_Do = txtLyDo.Text;
                    thuchi.Chung_Tu_Ban_Hang = txtChungTuBanHang.Text;
                    thuchi.Loai_Chung_Tu = Convert.ToInt32(txtLoaiChungTu.EditValue);
                    thuchi.Hinh_Thuc_Cong_No = Convert.ToInt32(txtHinhThucCongNo.EditValue);
                    thuchi.Ghi_Chu = txtGhiChu.Text;

                    db.THU_CHIs.InsertOnSubmit(thuchi);
                }
                else
                {
                    var thuchi = (from tc in db.THU_CHIs
                                  where tc.Ma_Chung_Tu == txtMaChungTu.Text
                                  select tc).FirstOrDefault();

                    thuchi.Ma_Chung_Tu = txtMaChungTu.Text;
                    thuchi.Ngay = txtNgay.DateTime;
                    thuchi.Ma_Khach_Hang = string.IsNullOrEmpty(txtKhachHang.Text) ? "" : txtKhachHang.EditValue.ToString();
                    thuchi.Ten_Khach_Hang = txtKhachHang.Text;
                    thuchi.Dia_Chi = txtDiaChi.Text;
                    thuchi.So_Tien = txtSoTien.Value;
                    thuchi.Ly_Do = txtLyDo.Text;
                    thuchi.Chung_Tu_Ban_Hang = txtChungTuBanHang.Text;
                    thuchi.Loai_Chung_Tu = Convert.ToInt32(txtLoaiChungTu.EditValue);
                    thuchi.Hinh_Thuc_Cong_No = Convert.ToInt32(txtHinhThucCongNo.EditValue);
                    thuchi.Ghi_Chu = txtGhiChu.Text;
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

        private void Nap_Hinh_Thuc_Cong_No()
        {
            dsThuChi.Hinh_Thuc_Cong_No.Rows.Clear();

            dsThuChi.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("0", "Khác", "Không tính vào báo cáo công nợ");
            dsThuChi.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("1", "Tăng công nợ", "Tăng công nợ phải thu");
            dsThuChi.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("2", "Giảm công nợ", "Giảm công nợ phải thu");
            //dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("2", "Giảm công nợ phải trả");
            //dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("3", "Tăng công nợ phải trả");


            txtHinhThucCongNo.EditValue = dsThuChi.Hinh_Thuc_Cong_No.Rows[0]["Ma"];
        }

        private void Nap_Loa_Chung_Tu()
        {
            dsThuChi.Loai_Chung_Tu.Rows.Clear();

            dsThuChi.Loai_Chung_Tu.AddLoai_Chung_TuRow("3", "Thu tiền", "Thu tiền");
            dsThuChi.Loai_Chung_Tu.AddLoai_Chung_TuRow("4", "Chi tiền", "Chi tiền");
            //dsThuChi.Loai_Chung_Tu.AddHinh_Thuc_Cong_NoRow("2", "Tăng công nợ", "Tăng công nợ phải thu");
            //dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("2", "Giảm công nợ phải trả");
            //dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("3", "Tăng công nợ phải trả");


            txtLoaiChungTu.EditValue = dsThuChi.Loai_Chung_Tu.Rows[0]["Ma"];
        }

        private void cbLoaiChungTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!txtMaChungTu.Properties.ReadOnly)
            {
                if(txtLoaiChungTu.EditValue.ToString() == "3")
                {
                    txtMaChungTu.Text = SqlHelper.GenCode("THU_CHI", "Ma_Chung_Tu", "TT", 1);
                }
                else
                {
                    txtMaChungTu.Text = SqlHelper.GenCode("THU_CHI", "Ma_Chung_Tu", "CT", 1);
                }
                

            }
        }
    }
}
