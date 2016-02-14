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
    public partial class KhuVucBan : Form
    {
        private BanBUS banbus = new BanBUS();
        private Ban[] dsban;
        private Ban sLBan = new Ban();

        public KhuVucBan()
        {
            InitializeComponent();
        }

        private void KhuVucBan_Load(object sender, EventArgs e)
        {
            LayDuLieu();
        }

        private void LayDuLieu()
        {
            dsban = banbus.DanhSachBan();

            lvBanThuong.Items.Clear();
            lvBanVIP.Items.Clear();

            ListViewItem temp;

            foreach (var item in dsban)
            {
                if (item.LoaiBan == 1)
                {
                    temp = new ListViewItem();
                    temp.ImageIndex = 0;
                    temp.Text = "Bàn " + item.MaBan;

                    lvBanThuong.Items.Add(temp);
                }
                else
                {
                    temp = new ListViewItem();
                    temp.ImageIndex = 0;
                    temp.Text = "Bàn " + item.MaBan;

                    lvBanVIP.Items.Add(temp);
                }
            }

            lvBanThuong.View = View.Tile;
            lvBanVIP.View = View.Tile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvBanThuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection SlItem = this.lvBanThuong.SelectedItems;

            if (SlItem.Count > 0)
            {
                ListViewItem temp = SlItem[0];
                sLBan = new BanObject();
                sLBan.MaBan = int.Parse(temp.Text.Replace("Bàn ", ""));
                sLBan.LoaiBan = 1;
                sLBan.TenLoai = "Khu thường";

                rbxThuong.Checked = true;
            }
        }

        private void lvBanVIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection SlItem = this.lvBanVIP.SelectedItems;

            if (SlItem.Count > 0)
            {
                ListViewItem temp = SlItem[0];
                sLBan.MaBan = int.Parse(temp.Text.Replace("Bàn ", ""));
                sLBan.LoaiBan = 2;
                sLBan.TenLoai = "Khu VIP";

                rbxVIP.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int ma = 1;
            if (!rbxThuong.Checked)
            {
                ma = 2;
            }

            if (banbus.ThemBan(ma))
            {
                MessageBox.Show("Thêm bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (!rbxThuong.Checked)
            {
                sLBan.LoaiBan = 2;
            }
            else
            {
                sLBan.LoaiBan = 1;
            }

            if (banbus.CapNhapLoaiBan(sLBan))
            {
                MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDuLieu();
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
