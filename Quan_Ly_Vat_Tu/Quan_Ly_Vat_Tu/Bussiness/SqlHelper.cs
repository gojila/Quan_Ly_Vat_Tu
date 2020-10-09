using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;
using System.IO;
using System.Data.OleDb;
using Newtonsoft.Json;

namespace Quan_Ly_Vat_Tu.Bussiness
{
    public class SqlHelper
    {
        //Data Source=.\SQLEXPRESS;Initial Catalog=QLK_quang_make;User ID=sa
        //Data Source=.\SQLEXPRESS;Initial Catalog=QLK_quang_make;Integrated Security=True
        //public static string connectionString = "Data Source=.\\SQLEXPRESS2005;Initial Catalog=QLK_quang_make;Integrated Security=SSPI;";

        private static string tenCSDL = "";
        public static string TenCSDL
        {
            get { return tenCSDL; }
            set { tenCSDL = value; }
        }

        private static string mayChu = "";
        public static string MayChu
        {
            get { return mayChu; }
            set { mayChu = value; }
        }

        public static string connectionString = "";
        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public static string GenCode(string tableName, string columnName, string fKey, int length)
        {
            string Result;

            string sql =
            @"
                SELECT MAX(CAST(REPLACE([" + columnName + @"], '" + fKey + @"', '') AS BIGINT))
                FROM   [" + tableName + @"]
                WHERE  [" + columnName + @"] LIKE N'" + @fKey + @"%'
                       AND ISNUMERIC(REPLACE([" + columnName + "], '" + fKey + @"', '')) = 1
            ";

            object ob = ExecuteScalar(sql);
            Result = ob == null ? "0" : ob.ToString();
            if (fKey.Length != 0) Result = Result.Replace(fKey, "").Trim();
            int num = 0;
            if (Int32.TryParse(Result,out num))
            {
                num = Convert.ToInt32(Result);
            }
            num++;
            string format = num.ToString();
            if (format.Length < length)
            {
                while (format.Length < length)
                {
                    format = "0" + format;
                }
            }

            return fKey + format;
        }

        static public string ExecuteScalar(string sql)
        {
            string value = "";
            
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    value = cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return value;
        }

        public DataTable ExecuteDataTable(string sql, string[] mypara, object[] myvalue)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                try
                {
                    if (mypara != null && myvalue != null)
                    {
                        for (int i = 0; i < mypara.Length; i++)
                        {
                            cmd.Parameters.Add(new SqlParameter(mypara[i], myvalue[i]));
                        }
                    }

                    conn.Open();
                    dt.Load(cmd.ExecuteReader());
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return dt;
        }

        public string ExecuteNonQuery(string sql, string[] mypara, object[] myvalue)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;

                try
                {
                    for (int i = 0; i < mypara.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(mypara[i], myvalue[i]));
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return "OK";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return "NOT OK";
                }
            }
        }

        public string ExecuteNonQuery(SqlTransaction transaction, string sql, string[] mypara, object[] myvalue)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;

                try
                {
                    for (int i = 0; i < mypara.Length; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter(mypara[i], myvalue[i]));
                    }
                    conn.Open();
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();
                    conn.Close();

                    return "OK";
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();
                    MessageBox.Show(ex.Message);
                    return "NOT OK";
                }
            }
        }

        public DataTable ReadFileExcel(string FilePath, string Extension, string isHDR)
        {
            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Không tìm thấy file dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string conStr = "";
                switch (Extension)
                {
                    case ".xls": //Excel 97-03
                        conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
                        break;
                    case ".xlsx": //Excel 07
                        conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
                        break;
                }
                conStr = String.Format(conStr, FilePath, isHDR);
                OleDbConnection connExcel = new OleDbConnection(conStr);
                OleDbCommand cmdExcel = new OleDbCommand();
                OleDbDataAdapter oda = new OleDbDataAdapter();
                DataTable dt = new DataTable();
                cmdExcel.Connection = connExcel;

                //Get the name of First Sheet
                connExcel.Open();
                DataTable dtExcelSchema;
                dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                connExcel.Close();

                //Read Data from First Sheet
                connExcel.Open();
                cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";
                oda.SelectCommand = cmdExcel;
                oda.Fill(dt);
                connExcel.Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(JsonConvert.SerializeObject(ex), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
