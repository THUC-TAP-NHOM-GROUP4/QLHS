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
            dgvHocSinh.DataSource = control.getListHocSinh();
            dgvHocSinh.Columns["ma"].HeaderText = "Mã";
            dgvHocSinh.Columns["ten"].HeaderText = "Họ tên";
            dgvHocSinh.Columns["ngaysinh"].HeaderText = "Ngày sinh";
           
            dgvHocSinh.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvHocSinh.Columns["Lopma"].HeaderText = "Mã lớp học phần";
            dgvHocSinh.Columns["email"].HeaderText = "Email";
            dgvHocSinh.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvHocSinh.Columns["ma"].Width = 60;
            dgvHocSinh.Columns["ten"].Width = 150;
            dgvHocSinh.Columns["email"].Width = 150;
            dgvHocSinh.Columns["gioitinh"].Width = 50;
            dgvHocSinh.Columns["ngaysinh"].Width = 100;
            dgvHocSinh.Columns["Lopma"].Width = 150;

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

            if (this.dtgDanhSachGV.SelectedRows.Count > 0)
            {

                int selectedIndex = dtgDanhSachGV.SelectedRows[0].Index;
                string rowID = dtgDanhSachGV[0, selectedIndex].Value.ToString();
                if (MessageBox.Show("Ban co chac  chan  xoa  giao vien ma "+rowID+"", "Xoa giao vien", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   
                    control.XoaGV(rowID);
                    update_FormMain();
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
            string s = dgvHocSinh.Rows[dgvHocSinh.CurrentRow.Index].Cells[0].Value.ToString() + "_"
                        + dgvHocSinh.Rows[dgvHocSinh.CurrentRow.Index].Cells[1].Value.ToString() + "_"
                        + dgvHocSinh.Rows[dgvHocSinh.CurrentRow.Index].Cells[2].Value.ToString() + "_"
                        + dgvHocSinh.Rows[dgvHocSinh.CurrentRow.Index].Cells[3].Value.ToString() + "_"
                        + dgvHocSinh.Rows[dgvHocSinh.CurrentRow.Index].Cells[4].Value.ToString() + "_"
                        + dgvHocSinh.Rows[dgvHocSinh.CurrentRow.Index].Cells[5].Value.ToString() + "_"
                        + dgvHocSinh.Rows[dgvHocSinh.CurrentRow.Index].Cells[6].Value.ToString() + "_"
                        + dgvHocSinh.Rows[dgvHocSinh.CurrentRow.Index].Cells[7].Value.ToString();

           
           
            frmSua = new frmSua(s);
            frmSua.ShowDialog();
            dgvHocSinh.DataSource = control.getListHocSinh();
        }

        public void update_FormMain()
        {
            dgvHocSinh.DataSource = control.getListHocSinh();
        }

        private void btnThemDSHS_Click(object sender, EventArgs e)
        {

            frm_AddHS = new AddHocSinh(this);
            frm_AddHS.ShowDialog();
            update_FormMain();
        }

        private void btnXoaDSHS_Click(object sender, EventArgs e)
        {

            if (this.dgvHocSinh.SelectedRows.Count > 0)
            {

                int selectedIndex = dgvHocSinh.SelectedRows[0].Index;
                string rowID = dgvHocSinh[0, selectedIndex].Value.ToString();
                if (MessageBox.Show("Ban co chac  chan  xoa  hoc sinh ma "+rowID+"", "Xoa hoc sinh", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    control.XoaHS(rowID);
                    update_FormMain();
                }
            }
            
        }

        private void btnTimKiemDSHS_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuDSHS_Click(object sender, EventArgs e)
        {

        }
    }
}
