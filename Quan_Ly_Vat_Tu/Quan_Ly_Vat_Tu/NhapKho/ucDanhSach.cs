using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quan_Ly_Vat_Tu.Bussiness;
using DevExpress.XtraGrid.Views.Grid;
using Quan_Ly_Vat_Tu.ThuChi;

namespace Quan_Ly_Vat_Tu.NhapKho
{
    public partial class ucDanhSach : UserControl
    {
        public ucDanhSach()
        {
            InitializeComponent();

            var tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var den = tu.AddMonths(1).AddDays(-1);

            txtTu.DateTime = tu;
            txtDen.DateTime = den;

            Nap_Hinh_Thuc_Cong_No();
            Nap_Hinh_Thuc_Thu_Chi();

            bbiXem_ItemClick(this, null);

            gbList.ShownEditor += (s, e) =>
                {
                    var view = s as GridView;
                    view.ActiveEditor.DoubleClick += ActiveEditor_DoubleClick;
                };
        }

        private void ActiveEditor_DoubleClick(object sender, EventArgs e)
        {
            bbiSua_ItemClick(this, null);
        }

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cHUNG_TU_Theo_NgayTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            cHUNG_TU_Theo_NgayTableAdapter.ClearBeforeFill = true;
            cHUNG_TU_Theo_NgayTableAdapter.Fill(dsNhapKho.CHUNG_TU_Theo_Ngay, txtTu.DateTime, txtDen.DateTime);

            gbList.BestFitColumns();
        }

        public void BestFit()
        {
            gbList.BestFitColumns();
        }

        public void Reload()
        {
            bbiXem_ItemClick(this, null);
        }

        void Set_Date(int month)
        {
            DateTime tu = new DateTime(DateTime.Now.Year, month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            txtTu.DateTime = tu;
            txtDen.DateTime = den;
        }

        private void bbiDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bbiXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            var db = new Data_QLKDataContext(SqlHelper.ConnectionString);

            int[] selectedRows = gbList.GetSelectedRows();
            string[] chungtu = new string[selectedRows.Length];
            for (int i = selectedRows.Length; i > 0; i--)
            {
                var arg = gbList.GetRowCellValue(selectedRows[i - 1], colMa_Chung_Tu);
                if (arg == null)
                    continue;
                chungtu[i - 1] = arg.ToString();
            }

            var ct = from c in db.CHUNG_TUs
                     where chungtu.Contains(c.Ma_Chung_Tu)
                     select c;


            foreach (var c in ct)
            {
                db.CHUNG_TUs.DeleteOnSubmit(c);
            }

            try
            {
                db.SubmitChanges();
                bbiXem_ItemClick(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTuyChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = cbTuyChon.SelectedItem.ToString();
            switch (item)
            {
                case "Tháng 1":
                    Set_Date(1);
                    break;
                case "Tháng 2":
                    Set_Date(2);
                    break;
                case "Tháng 3":
                    Set_Date(3);
                    break;
                case "Tháng 4":
                    Set_Date(4);
                    break;
                case "Tháng 5":
                    Set_Date(5);
                    break;
                case "Tháng 6":
                    Set_Date(6);
                    break;
                case "Tháng 7":
                    Set_Date(7);
                    break;
                case "Tháng 8":
                    Set_Date(8);
                    break;
                case "Tháng 9":
                    Set_Date(9);
                    break;
                case "Tháng 10":
                    Set_Date(10);
                    break;
                case "Tháng 12":
                    Set_Date(12);
                    break;
            }
        }

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void bbiSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var arg = gbList.GetFocusedRowCellValue(colMa_Chung_Tu);
            if (arg == null)
                return;

            var frm = new frmNhapKho(arg.ToString());
            frm.Reload += Reload;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        void Reload(object sender)
        {
            bbiXem_ItemClick(this, null);
        }

        private void bbiLapPhieuThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var machungtu = gbList.GetFocusedRowCellValue(colMa_Chung_Tu);
            if (machungtu == null)
                return;
            frmThuChi_Them_Sua frm = new frmThuChi_Them_Sua();
            frm.Lap_Phieu("Thu", machungtu.ToString());
            frm.Reload += (s) =>
            {
                bbiXem_ItemClick(this, null);
            };
            frm.ShowDialog();
        }

        private void bbiLapPhieuChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var machungtu = gbList.GetFocusedRowCellValue(colMa_Chung_Tu);
            if (machungtu == null)
                return;
            frmThuChi_Them_Sua frm = new frmThuChi_Them_Sua();
            frm.Lap_Phieu("Chi", machungtu.ToString());
            frm.Reload += (s) =>
            {
                bbiXem_ItemClick(this, null);
            };
            frm.ShowDialog();
        }

        private void Nap_Hinh_Thuc_Thu_Chi()
        {
            dsHinhThuc.Hinh_Thuc_Thu_Chi.Rows.Clear();

            dsHinhThuc.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("0", "Thu chi theo chứng từ", "Áp dụng cho khách lẻ quản lý công nợ theo chứng từ");
            dsHinhThuc.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("1", "Thu chi theo khách hàng", "Áp dụng cho quản lý công nợ theo khách hàng");
        }

        private void Nap_Hinh_Thuc_Cong_No()
        {
            dsHinhThuc.Hinh_Thuc_Cong_No.Rows.Clear();

            dsHinhThuc.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("0", "Khác", "Không quản lý công nợ chứng từ này");
            dsHinhThuc.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("1", "Tăng công nợ", "Tăng công nợ phải thu");
            dsHinhThuc.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("2", "Giảm công nợ", "Giảm công nợ phải thu");
        }
    }
}
