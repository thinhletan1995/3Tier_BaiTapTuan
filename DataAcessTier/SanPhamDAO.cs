using System;
using DTO;
using System.Data;
using System.Data.OleDb;

namespace DataAcessTier
{
    public class SanPhamDAO: DBConnection
    {
        public SanPhamDAO() : base() { }

        public DataTable GetSanPhamByMADM(string strDM)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tbSanPham WHERE madm = @madm ORDER BY MaSP ASC", conn);
                cmd.Parameters.Add("@madm", OleDbType.BSTR).Value = strDM;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                conn.Close();
                return null;
            }
        }

        public SanPham GetSanPhamByMASP(string strSP)
        {
            SanPham sp = null;
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tbSanPham WHERE masp = @masp ORDER BY MaSP ASC", conn);
                cmd.Parameters.Add("@masp", OleDbType.BSTR).Value = strSP;

                OleDbDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    sp = new SanPham();
                    sp.MaSanPham = rd["MaSp"].ToString();
                    sp.TenSanPham = rd["TenSP"].ToString();
                    sp.SoLuong = (int)rd["SoLuong"];
                    sp.DonGia = (int)rd["DonGia"];
                    sp.XuatXu = rd["XuatXu"].ToString();
                    sp.MaDanhMuc = rd["MaDM"].ToString();
                    rd.Close();
                }

            }
            catch (Exception)
            {

                conn.Close();
            }
            return sp;
        }


        public string GetTenDanhMuc(string strMaDM)

        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tbDanhMuc WHERE madm = @madm ORDER BY MaSP ASC", conn);
                cmd.Parameters.Add("@madm", OleDbType.BSTR).Value = strMaDM;

                OleDbDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    return rd["TenDM"].ToString();
                }
                rd.Close();

            }
            catch (Exception)
            {

                conn.Close();
            }
            return null;
        }
        public bool AddSanPham(SanPham sp)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                OleDbCommand cmd = new OleDbCommand("INSERT INTO tbSanPham VALUES (@masp, @tensp, @soluong,@dongia,@xuatxu,@madm)", conn);
                cmd.Parameters.Add("@masp", OleDbType.BSTR).Value = sp.MaSanPham;
                cmd.Parameters.Add("@tensp", OleDbType.BSTR).Value = sp.TenSanPham;
                cmd.Parameters.Add("@soluong", OleDbType.BSTR).Value = sp.SoLuong;
                cmd.Parameters.Add("@dongia", OleDbType.BSTR).Value = sp.DonGia;
                cmd.Parameters.Add("@xuatxu", OleDbType.BSTR).Value = sp.XuatXu;
                cmd.Parameters.Add("@madm", OleDbType.BSTR).Value = sp.MaDanhMuc;
                cmd.ExecuteNonQuery();
                return true;
                
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex);
                return false;
            }
        }
    }



    

    
}
