using QuanLyHocSinh.View;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
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

        private void btnSuaDSHS_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemDSHS_Click(object sender, EventArgs e)
        {
            frmSearch fr = new frmSearch("0");
            fr.Size = new Size(812, 515);
            fr.ShowDialog();
        }

        private void btnTimKiemDSGV_Click(object sender, EventArgs e)
        {
            frmSearch fr = new frmSearch("1");
            fr.Size = new Size(1060, 515);
            fr.ShowDialog();
        }
    }
}
