using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quan_Ly_Vat_Tu.Bussiness;

namespace Quan_Ly_Vat_Tu.PhucHoi
{
    public partial class frmPhucHoi : Form
    {
        public frmPhucHoi()
        {
            InitializeComponent();
            txtCoSoDuLieu.Text = SqlHelper.TenCSDL;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
            {
                return;
            }
            
            try
            {  
                string path = txtTenTapTin.Text;
                string sqlRestore  = "Use master Restore Database [" + txtCoSoDuLieu.Text + "] from disk='" + path + "'";

                /*
                 * restore filelistonly from disk='D:\\Database\\Quan_Ly_Vat_Tu_08_11_13_03_25.bak'
                    USE [master] 
                    RESTORE DATABASE [Quan_Ly_Vat_Tu] 
                    FROM DISK = 'D:\\Database\\Quan_Ly_Vat_Tu_08_11_13_03_25.bak'
                    WITH 
                    MOVE 'QLK_quang_make' 
                    TO 'D:\DO_AN\Quan_Ly_Vat_Tu.mdf',
                    MOVE 'QLK_quang_make_log' 
                    TO 'D:\DO_AN\Quan_Ly_Vat_Tu_log.ldf',
                    REPLACE
                 */

                SqlConnection con  = new SqlConnection(SqlHelper.ConnectionString);
                con.Open();
               
                SqlCommand cmd =  new SqlCommand(sqlRestore, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Database da duoc restore ");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex .Message, "Restore Database");
                return;
            }
            catch (Exception ex)
            {

            }
        }

        bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtCoSoDuLieu.Text))
            {
                MessageBox.Show("Tên tập tin không được rỗng.","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtTenTapTin.Text))
            {
                MessageBox.Show("Đường dẫn không được rỗng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txtTenTapTin_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = @"Backup File(*.bak)|*.bak|All File(*.*)|*.*",
                FilterIndex = 0
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //var cnn = new SqlConnection(_connectionString);
                //cnn.Open();
                //var conn = new ServerConnection(cnn);
                //var myServer = new Server(conn);

                //var currentDb = myServer.Databases[_database];
                //if (currentDb != null)
                //{
                //    txtBackupFolder.Text = _database;
                //}
                txtTenTapTin.Text = fileDialog.FileName;
                //cnn.Close();
            }

            //var folderBrowserDialog = new FolderBrowserDialog();
            //if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            //{
            //    txtTenTapTin.Text = folderBrowserDialog.SelectedPath;
            //}
        }
    }
}
