using QuanLyHocSinh.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocSinh.Controller;


namespace QuanLyHocSinh.Controller
{
    class Controllers
    {
        DataAccess da = new DataAccess();
        public HocSinh[] getListHocSinh()
        {
            DataTable table = da.Query("select hs.Ma, hs.Ten, hs.GioiTinh, hs.NgaySinh, hs.Sodienthoai , hs.Email, hs.Sodienthoai, lhp.ma as [Lopma] from Hocsinh hs inner join Lophocphan lhp on hs.Lopma = lhp.ma");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            HocSinh[] list = new HocSinh[n];
            for (i = 0; i < n; i++)
            {
                list[i] = getHocSinh(table.Rows[i]);
            }
            return list;
        }
        public HocSinh getHocSinh(DataRow row)
        {
            HocSinh hs = new HocSinh();
            hs.Ma = row["ma"].ToString().Trim();
            hs.Ten = row["ten"].ToString().Trim();
            int gt = 1;
            if (int.TryParse(row["gioitinh"].ToString().Trim(), out gt))
            {
                hs.GioiTinh = gt;
            }
            DateTime ns = new DateTime();
            if (DateTime.TryParse(row["ngaysinh"].ToString().Trim(), out ns))
            {
                hs.NgaySinh = ns;
            }
          
            hs.LopMa = row["Lopma"].ToString().Trim();
            hs.DienThoai = row["Sodienthoai"].ToString().Trim();
            hs.Email = row["email"].ToString().Trim();
            return hs;
        }

        public GiaoVien[] getListGiaoVien()
        {
            DataTable table = da.Query("select gv.Ma, gv.Ten, gv.GioiTinh, gv.NgaySinh, gv.Email, gv.Vaitro , gv.Bomonma , gv.nhiemvu, gv.anh,bm.ma as [Bomonma] from GiaoVien gv inner join Bomon bm on gv.Bomonma  = bm.ma where gv.trangthai=1");
            int n = table.Rows.Count;
            int i;
            if (n == 0) return null;
            GiaoVien[] list = new GiaoVien[n];
            for (i = 0; i < n; i++)
            {
                list[i] = getGiaoVien(table.Rows[i]);
            }
            return list;

        }
       

        public GiaoVien getGiaoVien(DataRow row)
        {
            GiaoVien gv = new GiaoVien();
            gv.Ma = row["Ma"].ToString().Trim();
            gv.Ten = row["Ten"].ToString().Trim();
            int gt = 1;
            if (int.TryParse(row["GioiTinh"].ToString().Trim(), out gt))
            {
                gv.GioiTinh = gt;
            }
            DateTime ns = new DateTime();
            if (DateTime.TryParse(row["NgaySinh"].ToString().Trim(), out ns))
            {
                gv.NgaySinh = ns;
            }
            gv.Email = row["Email"].ToString().Trim();
            gv.VaiTro = row["VaiTro"].ToString().Trim();
            gv.BoMonMa = row["BoMonMa"].ToString().Trim();
            gv.NhiemVu = row["NhiemVu"].ToString().Trim();
            gv.Anh = row["anh"].ToString().Trim();
            return gv;
        }

        //hs.Ma, hs.Ten, hs.GioiTinh, hs.NgaySinh, hs.Email, hs.DoiTuong, hs.DienThoai, hs.LopMa);
        public void Sua(string ma, string ten, int gioitinh,  DateTime ngaysinh, string email,  string doituong, string sodienthoai,  string lopma)
        {
            /*Update HocSinh set ten=N'Nguyễn Văn A', ngaysinh='28/03/2017 12:00:00 SA',
             *  gioitinh='1', ', dienthoai= 6456454 ,email= '456 , lopma= where ma ='SV001'*/
            da.NonQuery("Update HocSinh  set ten=N'" + ten + "', " + " ngaysinh='" + ngaysinh + "', gioitinh="
                + gioitinh + ", dienthoai= '" + sodienthoai + "'  ,email= '" + email
                + "' , lopma=  '" + lopma + "' where ma ='" + ma + "'");
        }

        // mâ- tên- gioitinh-ngaysinh - email - doituong,sodienthoai, lopma
        public void XoaHS(string ma)
        {
            da.NonQuery("delete Hocsinh where ma='" + ma + "'");
        }
     
        public void XoaGV(string ma)
        {
            da.NonQuery("update GiaoVien set trangthai=0 where  ma='" + ma+"'");
        }
      
        public bool ThemHS(HocSinh hs)
        {

            SqlParameter[] paraHS =
                       {
                new SqlParameter("ma" , hs.Ma ),
                new SqlParameter("ten", hs.Ten),
                new SqlParameter("lopma", hs.LopMa),
                new SqlParameter("ngaysinh",hs.NgaySinh),
                new SqlParameter("gioitinh", hs.GioiTinh),
                new SqlParameter("dantoc", hs.DanToc),
                new SqlParameter("diachi", hs.DiaChi),
               
            };
            da.Query("proc_insertHS", paraHS);
            return true;
        }

        public bool ThemGV(GiaoVien gv)
        {

            SqlParameter[] paraGV =
                       {
                new SqlParameter("ma" , gv.Ma ),
                new SqlParameter("ten", gv.Ten),
                new SqlParameter("gioitinh", gv.GioiTinh),
                new SqlParameter("ngaysinh",gv.NgaySinh),
                new SqlParameter("email", gv.Email),
                new SqlParameter("vaitro", gv.VaiTro),
                new SqlParameter("bomonma" , gv.BoMonMa),

            };
            da.Query("proc_insertGV", paraGV);
            return true;
        }
    }
}
