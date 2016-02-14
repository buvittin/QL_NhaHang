using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieu
    {
        public int ID { get; set; }
        public string TenNguyenLieu { get; set; }
        public string DonViTinh { get; set; }
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public float SoLuong { get; set; } 
    }
}
