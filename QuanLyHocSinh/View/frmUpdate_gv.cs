using QuanLyHocSinh.Controller;
using QuanLyHocSinh.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmUpdate_gv : Form
    {
        private Form1 frmMain;
        private Controllers control;
        private GiaoVien gv;
        //private String str;
        public frmUpdate_gv()
        {
            InitializeComponent();
        }
    
        public frmUpdate_gv(GiaoVien gv, Form1 frmMain)
        {
            InitializeComponent();
            this.gv = gv;
            this.frmMain = frmMain;
        }

        private void frmUpdate_gv_Load(object sender, EventArgs e)
        {
            txtMa.Text = gv.Ma;
            txtTen.Text = gv.Ten;
            if (gv.GioiTinh == 1)
            {
                rdbnam.Checked = true;
            }
            else rdbnu.Checked = true;
            if (gv.NgaySinh != null)
                dtpngaysinh.Text = gv.NgaySinh.ToString();
            txtLuong.Text = gv.Luong.ToString();
            txtEmail.Text = gv.Email;
            cbbBoMon.DataSource = (new Controllers()).getBoMon();
            cbbBoMon.Text = gv.BoMonMa;


            txtDiaChi.Text = gv.DiaChi;
            txtHocHam.Text = gv.HocHam;
            txtHocVi.Text = gv.HocVi;
            txtNhiemVu.Text = gv.NhiemVu;
            txtVaiTro.Text = gv.VaiTro;
            txtSodt.Text = gv.SoDienThoai;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            gv.Ma = txtMa.Text;
            gv.Ten = txtTen.Text.ToString().Trim();
            gv.NgaySinh = DateTime.Parse(dtpngaysinh.Value.ToShortDateString());
            if (rdbnam.Checked)
                gv.GioiTinh = 1;
            else gv.GioiTinh = 0;
           gv.SoDienThoai = txtSodt.Text.ToString().Trim();
            gv.Email = txtEmail.Text.ToString().Trim();
            Double luong = 0;
            if (double.TryParse(txtLuong.Text.ToString().Trim(), out luong))
            {
                gv.Luong = luong;
            }
            gv.Luong = luong;
       
            gv.NhiemVu = txtNhiemVu.Text.ToString().Trim();
            gv.VaiTro = txtVaiTro.Text.ToString().Trim();
            gv.HocHam = txtHocHam.Text.ToString().Trim(); 
            gv.HocVi = txtHocVi.Text.ToString().Trim();
            gv.DiaChi = txtDiaChi.Text.ToString().Trim();
            gv.BoMonMa = (new Controllers()).getMaBoMon(cbbBoMon.Text.ToString().Trim());

            (new Controllers()).update_gv(gv);
            DialogResult result = MessageBox.Show("Thành công", "Chỉnh sửa", MessageBoxButtons.OK);
            if(result == DialogResult.OK)
            {
                btnThoat_Click(sender, e);
                frmMain = new Form1();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
