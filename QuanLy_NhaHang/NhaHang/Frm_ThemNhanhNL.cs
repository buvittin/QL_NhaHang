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
    public partial class Frm_ThemNhanhNL : Form
    {
        public Frm_ThemNhanhNL()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            Frm_ThemNhanhNCC tmncc = new Frm_ThemNhanhNCC();
            tmncc.ShowDialog();
        }
    }
}
