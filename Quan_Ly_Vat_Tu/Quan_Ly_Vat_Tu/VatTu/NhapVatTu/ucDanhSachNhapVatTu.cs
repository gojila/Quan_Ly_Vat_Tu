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
//using Quan_Ly_Vat_Tu.ThuChi;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using DevExpress.XtraEditors.Filtering.Templates;
using Quan_Ly_Vat_Tu.VatTu.NhapVatTu.dsNhapVatTuTableAdapters;

namespace Quan_Ly_Vat_Tu.VatTu.NhapVatTu
{
    public partial class ucDanhSachNhapVatTu : UserControl
    {
        public int loai = 1; //1: nhap, 2: xuat
        public ucDanhSachNhapVatTu()
        {
            InitializeComponent();
        }

        private void ActiveEditor_DoubleClick(object sender, EventArgs e)
        {
            bbiSua_ItemClick(this, null);
        }

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try 
            {
                cHUNG_TU_From_ToTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                cHUNG_TU_From_ToTableAdapter.ClearBeforeFill = true;
                cHUNG_TU_From_ToTableAdapter.Fill(dsNhapVatTu.CHUNG_TU_From_To, loai, txtTu.DateTime.ToString("yyyy-MM-dd"), txtDen.DateTime.ToString("yyyy-MM-dd"));


                cHUNG_TU_CHI_TIET_From_ToTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                cHUNG_TU_CHI_TIET_From_ToTableAdapter.ClearBeforeFill = true;
                cHUNG_TU_CHI_TIET_From_ToTableAdapter.Fill(dsNhapVatTu.CHUNG_TU_CHI_TIET_From_To, loai, txtTu.DateTime.ToString("yyyy-MM-dd"), txtDen.DateTime.ToString("yyyy-MM-dd"));

                gbList.BestFitColumns();

                gbList_Child.BestFitColumns();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (XtraMessageBox.Show(this, "Có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var db = new Data_QLKDataContext(SqlHelper.ConnectionString);

            int[] selectedRows = gbList.GetSelectedRows();
            long[] chungtu = new long[selectedRows.Length];
            for (int i = selectedRows.Length; i > 0; i--)
            {
                var arg = gbList.GetRowCellValue(selectedRows[i - 1], colId);
                if (arg == null)
                    continue;
                chungtu[i - 1] = Convert.ToInt64(arg);
            }

            var ct = from c in db.CHUNG_TUs
                     where chungtu.Contains(c.Id)
                     select c;

            foreach (var c in ct)
            {
                c.IsDeleted = true;
                c.DeletedDate = DateTime.Now;
            }

            try
            {
                db.SubmitChanges();
                bbiXem_ItemClick(this, null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                var arg = gbList.GetFocusedRowCellValue(colId);
                if (arg == null)
                    return;

                var frm = new frmNhapVatTu(this.loai);
                frm.LoadData(Convert.ToInt64(arg));
                frm.Reload += Reload;
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Reload(object sender)
        {
            bbiXem_ItemClick(this, null);
        }

        private void ucDanhSachNhapVatTu_Load(object sender, EventArgs e)
        {
            var tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var den = tu.AddMonths(1).AddDays(-1);

            txtTu.DateTime = tu;
            txtDen.DateTime = den;

            bbiXem_ItemClick(this, null);

            gbList.ShownEditor += (ss, ee) =>
            {
                var view = ss as GridView;
                view.ActiveEditor.DoubleClick += ActiveEditor_DoubleClick;
            };
        }
    }
}
