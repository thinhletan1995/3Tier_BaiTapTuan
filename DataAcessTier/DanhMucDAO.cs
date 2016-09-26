using System;
using DTO;
using System.Data.OleDb;
using System.Data;

namespace DataAcessTier
{
    public class DanhMucDAO: DBConnection
    {
        public DanhMucDAO() : base() { }
        public bool DeleteDanhMuc(string madm)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                OleDbCommand cmd = new OleDbCommand("DELETE FROM tbDanhMuc Where madm = @madm", conn);
                cmd.Parameters.Add("@madm", OleDbType.BSTR).Value = madm;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
                throw;
            }
        }

        public DataTable GetAllDanhMuc()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT FROM tbDanhMuc ORDER BY MaDM ASC", conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
            
        }
    }
}
