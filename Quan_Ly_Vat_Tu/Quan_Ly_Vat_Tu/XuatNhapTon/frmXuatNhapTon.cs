using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using Newtonsoft.Json;
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

namespace Quan_Ly_Vat_Tu
{
    public partial class frmXuatNhapTon : Form
    {
        public frmXuatNhapTon()
        {
            InitializeComponent();

            DateTime tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;
            Nap_Danh_Sach_Kho_Hang();
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

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try 
            {
                string sql =
                @"
--DECLARE @FromDate DATETIME
--DECLARE @ToDate DATETIME
--DECLARE @KhoHang BIGINT = 0
                
--SET @FromDate = '1/1/2000'
--SET @ToDate = '12/31/2050'

SELECT XNT.Hang_Hoa_Id,
       hh.Ma_Hang,
       hh.Ten_Hang,
       XNT.Serial_No,
       XNT.Lo_Vat_Tu,
       hh.Don_Vi,
       XNT.Kho_Hang_Id,
       kh.Ma_Kho,
       kh.Ten_Kho,
       XNT.So_Luong_Dau_Ky,
       XNT.So_Luong_Nhap_Trong_Ky,
       XNT.So_Luong_Xuat_Trong_Ky,
       XNT.So_Luong_Cuoi_Ky
FROM   (
           SELECT ctct.Hang_Hoa_Id,
                  ctct.Serial_No,
                  ctct.Lo_Vat_Tu,
                  ctct.Kho_Hang_Id,
                  SUM(
                      CASE 
                           WHEN ctct.Loai_Chung_Tu = 1
                                AND (
                                        DATEDIFF(DAY, @FromDate, ct.Ngay) < 0
                                        OR ISNULL(ct.Dau_Ky, 0) = 1
                                    ) THEN ctct.So_Luong
                               WHEN ctct.Loai_Chung_Tu = 2
                                AND DATEDIFF(DAY, @FromDate, ct.Ngay) < 0 THEN (ctct.So_Luong * -1)
                               ELSE 0
                          END
                  )  AS So_Luong_Dau_Ky,
                  SUM(
                      CASE 
                           WHEN ctct.Loai_Chung_Tu = 1
                                AND DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                                AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
                                AND ISNULL(ct.Dau_Ky, 0) = 0 THEN ctct.So_Luong
                               ELSE 0
                          END
                  )  AS So_Luong_Nhap_Trong_Ky,
                  SUM(
                      CASE 
                           WHEN ctct.Loai_Chung_Tu = 2
                                AND DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
                                AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0 THEN ctct.So_Luong
                               ELSE 0
                          END
                  )  AS So_Luong_Xuat_Trong_Ky,
                  SUM(
                      CASE 
                           WHEN ctct.Loai_Chung_Tu = 1
                                AND (
                                        DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
                                        OR ISNULL(ct.Dau_Ky, 0) = 1
                                    ) THEN ctct.So_Luong
                               WHEN ctct.Loai_Chung_Tu = 2
                                AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0 THEN (ctct.So_Luong * -1)
                               ELSE 0
                          END
                  )  AS So_Luong_Cuoi_Ky
           FROM   CHUNG_TU_CHI_TIET ctct(NOLOCK)
                  LEFT OUTER JOIN CHUNG_TU ct(NOLOCK)
                       ON  ct.Id = ctct.Chung_Tu_Id
           WHERE  DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
                  AND (@KhoHang = 0 OR ctct.Kho_Hang_Id = @KhoHang)
           GROUP BY
                  ctct.Hang_Hoa_Id,
                  ctct.Serial_No,
                  ctct.Lo_Vat_Tu,
                  ctct.Kho_Hang_Id
       )
       XNT
       LEFT OUTER JOIN HANG_HOA hh(NOLOCK)
            ON  XNT.Hang_Hoa_Id = hh.Id
       LEFT OUTER JOIN KHO_HANG kh(NOLOCK)
            ON  XNT.Kho_Hang_Id = kh.Id
            ";

                string[] myPara = { "@FromDate", "@ToDate", "@KhoHang" };
                object[] myValue = { dtTu.DateTime, dtDen.DateTime, txtKhoHang.EditValue.ToString() };

                var sqlHelper = new SqlHelper();
                dsXuatNhapTon.Xuat_Nhap_Ton_Theo_Ngay.Rows.Clear();
                dsXuatNhapTon.Xuat_Nhap_Ton_Theo_Ngay.Merge(sqlHelper.ExecuteDataTable(sql, myPara, myValue));

                gbList.BestFitColumns();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (XtraMessageBox.Show("Bạn muốn mở không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                    Process.Start(dialog1.FileName);
                }
            }
            
        }

        private void Nap_Danh_Sach_Kho_Hang()
        {
            try 
            {
                var db = new Data_QLKDataContext(SqlHelper.ConnectionString);
                var khoHangs = (from kh in db.KHO_HANGs
                                select kh).ToList();

                var tatCa = new KHO_HANG();
                tatCa.Id = 0;
                tatCa.Ma_Kho = "(All)";
                tatCa.Ten_Kho = "Tất cả";

                //khoHangs.Add(tatCa);
                khoHangs.Insert(0, tatCa);

                txtKhoHang.Properties.DataSource = khoHangs;
                if (khoHangs.Count() > 0)
                {
                    txtKhoHang.EditValue = khoHangs.FirstOrDefault().Id;
                }
                txtKhoHang_View.BestFitColumns();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKhoHang_EditValueChanged(object sender, EventArgs e)
        {
            bbiXem_ItemClick(this, null);
        }        
    }
}
