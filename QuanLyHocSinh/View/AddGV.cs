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
                gv.Ten = txtHoTenGV.Text.ToString().Trim();
                if ( rbdNam.Checked) gv.GioiTinh = 1;
                else gv.GioiTinh = 0;
                gv.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
                gv.Email = txtEmail.Text.ToString().Trim();
               // gv.Anh = txtanh.Text.ToString().Trim();
                gv.Luong = double.Parse(txtluong.Text.ToString().Trim());
                gv.NhiemVu = txtnhiemvu.Text.ToString().Trim();
                gv.VaiTro = txtVaiTro.Text.ToString().Trim();
                gv.BoMonMa = control.getMaBoMon(cbbBoMon.Text);
                gv.TrangThai = int.Parse(txttrangthai.Text.ToString().Trim());
                
                (new Controllers()).ThemGV(gv);
                DialogResult result = MessageBox.Show("Thành công", "Chỉnh sửa", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    btnThoat_Click(sender, e);
                    form1 = new Form1();
                }

                
            }
        }
    //    ma, ten, gioitinh, ngaysinh , Email,anh , luong , nhiemvu, Vaitro, Bomonma , trangthai


        private bool checkAdd()
        {

            if (txtHoTenGV.Text.Trim().Equals(""))
            {
                erptxtTen.SetError(txtHoTenGV, "Phải nhập họ tên");
                return false;
            }
            erptxtTen.Clear();

            if (!(rbdNam.Checked || rbdNu.Checked))
            {
                erpGioiTinh.SetError(rbdNam, "Chưa nhập Giới Tính");
                return false;
            }
            erpGioiTinh.Clear();

            if (txtEmail.Text.Trim().Equals(""))
            {
                erpEmail.SetError(txtEmail, "Phải nhập Email");
                return false;
            }
            erpEmail.Clear();

            if (txtanh.Text.Trim().Equals(""))
            {
                erpAnh.SetError(txtanh, "Phải nhập Ảnh");
                return false;

            }
            erpAnh.Clear();
            if (txtluong.Text.Trim().Equals(""))
            {
                erpLuong.SetError(txtluong, "Phải nhập Lương bằng số");
                return false;
            }
            erpLuong.Clear();
            if (txtnhiemvu.Text.Trim().Equals(""))
            {
                erpNhiemVu.SetError(txtnhiemvu, "Phải nhập Nhiệm vụ");
                return false;
            }
            erpNhiemVu.Clear();
            if (txtVaiTro.Text.Trim().Equals(""))
            {
                erpVaiTro.SetError(txtVaiTro, "Phải nhập Vai Trò");
                return false;
            }
            erpVaiTro.Clear();
            if (txttrangthai.Text.Trim().Equals(""))
            {
                erpTrangthai.SetError(txttrangthai, "Phải nhập Trạng thái là 0 hoặc 1");
                return false;
            }
            erpTrangthai.Clear();
            return true;

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGV_Load(object sender, EventArgs e)
        {

            cbbBoMon.DataSource = control.getBoMon();

        }
    }
}
