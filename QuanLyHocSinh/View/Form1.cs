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
    public partial class Form1 : Form
    {
        Controllers control = new Controllers();
        frmUpdate_hs frmUpdate_hs = new frmUpdate_hs();
        frmUpdate_gv frmUpdate_gv = new frmUpdate_gv();
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            //GV
            dtgDanhSachHS.DataSource = control.getListHocSinh();
            dtgDanhSachHS.Columns["ma"].HeaderText = "Mã";
            dtgDanhSachHS.Columns["ten"].HeaderText = "Họ tên";
            dtgDanhSachHS.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dtgDanhSachHS.Columns["doituong"].HeaderText = "Đối tượng";
            dtgDanhSachHS.Columns["gioitinh"].HeaderText = "Giới tính";
            dtgDanhSachHS.Columns["Lopma"].HeaderText = "Mã lớp học phần";
            dtgDanhSachHS.Columns["email"].HeaderText = "Email";
            dtgDanhSachHS.Columns["DienThoai"].HeaderText = "Điện thoại";
            dtgDanhSachHS.Columns["ma"].Width = 60;
            dtgDanhSachHS.Columns["ten"].Width = 150;
            dtgDanhSachHS.Columns["email"].Width = 150;
            dtgDanhSachHS.Columns["gioitinh"].Width = 50;
            dtgDanhSachHS.Columns["ngaysinh"].Width = 100;
            dtgDanhSachHS.Columns["Lopma"].Width = 150;
            /*select gv.ma, gv.Ten, gv.Gioitinh, gv.Ngaysinh, gv.Email, gv.Luong, gv.Nhiemvu, gv.Vaitro, 
gv.Taikhoan, gv.Matkhau, gv.Hocham, gv.Hocvi, gv.sodt, gv.diachi, bm.ten from giaovien gv inner join Bomon bm
on gv.Bomonma = bm.Ma*/
            //HS
            dtgDanhSachGV.DataSource = control.getListGiaoVien();
            dtgDanhSachGV.Columns["ma"].HeaderText = "Mã";
            dtgDanhSachGV.Columns["ten"].HeaderText = "Họ tên";
            dtgDanhSachGV.Columns["gioitinh"].HeaderText = "Giới tính";
            dtgDanhSachGV.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dtgDanhSachGV.Columns["email"].HeaderText = "Email";
            dtgDanhSachGV.Columns["luong"].HeaderText = "Lương";
            dtgDanhSachGV.Columns["nhiemvu"].HeaderText = "Nhiệm vụ";
            dtgDanhSachGV.Columns["vaitro"].HeaderText = "Vai trò";
            dtgDanhSachGV.Columns["taikhoan"].HeaderText = "Tài khoản";
            dtgDanhSachGV.Columns["matkhau"].HeaderText = "Mật khẩu";
            dtgDanhSachGV.Columns["hocham"].HeaderText = "Học hàm";
            dtgDanhSachGV.Columns["hocvi"].HeaderText = "Học vị";
            dtgDanhSachGV.Columns["sodienthoai"].HeaderText = "Số điện thoại";
            dtgDanhSachGV.Columns["diachi"].HeaderText = "Địa chỉ";
           // dtgDanhSachGV.Columns["tenbomon"].HeaderText = "Tên bộ môn";
        }

        private void linklabelQLHS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //var browser = new WebBrowser();
            //browser.Dock = DockStyle.Fill;
            //tpDSHS.Controls.Add(browser);

            //tabControlChinh.TabPages.Add(tpDSHS);
            tabControlChinh.SelectedTab = tpDSHS;
        }

        private void linklabelQLGV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var browser = new WebBrowser();
            //browser.Dock = DockStyle.Fill;
            //tpQLGV.Controls.Add(browser);
            //tabControlChinh.TabPages.Add(tpQLGV);
            tabControlChinh.SelectedTab = tpQLGV;
        }

        private void btnThoatDSHS_Click(object sender, EventArgs e)
        {
            tabControlChinh.SelectedTab = tpTrangChu;
        }

        private void btnThoatDSGV_Click(object sender, EventArgs e)
        {
            tabControlChinh.SelectedTab = tpTrangChu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControlChinh.SelectedTab = tpDSHS;
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            tabControlChinh.SelectedTab = tpQLGV;
        }

        private void btnSuaDSGV_Click(object sender, EventArgs e)
        { 
            GiaoVien gv = new GiaoVien();
            gv.Ma = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[0].Value.ToString();
            gv.Ten = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[1].Value.ToString();
            int gioitinh = int.Parse(dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[2].Value.ToString());
           
            DateTime ns = DateTime.Now;
            if(DateTime.TryParse(dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[3].Value.ToString(), out ns)){
                gv.NgaySinh = ns;
            }
            gv.NgaySinh = ns;
            gv.Email = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[4].Value.ToString();
            //gv.Anh  = (dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[5].Value.ToString()== null) ? 
            //    " ": dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[5].Value.ToString();
            gv.Luong = double.Parse(dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[6].Value.ToString());
            gv.NhiemVu =dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[7].Value.ToString();
            gv.VaiTro= dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[8].Value.ToString();
            gv.TaiKhoan = (dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[9].Value.ToString());
            gv.MatKhau= dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[10].Value.ToString();
            gv.HocHam = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[11].Value.ToString();
            gv.HocVi = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[12].Value.ToString();
            gv.SoDienThoai = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[13].Value.ToString();
            gv.DiaChi = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[14].Value.ToString();
            gv.BoMonMa = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[15].Value.ToString();

            //ma, ten, gioitinh, ngaysinh, email, anh, luong, nhiemvu, vaitro, taikhoan, matkhau, hocham, hocvi, sodt, diachi, bomonma

            frmUpdate_gv = new frmUpdate_gv(gv, this);
            frmUpdate_gv.ShowDialog();
            dtgDanhSachGV.DataSource = control.getListGiaoVien();
           
        }

        private void btnThemDSGV_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaDSGV_Click(object sender, EventArgs e)
        {

        }
        
        private void linklabelQLGD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControlChinh.SelectTab(tpQLGiangDay);
        }

        private void btnGiangDay_Click(object sender, EventArgs e)
        {
            tabControlChinh.SelectTab(tpQLGiangDay);
        }

        private void btnSuaDSHS_Click(object sender, EventArgs e)
        {
            //Ma, Ten, Gioitinh, Ngaysinh , Email, Doituong, Sodienthoai, Lopma
            HocSinh hs = new HocSinh();
            hs.Ma = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[0].Value.ToString();
            hs.Ten = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[1].Value.ToString();
            int gioitinh = int.Parse(dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[2].Value.ToString());

            DateTime ns = DateTime.Now;
            if (DateTime.TryParse(dtgDanhSachGV.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[3].Value.ToString(), out ns))
            {
                hs.NgaySinh = ns;
            }
            hs.NgaySinh = ns;
            hs.DoiTuong = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[5].Value.ToString();
            hs.DienThoai = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[6].Value.ToString();
            hs.LopMa= dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[7].Value.ToString();

            frmUpdate_hs = new frmUpdate_hs(hs, this);
            frmUpdate_hs.ShowDialog();
            dtgDanhSachHS.DataSource = control.getListHocSinh();
        }

        private void dtgDanhSachHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
