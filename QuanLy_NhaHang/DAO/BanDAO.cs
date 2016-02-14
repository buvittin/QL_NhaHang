using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class BanDAO
    {
        public Ban[] LayDanhSachBan()
        {
            DataProvider dp = new DataProvider();

            DataTable dsban = dp.SqlExcuteQuery("sp_LayDanhSachBan", null);

            return GetDataFromTable(dsban);
        }

        public BanObject MoBan(BanObject bn)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[6];

            para[0] = new SqlParameter();
            para[0].ParameterName = "MaNhanVien";
            para[0].SqlDbType = SqlDbType.Int;
            //para[0].Value = bn.TaiKhoan.ID;
            para[0].Value = 1;

            para[1] = new SqlParameter();
            para[1].ParameterName = "MaBan";
            para[1].SqlDbType = SqlDbType.Int;
            para[1].Value = bn.MaBan;

            para[2] = new SqlParameter();
            para[2].ParameterName = "TenKhachHang";
            para[2].SqlDbType = SqlDbType.NVarChar;
            para[2].Value = bn.TenKhachHang;

            para[3] = new SqlParameter();
            para[3].ParameterName = "DiaChi";
            para[3].SqlDbType = SqlDbType.NVarChar;
            para[3].Value = bn.DiaChi;

            para[4] = new SqlParameter();
            para[4].ParameterName = "ThoiGian";
            para[4].SqlDbType = SqlDbType.DateTime;
            para[4].Value = bn.ThoiGian;

            para[5] = new SqlParameter();
            para[5].ParameterName = "TongTien";
            para[5].SqlDbType = SqlDbType.Int;
            para[5].Value = bn.Tongtien;

            DataTable value = dp.SqlExcuteQuery("sp_MoBan", para);

            if (value.Rows.Count > 0)
            {
                bn.IDPhieuGoi = int.Parse(value.Rows[0][0].ToString());
            }

            return bn;
        }

        public bool ThemBan(int maloai)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter();
            para[0].ParameterName = "MaLoai";
            para[0].SqlDbType = SqlDbType.Int;
            para[0].Value = maloai;

            return dp.SqlExcuteNonQuery("sp_ThemBan", para);
        }

        public bool CapNhapLoaiBan(Ban bn)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter();
            para[0].ParameterName = "MaBan";
            para[0].SqlDbType = SqlDbType.Int;
            para[0].Value = bn.MaBan;

            para[1] = new SqlParameter();
            para[1].ParameterName = "MaLoai";
            para[1].SqlDbType = SqlDbType.Int;
            para[1].Value = bn.LoaiBan;

            return dp.SqlExcuteNonQuery("sp_CapNhapLoaiBan", para);
        }

        private Ban[] GetDataFromTable(DataTable data)
        {
            if (data == null)
            {
                return null;
            }

            Ban[] dsban = new Ban[data.Rows.Count];

            for (int i = 0; i < data.Rows.Count; i++)
            {
                dsban[i] = new Ban();
                dsban[i].MaBan = int.Parse(data.Rows[i][0].ToString());
                dsban[i].LoaiBan = int.Parse(data.Rows[i][1].ToString());
                dsban[i].TenLoai = data.Rows[i][2].ToString();
            }

            return dsban;
        }
    }
}
