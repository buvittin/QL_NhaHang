using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO dao = new NhanVienDAO();

        public TaiKhoan DangNhap(TaiKhoan tk)
        {
            return dao.DangNhap(tk);
        }


    }
}
