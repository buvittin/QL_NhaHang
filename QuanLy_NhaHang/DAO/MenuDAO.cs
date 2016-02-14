using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class MenuDAO
    {
        public bool ThemVaoMenu(Menu mn)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[4];

            para[0] = new SqlParameter();
            para[0].ParameterName = "MaSanPham";
            para[0].SqlDbType = SqlDbType.Int;
            para[0].Value = mn.MaSanPham;

            para[1] = new SqlParameter();
            para[1].ParameterName = "HinhAnh";
            para[1].SqlDbType = SqlDbType.NVarChar;
            para[1].Value = mn.HinhAnh;

            para[2] = new SqlParameter();
            para[2].ParameterName = "DonGia";
            para[2].SqlDbType = SqlDbType.Int;
            para[2].Value = mn.DonGia;

            para[3] = new SqlParameter();
            para[3].ParameterName = "LoaiSanPham";
            para[3].SqlDbType = SqlDbType.Int;
            para[3].Value = mn.MaLoaiSanPham;

            bool result = dp.SqlExcuteNonQuery("sp_ThemMenu", para);

            return result;
        }

        public DataTable LayDSLoaiMon()
        {
            DataProvider dp = new DataProvider();

            DataTable dsloai = dp.SqlExcuteQuery("sp_LayDSLoaiSanPham", null);

            return dsloai;
        }

        public MonAn[] LayDSThucDon()
        {
            DataProvider dp = new DataProvider();

            DataTable dsmon = dp.SqlExcuteQuery("sp_LayDSThucDon", null);

            return GetDataFromTable(dsmon);
        }

        public DataTable LayDSMon()
        {
            DataProvider dp = new DataProvider();

            DataTable dsmon = dp.SqlExcuteQuery("sp_DSMon", null);

            return dsmon;
        }

        public DataTable LayDSNL()
        {
            DataProvider dp = new DataProvider();

            DataTable dsnl = dp.SqlExcuteQuery("sp_LayDSNgLieu", null);

            return dsnl;
        }

        public DataTable LayNguyenLieuMon(int mamon)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter();
            para[0].ParameterName = "MaMon";
            para[0].SqlDbType = SqlDbType.Int;
            para[0].Value = mamon;

            DataTable ngls = dp.SqlExcuteQuery("sp_CongThucMon", para);

            return ngls;
        }

        public bool GoiMon(int maph, MonAn ma)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[3];

            para[0] = new SqlParameter();
            para[0].ParameterName = "MaPhieu";
            para[0].SqlDbType = SqlDbType.Int;
            para[0].Value = maph;

            para[1] = new SqlParameter();
            para[1].ParameterName = "MaMon";
            para[1].SqlDbType = SqlDbType.Int;
            para[1].Value = ma.ID;

            para[2] = new SqlParameter();
            para[2].ParameterName = "SoLuong";
            para[2].SqlDbType = SqlDbType.Int;
            para[2].Value = ma.SoLuong;

            bool result = dp.SqlExcuteNonQuery("sp_GoiMon", para);

            return result;
        }

        public bool CapnhapSLGoi(int maph, MonAn ma)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[3];

            para[0] = new SqlParameter();
            para[0].ParameterName = "MaPhieu";
            para[0].SqlDbType = SqlDbType.Int;
            para[0].Value = maph;

            para[1] = new SqlParameter();
            para[1].ParameterName = "MaMon";
            para[1].SqlDbType = SqlDbType.Int;
            para[1].Value = ma.MaMon;

            para[2] = new SqlParameter();
            para[2].ParameterName = "SoLuong";
            para[2].SqlDbType = SqlDbType.Int;
            para[2].Value = ma.SoLuong;

            bool result = dp.SqlExcuteNonQuery("sp_CapNhapSLMonGoi", para);

            return result;
        }

        public DataTable LayDSMonHoaDon(int maph)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter();
            para[0].ParameterName = "MaPhieu";
            para[0].SqlDbType = SqlDbType.Int;
            para[0].Value = maph;

            DataTable result = dp.SqlExcuteQuery("sp_LayDSMonHoaDon", para);

            return result;
        }

        public bool ThemMon(string tenmon, NguyenLieu[] nl)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter();
            para[0].ParameterName = "TenMon";
            para[0].SqlDbType = SqlDbType.NVarChar;
            para[0].Value = tenmon;

            DataTable result = dp.SqlExcuteQuery("sp_ThemMon", para);

            int id = int.Parse(result.Rows[0][0].ToString());

            if (!ThemNLMon(id, nl))
            {
                return false;
            }

            return true;
        }

        public bool ThemNLMon(int id, NguyenLieu[] nl)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para;

            if (nl != null)
            {
                for (int i = 0; i < nl.Length; i++)
                {
                    para = new SqlParameter[3];

                    para[0] = new SqlParameter();
                    para[0].ParameterName = "MaMon";
                    para[0].SqlDbType = SqlDbType.Int;
                    para[0].Value = id;

                    para[1] = new SqlParameter();
                    para[1].ParameterName = "MaNguyenLieu";
                    para[1].SqlDbType = SqlDbType.Int;
                    para[1].Value = nl[i].ID;

                    para[2] = new SqlParameter();
                    para[2].ParameterName = "SoLuong";
                    para[2].SqlDbType = SqlDbType.Float;
                    para[2].Value = nl[i].SoLuong;

                    bool result = dp.SqlExcuteNonQuery("sp_ThemNLMon", para);
                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool CapNhapNLMon(int id, NguyenLieu[] nl)
        {
            DataProvider dp = new DataProvider();
            
            SqlParameter[] para = new SqlParameter[1];

            para[0] = new SqlParameter();
            para[0].ParameterName = "MaMon";
            para[0].SqlDbType = SqlDbType.Int;
            para[0].Value = id;

            bool result = dp.SqlExcuteNonQuery("sp_XoaCongThucMon", para);

            if (result)
            {
                ThemNLMon(id, nl);
                return true;
            }

            return false;
        }

        public bool CapNhapTTMon(MonAn ma)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[4];

            para[0] = new SqlParameter();
            para[0].ParameterName = "ID";
            para[0].SqlDbType = SqlDbType.Int;
            para[0].Value = ma.ID;

            para[1] = new SqlParameter();
            para[1].ParameterName = "DonGia";
            para[1].SqlDbType = SqlDbType.Int;
            para[1].Value = ma.DonGia;

            para[2] = new SqlParameter();
            para[2].ParameterName = "HinhAnh";
            para[2].SqlDbType = SqlDbType.NVarChar;
            para[2].Value = ma.HinhAnh;

            para[3] = new SqlParameter();
            para[3].ParameterName = "MaLoaiSP";
            para[3].SqlDbType = SqlDbType.Int;
            para[3].Value = ma.MaLoaiSanPham;

            bool result = dp.SqlExcuteNonQuery("sp_CapNhapTTMon", para);

            return result;
        }

        public DataTable ThucAnChuaCo()
        {
            DataProvider dp = new DataProvider();

            DataTable dsmon = dp.SqlExcuteQuery("sp_DSMonChuaCo", null);

            return dsmon;
        }

        public DataTable ThucUongChuaCo()
        {
            DataProvider dp = new DataProvider();

            DataTable dsmon = dp.SqlExcuteQuery("sp_DSThucUongChuaCo", null);

            return dsmon;
        }

        private MonAn[] GetDataFromTable(DataTable data)
        {
            if (data == null)
            {
                return null;
            }

            MonAn[] dsmon = new MonAn[data.Rows.Count];

            for (int i = 0; i < data.Rows.Count; i++)
            {
                dsmon[i] = new MonAn();

                dsmon[i].ID = int.Parse(data.Rows[i][0].ToString());
                dsmon[i].HinhAnh = data.Rows[i][1].ToString();
                dsmon[i].DonGia = int.Parse(data.Rows[i][2].ToString());
                dsmon[i].TenMonAn = data.Rows[i][3].ToString();
                dsmon[i].MaLoaiSanPham = int.Parse(data.Rows[i][4].ToString());
                dsmon[i].TenLoaiSanPham = data.Rows[i][5].ToString();
            }

            return dsmon;
        }
    }
}
