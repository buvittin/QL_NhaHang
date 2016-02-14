namespace DTO
{
    public class Menu
    {
        public int ID { get; set; }
        public int MaSanPham { get; set; }
        public string HinhAnh { get; set; }
        public int DonGia { get; set; }
        public int MaLoaiSanPham { get; set; }
        public string TenLoaiSanPham { get; set; }
    }

    public class MonAn : Menu
    {
        public int MaMon { get; set;}
        public string TenMonAn { get; set; }
        public int SoLuong { get; set; }
    }
}
