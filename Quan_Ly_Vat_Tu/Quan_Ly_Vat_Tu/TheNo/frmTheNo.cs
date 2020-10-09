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

namespace Quan_Ly_Vat_Tu.TheNo
{
    public partial class frmTheNo : Form
    {
        public frmTheNo()
        {
            InitializeComponent();

            DateTime tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;

            Nap_Hinh_Thuc_Cong_No();
            Nap_Loai_Chung_Tu();

            bbiXem_ItemClick(this, null);
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
            string truy_van_sql =
            @"
                --DECLARE @FromDate DATETIME
                --DECLARE @ToDate DATETIME
                --                
                --SET @FromDate = '8/1/2015'
                --SET @ToDate = '8/31/2015'

                DECLARE @TheNo_TB TABLE (
                            Ma_Khach_Hang VARCHAR(250) NULL,
                            Ma_Chung_Tu VARCHAR(250) NULL,
                            Ngay DATETIME NULL,
                            Loai_Chung_Tu INT NULL,
                            Hinh_Thuc_Cong_No INT NULL,
                            Thanh_Tien MONEY NULL,
                            Thanh_Toan MONEY NULL,
                            Cong_No MONEY NULL,
                            Cong_No_Con_Lai MONEY NULL,
                            Ghi_Chu NVARCHAR(250) NULL
                        )


                DECLARE @getTheNo CURSOR                   
                SET @getTheNo =                    CURSOR FOR
                SELECT *
                FROM   (
                           SELECT ct.Ma_Khach_Hang,
                                  ct.Ma_Chung_Tu,
                                  ct.Ngay,
                                  ct.Hinh_Thuc_Cong_No,
                                  ct.Loai_Chung_Tu,
                                  ct.Thanh_Tien,
                                  ct.Thanh_Toan,
                                  CASE 
                                       WHEN ct.Hinh_Thuc_Cong_No = 1 THEN (ct.Thanh_Tien - ct.Thanh_Toan)
                                       WHEN ct.Hinh_Thuc_Cong_No = 2 THEN ((ct.Thanh_Tien - ct.Thanh_Toan) * -1)
                                  END AS Cong_No,
                                  ct.Ghi_Chu
                           FROM   CHUNG_TU ct
                           WHERE  DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                                  AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
                                  AND ct.Hinh_Thuc_Cong_No != 0
                                  AND ct.Hinh_Thuc_Thu_Chi != 0
                           UNION ALL
                           SELECT tc.Ma_Khach_Hang,
                                  tc.Ma_Chung_Tu,
                                  tc.Ngay,
                                  tc.Hinh_Thuc_Cong_No,
                                  tc.Loai_Chung_Tu,
                                  tc.So_Tien,
                                  CAST(NULL AS MONEY),
                                  CASE 
                                       WHEN tc.Hinh_Thuc_Cong_No = 1 THEN (tc.So_Tien)
                                       WHEN tc.Hinh_Thuc_Cong_No = 2 THEN (tc.So_Tien * -1)
                                  END AS Cong_No,
                                  tc.Ghi_Chu
                           FROM   THU_CHI tc
                           WHERE  DATEDIFF(DAY, @FromDate, tc.Ngay) >= 0
                                  AND DATEDIFF(DAY, @ToDate, tc.Ngay) <= 0
                                  AND tc.Hinh_Thuc_Cong_No != 0
           
                           UNION ALL
                           SELECT No_Dau_Ky.Ma_Khach_Hang,
                                  '',
                                  CAST(NULL AS DATETIME),
                                  CAST(NULL AS INT),
                                  CAST(NULL AS INT),
                                  CAST(0 AS MONEY),
                                  CAST(NULL AS MONEY),
                                  SUM(
                                      CASE 
                                           WHEN No_Dau_Ky.Hinh_Thuc_Cong_No = 1 THEN No_Dau_Ky.Tien_Cong_No
                                           ELSE (No_Dau_Ky.Tien_Cong_No * -1)
                                      END
                                  ) AS Cong_No,
                                  N'Công nợ đầu kỳ'
                           FROM   (
                                      SELECT ct.Ma_Khach_Hang,
                                             ct.Hinh_Thuc_Cong_No,
                                             (ct.Thanh_Tien - ct.Thanh_Toan) AS Tien_Cong_No
                                      FROM   CHUNG_TU ct
                                      WHERE  DATEDIFF(DAY, @FromDate, ct.Ngay) < 0
                                             AND ct.Hinh_Thuc_Cong_No != 0
                                             AND ct.Hinh_Thuc_Thu_Chi != 0
                                      UNION ALL
                                      SELECT tc.Ma_Khach_Hang,
                                             tc.Hinh_Thuc_Cong_No,
                                             tc.So_Tien AS Tien_Cong_No
                                      FROM   THU_CHI tc
                                      WHERE  DATEDIFF(DAY, @FromDate, tc.Ngay) < 0
                                             AND tc.Hinh_Thuc_Cong_No != 0
                                  )No_Dau_Ky
                           GROUP BY
                                  No_Dau_Ky.Ma_Khach_Hang
                       )The_No
                ORDER BY
                       The_No.Ma_Khach_Hang,
                       The_No.Ngay
       
       
                DECLARE @Ma_Khach_Hang VARCHAR(250)
                DECLARE @Ma_Chung_Tu VARCHAR(250)
                DECLARE @Ngay DATETIME
                DECLARE @Hinh_Thuc_Cong_No INT
                DECLARE @Loai_Chung_Tu INT
                DECLARE @Thanh_Tien MONEY
                DECLARE @Thanh_Toan MONEY
                DECLARE @Cong_No MONEY
                DECLARE @Ghi_Chu NVARCHAR(250)

                DECLARE @Cong_No_Con_Lai MONEY
                DECLARE @Ma_Khach_Hang_Tam VARCHAR(250)

                SET @Cong_No_Con_Lai = 0
                SET @Ma_Khach_Hang_Tam = ''
       
                                        OPEN @getTheno
                                                FETCH NEXT
                                                FROM @getTheNo INTO @Ma_Khach_Hang, @Ma_Chung_Tu, 
                @Ngay,
                                                                    @Hinh_Thuc_Cong_No, @Loai_Chung_Tu,
                                                                    @Thanh_Tien, @Thanh_Toan, @Cong_No, 
                @Ghi_Chu
                WHILE @@FETCH_STATUS = 0
                BEGIN
                    PRINT @Ma_Khach_Hang
    
                    IF (@Ma_Khach_Hang != @Ma_Khach_Hang_Tam)
                    BEGIN
                        SET @Cong_No_Con_Lai = @Cong_No
                    END
                    ELSE
                    BEGIN
                        SET @Cong_No_Con_Lai = @Cong_No_Con_Lai + @Cong_No
                    END
    
                    INSERT INTO @TheNo_TB
                      (
                        Ma_Khach_Hang,
                        Ma_Chung_Tu,
                        Ngay,
                        Loai_Chung_Tu,
                        Hinh_Thuc_Cong_No,
                        Thanh_Tien,
                        Thanh_Toan,
                        Cong_No,
                        Cong_No_Con_Lai,
                        Ghi_Chu
                      )
                    VALUES
                      (
                        @Ma_Khach_Hang,
                        @Ma_Chung_Tu,
                        @Ngay,
                        @Loai_Chung_Tu,
                        @Hinh_Thuc_Cong_No,
                        @Thanh_Tien,
                        @Thanh_Toan,
                        @Cong_No,
                        @Cong_No_Con_Lai,
                        @Ghi_Chu
                      )
    
                    SET @Ma_Khach_Hang_Tam = @Ma_Khach_Hang
    
                    FETCH NEXT
                    FROM @getTheNo INTO @Ma_Khach_Hang, @Ma_Chung_Tu, @Ngay,
                    @Hinh_Thuc_Cong_No, @Loai_Chung_Tu,
                    @Thanh_Tien, @Thanh_Toan, @Cong_No, @Ghi_Chu
                END
                                                CLOSE @getTheNo
                                                DEALLOCATE @getTheNo
                
                SELECT tnt.*,
                       kh.Ten_Khach_Hang,
                       kh.Dia_Chi,
                       CASE 
                            WHEN tnt.Hinh_Thuc_Cong_No = 1 THEN tnt.Thanh_Tien
                            WHEN tnt.Loai_Chung_Tu = 1 AND tnt.Thanh_Toan != 0 THEN tnt.Thanh_Toan
                       END AS Tang_Cong_No,
                       CASE 
                            WHEN tnt.Hinh_Thuc_Cong_No = 2 THEN tnt.Thanh_Tien
                            WHEN tnt.Loai_Chung_Tu = 2 AND tnt.Thanh_Toan != 0 THEN tnt.Thanh_Toan
                       END AS Giam_Cong_No,
                       CASE 
                            WHEN tnt.Loai_Chung_Tu = 1 THEN tnt.Thanh_Tien
                       END AS So_Tien_Nhap_Hang,
                       CASE 
                            WHEN tnt.Loai_Chung_Tu = 2 THEN tnt.Thanh_Tien
                       END AS So_Tien_Xuat_Hang,
                       CASE 
                            WHEN tnt.Loai_Chung_Tu = 3 THEN tnt.Thanh_Tien
                            WHEN tnt.Loai_Chung_Tu = 2 AND tnt.Thanh_Toan != 0 THEN tnt.Thanh_Toan
                       END AS So_Tien_Thu,
                       CASE 
                            WHEN tnt.Loai_Chung_Tu = 4 THEN tnt.Thanh_Tien
                            WHEN tnt.Loai_Chung_Tu = 1 AND tnt.Thanh_Toan != 0 THEN tnt.Thanh_Toan
                       END AS So_Tien_Chi
                FROM   @TheNo_TB tnt
                       LEFT OUTER JOIN KHACH_HANG kh
                            ON  kh.Ma_Khach_Hang = tnt.Ma_Khach_Hang
            ";

            string[] myPara = { "@FromDate","@ToDate" };
            object[] myValue = { dtTu.DateTime, dtDen.DateTime };

            dsTheNo.The_No_Theo_Ngay.Rows.Clear();
            var sqlHelper = new SqlHelper();
            dsTheNo.The_No_Theo_Ngay.Merge(sqlHelper.ExecuteDataTable(truy_van_sql, myPara, myValue));

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
    }
}
