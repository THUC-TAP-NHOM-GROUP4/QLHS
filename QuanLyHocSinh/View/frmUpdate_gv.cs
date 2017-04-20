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
        private Controllers control;
        private GiaoVien gv;
        private String str;
        public frmUpdate_gv()
        {
            InitializeComponent();
        }
        public frmUpdate_gv(String str)
        {
            InitializeComponent();
            this.gv = new GiaoVien();
            this.str = str;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            // if (txtten.Text == "" || txtsocmnd.Text == "" || txtmaluong.Text == "" || txtemali.Text == "" || txtdienthoai.Text == "" || txtdiachi.Text == "")
            //   MessageBox.Show("Vui lòng xem lại có thể bạn chưa chọn đối tượng");
            //  else
            // {
            //    if (txtten.Text != "" || txtsocmnd.Text != "" || txtmaluong.Text != "" || txtemali.Text != "" || txtdienthoai.Text != "" || txtdiachi.Text != "")
            //    {
            gv.Ma = txtMa.Text;
            gv.Ten = txtTen.Text.ToString().Trim();
            gv.NgaySinh = DateTime.Parse(dtpngaysinh.Value.ToShortDateString());
            if (rdbnam.Checked)
                gv.GioiTinh = 1;
            else gv.GioiTinh = 0;
            /*select gv.ma, gv.Ten, gv.Gioitinh, gv.Ngaysinh, gv.Email, gv.Luong, gv.Nhiemvu, gv.Vaitro, 
gv.Taikhoan, gv.Matkhau, gv.Hocham, gv.Hocvi, gv.sodt, gv.diachi, bm.ten from giaovien gv inner join Bomon bm
on gv.Bomonma = bm.Ma*/

            gv.SoDienThoai = txtSodt.Text.ToString().Trim();
            gv.Email = txtEmail.Text.ToString().Trim();
            gv.Luong = double.Parse(txtLuong.ToString().Trim());
            gv.NhiemVu = txtNhiemVu.ToString().Trim();
            gv.VaiTro = txtVaiTro.ToString().Trim();
            gv.HocHam = txtHocHam.ToString().Trim(); 
            gv.HocVi = txtHocVi.ToString().Trim();
            gv.DiaChi = txtDiaChi.ToString().Trim();
            gv.BoMonMa = txtBoMon.ToString().Trim();

            control.update_gv(gv.Ma, gv.Ten, gv.GioiTinh, gv.NgaySinh, gv.Email, gv.Luong, gv.NhiemVu,
                gv.VaiTro, gv.TaiKhoan, gv.MatKhau, gv.HocHam, gv.HocVi, gv.SoDienThoai, gv.DiaChi, gv.BoMonMa);
            MessageBox.Show("Thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUpdate_gv_Load(object sender, EventArgs e)
        {
            if (str == null) return;
            string[] str1 = str.Split('_');
            txtMa.Text = str1[0];
            txtTen.Text = str1[1];
            if (str[2].ToString() == "1")
                rdbnam.Checked = true;
            else rdbnu.Checked = true;
            txtEmail.Text = str1[4];
            txtSodt.Text = str1[6];
            
        }
    }
}
