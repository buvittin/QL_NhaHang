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
        public Frm_Main()
        {
            InitializeComponent();
            //menuButton1.H
        }

        private void menuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void menuButton1_ButtonHover(object sender, EventArgs e)
        {
            menuButton1.BackColor = Color.Aqua;
        }

        private void menuButton1_ButtonLeave(object sender, EventArgs e)
        {
            menuButton1.BackColor = Color.Transparent;
        }
    }
}
