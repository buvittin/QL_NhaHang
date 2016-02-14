using BUS;
using DTO;
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
    public partial class DangNhap : Form
    {
        public TaiKhoan nguoidung = new TaiKhoan();
        private NhanVienBUS nvbus = new NhanVienBUS();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            nguoidung.TenTaiKhoan = txtTaiKhoan.Text;
            nguoidung.Password = txtpassword.Text;

            nguoidung = nvbus.DangNhap(nguoidung);
            if (nguoidung.ID > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, xem lại mật khẩu và tài khoản !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
