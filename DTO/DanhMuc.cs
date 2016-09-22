using System;

namespace DTO
{
    public class DanhMuc
    {
        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public DanhMuc() { }
        public DanhMuc(string madm, string tendm)
        {
            MaDanhMuc = madm;
            TenDanhMuc = tendm;
        }
    }
}
