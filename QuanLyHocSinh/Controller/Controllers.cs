﻿using QuanLyHocSinh.Model;
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
            DataTable table = da.Query("select hs.Ma, hs.Ten, hs.GioiTinh, hs.NgaySinh , hs.Email, hs.DanToc, " 
                + " hs.Sodienthoai, lhp.ma as [Lopma], hs.Diachi from Hocsinh hs inner join Lophocphan lhp on hs.Lopma = lhp.ma");
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
            DataTable table = da.Query("select gv.Ma, gv.Ten, gv.GioiTinh, gv.NgaySinh, gv.Email, gv.Vaitro , gv.Bomonma , " 
                + " gv.nhiemvu, gv.anh,bm.ma as [Bomonma] from GiaoVien gv inner join Bomon bm on gv.Bomonma  = bm.ma where gv.trangthai=1");
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
                new SqlParameter("taikhoan",gv.TaiKhoan),
                new SqlParameter("hocham",gv.HocHam),
                new SqlParameter("hocvi",gv.HocVi),
                new SqlParameter("sodt", gv.SoDienThoai),
                new SqlParameter("diachi", gv.DiaChi),
                new SqlParameter("bomonma", gv.BoMonMa),
            };
            da.Query("updateGV", para);
        }
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
