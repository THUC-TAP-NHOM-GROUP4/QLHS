using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinh.Controller;
using QuanLyHocSinh.Model;

namespace QuanLyHocSinh
{
    public partial class AddGV : Form
    {

        Controllers control = new Controllers();
        Form form1 = new Form();
        public AddGV(Form form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkAdd())
            {
                GiaoVien gv = new GiaoVien();
                gv.Ma = txtMaGV.Text.ToString().Trim();
                gv.Ten = txtHoTenGV.Text.ToString().Trim();
                if ( rbdNam.Checked) gv.GioiTinh = 1;
                else gv.GioiTinh = 0;
                gv.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
                gv.Email = txtEmail.Text.ToString().Trim();
                gv.VaiTro = txtVaiTro.Text.ToString().Trim();
                gv.BoMonMa = txtBoMon.Text.ToString().Trim();

                if (control.ThemGV(gv))
                {
                    this.Close();
                    this.form1.Visible = true;
                }
            }
        }


        private bool checkAdd()
        {
            if(txtBoMon.Text.Trim().Equals(""))
            {
                erpBoMon.SetError(txtBoMon, "Phải Nhập Bộ Môn");
                return false;
            }
            if(txtHoTenGV.Text.Trim().Equals(""))
            {
                erptxtTen.SetError(txtHoTenGV, "Phải nhập họ tên");
            }

            if (txtEmail.Text.Trim().Equals(""))
            {
                erpEmail.SetError(txtEmail, "Phải nhập Email");
            }
            if (txtVaiTro.Text.Trim().Equals(""))
            {
                erpVaiTro.SetError(txtVaiTro, "Phải nhập Vai Trò");
            }

            return true;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
