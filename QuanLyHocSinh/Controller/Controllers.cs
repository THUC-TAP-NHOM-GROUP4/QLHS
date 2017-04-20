using QuanLyHocSinh.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Controller
{
    class Controllers
    {
        DataAccess da = new DataAccess();
        public HocSinh[] getListHocSinh()
        {
            DataTable table = da.Query("select sv.Ma, sv.Ten, sv.GioiTinh, sv.NgaySinh, sv.Email, sv.Doituong, "
                        + " sv.Sodienthoai, lhp.ma as [Lopma] from SinhVien sv inner join lophocphan lhp " 
                        + " on sv.Lopma = lhp.ma");
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
            hs.DoiTuong = row["doituong"].ToString().Trim();
            hs.LopMa = row["Lopma"].ToString().Trim();
            hs.DienThoai = row["Sodienthoai"].ToString().Trim();
            hs.Email = row["email"].ToString().Trim();
            return hs;
        }
        //hs.Ma, hs.Ten, hs.GioiTinh, hs.NgaySinh, hs.Email, hs.DoiTuong, hs.DienThoai, hs.LopMa);
        public void update_hs(string ma, string ten, int gioitinh,  DateTime ngaysinh, string email,  string doituong, string sodienthoai,  string lopma)
        {
            /*Update HocSinh set ten=N'Nguyễn Văn A', ngaysinh='28/03/2017 12:00:00 SA',
             *  gioitinh='1', ', dienthoai= 6456454 ,email= '456 , lopma= where ma ='SV001'*/
            da.NonQuery("Update SinhVien  set ten=N'" + ten + "', " + " ngaysinh='" + ngaysinh + "', gioitinh="
                + gioitinh + ", sodienthoai= '" + sodienthoai + "'  ,email= '" + email
                + "' , lopma=  '" + lopma + "' where ma ='" + ma + "'");
        }

        public void update_gv(string ma, string ten, int gioitinh, DateTime ngaysinh, string email, double luong, 
            string nhiemvu, string vaitro, string taikhoan, string matkhau, string hocham, string hocvi, string sodt,
            string diachi, string tenbm)
        {
            da.NonQuery("Update GiaoVien set ten = N'" + ten + "', gioitinh = '" + gioitinh + "', email = N'" + email +  "', "
                + " luong = " + luong + ", nhiemvu = N'" + nhiemvu + "', vaitro= N'" + vaitro + "', taikhoan = N'" + taikhoan 
                + "', matkhau = N'" + matkhau + "', hocham = N'" + hocham + "', hocvi = N'" + hocvi + "', sodt = '" + sodt 
                + "' diachi = N'" + diachi + "', tenbm = N'"  + ten + "'");
            /*update GiaoVien set Ten = N'Hoàng Hồng Hạnh', Gioitinh = 1, Ngaysinh = , Email = , Anh = , Luong = 
Nhiemvu  = ,Vaitro = , Taikhoan = , Matkhau= , Hocham = , Hocvi= , sodt= , bomonma*/
        }
        // mâ- tên- gioitinh-ngaysinh - email - doituong,sodienthoai, lopma

        public GiaoVien[] getListGiaoVien()
        {
            DataTable table = da.Query("select gv.ma, gv.Ten, gv.Gioitinh, gv.Ngaysinh, gv.Email, gv.Luong, gv.Nhiemvu, "
                        + " gv.Vaitro, gv.Taikhoan, gv.Matkhau, gv.Hocham, gv.Hocvi, gv.sodt, gv.diachi, bm.ten as [tenbm]"
                        + " from giaovien gv inner join Bomon bm on gv.Bomonma = bm.Ma");
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
            /*select gv.ma, gv.Ten, gv.Gioitinh, gv.Ngaysinh, gv.Email, gv.Luong, gv.Nhiemvu, gv.Vaitro, 
gv.Taikhoan, gv.Matkhau, gv.Hocham, gv.Hocvi, gv.sodt, gv.diachi, bm.ten from giaovien gv inner join Bomon bm
on gv.Bomonma = bm.Ma*/
            GiaoVien gv = new GiaoVien();
            gv.Ma = row["ma"].ToString().Trim();
            gv.Ten = row["ten"].ToString().Trim();
            int gt = 1;
            if (int.TryParse(row["gioitinh"].ToString().Trim(), out gt))
            {
                gv.GioiTinh = gt;
            }
            DateTime ns = new DateTime();
            if (DateTime.TryParse(row["ngaysinh"].ToString().Trim(), out ns))
            {
                gv.NgaySinh = ns;
            }

            gv.Email = row["email"].ToString().Trim();
            gv.Luong = double.Parse(row["luong"].ToString().Trim());
            gv.NhiemVu = row["nhiemvu"].ToString().Trim();
            gv.VaiTro = row["vaitro"].ToString().Trim();
            gv.VaiTro = row["taikhoan"].ToString().Trim();
            gv.VaiTro = row["matkhau"].ToString().Trim();
            gv.VaiTro = row["hocham"].ToString().Trim();
            gv.VaiTro = row["hocvi"].ToString().Trim();
            gv.VaiTro = row["sodt"].ToString().Trim();
            gv.VaiTro = row["diachi"].ToString().Trim();
            gv.VaiTro = row["tenbm"].ToString().Trim();

            return gv;
        }
    }
}
