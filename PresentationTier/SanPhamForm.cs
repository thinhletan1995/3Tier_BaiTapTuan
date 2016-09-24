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
using DTO;

namespace PresentationTier
{
    public partial class SanPhamForm : Form
    {
        DanhMucBUS objDM = new DanhMucBUS();
        SanPhamBUS objSP = new SanPhamBUS();
        DataTable tbSP;

        public SanPhamForm()
        {
            InitializeComponent();
        }

        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            string strMaDM = MainForm.strMaDanhMuc_Chon;
            tbSP = objSP.GetSanPhamByMADM(strMaDM);
            dataGridView1.DataSource = tbSP;

            cboDanhMuc.DataSource = objDM.GetDanhMuc();
            cboDanhMuc.DisplayMember = "TenDM";
            cboDanhMuc.ValueMember = "MaDN";

            cboDanhMuc.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strMasp = "";
            if ((strMasp = dataGridView1.CurrentRow.Cells[0].Value.ToString()) != "")
            {
                SanPham sp = objSP.GetSanPhamByMASP(strMasp);

                txtMaSP.Text = sp.MaSanPham;
                txtTenSp.Text = sp.TenSanPham;
                txtSoLuong.Text = sp.SoLuong.ToString();
                txtGia.Text = sp.DonGia.ToString();
                txtXuatXu.Text = sp.XuatXu;
                cboDanhMuc.SelectedValue = sp.MaDanhMuc;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtSoLuong.Text);
            int dg = Convert.ToInt32(txtGia.Text);

            SanPham sp = new SanPham(txtMaSP.Text, txtTenSp.Text, s1, dg, txtXuatXu.Text, cboDanhMuc.SelectedValue.ToString());
            if(objSP.AddSanPham(sp))
            {
                MessageBox.Show("Thanh Cong");

                dataGridView1.DataSource = objSP.GetSanPhamByMADM(MainForm.strMaDanhMuc_Chon);
            }
            else
            {
                MessageBox.Show("That Bai");
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
