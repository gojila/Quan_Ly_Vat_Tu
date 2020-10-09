using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Quan_Ly_Vat_Tu.Bussiness;

using System.IO;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace Quan_Ly_Vat_Tu
{
    public partial class frmCauHinhCSDL : Form
    {
        public bool IsAppExit = true;
        public delegate void ThanhCongEventHander(object sender);

        public event ThanhCongEventHander ThanhCong;
        private void KetThucThanhCongEventHander()
        {
            if (ThanhCong != null)
            {
                ThanhCong(this);
            }
        }

        public frmCauHinhCSDL()
        {
            InitializeComponent();
            Nap_Cau_Hinh();

            SqlHelper.TenCSDL = txtTenCSDL.Text;
            SqlHelper.MayChu = txtMayChuSQL.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (IsAppExit)
            {
                Application.Exit();
            }
            else 
            {
                this.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!cbSuDungTaiKhoanWindows.Checked)
            {
                SqlHelper.ConnectionString = "Data Source=" + txtMayChuSQL.Text + ";Initial Catalog=" + txtTenCSDL.Text + ";User ID=" + txtTaiKhoanSQL.Text + ";Password=" + txtPassword.Text + ";";
            }
            else
            {
                SqlHelper.ConnectionString = "Data Source=" + txtMayChuSQL.Text + ";Initial Catalog=" + txtTenCSDL.Text + ";Integrated Security=True;";
            }

            SqlHelper.TenCSDL = txtTenCSDL.Text;
            SqlHelper.MayChu = txtMayChuSQL.Text;

            if (Kiem_Tra_Ket_Noi(SqlHelper.ConnectionString))
            {
                Luu_Cau_Hinh();
                KetThucThanhCongEventHander();
                if (IsAppExit)
                {
                    Close();
                }
                else 
                {
                    Application.Restart();
                }
            }
            else
            {
                return;
            }
        }

        private void cbSuDungTaiKhoanWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtTaiKhoanSQL.Properties.ReadOnly = cbSuDungTaiKhoanWindows.Checked;
            txtPassword.Properties.ReadOnly = cbSuDungTaiKhoanWindows.Checked;
        }

        public bool Kiem_Tra_Ket_Noi(string ConnectionString)
        {
            var connection = new SqlConnection(ConnectionString);
            
            try
            {
                connection.Open();
                connection.Close();
            }
            catch
            {
                MessageBox.Show(this, "Không thể kết nối với máy chủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }

        public void Luu_Cau_Hinh()
        {
            try
            {
                System.Data.DataSet ds = new System.Data.DataSet();
                var dt = new DataTable("CauHinhCSDL");

                dt.Columns.Add("MayChu");
                dt.Columns.Add("SuDungTaiKhoanWindows");
                dt.Columns.Add("TaiKhoanSQL");
                dt.Columns.Add("Password");
                dt.Columns.Add("CSDL");

                dt.Rows.Clear();
                dt.Rows.Add(
                    new object[]
                    {
                        txtMayChuSQL.Text,
                        cbSuDungTaiKhoanWindows.Checked.ToString(),
                        txtTaiKhoanSQL.Text,
                        txtPassword.Text,
                        txtTenCSDL.Text
                    }
                    );

                ds.Tables.Add(dt);
                ds.WriteXml("CauHinhCSDL.xml");

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Nap_Cau_Hinh() 
        {
            var dt = new DataTable("CauHinhCSDL");
            dt.Columns.Add("MayChu");
            dt.Columns.Add("SuDungTaiKhoanWindows");
            dt.Columns.Add("TaiKhoanSQL");
            dt.Columns.Add("Password");
            dt.Columns.Add("CSDL");

            var fi = new FileInfo(Application.StartupPath + "\\CauHinhCSDL.xml");
            if (!fi.Exists) return;

            dt.ReadXml(Application.StartupPath + "\\CauHinhCSDL.xml");
            try
            {
                if (dt.Rows.Count > 0)
                {
                    txtMayChuSQL.Text = dt.Rows[0]["MayChu"].ToString();
                    cbSuDungTaiKhoanWindows.Checked = (dt.Rows[0]["SuDungTaiKhoanWindows"] == DBNull.Value ? "" : dt.Rows[0]["SuDungTaiKhoanWindows"]).ToString().ToLower() == "true" ? true : false;
                    txtTaiKhoanSQL.Text = dt.Rows[0]["TaiKhoanSQL"].ToString();
                    txtPassword.Text = dt.Rows[0]["Password"].ToString();
                    txtTenCSDL.Text = dt.Rows[0]["CSDL"].ToString();

                    if (!cbSuDungTaiKhoanWindows.Checked)
                    {
                        SqlHelper.ConnectionString = "Data Source=" + txtMayChuSQL.Text + ";Initial Catalog=" + txtTenCSDL.Text + ";User ID=" + txtTaiKhoanSQL.Text + ";Password=" + txtPassword.Text + ";";
                    }
                    else
                    {
                        SqlHelper.ConnectionString = "Data Source=" + txtMayChuSQL.Text + ";Initial Catalog=" + txtTenCSDL.Text + ";Integrated Security=True;";
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
