using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Model
{
    public class GiaoVien
    {
        public String Ma { get; set; }
        public String Ten { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public String Email { get; set; }
       // public String Anh { get; set; }
        public double Luong { get; set; }
        public String NhiemVu { get; set; }
        public String VaiTro { get; set; }
        public String BoMonMa { get; set; }
      //  public int TrangThai { get; set; }
    }
}
