using System;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DataAcessTier
{
    public class DBConnection
    {
        protected OleDbConnection conn;
        //protected SqlConnection conn = new SqlConnection("Provider=Microsoft.SqlServerCe.Client.3.5;Data Source=|DataDirectory|\\Database.sdf");

        public DBConnection()
        {
            try
            {
                //conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbSanPham.mdb;Persist Security Info=True");
                conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbSanPham.mdb");
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
