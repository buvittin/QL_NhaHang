using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BanBUS
    {
        private BanDAO dao = new BanDAO();

        public Ban[] DanhSachBan()
        {
            return dao.LayDanhSachBan();
        }

        public BanObject MoBan(BanObject bn)
        {
            if (bn.LoaiBan == 2)
            {
                bn.Tongtien = bn.Tongtien + 100000;
            }
            if (bn.LoaiBan == 1)
            {
                bn.Tongtien = bn.Tongtien + 50000;
            }

            return dao.MoBan(bn);
        }

        public bool ThemBan(int maloai)
        {
            return dao.ThemBan(maloai);
        }

        public bool CapNhapLoaiBan(Ban bn)
        {
            return dao.CapNhapLoaiBan(bn);
        }
    }
}
