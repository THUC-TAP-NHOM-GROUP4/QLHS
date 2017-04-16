using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Model
{
  public  class HocSinh
    {
        public String Ma { get; set; }
        public String Ten { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public String Email { get; set; }
        public String DanToc { get; set; }
        public String DienThoai { get; set; }
        public String LopMa { get; set; }
        public String DiaChi { get; set; }
    }
}
