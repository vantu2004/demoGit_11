using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_01
{
    internal class DBconnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        string SqlStr;

        public DBconnection(string sqlStr)
        {
            SqlStr = sqlStr;
        }
        public DataTable Load()
        {
            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(SqlStr, conn);

                adapter.Fill(dtSinhVien);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtSinhVien;
        }
        public void thucThi()
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(SqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
