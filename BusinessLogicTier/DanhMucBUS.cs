using System;
using DataAcessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class DanhMucBUS
    {
        DanhMucDAO objDM = new DataAcessTier.DanhMucDAO();

        public DataTable GetDanhMuc()
        {
            return objDM.GetAllDanhMuc();
        }

        public bool DeleteDanhMuc(string madm)
        {
            return objDM.DeleteDanhMuc(madm);
        }
    }
}
