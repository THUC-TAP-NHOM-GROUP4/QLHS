﻿using QuanLyHocSinh.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinh.Model;
using QuanLyHocSinh.View;

namespace QuanLyHocSinh
{
    public partial class Form1 : Form
    {
        Controllers _control = new Controllers();
        frmSua frmSua = new frmSua();
        frmUpdate_gv frmUpdate_gv = new frmUpdate_gv();
        AddHocSinh frm_AddHS;
        AddGV frm_AddGV;

        LopHocPhan _lophocphan = new LopHocPhan();

        public Form1()
        {
            InitializeComponent();
            dtgDanhSachGV.DataSource = _control.getListGiaoVien();
            dtgDanhSachHS.DataSource = _control.getListHocSinh();

        }
        public void Loadd()
        {
            Load_gv();
            Load_hs();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_gv();
            Load_hs();
            Load_quanly();


        }
        private void Load_gv()
        {

            dtgDanhSachGV.Columns["ma"].HeaderText = "Mã";
            dtgDanhSachGV.Columns["ten"].HeaderText = "Họ tên";
            dtgDanhSachGV.Columns["ngaysinh"].HeaderText = "Ngày sinh";

            dtgDanhSachGV.Columns["gioitinh"].HeaderText = "Giới tính";
            dtgDanhSachGV.Columns["vaitro"].HeaderText = "Vai Trò";
            dtgDanhSachGV.Columns["email"].HeaderText = "Email";
            //  dtgDanhSachGV.Columns["sodt"].HeaderText = "Điện thoại";
            dtgDanhSachGV.Columns["Bomonma"].HeaderText = "Mã Bộ Môn";
            dtgDanhSachGV.Columns["Nhiemvu"].HeaderText = "Nhiệm vụ";
            dtgDanhSachGV.Columns["Luong"].HeaderText = "Lương";
            dtgDanhSachGV.Columns["ma"].Width = 100;
            dtgDanhSachGV.Columns["ten"].Width = 200;
            dtgDanhSachGV.Columns["email"].Width = 150;
            dtgDanhSachGV.Columns["gioitinh"].Width = 100;
            dtgDanhSachGV.Columns["ngaysinh"].Width = 100;
            dtgDanhSachGV.Columns["Bomonma"].Width = 100;
            dtgDanhSachGV.Columns["vaitro"].Width = 150;

            dtgDanhSachGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgDanhSachGV.DataSource = _control.getListGiaoVien();
        }
        private void Load_hs()
        {

            dtgDanhSachHS.Columns["ma"].HeaderText = "Mã";
            dtgDanhSachHS.Columns["ten"].HeaderText = "Họ tên";
            dtgDanhSachHS.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dtgDanhSachHS.Columns["gioitinh"].HeaderText = "Giới tính";
            dtgDanhSachHS.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgDanhSachHS.Columns["Lopma"].HeaderText = "Mã lớp học phần";
            dtgDanhSachHS.Columns["email"].HeaderText = "Email";
            dtgDanhSachHS.Columns["dantoc"].HeaderText = "Dân Tộc";
            dtgDanhSachHS.Columns["DienThoai"].HeaderText = "Điện thoại";
            dtgDanhSachHS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dtgDanhSachHS.Columns["ma"].Width = 100;
            //dtgDanhSachHS.Columns["ten"].Width = 200;
            //dtgDanhSachHS.Columns["email"].Width = 200;
            //dtgDanhSachHS.Columns["gioitinh"].Width = 90;
            //dtgDanhSachHS.Columns["ngaysinh"].Width = 100;
            //dtgDanhSachHS.Columns["Lopma"].Width = 150;
            //dtgDanhSachHS.Columns["DiaChi"].Width = 150;
            dtgDanhSachHS.DataSource = _control.getListHocSinh();
        }
        private void Load_quanly()
        {
            dtgQuanLy.DataSource = _control.getList_Lophophan();
            dtgQuanLy.Columns["ma"].HeaderText = "Mã lớp học phần";
            dtgQuanLy.Columns["monhocten"].HeaderText = "Tên môn học";
            dtgQuanLy.Columns["monhocma"].HeaderText = "Mã môn học";
            dtgQuanLy.Columns["hocky"].HeaderText = "Học kỳ";
            dtgQuanLy.Columns["namhoc"].HeaderText = "Năm học";
            dtgQuanLy.Columns["siso"].HeaderText = "Sĩ số";
            dtgQuanLy.Columns["thu"].HeaderText = "Thứ";
            dtgQuanLy.Columns["tiet"].HeaderText = "Tiết";
            dtgQuanLy.Columns["ngaybatdau"].HeaderText = "Ngày bắt đầu";
            dtgQuanLy.Columns["ngayketthuc"].HeaderText = "Ngày kết thúc";
            dtgQuanLy.Columns["ngaythi"].HeaderText = "Ngày thi";
            dtgQuanLy.Columns["giaovienma"].HeaderText = "Giáo viên mã";
            dtgQuanLy.Columns["giaovienten"].HeaderText = "Giáo viên";
            dtgQuanLy.Columns["hocky"].Width = 70;
            dtgQuanLy.Columns["siso"].Width = 55;
            dtgQuanLy.Columns["thu"].Width = 45;
            dtgQuanLy.Columns["tiet"].Width = 45;
            dtgQuanLy.Columns["giaovienten"].Width = 150;
            dtgQuanLy.Columns["monhocten"].Width = 150;
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
        private string str { get; set; }
        HocSinh hc = new HocSinh();
        private void dtgDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hc.Ma = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[0].Value.ToString().Trim();
            hc.Ten = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[1].Value.ToString().Trim();
            hc.NgaySinh = DateTime.Parse(dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[3].Value.ToString().Trim());
            hc.GioiTinh = int.Parse(dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[2].Value.ToString().Trim());
            hc.Email = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[4].Value.ToString().Trim();
            hc.DienThoai = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[6].Value.ToString().Trim();
            hc.LopMa = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[7].Value.ToString().Trim();

            str = hc.Ma + hc.Ten + hc.GioiTinh + hc.NgaySinh + hc.Email + hc.DienThoai + hc.LopMa;

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
            if (DateTime.TryParse(dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[3].Value.ToString(), out ns))
            {
                gv.NgaySinh = ns;
            }
            gv.NgaySinh = ns;
            gv.Email = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[4].Value.ToString();
            //gv.Anh  = (dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[5].Value.ToString()== null) ? 
            //    " ": dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[5].Value.ToString();
            gv.Luong = double.Parse(dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[5].Value.ToString());
            gv.NhiemVu = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[6].Value.ToString();
            gv.VaiTro = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[7].Value.ToString();
            gv.BoMonMa = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[8].Value.ToString();
            // gv.TrangThai = int.Parse(dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[9].Value.ToString());


            //ma, ten, gioitinh, ngaysinh, email, anh, luong, nhiemvu, vaitro, taikhoan, matkhau, hocham, hocvi, sodt, diachi, bomonma

            frmUpdate_gv = new frmUpdate_gv(gv, this);
            frmUpdate_gv.ShowDialog();
            dtgDanhSachGV.DataSource = _control.getListGiaoVien();
        }

        private void btnThemDSGV_Click(object sender, EventArgs e)
        {
            frm_AddGV = new AddGV(this);
            frm_AddGV.ShowDialog();
            update_FormMain();
        }

        private void btnXoaDSGV_Click(object sender, EventArgs e)
        {

            if (this.dtgDanhSachGV.SelectedRows.Count > 0)
            {

                int selectedIndex = dtgDanhSachGV.SelectedRows[0].Index;
                string rowID = dtgDanhSachGV[0, selectedIndex].Value.ToString();
                if (MessageBox.Show("Ban co chac  chan  xoa  giao vien ma " + rowID + "", "Xoa giao vien", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    _control.XoaGV(rowID);
                    dtgDanhSachGV.DataSource = _control.getListGiaoVien();
                }
            }
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
            if (DateTime.TryParse(dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[3].Value.ToString(), out ns))
            {
                hs.NgaySinh = ns;
            }
            hs.NgaySinh = ns;
            hs.Email = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[4].Value.ToString();
            hs.DanToc = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[5].Value.ToString();

            hs.DienThoai = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[6].Value.ToString();
            hs.LopMa = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[7].Value.ToString();
            hs.DiaChi = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[8].Value.ToString();
            frmSua = new frmSua(hs, this);
            frmSua.ShowDialog();
            dtgDanhSachHS.DataSource = _control.getListHocSinh();
        }

        public void update_FormMain()
        {
            dtgDanhSachHS.DataSource = _control.getListHocSinh();
        }

        private void btnThemDSHS_Click(object sender, EventArgs e)
        {

            frm_AddHS = new AddHocSinh(this);
            frm_AddHS.ShowDialog();
            update_FormMain();
        }

        private void btnXoaDSHS_Click(object sender, EventArgs e)
        {

            if (this.dtgDanhSachHS.SelectedRows.Count > 0)
            {

                int selectedIndex = dtgDanhSachHS.SelectedRows[0].Index;
                string rowID = dtgDanhSachHS[0, selectedIndex].Value.ToString();
                if (MessageBox.Show("Ban co chac  chan  xoa  hoc sinh ma " + rowID + "", "Xoa hoc sinh", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _control.XoaHS(rowID);
                    update_FormMain();
                }
            }

        }

        private void btnTimKiemDSHS_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch("1");
            frm.ShowDialog();
        }

        private void btnLuuDSHS_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemDSGV_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch("2");
            frm.ShowDialog();
        }



        private string st { get; set; }

        private void dtgDanhSachGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv.Ma = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[0].Value.ToString().Trim();
            gv.Ten = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[1].Value.ToString().Trim();
            gv.NgaySinh = DateTime.Parse(dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[3].Value.ToString().Trim());
            gv.GioiTinh = int.Parse(dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[2].Value.ToString().Trim());
            gv.Email = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[4].Value.ToString().Trim();
            gv.VaiTro = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[5].Value.ToString().Trim();
            gv.Luong = float.Parse(dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[6].Value.ToString().Trim());
            gv.BoMonMa = dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[7].Value.ToString().Trim();
            //  gv.TrangThai = int.Parse(dtgDanhSachGV.Rows[dtgDanhSachGV.CurrentRow.Index].Cells[8].Value.ToString().Trim());
            st = gv.Ma + gv.Ten + gv.GioiTinh + gv.NgaySinh + gv.Email + gv.VaiTro + gv.Luong + gv.BoMonMa;
        }

        private void linklabelHD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControlChinh.SelectedTab = tpHuongDan;
        }

        private void tvStile_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode nName = e.Node;
            string webPage = "";
            webPage = $"{Application.StartupPath}\\HeThong.html";
            if (webPage != "")
            {
                wbStile.Navigate(webPage);
            }
        }

        private void dtgQuanLy_DoubleClick(object sender, EventArgs e)
        {
            _lophocphan = new LopHocPhan();
            _lophocphan.Ma = dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[0].Value.ToString().Trim();
            _lophocphan.MonHocTen = dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[1].Value.ToString().Trim();
            _lophocphan.MonHocMa = dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[2].Value.ToString().Trim();
            _lophocphan.HocKy = int.Parse(dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[3].Value.ToString().Trim());
            _lophocphan.NamHoc = dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[4].Value.ToString().Trim();
            _lophocphan.SiSo = int.Parse(dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[5].Value.ToString().Trim());
            _lophocphan.Thu = dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[6].Value.ToString().Trim();
            _lophocphan.Tiet = int.Parse(dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[7].Value.ToString().Trim());
            _lophocphan.NgayBatDau = DateTime.Parse(dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[8].Value.ToString().Trim());
            _lophocphan.NgayKetThuc = DateTime.Parse(dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[9].Value.ToString().Trim());
            _lophocphan.NgayThi = DateTime.Parse(dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[10].Value.ToString().Trim());
            _lophocphan.GiaoVienMa = dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[11].Value.ToString().Trim();
            _lophocphan.GiaoVienTen = dtgQuanLy.Rows[dtgQuanLy.CurrentRow.Index].Cells[12].Value.ToString().Trim();

            tbQuanLyGD_MaLHP.Text = _lophocphan.Ma;
            tbQuanLyGD_TenMonHoc.Text = _lophocphan.MonHocTen;
            tbQuanLyGD_HocKy.Text = _lophocphan.HocKy + "";
            tbQuanLyGD_SiSo.Text = _lophocphan.SiSo + "";
            tbQuanLyGD_NamHoc.Text = _lophocphan.NamHoc;
            tbQuanLyGD_ThuTiet.Text = "Thứ" + _lophocphan.Thu + " " + _lophocphan.Tiet;
            tbQuanLyGD_NgayBatDau.Text = _lophocphan.NgayBatDau.ToShortDateString();
            tbQuanLyGD_NgayKetThuc.Text = _lophocphan.NgayKetThuc.ToShortDateString();
            tbQuanLyGD_NgayThi.Text = _lophocphan.NgayThi.ToShortDateString();
            tbQuanLyGD_GiaoVienMa.Text = _lophocphan.GiaoVienMa;
            tbQuanLyGD_GiaoVienTen.Text = _lophocphan.GiaoVienTen;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LopHocPhan lhp = new LopHocPhan();
            _lophocphan.NgayBatDau = DateTime.Parse(tbQuanLyGD_NgayBatDau.Text.ToString());
            _lophocphan.NgayKetThuc = DateTime.Parse(tbQuanLyGD_NgayKetThuc.Text.ToString());
            _lophocphan.NgayThi = DateTime.Parse(tbQuanLyGD_NgayThi.Text.ToString());
            _lophocphan.SiSo = int.Parse(tbQuanLyGD_SiSo.Text.ToString());
            String magiaovien = tbQuanLyGD_GiaoVienMa.Text.ToString();
            String tengiaovien = tbQuanLyGD_GiaoVienTen.Text.ToString();
            if(isChecked(magiaovien, tengiaovien))
            {
                _lophocphan.GiaoVienMa = magiaovien;
                _lophocphan.GiaoVienTen = tengiaovien;
            }
            if (MessageBox.Show("Cập nhật lớp học phần? ", "Cập nhật thông tin", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _control.UpdateLopHocPhan(_lophocphan);
                dtgQuanLy.DataSource = _control.getList_Lophophan();
            }
          
        }

        private bool isChecked(String magiaovien, String tengiaovien)
        {
            return _control.isChecked_GV(magiaovien, tengiaovien);
        }
        //thoát khỏi danh sách  quản lý
        private void btnThoat_Click(object sender, EventArgs e)
        {
            tabControlChinh.SelectTab(tpTrangChu);
        }

        private void tbQuanLyGD_SiSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbQuanLyGD_TinChi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }
}
