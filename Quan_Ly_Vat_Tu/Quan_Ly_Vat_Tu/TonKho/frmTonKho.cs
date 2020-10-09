using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Quan_Ly_Vat_Tu.Bussiness;

namespace Quan_Ly_Vat_Tu.TonKho
{
    public partial class frmTonKho : Form
    {
        Data_QLKDataContext db;
        public frmTonKho()
        {
            InitializeComponent();
            db = new Data_QLKDataContext(SqlHelper.ConnectionString);
            Danh_Sach_Kho_Hang();
            bbiXem_ItemClick(this, null);
        }

        void Danh_Sach_Kho_Hang()
        {
            try 
            {
                kHO_HANGTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                kHO_HANGTableAdapter.ClearBeforeFill = true;
                kHO_HANGTableAdapter.Fill(dsTonKho.KHO_HANG);

                DataRow dr = dsTonKho.KHO_HANG.NewRow();
                dr["Id"] = 0;
                dr["Ma_Kho"] = "All";
                dr["Ten_Kho"] = "(Tất Cả)";
                dsTonKho.KHO_HANG.Rows.InsertAt(dr, 0);

                if (dsTonKho.KHO_HANG.Rows.Count > 0)
                {
                    txtKhoHang.EditValue = dsTonKho.KHO_HANG.Rows[0]["Id"].ToString();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tON_KHOTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                tON_KHOTableAdapter.ClearBeforeFill = true;
                tON_KHOTableAdapter.Fill(dsTonKho.TON_KHO, Convert.ToInt64(txtKhoHang.EditValue));
                //tON_KHOTableAdapter.Fill(dsTonKho.TON_KHO, txtKhoHang.EditValue.ToString());

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

        private void txtKhoHang_EditValueChanged(object sender, EventArgs e)
        {
            bbiXem_ItemClick(this, null);
        }

        private void frmTonKho_Load(object sender, EventArgs e)
        {
        }
    }
}
