using DTO;
using NhaHang.UseControl;
using NhaHang.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaHang
{
    public partial class Frm_Main : Form
    {
        private TaiKhoan nguoidung = new TaiKhoan();

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            DangNhap();
            if (nguoidung.ID > 0)
            {
                this.Visible = true;
            }
            else
            {
                this.Close();
            }

            UCtrBanHang bh = new UCtrBanHang(nguoidung);
            bh.Dock = DockStyle.Fill;
            plContent.Controls.Add(bh);
        }

        private void DangNhap()
        {
            using (DangNhap dnForm = new DangNhap())
            {
                dnForm.StartPosition = FormStartPosition.CenterScreen;
                var result = dnForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    nguoidung = dnForm.nguoidung;
                }
            }
        }

        private void nbBanHang_ButtonClick(object sender, EventArgs e)
        {
            UCtrBanHang bh = new UCtrBanHang(nguoidung);
            bh.Dock = DockStyle.Fill;
            plContent.Controls.Clear();
            plContent.Controls.Add(bh);
        }

        private void mbQLBanHang_ButtonClick(object sender, EventArgs e)
        {
            UCtrQLBanHang bh = new UCtrQLBanHang();
            bh.Dock = DockStyle.Fill;
            plContent.Controls.Clear();
            plContent.Controls.Add(bh);
        }

        private void mbBaoCao_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}
