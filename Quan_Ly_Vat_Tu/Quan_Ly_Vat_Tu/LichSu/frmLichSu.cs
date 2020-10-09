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
    public partial class frmLichSu : Form
    {
        public frmLichSu()
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

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try 
            {
                string sql =
                @"
                SELECT ct.Id,
       ct.Ma_Chung_Tu,
       ct.Ngay,
       ct.Ma_Hoa_Don,
       ct.Ly_Do,
       ctct.Ma_Hang_Hoa,
       hh.Ma_Hang,
       hh.Ten_Hang,
       hh.Don_Vi,
       ctct.Loai_Chung_Tu,
       ctct.Ma_Kho_Hang,
       kh2.Ma_Kho,
       kh2.Ten_Kho,
       CASE 
            WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.So_Luong
       END                   AS So_Luong_Nhap,
       CASE 
            WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.Don_Gia
       END                   AS Don_Gia_Nhap,
       CASE 
            WHEN ctct.Loai_Chung_Tu = 1 THEN ctct.Thanh_Tien
       END                      Thanh_Tien_Nhap,
       CASE 
            WHEN ctct.Loai_Chung_Tu = 2 THEN ctct.So_Luong
       END                   AS So_Luong_Xuat,
       CASE 
            WHEN ctct.Loai_Chung_Tu = 2 THEN ctct.Don_Gia
       END                   AS Don_Gia_Xuat,
       CASE 
            WHEN ctct.Loai_Chung_Tu = 2 THEN ctct.Thanh_Tien
       END                   AS Thanh_Tien_Xuat,
       ctct.So_Luong,
       ctct.Don_Gia,
       ctct.Thanh_Tien,
       ctct.Ghi_Chu,
       ctct.Serial_No,
       ctct.Lo_Vat_Tu,
       nv.Ma_Nhan_Vien,
       nv.Ho_Ten             AS Ten_Nhan_Vien,
       kh1.Ma_Khach_Hang,
       kh1.Ten_Khach_Hang
FROM   CHUNG_TU_CHI_TIET ctct(NOLOCK)
       LEFT OUTER JOIN CHUNG_TU ct(NOLOCK)
            ON  ct.Id = ctct.Chung_Tu_Id
       LEFT OUTER JOIN HANG_HOA hh(NOLOCK)
            ON  hh.Id = ctct.Hang_Hoa_Id
       LEFT OUTER JOIN KHO_HANG kh2(NOLOCK)
            ON  kh2.Id = ctct.Kho_Hang_Id
       LEFT JOIN NHAN_VIEN   AS nv(NOLOCK)
            ON  ctct.Nhan_Vien_Id = nv.Id
       LEFT JOIN KHACH_HANG  AS kh1(NOLOCK)
            ON  ctct.Khach_Hang_Id = kh1.Id
WHERE  DATEDIFF(DAY, @FromDate, ct.Ngay) >= 0
       AND DATEDIFF(DAY, @ToDate, ct.Ngay) <= 0
            ";

                string[] myPara = { "@FromDate", "@ToDate" };
                object[] myValue = { dtTu.DateTime, dtDen.DateTime };

                var sqlHelper = new SqlHelper();

                dsLichSu.Lich_Su_Theo_Ngay.Rows.Clear();
                dsLichSu.Lich_Su_Theo_Ngay.Merge(sqlHelper.ExecuteDataTable(sql, myPara, myValue));

                gbList.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void gbList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
        }
    }
}
