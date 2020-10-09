using Newtonsoft.Json;
using Quan_Ly_Vat_Tu.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Vat_Tu
{
    public partial class frmTheKho : Form
    {
        public frmTheKho()
        {
            InitializeComponent();

            DateTime tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;

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
            try
            {
                string sql =
            @"
                
--DECLARE @FromDate DATETIME
--DECLARE @ToDate DATETIME
                
--SET @FromDate = '1/1/2000'
--SET @ToDate = '12/31/2026'

DECLARE @TheKho_TB TABLE (
            Ma_Chung_Tu VARCHAR(250) NULL,
            Ngay DATETIME NULL,
            Ngay_Sap_Xep DATETIME NULL,
            Ma_Hoa_Don VARCHAR(250) NULL,
            Hang_Hoa_Id BIGINT NULL,
            Kho_Hang_Id BIGINT NULL,
            Serial_No NVARCHAR(250) NULL,
            Lo_Vat_Tu NVARCHAR(250) NULL,
            Loai_Chung_Tu INT NULL,
            Dien_Giai NVARCHAR(250) NULL,
            So_Luong_Nhap MONEY NULL,
            So_Luong_Xuat MONEY NULL,
            So_Luong_Thuc MONEY NULL,
            So_Luong_Ton MONEY NULL,
            Ghi_Chu NVARCHAR(250) NULL,
            Nhan_Vien_Id BIGINT NULL,
            Khach_Hang_Id BIGINT NULL
        )


DECLARE @Ma_Chung_Tu VARCHAR(250)
DECLARE @Ngay DATETIME
DECLARE @Ngay_Sap_Xep DATETIME
DECLARE @Ma_Hoa_Don VARCHAR(250)
DECLARE @Hang_Hoa_Id BIGINT
DECLARE @Kho_Hang_Id BIGINT
DECLARE @Serial_No VARCHAR(250)
DECLARE @Lo_Vat_Tu VARCHAR(250)
DECLARE @Loai_Chung_Tu INT
DECLARE @Dien_Giai NVARCHAR(250)
DECLARE @So_Luong_Nhap MONEY
DECLARE @So_Luong_Xuat MONEY
DECLARE @So_Luong_Thuc MONEY
DECLARE @So_Luong_Ton MONEY
DECLARE @Ghi_Chu NVARCHAR(250)
DECLARE @Nhan_Vien_Id BIGINT
DECLARE @Khach_Hang_Id BIGINT

DECLARE @getTheKho CURSOR             
SET @getTheKho =              CURSOR FOR
SELECT *
FROM   (
           SELECT ct.Ma_Chung_Tu,
                  ct.Ngay,
                  ct.Ngay AS Ngay_Sap_Xep,
                  ct.Ma_Hoa_Don,
                  ctct.Hang_Hoa_Id,
                  ctct.Kho_Hang_Id,
                  ctct.Lo_Vat_Tu,
                  ctct.Serial_No,
                  ctct.Loai_Chung_Tu,
                  CASE 
                       WHEN ctct.Loai_Chung_Tu = 1 THEN N'Nhập'
                       ELSE N'Xuất'
                  END AS Dien_Giai,
                  CASE 
                       WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.So_Luong
                  END AS So_Luong_Nhap,
                  CASE 
                       WHEN ctct.Loai_Chung_Tu = 2 THEN ctct.So_Luong
                  END AS So_Luong_Xuat,
                  CASE 
                       WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.So_Luong
                       ELSE (ctct.So_Luong * -1)
                  END AS So_Luong_Thuc,
                  ctct.Ghi_Chu,
                  ctct.Nhan_Vien_Id,
                  ctct.Khach_Hang_Id
           FROM   CHUNG_TU_CHI_TIET ctct (NOLOCK)
                  LEFT OUTER JOIN CHUNG_TU ct (NOLOCK)
                       ON  ct.Id = ctct.Chung_Tu_Id
           WHERE  DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                  AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
                  AND ISNULL(ctct.IsDeleted,0) = 0
                  AND ISNULL(ct.Dau_Ky, 0) = 0
           
           UNION ALL
           
           SELECT '',
                  CAST(NULL AS DATETIME),
                  CAST('1/1/1753' AS DATETIME),
                  '',
                  Ton_Kho_Dau_Ky.Hang_Hoa_Id,
                  Ton_Kho_Dau_Ky.Kho_Hang_Id,
                  Ton_Kho_Dau_Ky.Lo_Vat_Tu,
                  Ton_Kho_Dau_Ky.Serial_No,
                  CAST(NULL AS INT),
                  N'Đầu kỳ',
                  CAST(NULL AS MONEY),
                  CAST(NULL AS MONEY),
                  Ton_Kho_Dau_Ky.So_Luong_Thuc,
                  N'Đầu kỳ',
                  CAST(NULL AS BIGINT),
                  CAST(NULL AS BIGINT)
           FROM   (
                      SELECT ctct.Hang_Hoa_Id,
                             ctct.Kho_Hang_Id,
                             ctct.Lo_Vat_Tu,
                             ctct.Serial_No,
                             SUM(
                                 CASE 
                                      WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.So_Luong
                                      ELSE (ctct.So_Luong * -1)
                                 END
                             ) AS So_Luong_Thuc
                      FROM   CHUNG_TU_CHI_TIET ctct (NOLOCK)
                             LEFT OUTER JOIN CHUNG_TU ct (NOLOCK)
                                  ON  ct.Id = ctct.Chung_Tu_Id
                      WHERE  (DATEDIFF(DAY, @FromDate, ct.Ngay) < 0 OR ISNULL(ct.Dau_Ky, 0) = 1) 
                      AND ISNULL(ctct.IsDeleted,0) = 0
                      GROUP BY
                             ctct.Hang_Hoa_Id,
                             ctct.Kho_Hang_Id,
                             ctct.Serial_No,
                             ctct.Lo_Vat_Tu
                  )Ton_Kho_Dau_Ky
       ) The_Kho
ORDER BY
       The_Kho.Hang_Hoa_Id,
       The_Kho.Kho_Hang_Id,
       The_Kho.Lo_Vat_Tu,
       The_Kho.Serial_No,
       The_Kho.Ngay_Sap_Xep
                


DECLARE @Hang_Hoa_Id_Tam BIGINT
DECLARE @Kho_Hang_Id_Tam BIGINT
DECLARE @Lo_Vat_Tu_Tam VARCHAR(250)
DECLARE @Serial_No_Tam VARCHAR(250)

SET @Hang_Hoa_Id_Tam = ''
SET @Kho_Hang_Id_Tam = ''
SET @Lo_Vat_Tu_Tam = ''
SET @Serial_No_Tam = ''
SET @So_Luong_Ton = 0

OPEN @getTheKho FETCH NEXT FROM @getTheKho INTO @Ma_Chung_Tu, @Ngay, @Ngay_Sap_Xep, @Ma_Hoa_Don, @Hang_Hoa_Id, @Kho_Hang_Id, 
@Lo_Vat_Tu,@Serial_No, @Loai_Chung_Tu, @Dien_Giai, @So_Luong_Nhap, @So_Luong_Xuat, @So_Luong_Thuc, @Ghi_Chu, @Nhan_Vien_Id, @Khach_Hang_Id
WHILE @@FETCH_STATUS = 0
BEGIN
    --PRINT @Ma_Chung_Tu
    
    IF ( @Hang_Hoa_Id_Tam != @Hang_Hoa_Id OR @Kho_Hang_Id_Tam != @Kho_Hang_Id OR @Lo_Vat_Tu_Tam != @Lo_Vat_Tu OR @Serial_No_Tam != @Serial_No)
    BEGIN
        SET @So_Luong_Ton = 0
    END
    
    SET @So_Luong_Ton = @So_Luong_Ton + @So_Luong_Thuc
    
    SET @Hang_Hoa_Id_Tam = @Hang_Hoa_Id 
    SET @Kho_Hang_Id_Tam = @Kho_Hang_Id
    SET @Lo_Vat_Tu_Tam = @Lo_Vat_Tu 
    SET @Serial_No_Tam = @Serial_No
    
    INSERT INTO @TheKho_TB(Ma_Chung_Tu,Ngay,Ngay_Sap_Xep,Ma_Hoa_Don,Hang_Hoa_Id,Kho_Hang_Id,Lo_Vat_Tu,Serial_No,Loai_Chung_Tu,
        Dien_Giai,So_Luong_Nhap,So_Luong_Xuat,So_Luong_Thuc,So_Luong_Ton,Ghi_Chu,Nhan_Vien_Id,Khach_Hang_Id)
    VALUES(@Ma_Chung_Tu,@Ngay,@Ngay_Sap_Xep,@Ma_Hoa_Don,@Hang_Hoa_Id,@Kho_Hang_Id,@Lo_Vat_Tu,@Serial_No,@Loai_Chung_Tu,@Dien_Giai,
        @So_Luong_Nhap,@So_Luong_Xuat,@So_Luong_Thuc,@So_Luong_Ton,@Ghi_Chu,@Nhan_Vien_Id, @Khach_Hang_Id)
    
FETCH NEXT
FROM @getTheKho INTO @Ma_Chung_Tu, @Ngay, @Ngay_Sap_Xep, @Ma_Hoa_Don, @Hang_Hoa_Id, @Kho_Hang_Id, @Lo_Vat_Tu,@Serial_No,
@Loai_Chung_Tu, @Dien_Giai, @So_Luong_Nhap, @So_Luong_Xuat,@So_Luong_Thuc, @Ghi_Chu, @Nhan_Vien_Id, @Khach_Hang_Id
END
CLOSE @getTheKho
DEALLOCATE @getTheKho

SELECT thekho.*,
		hh.Ma_Hang,
       hh.Ten_Hang,
       hh.Don_Vi,
       kh.Ma_Kho,
       kh.Ten_Kho,
       kh1.Ma_Khach_Hang, 
       kh1.Ten_Khach_Hang,
       nv.Ma_Nhan_Vien, 
       nv.Ho_Ten AS Ten_Nhan_Vien
FROM   @TheKho_TB thekho
       LEFT OUTER JOIN HANG_HOA hh (NOLOCK)
            ON  hh.Id = thekho.Hang_Hoa_Id
       LEFT OUTER JOIN KHO_HANG kh (NOLOCK)
            ON  thekho.Kho_Hang_Id = kh.Id
		LEFT JOIN NHAN_VIEN AS nv(NOLOCK) 
			ON thekho.Nhan_Vien_Id =  nv.Id
        LEFT JOIN KHACH_HANG AS kh1(NOLOCK)
            ON thekho.Khach_Hang_Id = kh1.Id
            ";

                string[] myPara = { "@FromDate", "@ToDate" };
                object[] myValue = { dtTu.DateTime, dtDen.DateTime };

                var sqlHelper = new SqlHelper();

                dsTheKho.The_Kho_Theo_Ngay.Rows.Clear();
                dsTheKho.The_Kho_Theo_Ngay.Merge(sqlHelper.ExecuteDataTable(sql, myPara, myValue));

                gbList.BestFitColumns();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
