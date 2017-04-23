using QuanLyHocSinh.Controller;
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
        Controllers control = new Controllers();
        frmSua frmSua = new frmSua();
        AddHocSinh frm_AddHS;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgDanhSachHS.DataSource = control.getListHocSinh();
            dtgDanhSachHS.Columns["ma"].HeaderText = "Mã";
            dtgDanhSachHS.Columns["ten"].HeaderText = "Họ tên";
            dtgDanhSachHS.Columns["ngaysinh"].HeaderText = "Ngày sinh";
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

            //
            dtgDanhSachGV.DataSource = control.getListGiaoVien();
            dtgDanhSachGV.Columns["ma"].HeaderText = "Mã";
            dtgDanhSachGV.Columns["ten"].HeaderText = "Họ tên";
            dtgDanhSachGV.Columns["ngaysinh"].HeaderText = "Ngày sinh";

            dtgDanhSachGV.Columns["gioitinh"].HeaderText = "Giới tính";
            dtgDanhSachGV.Columns["vaitro"].HeaderText = "Vai Trò";
            dtgDanhSachGV.Columns["email"].HeaderText = "Email";
          //  dtgDanhSachGV.Columns["sodt"].HeaderText = "Điện thoại";
            dtgDanhSachGV.Columns["Bomonma"].HeaderText = "Mã Bộ Môn";
            dtgDanhSachGV.Columns["Nhiemvu"].HeaderText = "Nhiệm vụ";
            dtgDanhSachGV.Columns["Anh"].HeaderText = "ẢNH";
            dtgDanhSachGV.Columns["ma"].Width = 60;
            dtgDanhSachGV.Columns["ten"].Width = 150;
            dtgDanhSachGV.Columns["email"].Width = 150;
            dtgDanhSachGV.Columns["gioitinh"].Width = 50;
            dtgDanhSachGV.Columns["ngaysinh"].Width = 100;
            dtgDanhSachGV.Columns["Bomonma"].Width = 150;

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
            hc.Email= dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[4].Value.ToString().Trim();
            hc.DienThoai = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[6].Value.ToString().Trim();
            hc.LopMa = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[7].Value.ToString().Trim();
          
            str = hc.Ma + hc.Ten +hc.GioiTinh+hc.NgaySinh+ hc.Email +hc.DienThoai+hc.LopMa;
            
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
           
        }

        private void btnThemDSGV_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaDSGV_Click(object sender, EventArgs e)
        {

            if (this.dtgDanhSachGV.SelectedRows.Count > 0)
            {

                int selectedIndex = dtgDanhSachGV.SelectedRows[0].Index;
                string rowID = dtgDanhSachGV[0, selectedIndex].Value.ToString();
                if (MessageBox.Show("Ban co chac  chan  xoa  giao vien ma "+rowID+"", "Xoa giao vien", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   
                    control.XoaGV(rowID);
                    dtgDanhSachGV.DataSource = control.getListGiaoVien();
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
            if (DateTime.TryParse(dtgDanhSachGV.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[3].Value.ToString(), out ns))
            {
                hs.NgaySinh = ns;
            }
            hs.NgaySinh = ns;
            hs.Email = dtgDanhSachGV.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[4].Value.ToString();
            hs.DanToc =  dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[5].Value.ToString();
           
            hs.DienThoai = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[6].Value.ToString();
            hs.LopMa = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[7].Value.ToString();
            hs.DiaChi  = dtgDanhSachHS.Rows[dtgDanhSachHS.CurrentRow.Index].Cells[8].Value.ToString();
            frmSua = new frmSua(hs, this);
            frmSua.ShowDialog();
            dtgDanhSachHS.DataSource = control.getListHocSinh();
        }

        public void update_FormMain()
        {
            dtgDanhSachHS.DataSource = control.getListHocSinh();
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
                if (MessageBox.Show("Ban co chac  chan  xoa  hoc sinh ma "+rowID+"", "Xoa hoc sinh", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    control.XoaHS(rowID);
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
    }
}
