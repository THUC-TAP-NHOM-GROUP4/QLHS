using QuanLyHocSinh.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public void update_hs(HocSinh hs)
        {
            SqlParameter[] para =
             {
                new SqlParameter("ma", hs.Ma),
                new SqlParameter("ten", hs.Ten),
                new SqlParameter("gioitinh", hs.GioiTinh),
                new SqlParameter("ngaysinh", hs.NgaySinh),
                new SqlParameter("email", hs.Email),
                new SqlParameter("doituong", hs.DoiTuong),
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
        public GiaoVien[] getListGiaoVien()
        {
            DataTable table = da.Query("select gv.ma, gv.Ten, gv.Gioitinh, gv.Ngaysinh, gv.Email, gv.Luong, gv.Nhiemvu, "
                        + " gv.Vaitro, gv.Taikhoan, gv.Matkhau, gv.Hocham, gv.Hocvi, gv.sodt as[sodienthoai], gv.diachi, bm.ten as [tenbomon]"
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
            gv.TaiKhoan = row["taikhoan"].ToString().Trim();
            gv.MatKhau = row["matkhau"].ToString().Trim();
            gv.HocHam = row["hocham"].ToString().Trim();
            gv.HocVi = row["hocvi"].ToString().Trim();
            gv.SoDienThoai = row["sodienthoai"].ToString().Trim();
            gv.DiaChi = row["diachi"].ToString().Trim();
            gv.BoMonMa = row["tenbomon"].ToString().Trim();

            return gv;
        }
        public String getBoMon(String bomonma)
        {
            if (bomonma == "") return "";
            DataTable table = da.Query("Select ten from bomon where bomon.ma = '" + bomonma+ "'");
            int n = table.Rows.Count;
            int i;
            if(n== 1)
            {
                return  table.Rows[0]["ten"].ToString().Trim();
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
            for(i = 0; i< n; i++)
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
            int i;
            if (n == 1)
            {
                return table.Rows[0]["ma"].ToString().Trim();
            }

            return "";
        }
    }
}
