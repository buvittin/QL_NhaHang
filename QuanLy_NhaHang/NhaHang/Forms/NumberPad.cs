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
    public partial class NumberPad : Form
    {
        public int number = 0;
        private string temp = "";

        public NumberPad()
        {
            InitializeComponent();
        }

        private void NumberPad_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (int.Parse(temp) < 1)
            {
                MessageBox.Show("Không thể nhập số nhỏ hơn 1.");
                return;
            }
            number = int.Parse(temp);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            string nm = ((Button)sender).Name.Replace("Num", "");
            temp = temp + nm;
            txtNum.Text = temp;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
