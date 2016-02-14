using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaHang.ReportFiles;

namespace NhaHang.Forms
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        public void KhoiTao(HoaDonCRP dsmon)
        {
            crpHoaDon.ReportSource = dsmon;
        }
    }
}
