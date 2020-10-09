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
using DevExpress.XtraPrinting;
using System.IO;
using System.Diagnostics;

namespace Quan_Ly_Vat_Tu.DoanhThu
{
    public partial class ucTheoKhachHang : UserControl
    {
        public delegate void CloseEventHander(object sender);

        public event CloseEventHander Closed;
        private void RaiseCloseEventHander()
        {
            if (Closed != null)
            {
                Closed(this);
            }
        }

        public ucTheoKhachHang()
        {
            InitializeComponent();

            var tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var den = tu.AddMonths(1).AddDays(-1);

            txtTu.DateTime = tu;
            txtDen.DateTime = den;

            bbiXem_ItemClick(this, null);
        }

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string truy_van_sql =
            @"
                --DECLARE @FromDate DATETIME
                --DECLARE @ToDate DATETIME
                --
                --SET @FromDate = '1/1/2000'
                --SET @ToDate = '12/31/2017'

                SELECT Theo_Khach_Hang.Ma_Khach_Hang,
                       kh.Ten_Khach_Hang,
                       kh.Dia_Chi,
                       kh.Ma_Khu_Vuc,
                       kv.Ten_Khu_Vuc,
                       Theo_Khach_Hang.Thanh_Tien_Nhap,
                       Theo_Khach_Hang.Thanh_Tien_Xuat
                FROM   (
                           SELECT ct.Ma_Khach_Hang,
                                  SUM(
                                      CASE 
                                           WHEN ct.Loai_Chung_Tu = 1 THEN ct.Thanh_Tien
                                           ELSE 0
                                      END
                                  ) AS Thanh_Tien_Nhap,
                                  SUM(
                                      CASE 
                                           WHEN ct.Loai_Chung_Tu = 2 THEN ct.Thanh_Tien
                                           ELSE 0
                                      END
                                  ) AS Thanh_Tien_Xuat
                           FROM   CHUNG_TU ct
                           WHERE  DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                                  AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
                           GROUP BY
                                  ct.Ma_Khach_Hang
                       )Theo_Khach_Hang
                       LEFT OUTER JOIN KHACH_HANG kh
                            ON  kh.Ma_Khach_Hang = Theo_Khach_Hang.Ma_Khach_Hang
                       LEFT OUTER JOIN KHU_VUC kv
                            ON  kv.Ma_Khu_Vuc = kh.Ma_Khu_Vuc
            ";

            string[] myPara = { "@FromDate", "@ToDate" };
            object[] myValue = { txtTu.DateTime, txtDen.DateTime };

            var sqlHelper = new SqlHelper();

            dsDoanhThu.Theo_Khach_Hang_Theo_Ngay.Rows.Clear();
            dsDoanhThu.Theo_Khach_Hang_Theo_Ngay.Merge(sqlHelper.ExecuteDataTable(truy_van_sql, myPara, myValue));

            gbList.BestFitColumns();
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
