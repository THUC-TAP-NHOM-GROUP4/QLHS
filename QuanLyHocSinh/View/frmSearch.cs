using QLNS.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.View
{
    public partial class frmSearch : Form
    {
        private string str;
        public frmSearch(string  str)
        {
            this.str = str;
            InitializeComponent();
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text != "" && txttimkiem.Text != "Nhập tên cần tìm...")
            {
                if(str.Equals("1"))
                dgvdanhsach.DataSource = da.Query("getListGV", new SqlParameter("@ten", txttimkiem.Text));
                if(str.Equals("0"))
                    dgvdanhsach.DataSource = da.Query("getListSV", new SqlParameter("@TEN", txttimkiem.Text));
            }
            else
                MessageBox.Show("Vui lòng nhập tên cần tìm");
        }
        DataAccess da = new DataAccess();
        private void frmSearch_Load(object sender, EventArgs e)
        {
            if(str.Equals("0"))
            {
                groupBox2.Size = new Size(328, 407);
                lbvaitro.Text = "Đối tượng";
                lbnhiemvu.Text = "Lớp";
                lbbomon.Visible = false;
                txtbomon.Visible = false;
                lbanh.Visible = false;
                dgvdanhsach.DataSource = da.Query("select *from Sinhvien");
            }
            if(str.Equals("1"))
            {
                groupBox2.Size = new Size(591, 407);
                lbvaitro.Text = "Vai trò";
                lbnhiemvu.Text = "Nhiệm vụ";
                txtbomon.Visible = true;
                lbbomon.Visible = true;
                lbanh.Visible = true;
                dgvdanhsach.DataSource = da.Query("select *from Giaovien");
            }
        }

        private void dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdanhsach.CurrentRow != null)
            {
                txtma.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                txtten.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                txtsodt.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[4].Value.ToString().Trim();
                txtemail.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[5].Value.ToString().Trim();
                txtvaitro.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[6].Value.ToString().Trim();
                txtnhiemvu.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[7].Value.ToString().Trim();
                if (str == "1")
                {
                    txtbomon.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[8].Value.ToString().Trim();
                    txthocham.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[10].Value.ToString().Trim();
                    txthocvi.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[11].Value.ToString().Trim();
                    txttaikhoan.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[12].Value.ToString().Trim();
                    txtmatkhau.Text = dgvdanhsach.Rows[dgvdanhsach.CurrentRow.Index].Cells[13].Value.ToString().Trim();
                }
            }
        }

        private void txttimkiem_MouseClick(object sender, MouseEventArgs e)
        {
            txttimkiem.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
