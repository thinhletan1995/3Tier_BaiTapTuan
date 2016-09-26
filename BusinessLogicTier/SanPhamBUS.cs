using System;
using DataAcessTier;
using DTO;
using System.Data;

namespace BusinessLogicTier
{
    public class SanPhamBUS
    {
        SanPhamDAO objSP = new DataAcessTier.SanPhamDAO();

        public SanPham GetSanPhamByMASP(string strmasp)
        {
            return objSP.GetSanPhamByMASP(strmasp);
        }
        public DataTable GetSanPhamByMADM(string strmadm)
        {
            return objSP.GetSanPhamByMADM(strmadm);
        }

        public string GetTenDanhMuc(string strmadm)
        {
            return objSP.GetTenDanhMuc(strmadm);
        }

        public bool AddSanPham(SanPham sp)
        {
            return objSP.AddSanPham(sp);
        }
    }
}
