using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Quan_Ly_Vat_Tu.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Vat_Tu.ThuChi
{
    public partial class frmThuChi : Form
    {
        public frmThuChi()
        {
            InitializeComponent();

            DateTime tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;

            Nap_Loai_Chung_Tu();
            Nap_Hinh_Thuc_Cong_No();

            bbiXem_ItemClick(this, null);

            gbList.ShownEditor += (s, e) => 
            {
                var view = s as GridView;
                view.ActiveEditor.DoubleClick += (s_, e_) => 
                {
                    bbiSua_ItemClick(this, null);
                };
            };
        }

        void Set_Date(int month)
        {
            DateTime tu = new DateTime(DateTime.Now.Year, month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;
        }

        private void cbChonNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = cbChonNgay.SelectedItem.ToString();
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

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tHU_CHI_Theo_NgayTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            tHU_CHI_Theo_NgayTableAdapter.ClearBeforeFill = true;
            tHU_CHI_Theo_NgayTableAdapter.Fill(dsThuChi.THU_CHI_Theo_Ngay, dtTu.DateTime, dtDen.DateTime);
            
            gbList.BestFitColumns();
        }

        private void bbiThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThuChi_Them_Sua frm = new frmThuChi_Them_Sua();
            frm.Reload += (s) => 
            {
                bbiXem_ItemClick(this, null);
            };
            frm.ShowDialog();
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
            var ma = gbList.GetFocusedRowCellValue(colMa_Chung_Tu);
            if (ma == null)
                return;
            frmThuChi_Them_Sua frm = new frmThuChi_Them_Sua(ma.ToString());
            frm.Reload += (s) =>
            {
                bbiXem_ItemClick(this, null);
            };
            frm.ShowDialog();
        }

        private void bbiXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            var db = new Data_QLKDataContext(SqlHelper.ConnectionString);
            var ma = gbList.GetFocusedRowCellValue(colMa_Chung_Tu);
            if (ma == null)
                return;

            int[] selectedRows = gbList.GetSelectedRows();
            string[] thuchi = new string[selectedRows.Length];
            for (int i = selectedRows.Length; i > 0; i--)
            {
                var arg = gbList.GetRowCellValue(selectedRows[i - 1], colMa_Chung_Tu);
                if (arg == null)
                    continue;
                thuchi[i - 1] = arg.ToString();
            }

            var tc = from tc_ in db.THU_CHIs
                     //where k.Ma_Khu_Vuc == ma.ToString()
                     where thuchi.Contains(tc_.Ma_Chung_Tu)
                     select tc_;


            foreach (var t in tc)
            {
                db.THU_CHIs.DeleteOnSubmit(t);
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

        private void Nap_Loai_Chung_Tu()
        {
            dsThuChi.Loai_Chung_Tu.Rows.Clear();

            dsThuChi.Loai_Chung_Tu.AddLoai_Chung_TuRow("3", "Thu tiền", "");
            dsThuChi.Loai_Chung_Tu.AddLoai_Chung_TuRow("4", "Chi tiền", "");
        }

        private void Nap_Hinh_Thuc_Cong_No()
        {
            dsThuChi.Hinh_Thuc_Cong_No.Rows.Clear();

            dsThuChi.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("0", "Khác", "Không tính vào báo cáo công nợ");
            dsThuChi.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("1", "Tăng công nợ", "Tăng công nợ phải thu");
            dsThuChi.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("2", "Giảm công nợ","Giảm công nợ phải thu)");
            //dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("2", "Giảm công nợ phải trả");
            //dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("3", "Tăng công nợ phải trả");
            
        }

        private void bbiXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = "";
            SaveFileDialog dialog1 = new SaveFileDialog();
            dialog1.Filter = "Excel Files (*.xls)|*.xls|All Files (*.*)|*.*";
            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                path = dialog1.FileName;
                gcList.ExportToXls(path, new DevExpress.XtraPrinting.XlsExportOptions(TextExportMode.Text, true, true));

                if (File.Exists(dialog1.FileName))
                {
                    if (MessageBox.Show("Bạn muốn mở không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                    Process.Start(dialog1.FileName);
                }
            }
        }

        private void bbiLapPhieuThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThuChi_Them_Sua frm = new frmThuChi_Them_Sua();
            frm.Lap_Phieu("Thu");
            frm.Reload += (s) =>
            {
                bbiXem_ItemClick(this, null);
            };
            frm.ShowDialog();
        }

        private void bbiLapPhieuChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThuChi_Them_Sua frm = new frmThuChi_Them_Sua();
            frm.Lap_Phieu("Chi");
            frm.Reload += (s) =>
            {
                bbiXem_ItemClick(this, null);
            };
            frm.ShowDialog();
        }
    }
}
