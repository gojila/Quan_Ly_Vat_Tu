using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using System.Diagnostics;

namespace Quan_Ly_Vat_Tu.Test
{
    public partial class frmTestList : Form
    {
        public frmTestList()
        {
            InitializeComponent();

            DateTime tu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            dtTu.DateTime = tu;
            dtDen.DateTime = den;
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

        private void frmTestList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTEST.STOCK_OUTWARD_DETAIL' table. You can move, or remove it, as needed.
            this.sTOCK_OUTWARD_DETAILTableAdapter.Fill(this.dsTEST.STOCK_OUTWARD_DETAIL);

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

        private void bbiExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var openFileDialog = new SaveFileDialog();
            //openFileDialog.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            //openFileDialog.FilterIndex = 1;
            //openFileDialog.RestoreDirectory = true;

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    var option = new XlsExportOptions();
            //    option.ShowGridLines = true;

            //    gbList.ExportToXls(openFileDialog.FileName, option);
            //    if (MessageBox.Show("Do you want open this file?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        Process.Start(openFileDialog.FileName);
            //    }
            //}
        }
    }
}
