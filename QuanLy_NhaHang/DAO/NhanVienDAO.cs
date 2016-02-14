using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        public TaiKhoan DangNhap(TaiKhoan tk)
        {
            DataProvider dp = new DataProvider();

            SqlParameter[] para = new SqlParameter[2];

            para[0] = new SqlParameter();
            para[0].ParameterName = "TaiKhoan";
            para[0].SqlDbType = SqlDbType.NVarChar;
            para[0].Value = tk.TenTaiKhoan;

            para[1] = new SqlParameter();
            para[1].ParameterName = "MatKhau";
            para[1].SqlDbType = SqlDbType.NVarChar;
            para[1].Value = tk.Password;

            DataTable value = dp.SqlExcuteQuery("sp_DangNhap", para);

            if (value.Rows.Count > 0)
            {
                tk.ID = int.Parse(value.Rows[0][0].ToString());
                tk.LoaiTK = int.Parse(value.Rows[0][1].ToString());
                tk.TenLoaiTK = value.Rows[0][2].ToString();
            }

            return tk;
        }
    }
}
