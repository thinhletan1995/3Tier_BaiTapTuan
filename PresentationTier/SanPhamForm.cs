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
        string strMasp = "";

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
            cboDanhMuc.ValueMember = "MaDM";

            cboDanhMuc.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            strMasp = "";
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
            int soluong;
            int dongia;
            if (txtGia.Text == "" || txtMaSP.Text == "" || txtSoLuong.Text == "" || txtTenSp.Text == "" || txtXuatXu.Text == "")
            {
                MessageBox.Show("Vui long nhap du lieu con thieu");
            }
            else if (!int.TryParse(txtSoLuong.Text, out soluong))
            {
                MessageBox.Show("Vui long nhap lai So Luong.");
            }
            else if (!int.TryParse(txtGia.Text, out dongia))
            {
                MessageBox.Show("Vui long nhap lai Gia.");
            }
            else
            {
                SanPham sp = new SanPham(txtMaSP.Text, txtTenSp.Text, soluong, dongia, txtXuatXu.Text, cboDanhMuc.SelectedValue.ToString());
                if (objSP.AddSanPham(sp))
                {
                    MessageBox.Show("Thanh Cong");
                    dataGridView1.DataSource = objSP.GetSanPhamByMADM(MainForm.strMaDanhMuc_Chon);
                }
                else
                {
                    MessageBox.Show("That Bai");
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            int soluong;
            int dongia;
            if(!int.TryParse(txtSoLuong.Text,out soluong))
            {
                MessageBox.Show("Vui long nhap lai So Luong.");
            }
            else if (!int.TryParse(txtGia.Text, out dongia))
            {
                MessageBox.Show("Vui long nhap lai Gia.");
            }
            else
            {
                sp.MaSanPham = txtMaSP.Text;
                sp.SoLuong = soluong;
                sp.DonGia = dongia;
               
                sp.XuatXu = txtXuatXu.Text;
                sp.TenSanPham = txtTenSp.Text;
                sp.MaDanhMuc = cboDanhMuc.SelectedValue.ToString();
                if (objSP.UpdateSanPham(sp,strMasp))
                {
                    MessageBox.Show("Thanh Cong");
                    dataGridView1.DataSource = objSP.GetSanPhamByMADM(MainForm.strMaDanhMuc_Chon);
                }
                else
                {
                    MessageBox.Show("That Bai");
                }
            }
        }
    }
}
