using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;


namespace PresentationTier
{
    public partial class MainForm : Form
    {
        DanhMucBUS objdm = new DanhMucBUS();

        DataTable tbDanhMuc;

        public static string strMaDanhMuc_Chon = "";

        public MainForm()
        {
            InitializeComponent();
            tbDanhMuc = objdm.GetDanhMuc();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lstDanhMuc.DataSource = tbDanhMuc;
            lstDanhMuc.DisplayMember = "TENDM";
            lstDanhMuc.ValueMember = "MADM";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            strMaDanhMuc_Chon = lstDanhMuc.SelectedValue.ToString();
            SanPhamForm f = new SanPhamForm();
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(objdm.DeleteDanhMuc(lstDanhMuc.SelectedValue.ToString()))
            {
                MessageBox.Show("Thanh Cong");
                lstDanhMuc.DataSource = objdm.GetDanhMuc();
            }
            else
            {
                MessageBox.Show("That Bai");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
