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

namespace QuanLyHocSinh.View
{
    public partial class frmSearch : Form
    {
        private string str { get; set; }
        public frmSearch()
        {

            InitializeComponent();


            this.str = str;
            dgvdstimkiem.DataSource = da.Query("select *from Hocsinh");
        }
        public frmSearch(string str)
        {
            
            InitializeComponent();
           
            
            this.str = str;
            
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            if(str=="1")
            {  
                cbbSearch.Items.Add("Tìm kiếm theo mã");
                cbbSearch.Items.Add("Tìm kiếm theo tên");
                cbbSearch.Items.Add("Tìm kiếm theo lớp");
                cbbSearch.Items.Add("Tìm kiếm theo dân tộc");
                cbbSearch.Items.Add("Tìm kiếm theo giới tính");
                cbbSearch.Items.Add("Tìm kiếm theo địa chỉ");
              
            }
            if(str=="2")
            {
              
                cbbSearch.Items.Add("Tìm kiếm theo mã");
                cbbSearch.Items.Add("Tìm kiếm theo tên");
                cbbSearch.Items.Add("Tìm kiếm theo bộ môn");
                cbbSearch.Items.Add("Tìm kiếm theo dân tộc");
                cbbSearch.Items.Add("Tìm kiếm theo giới tính");
                cbbSearch.Items.Add("Tìm kiếm theo địa chỉ");
               
            }
        }
        DataAccess da;
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if(str=="1")
            {
                if(cbbSearch.Text.Equals("Tìm kiếm theo mã"))
                {
                    
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSHSTHEOMA", new System.Data.SqlClient.SqlParameter("@ma", TXTma.Text));
                }
                else if (cbbSearch.Text.Equals("Tìm kiếm theo tên"))
                {
                    lbma.Visible = true;
                    lbma.Text = "Họ và tên";
                    
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSHSTHEOTEN", new System.Data.SqlClient.SqlParameter("@ten", TXTma.Text));
                }
                else if (cbbSearch.Text.Equals("Tìm kiếm theo dân tộc"))
                {

                    lbma.Text = "Dân tộc";
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSHSTHEODANTOC",new System.Data.SqlClient.SqlParameter("@dantoc",TXTma.Text));
                }
                else if (cbbSearch.Text.Equals("Tìm kiếm theo giới tính"))
                {
                    lbma.Text = "Giới tính";
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSHSTHEOGIOITINH",new System.Data.SqlClient.SqlParameter("@gioitinh", TXTma.Text));
                }
                else if (cbbSearch.Text.Equals("Tìm kiếm theo địa chỉ"))
                {

                    lbma.Text = "Địa chỉ";
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSHSTHEODIACHI", new System.Data.SqlClient.SqlParameter("@diachi", TXTma.Text));
                }
                else if (cbbSearch.Text.Equals("Tìm kiếm theo lớp"))
                {

                    lbma.Text = "Lớp";
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSHSTHEOLOP", new System.Data.SqlClient.SqlParameter("@lop",TXTma.Text));
                }
            }
            if (str == "2")
            {
                if (cbbSearch.Text.Equals("Tìm kiếm theo mã"))
                {
                   
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSGVTHEOMA", new System.Data.SqlClient.SqlParameter("@ma", TXTma.Text));
                }
                else if (cbbSearch.Text.Equals("Tìm kiếm theo tên"))
                {
                   
                    lbma.Text = "Họ và tên";
                   
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSGVTHEOTEN", new System.Data.SqlClient.SqlParameter("@ma", TXTma.Text));
                }
                else if (cbbSearch.Text.Equals("Tìm kiếm theo dân tộc"))
                {

                    lbma.Text = "Dân tộc";
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSGVTHEODANTOC");
                }
                else if (cbbSearch.Text.Equals("Tìm kiếm theo giới tính"))
                {
                    ;
                    lbma.Text = "Giới tính";
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSGVTHEOGIOITINH", new System.Data.SqlClient.SqlParameter("@gioitinh", TXTma.Text));
                }
                else if (cbbSearch.Text.Equals("Tìm kiếm theo địa chỉ"))
                {

                    lbma.Text = "Địa chỉ";
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSGVTHEODIACHI", new System.Data.SqlClient.SqlParameter("@diachi", TXTma.Text));
                }
                else if (cbbSearch.Text.Equals("Tìm kiếm theo bộ môn"))
                {

                    lbma.Text = "Bộ môn";
                    da = new DataAccess();
                    dgvdstimkiem.DataSource = da.Query("DSGVTHEOBOMON", new System.Data.SqlClient.SqlParameter("@bomon", TXTma.Text));
                }
            }
        }
    }
}
