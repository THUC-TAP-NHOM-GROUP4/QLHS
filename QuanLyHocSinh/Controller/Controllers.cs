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
            //DataTable table = da.Query("select hs.Ma, hs.Ten, hs.GioiTinh, hs.NgaySinh , hs.Email, hs.DanToc, " 
            //    + " hs.Sodienthoai, lhp.ma as [Lopma], hs.Diachi from Hocsinh hs inner join Lophocphan lhp on hs.Lopma = lhp.ma");
            //DataTable table = da.Query("select hs.Ma, hs.Ten, hs.GioiTinh, hs.NgaySinh , hs.Email, hs.DanToc, hs.Lopma ,"
            //   + " hs.Sodienthoai, hs.Diachi from Hocsinh hs");
//<<<<<<< HEAD

            DataTable table = da.Query("select hs.Ma, hs.Ten, hs.GioiTinh, hs.NgaySinh, hs.Sodienthoai , hs.Email,hs.DanToc, "
                + "hs.DiaChi, hs.Sodienthoai, lhp.ma as [Lopma] from Hocsinh hs inner join Lophocphan lhp on hs.Lopma = lhp.ma where hs.Trangthai=1");
//=======
//            DataTable table = da.Query("select hs.Ma, hs.Ten, hs.GioiTinh, hs.NgaySinh, hs.Sodienthoai , hs.Email,hs.DanToc,hs.DiaChi, hs.Sodienthoai, lhp.ma as [Lopma] from Hocsinh hs inner join Lophocphan lhp on hs.Lopma = lhp.ma where hs.Trangthai=1");
//>>>>>>> 62440c2b927b403c2b74c7968b4d4de2fddb1bbb

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
            hs.DanToc = row["dantoc"].ToString().Trim();
            hs.DiaChi = row["diachi"].ToString().Trim();
            hs.LopMa = row["Lopma"].ToString().Trim();
            hs.DienThoai = row["Sodienthoai"].ToString().Trim();
            hs.Email = row["email"].ToString().Trim();
            return hs;
        }

        public GiaoVien[] getListGiaoVien()
        {
            //        DataTable table = da.Query("select gv.Ma, gv.Ten, gv.GioiTinh, gv.NgaySinh, gv.Email, gv.Vaitro , gv.Bomonma , "
            //+ " gv.nhiemvu, gv.anh, gv.trangthai from GiaoVien gv ");
            //DataTable table = da.Query("select gv.Ma, gv.Ten, gv.GioiTinh, gv.NgaySinh, gv.Email, gv.Vaitro , gv.Bomonma , "
            //    + " gv.nhiemvu, gv.anh,bm.ma as [Bomonma], gv.trangthai from GiaoVien gv inner join Bomon bm on gv.Bomonma  = bm.ma ");

//            DataTable table = da.Query("select gv.Ma, gv.Ten, gv.GioiTinh, gv.NgaySinh, gv.Email, gv.Vaitro , gv.Bomonma ,"
//                + " gv.nhiemvu,bm.ma as [Bomonma] from GiaoVien gv inner join Bomon bm on gv.Bomonma  = bm.ma where gv.trangthai=1");

            DataTable table = da.Query("select gv.Ma, gv.Ten, gv.GioiTinh, gv.NgaySinh, gv.Email, gv.luong, gv.Vaitro , gv.Bomonma , gv.nhiemvu, "
             + " gv.anh,bm.ma as [Bomonma] from GiaoVien gv inner join Bomon bm on gv.Bomonma  = bm.ma where gv.trangthai=1");


            int n = table.Rows.Count;
            int i;
            if (n == 0) return new GiaoVien[0];
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
//<<<<<<< HEAD
            //gv.Anh = row["anh"].ToString().Trim();
//=======
          //  gv.Anh = row["anh"].ToString().Trim();
            Double luong = 0;
            if (Double.TryParse(row["luong"].ToString().Trim(), out luong))
            {
                gv.Luong = luong;
            }
//>>>>>>> 62440c2b927b403c2b74c7968b4d4de2fddb1bbb
            //bool i = bool.Parse(row["trangthai"].ToString().Trim());
            //if (i)
            //    gv.TrangThai = 1;
            //else gv.TrangThai = 0;
            return gv;
        }

        public LopHocPhan[] getList_Lophophan()
        {
            DataTable table = da.Query("select l.ma, l.Hocki, l.Namhoc, l.Siso, l.Thu, mh.ma as monma, mh.Ten as monten, "
                + " gv.ma as giaovienma, gv.ten as giaovienten from Lophocphan l inner  join monhoc mh on l.monma = mh.ma "
                + " inner join giaovien gv on gv.ma = l.Giaovienma");
            int n = table.Rows.Count;

            int i;
            if (n == 0) return new LopHocPhan[0];
            LopHocPhan[] list = new LopHocPhan[n];
            for(i =0; i< n; i++)
            {
                list[i] = getLopHocPhan(table.Rows[i]);
            }
            return list;
        }

        public String[] getList_Lophophan_ID()
        {
            DataTable table = da.Query("select l.ma, l.Hocki, l.Namhoc, l.Siso, l.Thu, mh.ma as monma, mh.Ten as monten, "
                + " gv.ma as giaovienma, gv.ten as giaovienten from Lophocphan l inner  join monhoc mh on l.monma = mh.ma "
                + " inner join giaovien gv on gv.ma = l.Giaovienma");
            int n = table.Rows.Count;

            int i;
            if (n == 0) return new String[0];
            String[] list = new String[n];
            for (i = 0; i < n; i++)
            {
                list[i] = table.Rows[i]["ma"].ToString().Trim();
            }
            return list;
        }
        private LopHocPhan getLopHocPhan(DataRow row)
        {
            LopHocPhan l = new LopHocPhan();
            l.Ma = row["ma"].ToString().Trim();
            l.HocKy = int.Parse(row["hocki"].ToString().Trim());
            l.NamHoc = row["namhoc"].ToString().Trim();
            l.Thu = row["thu"].ToString().Trim();
            l.MonHocMa = row["monma"].ToString().Trim();
            l.MonHocTen = row["monten"].ToString().Trim();
            l.GiaoVienMa = row["giaovienma"].ToString().Trim();
            l.GiaoVienTen = row["giaovienten"].ToString().Trim();
            l.SiSo = int.Parse(row["siso"].ToString().Trim());
            return l;
        }
        public void update_hs(HocSinh hs)
        {
            SqlParameter[] para =
             {
                new SqlParameter("ma", hs.Ma),
                new SqlParameter("ten", hs.Ten),
                new SqlParameter("gioitinh", hs.GioiTinh),
                new SqlParameter("ngaysinh", hs.NgaySinh),
                new SqlParameter("email", hs.Email),
                new SqlParameter("dantoc", hs.DanToc),
                new SqlParameter("diachi", hs.DiaChi),
                new SqlParameter("sodt", hs.DienThoai),
                new SqlParameter("lopma", hs.LopMa),
            };
            da.Query("updateHS", para);
        }

        public void update_gv(GiaoVien gv)
        {
            SqlParameter[] para =
                   {
                new SqlParameter("ma", gv.Ma),
                new SqlParameter("ten", gv.Ten),
                new SqlParameter("gioitinh", gv.GioiTinh),
                new SqlParameter("ngaysinh", gv.NgaySinh),
                new SqlParameter("email", gv.Email),
                new SqlParameter("luong",gv.Luong),
                new SqlParameter("nhiemvu", gv.NhiemVu),
                new SqlParameter("vaitro",gv.VaiTro),
                new SqlParameter("bomonma", gv.BoMonMa),
            };
          
            da.Query("updateGV", para);
        }
        public void XoaHS(string ma)
        {
            da.NonQuery("update Hocsinh set trangthai=0 where ma='" + ma + "'");
        }
     
        public void XoaGV(string ma)
        {
            da.NonQuery("update GiaoVien set trangthai=0 where  ma='" + ma+"'");
        }
      
        public bool ThemHS(HocSinh hs)
        {

            SqlParameter[] paraHS =
                       {
                new SqlParameter("ten", hs.Ten),
                new SqlParameter("lopma", hs.LopMa),
                new SqlParameter("ngaysinh",hs.NgaySinh),
                new SqlParameter("gioitinh", hs.GioiTinh),
                new SqlParameter("dantoc", hs.DanToc),
                new SqlParameter("diachi", hs.DiaChi),
                new SqlParameter("email", hs.Email),
                new SqlParameter("sodienthoai",hs.DienThoai)


               
           
        };
            da.Query("proc_insertHS", paraHS);
            return true;
        }

        public bool ThemGV(GiaoVien gv)
        {

            SqlParameter[] paraGV =
                       {
                new SqlParameter("ten", gv.Ten),
                new SqlParameter("gioitinh", gv.GioiTinh),
                new SqlParameter("ngaysinh",gv.NgaySinh),
                new SqlParameter("email", gv.Email),
               // new SqlParameter("anh" , gv.Anh),
                new SqlParameter("luong" , gv.Luong),
                new SqlParameter("nhiemvu" , gv.NhiemVu),
                new SqlParameter("vaitro", gv.VaiTro),
                new SqlParameter("bomonma" , gv.BoMonMa),
                new SqlParameter("trangthai" , gv.TrangThai)
    };
            da.Query("proc_insertGV", paraGV);
            return true;
        }

        public String getBoMon(String bomonma)
        {
            if (bomonma == "") return "";
            DataTable table = da.Query("Select ten from bomon where bomon.ma = '" + bomonma + "'");
            int n = table.Rows.Count;
            if (n == 1)
            {
                return table.Rows[0]["ten"].ToString().Trim();
            }

            return "";
        }
        public List<String> getBoMon()
        {
            DataTable table = da.Query("Select ten from bomon ");
            List<String> listBM = new List<string>();
            int n = table.Rows.Count;
            int i;
            if (n == 0) return new List<string>();
            for (i = 0; i < n; i++)
            {
                listBM.Add(table.Rows[i]["ten"].ToString().Trim());
            }

            return listBM;
        }
        public String getMaBoMon(String tenbomon)
        {
            if (tenbomon == "") return "";
            DataTable table = da.Query("Select ma from bomon where bomon.ten = N'" + tenbomon + "'");
            int n = table.Rows.Count;
            if (n == 1)
            {
                return table.Rows[0]["ma"].ToString().Trim();
            }

            return "";
        }
    }
}
