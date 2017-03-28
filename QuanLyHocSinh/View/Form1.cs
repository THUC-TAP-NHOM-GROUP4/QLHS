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

namespace QuanLyHocSinh
{
    public partial class Form1 : Form
    {
        Controllers control = new Controllers();
        frmSua frmSua = new frmSua();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgDanhSach.DataSource = control.getListHocSinh();
            dtgDanhSach.Columns["ma"].HeaderText = "Mã";
            dtgDanhSach.Columns["ten"].HeaderText = "Họ tên";
            dtgDanhSach.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dtgDanhSach.Columns["doituong"].HeaderText = "Đối tượng";
            dtgDanhSach.Columns["gioitinh"].HeaderText = "Giới tính";
            dtgDanhSach.Columns["Lopma"].HeaderText = "Mã lớp học phần";
            dtgDanhSach.Columns["email"].HeaderText = "Email";
            dtgDanhSach.Columns["DienThoai"].HeaderText = "Điện thoại";
            dtgDanhSach.Columns["ma"].Width = 60;
            dtgDanhSach.Columns["ten"].Width = 150;
            dtgDanhSach.Columns["email"].Width = 150;
            dtgDanhSach.Columns["gioitinh"].Width = 50;
            dtgDanhSach.Columns["ngaysinh"].Width = 100;
            dtgDanhSach.Columns["Lopma"].Width = 150;
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

        private void dtgDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            string s = dtgDanhSach.Rows[dtgDanhSach.CurrentRow.Index].Cells[0].Value.ToString() + "_"
                        + dtgDanhSach.Rows[dtgDanhSach.CurrentRow.Index].Cells[1].Value.ToString() + "_"
                        + dtgDanhSach.Rows[dtgDanhSach.CurrentRow.Index].Cells[2].Value.ToString() + "_"
                        + dtgDanhSach.Rows[dtgDanhSach.CurrentRow.Index].Cells[3].Value.ToString() + "_"
                        + dtgDanhSach.Rows[dtgDanhSach.CurrentRow.Index].Cells[4].Value.ToString() + "_"
                        + dtgDanhSach.Rows[dtgDanhSach.CurrentRow.Index].Cells[5].Value.ToString() + "_"
                        + dtgDanhSach.Rows[dtgDanhSach.CurrentRow.Index].Cells[6].Value.ToString() + "_"
                        + dtgDanhSach.Rows[dtgDanhSach.CurrentRow.Index].Cells[7].Value.ToString();

           
           
            frmSua = new frmSua(s);
            frmSua.ShowDialog();
            dtgDanhSach.DataSource = control.getListHocSinh();
        }
    }
}
