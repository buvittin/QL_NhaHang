using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int ID { get; set; }
        public String HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public String CMND { get; set; }
        public String DiaChi { get; set; }
        public String SoDienThoai { get; set; }
    }

    public class TaiKhoan : NhanVien
    {
        public String TenTaiKhoan { get; set; }
        public String Password { get; set; }
        public int LoaiTK { get; set; }
        public String TenLoaiTK { get; set; }
    }
}
