using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class MenuBUS
    {
        public bool ThemVaoMenu(Menu mn)
        {
            return dao.ThemVaoMenu(mn);
        }

        private MenuDAO dao = new MenuDAO();

        public DataTable DSLoaiSanPham()
        {
            return dao.LayDSLoaiMon();
        }

        public DataTable ThucAnChuaCo()
        {
            return dao.ThucAnChuaCo();
        }

        public DataTable ThucUongChuaCo()
        {
            return dao.ThucUongChuaCo();
        }

        public MonAn[] DSThucDon()
        {
            return dao.LayDSThucDon();
        }

        public DataTable DSMonAn()
        {
            return dao.LayDSMon();
        }

        public DataTable DSNgLieu()
        {
            return dao.LayDSNL();
        }

        public bool ThemMon(string tenmon, NguyenLieu[] nl)
        {
            return dao.ThemMon(tenmon, nl);
        }

        public bool CapNhapNLMon(int id, NguyenLieu[] nl)
        {
            return dao.CapNhapNLMon(id, nl);
        }

        public DataTable LayNgLieuMon(int mamon)
        {
            return dao.LayNguyenLieuMon(mamon);
        }

        public bool GoiMon(int maph, MonAn ma)
        {
            return dao.GoiMon(maph, ma);
        }

        public bool CapNhapTTMon(MonAn ma)
        {
            return dao.CapNhapTTMon(ma);
        }

        public bool CapnhapSLGoi(int maph, MonAn ma)
        {
            return dao.CapnhapSLGoi(maph, ma);
        }

        public DataTable LayDSMonHoaDon(int maph)
        {
            return dao.LayDSMonHoaDon(maph);
        }
    }
}
