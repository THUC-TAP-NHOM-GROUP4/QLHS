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
        public void Sua(string ma, string ten, int gioitinh,  DateTime ngaysinh, string email,  string doituong, string sodienthoai,  string lopma)
        {
            /*Update HocSinh set ten=N'Nguyễn Văn A', ngaysinh='28/03/2017 12:00:00 SA',
             *  gioitinh='1', ', dienthoai= 6456454 ,email= '456 , lopma= where ma ='SV001'*/
            da.NonQuery("Update SinhVien  set ten=N'" + ten + "', " + " ngaysinh='" + ngaysinh + "', gioitinh="
                + gioitinh + ", dienthoai= '" + sodienthoai + "'  ,email= '" + email
                + "' , lopma=  '" + lopma + "' where ma ='" + ma + "'");
        }
        
       // mâ- tên- gioitinh-ngaysinh - email - doituong,sodienthoai, lopma
    }
}
