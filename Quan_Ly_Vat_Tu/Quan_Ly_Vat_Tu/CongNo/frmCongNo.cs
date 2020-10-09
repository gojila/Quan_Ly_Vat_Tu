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

namespace Quan_Ly_Vat_Tu.CongNo
{
    public partial class frmCongNo : Form
    {
        public frmCongNo()
        {
            InitializeComponent();

            DateTime tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;

            Nap_Loai_Chung_Tu();
            Nap_Hinh_Thuc_Thu_Chi();

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
            //tHU_CHI_Theo_NgayTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            //tHU_CHI_Theo_NgayTableAdapter.ClearBeforeFill = true;
            //tHU_CHI_Theo_NgayTableAdapter.Fill(dsThuChi.THU_CHI_Theo_Ngay, dtTu.DateTime, dtDen.DateTime);

            string truy_van_sql =
            @"
                --DECLARE @FromDate DATETIME
                --DECLARE @ToDate DATETIME
                --                
                --SET @FromDate = '1/1/2000'
                --SET @ToDate = '12/31/2016'

                SELECT BaoCaoCongNo.Ma_Khach_Hang,
                       kh.Ten_Khach_Hang,
                       kh.Dia_Chi,
                       kh.Ma_Khu_Vuc,
                       kv.Ten_Khu_Vuc,
                       SUM(
                           CASE 
                                WHEN DATEDIFF(DAY, @FromDate, BaoCaoCongNo.Ngay) < 0 THEN 
                                     BaoCaoCongNo.Cong_No
                                ELSE 0
                           END
                       ) AS Cong_No_Dau_Ky,
                       SUM(
                           CASE 
                                WHEN DATEDIFF(DAY, @FromDate, BaoCaoCongNo.Ngay) >= 0
                           AND DATEDIFF(DAY, @ToDate, BaoCaoCongNo.Ngay) <= 0 THEN BaoCaoCongNo.Tang_Cong_No 
                               ELSE 0 END
                       ) AS Tang_Trong_Ky,
                       SUM(
                           CASE 
                                WHEN DATEDIFF(DAY, @FromDate, BaoCaoCongNo.Ngay) >= 0
                           AND DATEDIFF(DAY, @ToDate, BaoCaoCongNo.Ngay) <= 0 THEN BaoCaoCongNo.Giam_Cong_No 
                               ELSE 0 END
                       ) AS Giam_Trong_Ky,
                       SUM(
                           CASE 
                                WHEN DATEDIFF(DAY, @ToDate, BaoCaoCongNo.Ngay) <= 0 THEN BaoCaoCongNo.Cong_No
                                ELSE 0
                           END
                       ) AS Cong_No_Cuoi_Ky
                FROM   (
                           SELECT ct.Ma_Khach_Hang,
                                  ct.Ngay,
                                  CASE 
                                       WHEN ct.Hinh_Thuc_Cong_No = 1 THEN ct.Thanh_Tien
                                       WHEN ct.Hinh_Thuc_Cong_No = 2 THEN ct.Thanh_Toan
                                       ELSE 0
                                  END AS Tang_Cong_No,
                                  CASE 
                                       WHEN ct.Hinh_Thuc_Cong_No = 2 THEN ct.Thanh_Tien
                                       WHEN ct.Hinh_Thuc_Cong_No = 1 THEN ct.Thanh_Toan
                                       ELSE 0
                                  END AS Giam_Cong_No,
                                  CASE 
                                       WHEN ct.Hinh_Thuc_Cong_No = 1 THEN (ct.Thanh_Tien - ct.Thanh_Toan)
                                       WHEN ct.Hinh_Thuc_Cong_No = 2 THEN ((ct.Thanh_Tien - ct.Thanh_Toan) * -1)
                                       ELSE 0
                                  END AS Cong_No
                           FROM   CHUNG_TU ct
                           WHERE  ct.Hinh_Thuc_Thu_Chi = 1
                                  --AND DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                                  AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
           
                           UNION ALL
           
                           SELECT tc.Ma_Khach_Hang,
                                  tc.Ngay,
                                  CASE 
                                       WHEN tc.Hinh_Thuc_Cong_No = 1 THEN (tc.So_Tien)
                                       ELSE 0
                                  END AS Tang_Cong_No,
                                  CASE 
                                       WHEN tc.Hinh_Thuc_Cong_No = 2 THEN (tc.So_Tien)
                                       ELSE 0
                                  END AS Giam_Cong_No,
                                  CASE 
                                       WHEN tc.Hinh_Thuc_Cong_No = 2 THEN (tc.So_Tien * -1)
                                       WHEN tc.Hinh_Thuc_Cong_No = 1 THEN (tc.So_Tien)
                                       ELSE 0
                                  END AS Cong_No
                           FROM   THU_CHI tc
                           WHERE  tc.Hinh_Thuc_Cong_No != 0
                                  --AND DATEDIFF(DAY, @FromDate, tc.Ngay) >= 0
                                  AND DATEDIFF(DAY, @ToDate, tc.Ngay) <= 0
                       )BaoCaoCongNo
                       LEFT OUTER JOIN KHACH_HANG kh
                            ON  kh.Ma_Khach_Hang = BaoCaoCongNo.Ma_Khach_Hang
                       LEFT OUTER JOIN KHU_VUC kv
                            ON  kv.Ma_Khu_Vuc = kh.Ma_Khu_Vuc
                GROUP BY
                       BaoCaoCongNo.Ma_Khach_Hang,
                       kh.Ten_Khach_Hang,
                       kh.Dia_Chi,
                       kh.Ma_Khu_Vuc,
                       kv.Ten_Khu_Vuc
            ";

            string[] myPara = { "@FromDate", "@ToDate" };
            object[] myValue = { dtTu.DateTime, dtDen.DateTime };
            
            var sqlHelper = new SqlHelper();
            dsCongNo.Cong_No_Theo_Ngay.Rows.Clear();

            dsCongNo.Cong_No_Theo_Ngay.Merge(sqlHelper.ExecuteDataTable(truy_van_sql, myPara, myValue));
            
            gbList.BestFitColumns();
        }

        private void bbiThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmThuChi_Them_Sua frm = new frmThuChi_Them_Sua();
            //frm.Reload += (s) => 
            //{
            //    bbiXem_ItemClick(this, null);
            //};
            //frm.ShowDialog();
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
            //var ma = gbList.GetFocusedRowCellValue(colMa_Chung_Tu);
            //if (ma == null)
            //    return;
            //frmThuChi_Them_Sua frm = new frmThuChi_Them_Sua(ma.ToString());
            //frm.Reload += (s) =>
            //{
            //    bbiXem_ItemClick(this, null);
            //};
            //frm.ShowDialog();
        }

        private void bbiXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (MessageBox.Show("Có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //    return;

            //var db = new Data_QLKDataContext(SqlHelper.ConnectionString);
            //var ma = gbList.GetFocusedRowCellValue(colMa_Chung_Tu);
            //if (ma == null)
            //    return;

            //int[] selectedRows = gbList.GetSelectedRows();
            //string[] thuchi = new string[selectedRows.Length];
            //for (int i = selectedRows.Length; i > 0; i--)
            //{
            //    var arg = gbList.GetRowCellValue(selectedRows[i - 1], colMa_Chung_Tu);
            //    if (arg == null)
            //        continue;
            //    thuchi[i - 1] = arg.ToString();
            //}

            //var tc = from tc_ in db.THU_CHIs
            //         //where k.Ma_Khu_Vuc == ma.ToString()
            //         where thuchi.Contains(tc_.Ma_Chung_Tu)
            //         select tc_;


            //foreach (var t in tc)
            //{
            //    db.THU_CHIs.DeleteOnSubmit(t);
            //}

            //try
            //{
            //    db.SubmitChanges();
            //    bbiXem_ItemClick(this, null);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Nap_Loai_Chung_Tu()
        {
            //dsThuChi.Loai_Chung_Tu.Rows.Clear();

            //dsThuChi.Loai_Chung_Tu.AddLoai_Chung_TuRow("0", "Thu tiền");
            //dsThuChi.Loai_Chung_Tu.AddLoai_Chung_TuRow("1", "Chi tiền");
        }

        private void Nap_Hinh_Thuc_Thu_Chi()
        {
            //dsThuChi.Hinh_Thuc_Thu_Chi.Rows.Clear();

            //dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("0", "Giảm công nợ (công nợ phải thu)");
            //dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("1", "Tăng công nợ (công nợ phải thu)");
            ////dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("2", "Giảm công nợ phải trả");
            ////dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("3", "Tăng công nợ phải trả");
            //dsThuChi.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("4", "Khác (không tính vào báo cáo công nợ)");
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
    }
}
