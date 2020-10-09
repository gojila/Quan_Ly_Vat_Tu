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
using DevExpress.XtraEditors;
using Newtonsoft.Json;

namespace Quan_Ly_Vat_Tu.VatTu.NhapVatTu
{
    public partial class ucChiTietNhapVatTu : UserControl
    {
        public int loai = 1; //1: nhap, 2: xuat
        public ucChiTietNhapVatTu()
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
                cHUNG_TU_CHI_TIET_From_ToTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                cHUNG_TU_CHI_TIET_From_ToTableAdapter.ClearBeforeFill = true;
                cHUNG_TU_CHI_TIET_From_ToTableAdapter.Fill(dsNhapVatTu.CHUNG_TU_CHI_TIET_From_To, this.loai, txtTu.DateTime.ToString("yyyy-MM-dd"), txtDen.DateTime.ToString("yyyy-MM-dd"));

                gbList.BestFitColumns();
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
                var arg = gbList.GetFocusedRowCellValue(colChung_Tu_Id);
                if (arg == null)
                    return;

                var frm = new frmNhapVatTu(loai);
                frm.LoadData(Convert.ToInt64(arg.ToString()));
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

        private void ucChiTietNhapVatTu_Load(object sender, EventArgs e)
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
