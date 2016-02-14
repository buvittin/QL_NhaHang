using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NhaHang.Forms
{
    public partial class ThucAnUong : Form
    {
        private MenuBUS menubus = new MenuBUS();
        private DataTable dsThucan = new DataTable();
        private DataTable dsThucuong = new DataTable();
        private MonAn nm = new MonAn();
        private DataTable dsLoaiMon = new DataTable();

        public ThucAnUong()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThucAnUong_Load(object sender, EventArgs e)
        {
            LayDuLieu();
        }

        private void LayDuLieu()
        {
            dsLoaiMon = menubus.DSLoaiSanPham();

            cbxLoai1.DataSource = dsLoaiMon;
            cbxLoai1.DisplayMember = "TenLoaiSanPham";
            cbxLoai1.ValueMember = "ID";

            dsThucan = menubus.ThucAnChuaCo();
            dsThucuong = menubus.ThucUongChuaCo();

            lbxThucAn.DataSource = dsThucan;
            lbxThucAn.DisplayMember = "TenMon";
            lbxThucAn.ValueMember = "ID";

            lbxThucUong.DataSource = dsThucuong;
            lbxThucUong.DisplayMember = "TenNguyenLieu";
            lbxThucUong.ValueMember = "ID";
        }

        private void lbxThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenMon.Text = lbxThucAn.Text;
        }

        private void lbxThucUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbThucUong.Text = lbxThucUong.Text;
        }

        private void btnThemThucAn_Click(object sender, EventArgs e)
        {
            nm = new MonAn();
            nm.TenMonAn = lbxThucAn.Text;
            nm.MaSanPham = int.Parse(lbxThucAn.SelectedValue.ToString());
            nm.MaLoaiSanPham = int.Parse(cbxLoai1.SelectedValue.ToString());
            nm.DonGia = int.Parse(txtGia.Text);
            nm.HinhAnh = txtHinh.Text;

            if (menubus.ThemVaoMenu(nm))
            {
                MessageBox.Show("Thêm vào menu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nm = new MonAn();
                LayDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm vào menu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThucUong_Click(object sender, EventArgs e)
        {
            nm = new MonAn();
            nm.TenMonAn = lbxThucUong.Text;
            nm.MaSanPham = int.Parse(lbxThucUong.SelectedValue.ToString());
            nm.MaLoaiSanPham = 7;
            nm.DonGia = int.Parse(txtGia2.Text);
            nm.HinhAnh = txtHinh.Text;

            if (menubus.ThemVaoMenu(nm))
            {
                MessageBox.Show("Thêm vào menu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nm = new MonAn();
                LayDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm vào menu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Picture Files (.png)|*.png|(.jpg)|*.jpg|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Chọn hình cho món ăn";

            DialogResult result = openFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {
                string sourcepath = openFileDialog1.FileName;

                string name = DateTime.Now.ToString("yyyyMMddHHmmss");

                bool exists = System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh");

                if (!exists)
                    System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh");

                File.Copy(sourcepath, AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh\\" + name + ".png");

                txtHinh.Text = name + ".png";
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Picture Files (.png)|*.png|(.jpg)|*.jpg|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Chọn hình cho thức uống";

            DialogResult result = openFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {
                string sourcepath = openFileDialog1.FileName;

                string name = DateTime.Now.ToString("yyyyMMddHHmmss");

                bool exists = System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh");

                if (!exists)
                    System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh");

                File.Copy(sourcepath, AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh\\" + name + ".png");

                txtHinh2.Text = name + ".png";
            }
        }
    }
}
