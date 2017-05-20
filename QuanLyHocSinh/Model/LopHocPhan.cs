using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Model
{
    public class LopHocPhan
    {
        public String Ma { get; set; }
        public String MonHocTen { get; set; }
        public String MonHocMa { get; set; }
        public int HocKy { get; set; }
        public String NamHoc { get; set; }
        public int SiSo { get; set; }
        public String Thu { get; set; }
        public int Tiet { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public DateTime NgayThi { get; set; }
        public String GiaoVienMa { get; set; }
        public String GiaoVienTen { get; set; }
    }
}
