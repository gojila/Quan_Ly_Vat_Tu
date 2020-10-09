using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quan_Ly_Vat_Tu.Bussiness;
using Quan_Ly_Vat_Tu.KhachHang;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;

namespace Quan_Ly_Vat_Tu.NhanVien
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();

            gbList.ShownEditor += (s, e) =>
            {
                var view = s as GridView;
                view.ActiveEditor.DoubleClick += ActiveEditor_DoubleClick;
            };

            bbiXem_ItemClick(this, null);
        }

        private void ActiveEditor_DoubleClick(object sender, EventArgs e)
        {
            bbiSua_ItemClick(this, null);
        }

        private void bbiThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien_Them_Sua frm = new frmNhanVien_Them_Sua();
            frm.Reload += frm_Reload;
            frm.ShowDialog();
        }

        void frm_Reload(object sender)
        {
            bbiXem_ItemClick(this, null);
        }

        private void bbiXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try 
            {
                nhan_VienTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                nhan_VienTableAdapter.ClearBeforeFill = true;
                nhan_VienTableAdapter.Fill(dsNhanVien.Nhan_Vien);

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

        private void bbiSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ma = gbList.GetFocusedRowCellValue(colId);
            if (ma == null)
                return;
            frmNhanVien_Them_Sua frm = new frmNhanVien_Them_Sua(Convert.ToInt64(ma));
            frm.Reload += frm_Reload;
            frm.ShowDialog();
        }

        private void bbiXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

                var db = new Data_QLKDataContext(SqlHelper.ConnectionString);

                int[] selectedRows = gbList.GetSelectedRows();
                long[] nhanvien = new long[selectedRows.Length];
                for (int i = selectedRows.Length; i > 0; i--)
                {
                    var arg = gbList.GetRowCellValue(selectedRows[i - 1], colId);
                    if (arg == null)
                        continue;
                    nhanvien[i - 1] = Convert.ToInt64(arg);
                }

                var nv = from h in db.NHAN_VIENs
                         where nhanvien.Contains(h.Id)
                         select h;


                foreach (var n in nv)
                {
                    n.IsDeleted = true;
                    n.DeletedDate = DateTime.Now;
                }

                db.SubmitChanges();
                bbiXem_ItemClick(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbiDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
