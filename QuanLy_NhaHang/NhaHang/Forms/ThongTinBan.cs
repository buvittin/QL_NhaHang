using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaHang.Forms
{
    public partial class ThongTinBan : Form
    {
        public String TenKhach = "";
        public String DiaChi = "";

        public ThongTinBan(String maban, String KhuVuc)
        {
            InitializeComponent();
            lbMaBan.Text = maban;
            lbKhuVuc.Text = KhuVuc;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            TenKhach = txtTenKhach.Text;
            DiaChi = txtDiaChi.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
