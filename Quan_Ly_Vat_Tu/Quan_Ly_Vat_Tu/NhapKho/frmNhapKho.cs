using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quan_Ly_Vat_Tu.Bussiness;

namespace Quan_Ly_Vat_Tu.NhapKho
{
    public partial class frmNhapKho : Form
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
        public frmNhapKho()
        {
            InitializeComponent();
            bm.SetPopupContextMenu(gcList, pm);

            Khach_Hang();
            Hang_Hoa();
            Kho_Hang();
            Nhan_Vien();
            Nap_Hinh_Thuc_Thu_Chi();
            Nap_Hinh_Thuc_Thanh_Toan();

            db = new Data_QLKDataContext(SqlHelper.ConnectionString);
            bbiTaoMoi_ItemClick(this, null);
            _mColumn = new Column();
            _mColumn = Column.None;
            tinh_trang = "them";
        }

        public frmNhapKho(string ma)
        {
            InitializeComponent();
            bm.SetPopupContextMenu(gcList, pm);

            Khach_Hang();
            Hang_Hoa();
            Kho_Hang();
            Nhan_Vien();
            Nap_Hinh_Thuc_Thu_Chi();
            Nap_Hinh_Thuc_Thanh_Toan();

            db = new Data_QLKDataContext(SqlHelper.ConnectionString);
            bbiTaoMoi_ItemClick(this, null);
            _mColumn = new Column();
            _mColumn = Column.None;
            tinh_trang = "sua";

            var ct = (from c in db.CHUNG_TUs
                     where c.Ma_Chung_Tu == ma
                      select c).FirstOrDefault();

            txtMaChungTu.Text = ct.Ma_Chung_Tu;
            txtMaChungTu.Properties.ReadOnly = true;
            txtMaHoaDon.Text = ct.Ma_Hoa_Don;
            txtNgay.EditValue = ct.Ngay;
            txtNhanVien.EditValue = ct.Nhan_Vien;
            txtKhachHang.EditValue = ct.Ma_Khach_Hang;
            txtDiaChi.Text = ct.Dia_Chi;
            txtLyDo.Text = ct.Ly_Do;
            txtGhiChu.Text = ct.Ghi_Chu;
            txtChietKhauPhanTram.Value = ct.Chiet_Khau_Phan_Tram ?? 0;
            txtVATPhanTram.Value = ct.VAT_Phan_Tram ?? 0;
            txtChietKhauThanhTien.Value = ct.Chiet_Khau_Thanh_Tien ?? 0;
            txtVATThanhTien.Value = ct.VAT_Thanh_Tien ?? 0;
            txtThanhTien.Value = ct.Thanh_Tien ?? 0;
            txtHinhThucCongNo.EditValue = ct.Hinh_Thuc_Cong_No ?? 0;
            txtHinhThucThuChi.EditValue = ct.Hinh_Thuc_Thu_Chi ?? 0;
            txtThanhToan.Value = ct.Thanh_Toan ?? 0;

            cHUNG_TU_CHI_TIETTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            cHUNG_TU_CHI_TIETTableAdapter.ClearBeforeFill = true;
            cHUNG_TU_CHI_TIETTableAdapter.Fill(dsNhapKho.CHUNG_TU_CHI_TIET, txtMaChungTu.Text);
        }

        void Khach_Hang()
        {
            kHACH_HANGTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            kHACH_HANGTableAdapter.ClearBeforeFill = true;
            kHACH_HANGTableAdapter.Fill(dsKhachHang.KHACH_HANG);
        }

        void Hang_Hoa()
        {
            hANG_HOATableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            hANG_HOATableAdapter.ClearBeforeFill = true;
            hANG_HOATableAdapter.Fill(dsHangHoa.HANG_HOA);
        }

        void Kho_Hang()
        {
            kHO_HANGTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            kHO_HANGTableAdapter.ClearBeforeFill = true;
            kHO_HANGTableAdapter.Fill(dsKho.KHO_HANG);
        }

        void Nhan_Vien()
        {
            nhan_VienTableAdapter.Connection.ConnectionString = SqlHelper.ConnectionString;
            nhan_VienTableAdapter.ClearBeforeFill = true;
            nhan_VienTableAdapter.Fill(dsNhanVien.Nhan_Vien);
        }

        void Nap_Hinh_Thuc_Thu_Chi()
        {
            dsHinhThuc.Hinh_Thuc_Thu_Chi.Rows.Clear();

            dsHinhThuc.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("0", "Thu chi theo chứng từ", "Áp dụng cho khách lẻ quản lý công nợ theo chứng từ");
            dsHinhThuc.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("1", "Thu chi theo khách hàng", "Áp dụng cho quản lý công nợ theo khách hàng");
            //dsHinhThuc.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("", "");
            //dsHinhThuc.Hinh_Thuc_Thu_Chi.AddHinh_Thuc_Thu_ChiRow("", "");

            txtHinhThucThuChi.EditValue = dsHinhThuc.Hinh_Thuc_Thu_Chi.Rows[0]["Ma"];

        }

        void Nap_Hinh_Thuc_Thanh_Toan()
        {
            dsHinhThuc.Hinh_Thuc_Thanh_Toan.Rows.Clear();

            dsHinhThuc.Hinh_Thuc_Thanh_Toan.AddHinh_Thuc_Thanh_ToanRow("0", "Khác", "Không quản lý công nợ chứng từ này");
            dsHinhThuc.Hinh_Thuc_Thanh_Toan.AddHinh_Thuc_Thanh_ToanRow("1", "Tăng công nợ", "Tăng công nợ phải thu");
            dsHinhThuc.Hinh_Thuc_Thanh_Toan.AddHinh_Thuc_Thanh_ToanRow("2", "Giảm công nợ", "Giảm công nợ phải thu");
            //dsHinhThuc.Hinh_Thuc_Thanh_Toan.AddHinh_Thuc_Thanh_ToanRow("", "");

            txtHinhThucCongNo.EditValue = dsHinhThuc.Hinh_Thuc_Thanh_Toan.Rows[0]["Ma"];
        }

        private void bbiDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiTaoMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tinh_trang = "them";
            txtKhachHang.EditValue = null;
            txtDiaChi.Text = "";
            txtLyDo.Text = "";
            txtGhiChu.Text = "";
            txtMaChungTu.Text = "";
            txtMaChungTu.Properties.ReadOnly = false;
            txtMaChungTu.Text = SqlHelper.GenCode("CHUNG_TU", "Ma_Chung_Tu", "NK", 1);
            txtMaHoaDon.Text = "";
            txtNgay.DateTime = DateTime.Now;
            txtVATPhanTram.Value = 0;
            txtVATThanhTien.Value = 0;
            txtChietKhauPhanTram.Value = 0;
            txtChietKhauThanhTien.Value = 0;
            txtThanhTien.Value = 0;
            txtThanhToan.Value = 0;

            dsNhapKho.CHUNG_TU_CHI_TIET.Rows.Clear();
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
            MaHang = 1,
            TenHang = 2,
            KhoHang = 3,
            SoLuong = 4,
            DonGia = 5,
            ThanhTien = 6,
            Lock = 7,
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
                    _mColumn = Column.MaHang;
                }
                else if (e.Column.FieldName == "Ten_Hang")
                {
                    _mColumn = Column.TenHang;
                }
                else if (e.Column.FieldName == "Ma_Kho_Hang")
                {
                    _mColumn = Column.KhoHang;
                }
                else if (e.Column.FieldName == "So_Luong")
                {
                    _mColumn = Column.SoLuong;
                }
                else if (e.Column.FieldName == "Don_Gia")
                {
                    _mColumn = Column.DonGia;
                }
                else if (e.Column.FieldName == "Thanh_Tien")
                {
                    _mColumn = Column.ThanhTien;
                }
            }

            switch (_mColumn)
            {
                case Column.None:
                    return;
                case Column.MaHang:
                    _mColumn = Column.Lock;

                    if (e.Value != null)
                    {
                        var hanghoa = (from hh in db.HANG_HOAs
                                      where hh.Ma_Hang == e.Value.ToString()
                                       select hh).FirstOrDefault();

                        gbList.SetFocusedRowCellValue(gbList.Columns["Ma_Hang_Hoa"], hanghoa.Ma_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ten_Hang"], hanghoa.Ma_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Don_Vi"], hanghoa.Don_Vi);
                        gbList.SetFocusedRowCellValue(gbList.Columns["So_Luong"], 1);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Don_Gia"], hanghoa.Gia_Nhap);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Thanh_Tien"], hanghoa.Gia_Nhap);
                        Tinh_Thanh_Tien();
                    }
                    _mColumn = Column.None;
                    break;
                case Column.TenHang:
                    _mColumn = Column.Lock;

                    if (e.Value != null)
                    {
                        var hanghoa = (from hh in db.HANG_HOAs
                                       where hh.Ma_Hang == e.Value.ToString()
                                       select hh).FirstOrDefault();

                        gbList.SetFocusedRowCellValue(gbList.Columns["Ma_Hang_Hoa"], hanghoa.Ma_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Ten_Hang"], hanghoa.Ma_Hang);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Don_Vi"], hanghoa.Don_Vi);
                        gbList.SetFocusedRowCellValue(gbList.Columns["So_Luong"], 1);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Don_Gia"], hanghoa.Gia_Nhap);
                        gbList.SetFocusedRowCellValue(gbList.Columns["Thanh_Tien"], hanghoa.Gia_Nhap);
                        Tinh_Thanh_Tien();
                    }
                    _mColumn = Column.None;
                    break;
                case Column.SoLuong:
                    {
                        var dongia = gbList.GetRowCellValue(e.RowHandle, "Don_Gia");
                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Thanh_Tien", Convert.ToDecimal(e.Value == DBNull.Value ? 0.0 : e.Value) * Convert.ToDecimal(dongia == DBNull.Value ? 0 : dongia));
                        Tinh_Thanh_Tien();
                        _mColumn = Column.None;
                        break;
                    }
                case Column.DonGia:
                    {
                        var soluong = gbList.GetRowCellValue(e.RowHandle, "So_Luong");
                        _mColumn = Column.Lock;
                        gbList.SetRowCellValue(e.RowHandle, "Thanh_Tien", Convert.ToDecimal(e.Value == DBNull.Value ? 0.0 : e.Value) * Convert.ToDecimal(soluong == DBNull.Value ? 0 : soluong));
                        Tinh_Thanh_Tien();
                        _mColumn = Column.None;
                        break;
                    }
            }
            _mColumn = Column.None;
            gbList.ClearColumnErrors();
        }

        private void txtChietKhauPhanTram_EditValueChanged(object sender, EventArgs e)
        {
            Tinh_Thanh_Tien();
        }

        void Tinh_Thanh_Tien()
        {
            decimal tong_tien = Convert.ToDecimal(colThanh_Tien.SummaryItem.SummaryValue);
            decimal vat_phan_tram = txtVATPhanTram.Value;
            decimal chiet_khau_phan_tram = txtChietKhauPhanTram.Value;

            txtVATThanhTien.Value = (tong_tien / 100) * vat_phan_tram;
            txtChietKhauThanhTien.Value = (tong_tien / 100) * chiet_khau_phan_tram;

            txtThanhTien.Value = tong_tien - txtChietKhauThanhTien.Value + txtVATThanhTien.Value;
        }

        private void txtVATPhanTram_EditValueChanged(object sender, EventArgs e)
        {
            Tinh_Thanh_Tien();
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

                if (tinh_trang == "them")
                {
                    CHUNG_TU chung_tu = new CHUNG_TU
                    {
                        Ma_Chung_Tu = txtMaChungTu.Text,
                        Ma_Hoa_Don = txtMaHoaDon.Text,
                        Ngay = txtNgay.DateTime,
                        Loai_Chung_Tu = 1, //1 la nhap kho 2 la xuat kho
                        Ma_Khach_Hang = string.IsNullOrEmpty(txtKhachHang.Text) ? "" : txtKhachHang.EditValue.ToString(),
                        Dia_Chi = txtDiaChi.Text,
                        Ly_Do = txtLyDo.Text,
                        VAT_Phan_Tram = txtVATPhanTram.Value,
                        VAT_Thanh_Tien = txtVATThanhTien.Value,
                        Chiet_Khau_Phan_Tram = txtChietKhauPhanTram.Value,
                        Chiet_Khau_Thanh_Tien = txtChietKhauThanhTien.Value,
                        Thanh_Tien = txtThanhTien.Value,
                        Hinh_Thuc_Cong_No = Convert.ToInt32(txtHinhThucCongNo.EditValue),
                        Hinh_Thuc_Thu_Chi = Convert.ToInt32(txtHinhThucThuChi.EditValue),
                        Thanh_Toan = txtThanhToan.Value,
                        Ghi_Chu = txtGhiChu.Text,
                        So_Thu_Tu = 0,
                        Nhan_Vien = string.IsNullOrEmpty(txtNhanVien.Text) ? "" : txtNhanVien.EditValue.ToString()
                    };
                    database.CHUNG_TUs.InsertOnSubmit(chung_tu);
                    
                }
                else
                {
                    var chung_tu = (from ct in database.CHUNG_TUs
                                   where ct.Ma_Chung_Tu == txtMaChungTu.Text
                                   select ct).FirstOrDefault();

                    chung_tu.Ma_Chung_Tu = txtMaChungTu.Text;
                    chung_tu.Ma_Hoa_Don = txtMaHoaDon.Text;
                    chung_tu.Ngay = txtNgay.DateTime;
                    chung_tu.Loai_Chung_Tu = 1; //1 la nhap kho 2 la xuat kho
                    chung_tu.Ma_Khach_Hang = string.IsNullOrEmpty(txtKhachHang.Text) ? "" : txtKhachHang.EditValue.ToString();
                    chung_tu.Dia_Chi = txtDiaChi.Text;
                    chung_tu.Ly_Do = txtLyDo.Text;
                    chung_tu.VAT_Phan_Tram = txtVATPhanTram.Value;
                    chung_tu.VAT_Thanh_Tien = txtVATThanhTien.Value;
                    chung_tu.Chiet_Khau_Phan_Tram = txtChietKhauPhanTram.Value;
                    chung_tu.Chiet_Khau_Thanh_Tien = txtChietKhauThanhTien.Value;
                    chung_tu.Thanh_Tien = txtThanhTien.Value;
                    chung_tu.Hinh_Thuc_Cong_No = Convert.ToInt32(txtHinhThucCongNo.EditValue);
                    chung_tu.Hinh_Thuc_Thu_Chi = Convert.ToInt32(txtHinhThucThuChi.EditValue);
                    chung_tu.Thanh_Toan = txtThanhToan.Value;
                    chung_tu.Ghi_Chu = txtGhiChu.Text;
                    chung_tu.Nhan_Vien = string.IsNullOrEmpty(txtNhanVien.Text) ? "" : txtNhanVien.EditValue.ToString();
                    chung_tu.So_Thu_Tu = 0;

                }


                if (Luu_Chi_Tiet(database, 0) == "OK")
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
                MessageBox.Show(ex.ToString());
            }
        }

        string Luu_Chi_Tiet(Data_QLKDataContext database, long chungTuId)
        {
            var result = "OK";
            var dt = dsNhapKho.CHUNG_TU_CHI_TIET;
            long id = 0;
            var row = 0;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].RowState != DataRowState.Deleted)
                {
                    row++;

                    if (dt.Rows[i]["Ma_Hang_Hoa"] == DBNull.Value)
                    {

                        MessageBox.Show("Vui lòng chọn mặt hàng.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        result = "Chưa chọn mặt hàng";
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colMa_Hang_Hoa, "Chưa chọn mặt hàng");
                        return result;
                    }

                    if (dt.Rows[i]["Ma_Kho_Hang"] == DBNull.Value)
                    {

                        MessageBox.Show("Chưa chọn kho hàng.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        result = "Chưa chọn kho hàng";
                        gbList.FocusedRowHandle = row;
                        gbList.SetColumnError(colMa_Kho_Hang, "Chưa chọn kho hàng");
                        return result;
                    }

                    id = Convert.ToInt64(dt.Rows[i]["Ma_Chi_Tiet"]);
                }
                var dr = dt.Rows[i];
                switch (dr.RowState)
                {
                    case DataRowState.Added:
                        
                        var chung_tu_chi_tiet = new CHUNG_TU_CHI_TIET 
                        { 
                            Chung_Tu_Id = chungTuId,
                            Ma_Hang_Hoa = dt.Rows[i]["Ma_Hang_Hoa"].ToString(),
                            Loai_Chung_Tu = 1, //1 nhap kho 2 xuat kho
                            Tinh_Trang = true, //true nhap kho false xuat kho
                            Ma_Kho_Hang = dt.Rows[i]["Ma_Kho_Hang"].ToString(),
                            So_Luong = Convert.ToDecimal(dt.Rows[i]["So_Luong"]),
                            Don_Gia = Convert.ToDecimal(dt.Rows[i]["Don_Gia"]),
                            Thanh_Tien = Convert.ToDecimal(dt.Rows[i]["Thanh_Tien"]),
                            Ghi_Chu = dt.Rows[i]["Ghi_Chu"].ToString(),
                            So_Thu_Tu = 0
                        };
                        database.CHUNG_TU_CHI_TIETs.InsertOnSubmit(chung_tu_chi_tiet);
                        
                        break;
                    case DataRowState.Modified:

                        var chi_tiet_sua = (from ctct in database.CHUNG_TU_CHI_TIETs
                                                where ctct.Id == id
                                                select ctct).FirstOrDefault();

                        chi_tiet_sua.Id = id;
                        chi_tiet_sua.Chung_Tu_Id = chungTuId;
                        chi_tiet_sua.Ma_Hang_Hoa = dt.Rows[i]["Ma_Hang_Hoa"].ToString();
                        chi_tiet_sua.Loai_Chung_Tu = 1; //1 nhap kho 2 xuat kho
                        chi_tiet_sua.Tinh_Trang = true; //true nhap kho false xuat kho
                        chi_tiet_sua.Ma_Kho_Hang = dt.Rows[i]["Ma_Kho_Hang"].ToString();
                        chi_tiet_sua.So_Luong = Convert.ToDecimal(dt.Rows[i]["So_Luong"]);
                        chi_tiet_sua.Don_Gia = Convert.ToDecimal(dt.Rows[i]["Don_Gia"]);
                        chi_tiet_sua.Thanh_Tien = Convert.ToDecimal(dt.Rows[i]["Thanh_Tien"]);
                        chi_tiet_sua.Ghi_Chu = dt.Rows[i]["Ghi_Chu"].ToString();
                        chi_tiet_sua.So_Thu_Tu = 0;
                        break;
                    case DataRowState.Deleted:
                        var chi_tiet_xoa = (from ctct in database.CHUNG_TU_CHI_TIETs
                                        where ctct.Id == id
                                        select ctct).FirstOrDefault();
                        database.CHUNG_TU_CHI_TIETs.DeleteOnSubmit(chi_tiet_xoa);
                        break;
                }
                database.SubmitChanges();
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
            
            if (dsNhapKho.CHUNG_TU_CHI_TIET.Rows.Count == 0)
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
            dsNhapKho.CHUNG_TU_CHI_TIET.Rows.Clear();
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
            // TODO: This line of code loads data into the 'dsNhanVien.Nhan_Vien' table. You can move, or remove it, as needed.
            this.nhan_VienTableAdapter.Fill(this.dsNhanVien.Nhan_Vien);

        }

        private void txtKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKhachHang.Text))
            {
                DataRow _dataRow = txtKhachHang_View.GetFocusedDataRow();
                if (_dataRow != null)
                {
                    txtDiaChi.Text = _dataRow["Dia_Chi"].ToString();
                }
            }
        }
    }
}
