using System;
using System.Collections.Generic;

namespace DTO
{
    public class Ban
    {
        public int MaBan { get; set; }
        public int LoaiBan { get; set; }
        public string TenLoai { get; set; }
    }

    public class BanObject : Ban
    {
        public int IDPhieuGoi { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public int Tongtien { get; set; }
        public List<MonAn> DSGoiMon { get; set; }
        public DateTime ThoiGian { get; set; }
        public bool DaThanhToan { get; set; }

        public BanObject()
        {
            DSGoiMon = new List<MonAn>();
            Tongtien = 0;
        }

        public static BanObject GetData(Ban bn)
        {
            BanObject temp = new BanObject();
            temp.MaBan = bn.MaBan;
            temp.LoaiBan = bn.LoaiBan;
            temp.TenLoai = bn.TenLoai;

            return temp;
        }

        public static BanObject[] GetArrayData(Ban[] bn)
        {
            BanObject[] temp = new BanObject[bn.Length];

            for (int i = 0; i < bn.Length; i++)
            {
                temp[i] = new BanObject();

                temp[i].MaBan = bn[i].MaBan;
                temp[i].LoaiBan = bn[i].LoaiBan;
                temp[i].TenLoai = bn[i].TenLoai;
            }

            return temp;
        }

    }
}
