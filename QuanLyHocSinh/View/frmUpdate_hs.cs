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
    public partial class frmUpdate_hs : Form
    {
        Controllers control = new Controllers();
        HocSinh hs = new HocSinh();
        Form1 frmMain;

        public frmUpdate_hs()
        {
            InitializeComponent();
        }
        public frmUpdate_hs(HocSinh hs, Form1 frmMain)
        {
            InitializeComponent();
            this.hs = hs;
            this.frmMain = frmMain;
        }
        private void frmUpdate_hs_Load(object sender, EventArgs e)
        {
            txtMa.Text = hs.Ma;
            txtTen.Text = hs.Ten;
            if (hs.GioiTinh == 1)
            {
                rdbnam.Checked = true;
            }
            else rbdnu.Checked = true;
            if (hs.NgaySinh != null)
                dtpngaysinh.Text = hs.NgaySinh.ToString();
            
            txtEmail.Text = hs.Email;
            txtDienThoai.Text = hs.DienThoai;
            txtDoiTuong.Text = hs.DoiTuong;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            hs.Ma = txtMa.Text;
            hs.Ten = txtTen.Text.ToString().Trim();
            hs.NgaySinh = DateTime.Parse(dtpngaysinh.Value.ToShortDateString());
            if (rdbnam.Checked)
                hs.GioiTinh = 1;
            else hs.GioiTinh = 0;
            hs.DienThoai= txtDienThoai.Text.ToString().Trim();
            hs.Email = txtEmail.Text.ToString().Trim();
            hs.DoiTuong = txtDoiTuong.Text.ToString().Trim();
           

            (new Controllers()).update_hs(hs);
            DialogResult result = MessageBox.Show("Thành công", "Chỉnh sửa", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                btnThoat_Click(sender, e);
                frmMain = new Form1();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
