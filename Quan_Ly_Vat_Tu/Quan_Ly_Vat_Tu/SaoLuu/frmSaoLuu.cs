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
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace Quan_Ly_Vat_Tu.SaoLuu
{
    public partial class frmSaoLuu : Form
    {
        public frmSaoLuu()
        {
            InitializeComponent();
            txtTenTapTin.Text = SqlHelper.TenCSDL + "_" + String.Format("{0:dd_MM_yy_hh_mm.bak}", DateTime.Now);
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
//            try
//            {
//                //string sqlBackup = "BACKUP DATABASE [UITGPP] TO DISK='D:\\backupUITGPP.bak'";

//                string sql =
//                @"
//                    USE [master]
//                    BACKUP DATABASE [" + SqlHelper.TenCSDL + @"] TO DISK = @path
//                ";


//                SqlConnection con =new SqlConnection(SqlHelper.ConnectionString);
//                con.Open();
//                SqlCommand cmd = new SqlCommand(sql, con);
//                cmd.Parameters.Add(new SqlParameter("@path", txtDuongDan.Text + "\\" + txtTenTapTin.Text));
//                cmd.ExecuteNonQuery();
//                con.Close();
//                MessageBox.Show("Đã backup cơ sở dữ liệu");
//            }
//            catch (SqlException ex)
//            {
//                MessageBox.Show(ex.Message, "Backup Database");
//                return;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//                return;
//            }

            

            try
            {
                progressBar1.Value = 0;
                progressBar1.Refresh();

                progressBarControl1.EditValue = 0;
                progressBarControl1.Refresh();

                SqlConnection sqlConn = new SqlConnection(SqlHelper.ConnectionString);
                ServerConnection conn = new ServerConnection(sqlConn);
                Server srv = new Server(conn);
                Database database = srv.Databases[SqlHelper.TenCSDL];
                Backup backup = new Backup();
                backup.Action = BackupActionType.Database;
                backup.Database = database.Name;
                backup.Devices.AddDevice(txtDuongDan.Text + "\\" + txtTenTapTin.Text, DeviceType.File);
                backup.PercentCompleteNotification = 10;
                backup.PercentComplete += new PercentCompleteEventHandler(ProgressEventHandler);
                backup.SqlBackup(srv);
                MessageBox.Show("Sao lưu hoàn tất");
            }
            catch (Exception ex)
            {
                //dbBackup.Abort();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //sqlConn.Close();
            }
        }

        void ProgressEventHandler(object sender, PercentCompleteEventArgs e)
        {
            //Console.WriteLine(e.Percent);
            //progressBarControl1.
            progressBar1.Value = e.Percent;
            progressBar1.Refresh();

            progressBarControl1.EditValue = e.Percent;
            progressBarControl1.Refresh();

        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = folderBrowserDialog.SelectedPath;
            }
        }

        bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtTenTapTin.Text))
            {
                MessageBox.Show("Tên tập tin không được rỗng.","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtDuongDan.Text))
            {
                MessageBox.Show("Đường dẫn không được rỗng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
