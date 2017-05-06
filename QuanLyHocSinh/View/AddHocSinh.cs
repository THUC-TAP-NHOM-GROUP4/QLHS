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
    public partial class AddHocSinh : Form
    {
        Controllers control = new Controllers();
        Form form1 = new Form();
        public AddHocSinh(Form form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkAdd())
            {
                HocSinh hs = new HocSinh();
                hs.Ten = txtHoTenHS.Text.ToString().Trim();
                hs.LopMa = txtLop.Text.ToString().Trim();
                hs.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
                if (rdbnam.Checked) hs.GioiTinh = 1;
                else hs.GioiTinh = 0;
                hs.DanToc = txtDanToc.Text.ToString().Trim();
                hs.DiaChi = txtDiaChi.Text.ToString().Trim();
                hs.Email = txtEmail.Text.ToString().Trim();
                hs.DienThoai = txtSDT.Text.ToString().Trim();

                //    ma, ten, gioitinh, ngaysinh , Email,anh , luong , nhiemvu, Vaitro, Bomonma , trangthai
                (new Controllers()).ThemHS(hs);
                DialogResult result = MessageBox.Show("Thành công", "Chỉnh sửa", MessageBoxButtons.OK);
            
                if (result == DialogResult.OK)
                {
                    btnThoat_Click(sender, e);
                    form1 = new Form1();
                }


               
            }

        }

        private bool checkAdd()
        {
            return true;
        }

       
    }
}