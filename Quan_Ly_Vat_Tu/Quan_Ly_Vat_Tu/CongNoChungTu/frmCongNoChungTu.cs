using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Quan_Ly_Vat_Tu.Bussiness;
using Quan_Ly_Vat_Tu.ThuChi;
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

namespace Quan_Ly_Vat_Tu.CongNoChungTu
{
    public partial class frmCongNoChungTu : Form
    {
        public frmCongNoChungTu()
        {
            InitializeComponent();

            DateTime tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;

            Nap_Hinh_Thuc_Cong_No();
            Nap_Loai_Chung_Tu();

            bbiXem_ItemClick(this, null);

            gbList.ShownEditor += (s, e) => 
            {
                var view = s as GridView;
                view.ActiveEditor.DoubleClick += (s_, e_) => 
                {
                    var machungtu = gbList.GetFocusedRowCellValue(colMa_Chung_Tu);
                    if (machungtu == null)
                        return;

                    frmThuChi_Them_Sua frm = new frmThuChi_Them_Sua();
                    frm.Lap_Phieu_Tu_Dong(machungtu.ToString());
                    frm.Reload += (s__) =>
                    {
                        bbiXem_ItemClick(this, null);
                    };
                    frm.ShowDialog();
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

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
//            string truy_van_sql =
//            @"
//                
//            ";

//            string[] myPara = { "@FromDate","@ToDate" };
//            object[] myValue = { dtTu.DateTime, dtDen.DateTime };

//            dsCongNoChungTu.Cong_No_Chung_Tu.Rows.Clear();
//            var sqlHelper = new SqlHelper();
//            dsCongNoChungTu.Cong_No_Chung_Tu.Merge(sqlHelper.ExecuteDataTable(truy_van_sql, myPara, myValue));

            cong_No_Chung_TuTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            cong_No_Chung_TuTableAdapter.ClearBeforeFill = true;
            cong_No_Chung_TuTableAdapter.Fill(dsCongNoChungTu.Cong_No_Chung_Tu, cbTatCa.Checked);

            gbList.BestFitColumns();
        }

        private void Nap_Hinh_Thuc_Cong_No()
        {
            dsHinhThuc.Hinh_Thuc_Cong_No.Rows.Clear();

            dsHinhThuc.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("1", "Tăng công nợ", "Tăng công nợ phải thu");
            dsHinhThuc.Hinh_Thuc_Cong_No.AddHinh_Thuc_Cong_NoRow("2", "Giảm công nợ", "Giảm công nợ phải thu");
        }

        private void Nap_Loai_Chung_Tu()
        {
            dsHinhThuc.Loai_Chung_Tu.Rows.Clear();

            dsHinhThuc.Loai_Chung_Tu.AddLoai_Chung_TuRow("1", "Nhập hàng", "Nhập hàng");
            dsHinhThuc.Loai_Chung_Tu.AddLoai_Chung_TuRow("2", "Xuất hàng", "Xuất hàng");
            dsHinhThuc.Loai_Chung_Tu.AddLoai_Chung_TuRow("3", "Thu tiền", "Thu tiền");
            dsHinhThuc.Loai_Chung_Tu.AddLoai_Chung_TuRow("4", "Chi tiền", "Chi tiền");
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

        private void cbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            bbiXem_ItemClick(this, null);
        }
    }
}
