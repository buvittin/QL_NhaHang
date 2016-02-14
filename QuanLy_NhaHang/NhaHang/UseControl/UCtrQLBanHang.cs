using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using NhaHang.Forms;

namespace NhaHang.UseControl
{
    public partial class UCtrQLBanHang : UserControl
    {
        public UCtrQLBanHang()
        {
            InitializeComponent();
        }

        private void UCtrQLBanHang_Load(object sender, EventArgs e)
        {
            plContent.Controls.Clear();
            UCtrMenu mn = new UCtrMenu();
            mn.Dock = DockStyle.Fill;
            plContent.Controls.Add(mn);

            btnMenu.Focus();
        }

        private void btnKhuVucBan_Click(object sender, EventArgs e)
        {
            KhuVucBan kvb = new KhuVucBan();
            kvb.StartPosition = FormStartPosition.CenterParent;
            kvb.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            plContent.Controls.Clear();
            UCtrMenu mn = new UCtrMenu();
            mn.Dock = DockStyle.Fill;
            plContent.Controls.Add(mn);

            btnMenu.Focus();
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            plContent.Controls.Clear();
            UCtrMon mn = new UCtrMon();
            mn.Dock = DockStyle.Fill;
            plContent.Controls.Add(mn);

            btnMenu.Focus();
        }

        private void btnNuoc_Click(object sender, EventArgs e)
        {
            ThucAnUong tu = new ThucAnUong();
            tu.StartPosition = FormStartPosition.CenterParent;
            tu.ShowDialog();
        }
    }
}

