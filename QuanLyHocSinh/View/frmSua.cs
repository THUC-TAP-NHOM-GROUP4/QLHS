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
    public partial class frmSua : Form
    {
        Controllers control = new Controllers();
        HocSinh hs = new HocSinh();
        string str;

        public frmSua()
        {
            InitializeComponent();
        }
        public frmSua(string str)
        {
            InitializeComponent();
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
            hs.Ma = txtMa.Text;
            hs.Ten = txtTen.Text.ToString().Trim();
            hs.NgaySinh = DateTime.Parse(dtpngaysinh.Value.ToShortDateString());
            if (rdbnam.Checked)
                hs.GioiTinh = 1;
            else hs.GioiTinh = 0;
            
            
            hs.DienThoai = txtDienThoai.Text.ToString().Trim();
            hs.DanToc = txtDoiTuong.Text.ToString().Trim();
            hs.LopMa = "L001";
            hs.Email = txtEmail.Text.ToString().Trim();

            control.Sua(hs.Ma, hs.Ten, hs.GioiTinh, hs.NgaySinh, hs.Email, hs.DanToc, hs.DienThoai, hs.LopMa);
            MessageBox.Show("Thành công");
        }

        private void frmSua_Load(object sender, EventArgs e)
        {
            string[] str1 = str.Split('_');
            txtMa.Text = str1[0];
            txtTen.Text = str1[1];
            if (str[2].ToString() == "1")
                rdbnam.Checked = true;
            else rbdnu.Checked = true;
            txtEmail.Text = str1[4];
            txtDienThoai.Text = str1[6];
            txtDoiTuong.Text = str1[5];
            

            //mâ - tên - gioitinh - ngaysinh - email - doituong,sodienthoai, lopma
        }
    }
}
