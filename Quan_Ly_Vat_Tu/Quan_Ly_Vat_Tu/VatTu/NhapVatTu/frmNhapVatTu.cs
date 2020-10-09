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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using Microsoft.SqlServer.Management.Smo.Agent;
using Newtonsoft.Json;
using Quan_Ly_Vat_Tu.Bussiness;
using Quan_Ly_Vat_Tu.HangHoa;
using Quan_Ly_Vat_Tu.KhachHang;
using Quan_Ly_Vat_Tu.Kho;
using Quan_Ly_Vat_Tu.NhanVien;

namespace Quan_Ly_Vat_Tu.VatTu.NhapVatTu
{
    public partial class frmNhapVatTu : Form
    {
        public delegate void ReloadEventHander(object sender);

        public event ReloadEventHander Reload;
        private void RaiseReloadEventHander()
        {
            if (Reload != null)
            {
                Reload(this);
            }
        }

        Data_QLKDataContext db;
        string tinh_trang = "them";
        long id = 0;
        int loai = 1; //1: nhap, 2: xuat
        public frmNhapVatTu(int loai)
        {
            InitializeComponent();
            this.loai = loai;
            bbiTaoMoi_ItemClick(this, null);
            _mColumn = new Column();
            _mColumn = Column.None;
            tinh_trang = "them";

            if (loai != 1) 
            {
                cbNhapDauKy.Visible = false;
            }
        }

        public void LoadData(long id) 
        {
            try
            {
                db = new Data_QLKDataContext(SqlHelper.ConnectionString);
                bbiTaoMoi_ItemClick(this, null);
                _mColumn = new Column();
                _mColumn = Column.None;
                tinh_trang = "sua";
                this.id = id;

                var ct = (from c in db.CHUNG_TUs
                          where c.Id == id
                          select c).FirstOrDefault();

                txtMaChungTu.Text = ct.Ma_Chung_Tu;
                //txtMaChungTu.Properties.ReadOnly = true;
                txtNgay.EditValue = ct.Ngay;
                txtLyDo.Text = ct.Ly_Do;
                txtGhiChu.Text = ct.Ghi_Chu;
                loai = ct.Loai_Chung_Tu.Value;

                if (this.loai == 1) 
                {
                    cbNhapDauKy.Checked = ct.Dau_Ky.Value;
                }

                cHUNG_TU_CHI_TIETTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                cHUNG_TU_CHI_TIETTableAdapter.ClearBeforeFill = true;
                cHUNG_TU_CHI_TIETTableAdapter.Fill(dsNhapVatTu.CHUNG_TU_CHI_TIET, id);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Khach_Hang()
        {
            try
            {
                kHACH_HANGTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                kHACH_HANGTableAdapter.ClearBeforeFill = true;
                kHACH_HANGTableAdapter.Fill(dsKhachHang.KHACH_HANG);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Hang_Hoa()
        {
            try 
            {
                vAT_TUTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                vAT_TUTableAdapter.ClearBeforeFill = true;
                vAT_TUTableAdapter.Fill(dsNhapVatTu.VAT_TU);
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Kho_Hang()
        {
            try
            {
                kHO_HANGTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                kHO_HANGTableAdapter.ClearBeforeFill = true;
                kHO_HANGTableAdapter.Fill(dsKho.KHO_HANG);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Nhan_Vien()
        {
            try
            {
                nhan_VienTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
                nhan_VienTableAdapter.ClearBeforeFill = true;
                nhan_VienTableAdapter.Fill(dsNhanVien.Nhan_Vien);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbiDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiTaoMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tinh_trang = "them";
            txtLyDo.Text = "";
            txtGhiChu.Text = "";
            txtMaChungTu.Text = "";
            //txtMaChungTu.Properties.ReadOnly = false;
            string refString = this.loai == 1 ? "NVT" : "XVT";
            txtMaChungTu.Text = SqlHelper.GenCode("CHUNG_TU", "Ma_Chung_Tu", refString, 5);
            txtNgay.DateTime = DateTime.Now;

            dsNhapVatTu.CHUNG_TU_CHI_TIET.Rows.Clear();
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

        private enum Column
        {
            None = 0,
            Lock = 1,
            Ma_Hang_Hoa = 2,
            Ten_Hang_Hoa = 3,
            Ma_Kho_Hang = 4,
            Nhan_Vien_Id = 5,
            Khach_Hang_Id = 6,
            Hang_Hoa_Id = 7,
            Kho_Hang_Id = 8,
        }

        Column _mColumn;

        private void gbList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gbList.UpdateCurrentRow();
            if (_mColumn == Column.Lock) return;

            if (_mColumn == Column.None)
            {
                if (e.Column.FieldName == "Ma_Hang_Hoa")
                {
                    _mColumn = Column.Ma_Hang_Hoa;
                }
                else if (e.Column.FieldName == "Ten_Hang_Hoa")
                {
                    _mColumn = Column.Ten_Hang_Hoa;
                }
                else if (e.Column.FieldName == "Ma_Kho_Hang")
                {
                    _mColumn = Column.Ma_Kho_Hang;
                }
                else if (e.Column.FieldName == "Nhan_Vien_Id")
                {
                    _mColumn = Column.Nhan_Vien_Id;
                }
                else if (e.Column.FieldName == "Khach_Hang_Id")
                {
                    _mColumn = Column.Khach_Hang_Id;
                }
                else if (e.Column.FieldName == "Hang_Hoa_Id")
                {
                    _mColumn = Column.Hang_Hoa_Id;
                }
                else if (e.Column.FieldName == "Kho_Hang_Id")
                {
                    _mColumn = Column.Kho_Hang_Id;
                }
            }

            switch (_mColumn)
            {
                case Column.None:
                    return;
                case Column.Hang_Hoa_Id:
                    _mColumn = Column.Lock;

                    if (e.Value != null)
                    {
                        var hanghoa = (from hh in db.HANG_HOAs
                                       where hh.Id == Convert.ToInt64(e.Value)
                                       select hh).FirstOrDefault();

                        gbList.SetFocusedRowCellValue(gbList.Columns["Ma_Hang_Hoa"], hanghoa.Ma_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ten_Hang_Hoa"], hanghoa.Ten_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Don_Vi"], hanghoa.Don_Vi);
                        gbList.SetFocusedRowCellValue(gbList.Columns["So_Luong"], 1);
                    }
                    _mColumn = Column.None;
                    break;
                case Column.Ma_Hang_Hoa:
                    _mColumn = Column.Lock;

                    if (e.Value != null)
                    {
                        var hanghoa = (from hh in db.HANG_HOAs
                                       where hh.Id == Convert.ToInt64(e.Value)
                                       select hh).FirstOrDefault();
                        
                        //gbList.SetFocusedRowCellValue(gbList.Columns["Hang_Hoa_Id"], hanghoa.Id);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ma_Hang_Hoa"], hanghoa.Ma_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ten_Hang_Hoa"], hanghoa.Ten_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Don_Vi"], hanghoa.Don_Vi);
                        gbList.SetFocusedRowCellValue(gbList.Columns["So_Luong"], 1);
                    }
                    _mColumn = Column.None;
                    break;
                case Column.Ten_Hang_Hoa:
                    _mColumn = Column.Lock;

                    if (e.Value != null)
                    {
                        var hanghoa = (from hh in db.HANG_HOAs
                                       where hh.Id == Convert.ToInt64(e.Value)
                                       select hh).FirstOrDefault();

                        //gbList.SetFocusedRowCellValue(gbList.Columns["Hang_Hoa_Id"], hanghoa.Id);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ma_Hang_Hoa"], hanghoa.Ma_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ten_Hang_Hoa"], hanghoa.Ten_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Don_Vi"], hanghoa.Don_Vi);
                        gbList.SetFocusedRowCellValue(gbList.Columns["So_Luong"], 1);                   
                    }
                    _mColumn = Column.None;
                    break;
                case Column.Kho_Hang_Id:
                    _mColumn = Column.Lock;

                    if (e.Value != null)
                    {
                        var khohang = (from kho in db.KHO_HANGs
                                       where kho.Id == Convert.ToInt64(e.Value)
                                       select kho).FirstOrDefault();
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ma_Kho_Hang"], khohang.Ma_Kho);
                    }
                    _mColumn = Column.None;
                    break;
            }
            _mColumn = Column.None;
            gbList.ClearColumnErrors();
        }

        private void bbiLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbList.FocusedRowHandle += 1;
            gbList.UpdateCurrentRow();

            if (!Kiem_Tra())
            {
                return;
            }

            Data_QLKDataContext database = new Data_QLKDataContext(SqlHelper.ConnectionString);
            try
            {
                database.Connection.Open();
                System.Data.Common.DbTransaction transaction = database.Connection.BeginTransaction();
                database.Transaction = transaction;

                long chungTuId = 0;

                if (tinh_trang == "them")
                {
                    CHUNG_TU chung_tu = new CHUNG_TU();
                    
                    chung_tu.Ma_Chung_Tu = txtMaChungTu.Text;
                    chung_tu.Ngay = txtNgay.DateTime;
                    chung_tu.Loai_Chung_Tu = this.loai; //1 la nhap kho 2 la xuat kho
                    chung_tu.Ly_Do = txtLyDo.Text;
                    chung_tu.Ghi_Chu = txtGhiChu.Text;
                    chung_tu.CreateDate = DateTime.Now;
                    chung_tu.IsDeleted = false;
                    if (loai == 1)
                    {
                        chung_tu.Dau_Ky = cbNhapDauKy.Checked;
                    }

                    database.CHUNG_TUs.InsertOnSubmit(chung_tu);
                    database.SubmitChanges();
                    chungTuId = chung_tu.Id;


                }
                else
                {
                    var chung_tu = (from ct in database.CHUNG_TUs
                                    where ct.Id == this.id
                                    select ct).FirstOrDefault();

                    chung_tu.Ma_Chung_Tu = txtMaChungTu.Text;
                    chung_tu.Ngay = txtNgay.DateTime;
                    chung_tu.Loai_Chung_Tu = this.loai; //1 la nhap kho 2 la xuat kho
                    chung_tu.Ly_Do = txtLyDo.Text;
                    chung_tu.Ghi_Chu = txtGhiChu.Text;
                    chung_tu.ModifiedDate = DateTime.Now;
                    if (loai == 1) 
                    {
                        chung_tu.Dau_Ky = cbNhapDauKy.Checked;
                    }

                    chungTuId = chung_tu.Id;
                }


                if (Luu_Chi_Tiet(database, chungTuId) == "OK")
                {
                    database.SubmitChanges();
                    database.Transaction.Commit();
                    RaiseReloadEventHander();
                    Close();
                }
                else
                {
                    database.Transaction.Rollback();
                }
            }
            catch (Exception ex)
            {
                database.Transaction.Rollback();
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string Luu_Chi_Tiet(Data_QLKDataContext database, long chungTuId)
        {
            var result = "OK";
            var dt = dsNhapVatTu.CHUNG_TU_CHI_TIET;
            long id = 0;
            var row = 0;
            CalulateInventory calulateInventory = new CalulateInventory();

            long vatTuId = 0;
            long khoNhap = 0;
            long khoXuat = 0;
            decimal soLuong = 0;
            string loVatTu = "";
            string serialNo = "";
            decimal orgSoLuong = 0;

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Deleted)
                {
                    row++;

                    if (dt.Rows[i]["Hang_Hoa_Id"] == DBNull.Value || Convert.ToInt64(dt.Rows[i]["Hang_Hoa_Id"]) == 0)
                    {

                        MessageBox.Show(this, String.Format("Dòng {0}: Vui lòng chọn mặt hàng.", row.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        result = "Chưa chọn mặt hàng";
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colMa_Hang_Hoa, "Chưa chọn mặt hàng");
                        return result;
                    }

                    if (dt.Rows[i]["Kho_Hang_Id"] == DBNull.Value || Convert.ToInt64(dt.Rows[i]["Kho_Hang_Id"]) == 0)
                    {

                        MessageBox.Show(this, String.Format("Dòng {0}: Vui lòng chọn kho hàng.", row.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        result = "Chưa chọn kho hàng";
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colMa_Kho_Hang, "Chưa chọn kho hàng");
                        return result;
                    }

                    id = Convert.ToInt64(dt.Rows[i]["Id"]);
                }
                var dr = dt.Rows[i];
                switch (dr.RowState)
                {
                    case DataRowState.Added:
                        
                        var chi_tiet_them = new CHUNG_TU_CHI_TIET();

                        chi_tiet_them.Chung_Tu_Id = chungTuId;
                        chi_tiet_them.Hang_Hoa_Id = Convert.ToInt64(dt.Rows[i]["Hang_Hoa_Id"]);
                        chi_tiet_them.Ma_Hang_Hoa = dt.Rows[i]["Ma_Hang_Hoa"].ToString();
                        chi_tiet_them.Ten_Hang_Hoa = dt.Rows[i]["Ten_Hang_Hoa"].ToString();
                        chi_tiet_them.Loai_Chung_Tu = this.loai; //1 nhap kho 2 xuat kho

                        chi_tiet_them.Tinh_Trang = true; //true nhap kho false xuat kho
                        chi_tiet_them.Kho_Hang_Id = Convert.ToInt64(dt.Rows[i]["Kho_Hang_Id"]);
                        chi_tiet_them.Ma_Kho_Hang = dt.Rows[i]["Ma_Kho_Hang"].ToString();
                        chi_tiet_them.So_Luong = Convert.ToDecimal(dt.Rows[i]["So_Luong"]);
                        chi_tiet_them.Ghi_Chu = dt.Rows[i]["Ghi_Chu"].ToString();

                        chi_tiet_them.Serial_No = dt.Rows[i]["Serial_No"].ToString();
                        chi_tiet_them.Lo_Vat_Tu = dt.Rows[i]["Lo_Vat_Tu"].ToString();
                        chi_tiet_them.Don_Vi = dt.Rows[i]["Don_Vi"].ToString();
                        chi_tiet_them.Nhan_Vien_Id = Convert.ToInt64(dt.Rows[i]["Nhan_Vien_Id"] == DBNull.Value ? 0 : dt.Rows[i]["Nhan_Vien_Id"]);
                        chi_tiet_them.Khach_Hang_Id = Convert.ToInt64(dt.Rows[i]["Khach_Hang_Id"] == DBNull.Value ? 0 : dt.Rows[i]["Khach_Hang_Id"]);
                        
                        chi_tiet_them.So_Thu_Tu = i;
                        chi_tiet_them.CreatedDate = DateTime.Now;

                        database.CHUNG_TU_CHI_TIETs.InsertOnSubmit(chi_tiet_them);

                        if (this.loai == 1)
                        {
                            khoNhap = chi_tiet_them.Kho_Hang_Id.Value;
                        }
                        else 
                        {
                            khoXuat = chi_tiet_them.Kho_Hang_Id.Value;
                        }
                        vatTuId = chi_tiet_them.Hang_Hoa_Id.Value;
                        soLuong = chi_tiet_them.So_Luong.Value;
                        loVatTu = chi_tiet_them.Lo_Vat_Tu;
                        serialNo = chi_tiet_them.Serial_No;


                        break;
                    case DataRowState.Modified:

                        var chi_tiet_sua = (from ctct in database.CHUNG_TU_CHI_TIETs
                                                where ctct.Id == id
                                                select ctct).FirstOrDefault();

                        chi_tiet_sua.Chung_Tu_Id = chungTuId;
                        chi_tiet_sua.Hang_Hoa_Id = Convert.ToInt64(dt.Rows[i]["Hang_Hoa_Id"]);
                        chi_tiet_sua.Ma_Hang_Hoa = dt.Rows[i]["Ma_Hang_Hoa"].ToString();
                        chi_tiet_sua.Ten_Hang_Hoa = dt.Rows[i]["Ma_Hang_Hoa"].ToString();
                        chi_tiet_sua.Loai_Chung_Tu = this.loai; //1 nhap kho 2 xuat kho

                        chi_tiet_sua.Tinh_Trang = true; //true nhap kho false xuat kho
                        chi_tiet_sua.Kho_Hang_Id = Convert.ToInt64(dt.Rows[i]["Kho_Hang_Id"]);
                        chi_tiet_sua.Ma_Kho_Hang = dt.Rows[i]["Ma_Kho_Hang"].ToString();
                        chi_tiet_sua.So_Luong = Convert.ToDecimal(dt.Rows[i]["So_Luong"]);
                        chi_tiet_sua.Ghi_Chu = dt.Rows[i]["Ghi_Chu"].ToString();

                        chi_tiet_sua.Serial_No = dt.Rows[i]["Serial_No"].ToString();
                        chi_tiet_sua.Lo_Vat_Tu = dt.Rows[i]["Lo_Vat_Tu"].ToString();
                        chi_tiet_sua.Don_Vi = dt.Rows[i]["Don_Vi"].ToString();
                        chi_tiet_sua.Nhan_Vien_Id = Convert.ToInt64(dt.Rows[i]["Nhan_Vien_Id"] == DBNull.Value ? 0 : dt.Rows[i]["Nhan_Vien_Id"]);
                        chi_tiet_sua.Khach_Hang_Id = Convert.ToInt64(dt.Rows[i]["Khach_Hang_Id"] == DBNull.Value ? 0 : dt.Rows[i]["Khach_Hang_Id"]);

                        chi_tiet_sua.So_Thu_Tu = i;
                        chi_tiet_sua.ModifiedDate = DateTime.Now;

                        orgSoLuong = Convert.ToDecimal(dt.Rows[i]["So_Luong", DataRowVersion.Original]);

                        if (this.loai == 1)
                        {
                            khoNhap = chi_tiet_sua.Kho_Hang_Id.Value;
                        }
                        else
                        {
                            khoXuat = chi_tiet_sua.Kho_Hang_Id.Value;
                        }
                        vatTuId = chi_tiet_sua.Hang_Hoa_Id.Value;
                        soLuong = chi_tiet_sua.So_Luong.Value - orgSoLuong;
                        loVatTu = chi_tiet_sua.Lo_Vat_Tu;
                        serialNo = chi_tiet_sua.Serial_No;

                        break;
                    case DataRowState.Deleted:
                        var idDetail = Convert.ToInt64(dt.Rows[i]["Id", DataRowVersion.Original]); //dt.Rows[i]["Ma_Chi_Tiet", DataRowVersion.Original];
                        var chi_tiet_xoa = (from ctct in database.CHUNG_TU_CHI_TIETs
                                            where ctct.Id == idDetail
                                            select ctct).FirstOrDefault();
                        chi_tiet_xoa.IsDeleted = true;
                        chi_tiet_xoa.DeletetedDate = DateTime.Now;

                        orgSoLuong = Convert.ToDecimal(dt.Rows[i]["So_Luong", DataRowVersion.Original]);

                        if (this.loai == 1)
                        {
                            khoNhap = chi_tiet_xoa.Kho_Hang_Id.Value;
                        }
                        else
                        {
                            khoXuat = chi_tiet_xoa.Kho_Hang_Id.Value;
                        }
                        vatTuId = chi_tiet_xoa.Hang_Hoa_Id.Value;
                        soLuong = chi_tiet_xoa.So_Luong.Value - orgSoLuong;
                        loVatTu = chi_tiet_xoa.Lo_Vat_Tu;
                        serialNo = chi_tiet_xoa.Serial_No;
                        //database.CHUNG_TU_CHI_TIETs.DeleteOnSubmit(chi_tiet_xoa);
                        break;
                }
                database.SubmitChanges();
                calulateInventory.ProcessCalculate(database, soLuong, vatTuId, loVatTu, serialNo, khoNhap, khoXuat);
            }
            return result;
        }

        bool Kiem_Tra()
        {
            if (string.IsNullOrEmpty(txtMaChungTu.Text))
            {
                MessageBox.Show("Mã chứng từ rỗng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (dsNhapVatTu.CHUNG_TU_CHI_TIET.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        private void bbiXoaTatCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là xóa tất cả dữ liệu này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            gbList.SelectAll();
            gbList.DeleteSelectedRows();
            dsNhapVatTu.CHUNG_TU_CHI_TIET.Rows.Clear();
        }

        private void bbiXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gbList.GetSelectedRows().Length > 0)
            {
                if (MessageBox.Show("Bạn có chắc là xóa dữ liệu này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                gbList.DeleteSelectedRows();
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc là xóa dữ liệu này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                gbList.DeleteRow(gbList.FocusedRowHandle);
            }
            gbList.UpdateCurrentRow();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNhapVatTu.VAT_TU' table. You can move, or remove it, as needed.
            
            try
            {
                bm.SetPopupContextMenu(gcList, pm);

                Khach_Hang();
                Hang_Hoa();
                Kho_Hang();
                Nhan_Vien();
                this.vAT_TUTableAdapter.Fill(this.dsNhapVatTu.VAT_TU);
                db = new Data_QLKDataContext(SqlHelper.ConnectionString);

                this.Text = String.Format("{0} Vật Tư", this.loai == 1 ? "Nhập" : "Xuất");
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptHangHoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try 
            {
                if (e.Button.Tag.ToString().ToLower() == "add") 
                {
                    var _frmHangHoa = new frmHangHoa_Them_Sua();
                    _frmHangHoa.Reload += (_s) => 
                    {
                        Hang_Hoa();
                    };
                    _frmHangHoa.SendData += (_s, hangHoa) =>
                    {
                        _mColumn = Column.Lock;
                        gbList.SetFocusedRowCellValue(gbList.Columns["Hang_Hoa_Id"], hangHoa.Id);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ma_Hang_Hoa"], hangHoa.Ma_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ten_Hang_Hoa"], hangHoa.Ten_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Serial_No"], "");
                        gbList.SetFocusedRowCellValue(gbList.Columns["Lo_Vat_Tu"], "");
                        gbList.SetFocusedRowCellValue(gbList.Columns["Don_Vi"], hangHoa.Don_Vi);
                        gbList.SetFocusedRowCellValue(gbList.Columns["So_Luong"], 1);
                        _mColumn = Column.None;
                    };
                    _frmHangHoa.ShowDialog();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptTenHangHoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Tag.ToString().ToLower() == "add")
                {
                    var _frmHangHoa = new frmHangHoa_Them_Sua();
                    _frmHangHoa.Reload += (_s) =>
                    {
                        Hang_Hoa();
                    };
                    _frmHangHoa.SendData += (_s, hangHoa) =>
                    {
                        _mColumn = Column.Lock;
                        gbList.SetFocusedRowCellValue(gbList.Columns["Hang_Hoa_Id"], hangHoa.Id);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ma_Hang_Hoa"], hangHoa.Ma_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ten_Hang_Hoa"], hangHoa.Ten_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Serial_No"], "");
                        gbList.SetFocusedRowCellValue(gbList.Columns["Lo_Vat_Tu"], "");
                        gbList.SetFocusedRowCellValue(gbList.Columns["Don_Vi"], hangHoa.Don_Vi);
                        gbList.SetFocusedRowCellValue(gbList.Columns["So_Luong"], 1);
                        _mColumn = Column.None;
                    };
                    _frmHangHoa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptKhoHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Tag.ToString().ToLower() == "add")
                {
                    var _frmKhoHang_Them_Sua = new frmKhoHang_Them_Sua();
                    _frmKhoHang_Them_Sua.Reload += (_s) =>
                    {
                        Kho_Hang();
                    };
                    _frmKhoHang_Them_Sua.SendData += (_s, khoHang) => 
                    {
                        _mColumn = Column.Lock;
                        gbList.SetFocusedRowCellValue(gbList.Columns["Kho_Hang_Id"], khoHang.Id);
                        _mColumn = Column.None;
                    };
                    _frmKhoHang_Them_Sua.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptNhanVien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Tag.ToString().ToLower() == "add")
                {
                    var _frmNhanVien_Them_Sua = new frmNhanVien_Them_Sua();
                    _frmNhanVien_Them_Sua.Reload += (_s) =>
                    {
                        Nhan_Vien();
                    };
                    _frmNhanVien_Them_Sua.SendData += (_s, nhanVien) =>
                    {
                        _mColumn = Column.Lock;
                        gbList.SetFocusedRowCellValue(gbList.Columns["Nhan_Vien_Id"], nhanVien.Id);
                        _mColumn = Column.None;
                    };
                    _frmNhanVien_Them_Sua.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptKhachHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (e.Button.Tag.ToString().ToLower() == "add")
                {
                    var _frmKhachHang_Them_Sua = new frmKhachHang_Them_Sua();
                    _frmKhachHang_Them_Sua.Reload += (_s) =>
                    {
                        Khach_Hang();
                    };
                    _frmKhachHang_Them_Sua.SendData += (_s, khachHang) =>
                    {
                        _mColumn = Column.Lock;
                        gbList.SetFocusedRowCellValue(gbList.Columns["Khach_Hang_Id"], khachHang.Id);
                        _mColumn = Column.None;
                    };
                    _frmKhachHang_Them_Sua.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptHangHoa_EditValueChanged(object sender, EventArgs e)
        {
            try 
            {
                var view = sender as GridLookUpEdit;
                DataRow row = view.Properties.View.GetDataRow(view.Properties.View.FocusedRowHandle);
                _mColumn = Column.Lock;
                gbList.SetFocusedRowCellValue(gbList.Columns["Hang_Hoa_Id"], Convert.ToInt64(row["Id"]));
                gbList.SetFocusedRowCellValue(gbList.Columns["Ma_Hang_Hoa"], row["Ma_Hang"].ToString());
                gbList.SetFocusedRowCellValue(gbList.Columns["Ten_Hang_Hoa"], row["Ten_Hang"].ToString());
                gbList.SetFocusedRowCellValue(gbList.Columns["Serial_No"], row["Serial_No"].ToString());
                gbList.SetFocusedRowCellValue(gbList.Columns["Lo_Vat_Tu"], row["Lo_Vat_Tu"].ToString());
                gbList.SetFocusedRowCellValue(gbList.Columns["Don_Vi"], row["Don_Vi"].ToString());
                gbList.SetFocusedRowCellValue(gbList.Columns["Kho_Hang_Id"], Convert.ToInt64(row["Kho_Id"] == DBNull.Value ? 0 : row["Kho_Id"]));
                gbList.SetFocusedRowCellValue(gbList.Columns["So_Luong"], 1);
                _mColumn = Column.None;
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmNhapVatTu_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void frmNhapVatTu_DragDrop(object sender, DragEventArgs e)
        {
            try 
            {
                var data = e.Data.GetData(DataFormats.FileDrop);
                if (data != null)
                {
                    var fileNames = data as string[];
                    if (fileNames.Length > 0 && File.Exists(fileNames[0]))
                    {
                        ProcessImportExcelFile(fileNames[0]);
                    }
                    else 
                    {
                        XtraMessageBox.Show(this, "Không tìm thấy file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    XtraMessageBox.Show(this, "Không tìm thấy file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbiImportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try 
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "(*.xls, *.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;

                openFileDialog1.Multiselect = false;

                // Call the ShowDialog method to show the dialog box.
                if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                string path = openFileDialog1.FileName;

                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {

                    ProcessImportExcelFile(path);
                }
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessImportExcelFile(string fileName) 
        {
            try
            {
                var sqlHelper = new SqlHelper();
                var dtReadExel = sqlHelper.ReadFileExcel(fileName, Path.GetExtension(fileName), "yes");

                foreach (DataRow dr in dtReadExel.Rows)
                {

                    var vatTu = (from hh in db.HANG_HOAs
                                 where hh.Ma_Hang == (dr["Ma_Vat_Tu"] == DBNull.Value ? "" : dr["Ma_Vat_Tu"]).ToString() && !hh.IsDeleted.Value
                                 select hh).FirstOrDefault();

                    var kho = (from kh in db.KHO_HANGs
                               where kh.Ma_Kho == (dr["Ma_Kho"] == DBNull.Value ? "" : dr["Ma_Kho"]).ToString() && !kh.IsDeleted.Value
                               select kh).FirstOrDefault();

                    var nhanVien = (from nv in db.NHAN_VIENs
                                    where nv.Ma_Nhan_Vien == (dr["Ma_Nhan_Vien"] == DBNull.Value ? "" : dr["Ma_Nhan_Vien"]).ToString() && !nv.IsDeleted.Value
                                    select nv).FirstOrDefault();

                    var khachHang = (from kh in db.KHACH_HANGs
                                     where kh.Ma_Khach_Hang == (dr["Ma_Khach_Hang"] == DBNull.Value ? "" : dr["Ma_Khach_Hang"]).ToString() && !kh.IsDeleted.Value
                                     select kh).FirstOrDefault();


                    dsNhapVatTu.CHUNG_TU_CHI_TIET.AddCHUNG_TU_CHI_TIETRow(
                        0,
                        (vatTu == null ? 0 : vatTu.Id),
                        (dr["Ma_Vat_Tu"] == DBNull.Value ? "" : dr["Ma_Vat_Tu"]).ToString(),
                        (dr["Ten_Vat_Tu"] == DBNull.Value ? "" : dr["Ten_Vat_Tu"]).ToString(),
                        this.loai,

                        false,
                        false,
                        "", //Ma Chi Nhanh
                        (kho == null ? 0 : kho.Id), //Kho Hang ID
                        (dr["Ma_Kho"] == DBNull.Value ? "" : dr["Ma_Kho"]).ToString(), //Ma Kho

                        (dr["Lo_Vat_Tu"] == DBNull.Value ? "" : dr["Lo_Vat_Tu"]).ToString(),
                        (dr["Serial_No"] == DBNull.Value ? "" : dr["Serial_No"]).ToString(),
                        Convert.ToDecimal(dr["So_Luong"] == DBNull.Value ? 0 : dr["So_Luong"]),
                        0, //Don gia
                        0, //Thanh tien

                        (nhanVien == null ? 0 : nhanVien.Id), //0, //Nhan vien id
                        (khachHang == null ? 0 : khachHang.Id), //0, //Khach hang id
                        (dr["Ghi_Chu"] == DBNull.Value ? "" : dr["Ghi_Chu"]).ToString(), //Ghi chu
                        0, //STT
                        false,

                        0,
                        DateTime.Now,
                        0,
                        DateTime.Now,
                        0,
                        DateTime.Now,
                        (vatTu == null ? "" : vatTu.Don_Vi), //Don vi
                        0);

                    dsNhapVatTu.CHUNG_TU_CHI_TIET.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbiExelMau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try 
            {
                var fi = new FileInfo(Application.StartupPath + "\\ExcelTemplate\\template_nhap_xuat.xlsx");
                if (!fi.Exists) 
                {
                    XtraMessageBox.Show(this, "Không tìm thấy file mẫu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                };
                Process.Start(Application.StartupPath + "\\ExcelTemplate\\template_nhap_xuat.xlsx");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
