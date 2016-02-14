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
using System.IO;
using NhaHang.Properties;

namespace NhaHang.UseControl
{
    public partial class UCtrMenu : UserControl
    {
        private MonAn[] dsmon;
        private MenuBUS menubus = new MenuBUS();
        private DataTable dsLoaiSP = new DataTable();
        private MonAn SLMon = new MonAn();

        public UCtrMenu()
        {
            InitializeComponent();
        }

        private void UCtrMenu_Load(object sender, EventArgs e)
        {
            LayDuLieu();
        }

        private void LayDuLieu()
        {
            dsmon = menubus.DSThucDon();
            dsLoaiSP = menubus.DSLoaiSanPham();
            LayDanhSachMon();
            CaiDat();
        }

        private void CaiDat()
        {
            cbxLoai.DataSource = dsLoaiSP;
            cbxLoai.DisplayMember = "TenLoaiSanPham";
            cbxLoai.ValueMember = "ID";
            cbxLoai.SelectedIndex = 0;
        }

        private void lvMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = ((sender as ListView).SelectedItems as ListView.SelectedListViewItemCollection);
            if (items.Count > 0)
            {
                ListViewItem item = items[0];
                int ID = int.Parse(item.Name.Replace("MA", ""));

                SLMon = dsmon.Where(m => m.ID == ID).FirstOrDefault();
                lbTenMon.Text = SLMon.TenMonAn;
                txtGia.Text = SLMon.DonGia.ToString();
                txtHinh.Text = SLMon.HinhAnh;
                cbxLoai.SelectedValue = SLMon.MaLoaiSanPham;
            }
        }

        private void LayDanhSachMon()
        {
            tctrMonAn.TabPages.Clear();

            TabPage tptemp;
            ListView lvtemp;
            foreach (DataRow item in dsLoaiSP.Rows)
            {
                tptemp = new TabPage();
                lvtemp = new ListView();

                tptemp.Name = "tp" + item[0].ToString();
                tptemp.Text = item[1].ToString();

                lvtemp.Name = "lv" + item[0].ToString();
                lvtemp.Dock = DockStyle.Fill;
                lvtemp.View = View.LargeIcon;
                lvtemp.MultiSelect = false;

                tptemp.Controls.Add(lvtemp);
                tctrMonAn.TabPages.Add(tptemp);
            }

            ImageList imageListLarge;
            ImageList templist = new ImageList();
            templist.ImageSize = new Size(64, 64);
            templist.Images.Add(Resources.noimage);

            Bitmap bm;
            ListViewItem lvitem;
            ListView lv;
            foreach (DataRow l in dsLoaiSP.Rows)
            {
                imageListLarge = new ImageList();
                imageListLarge.ImageSize = new Size(64, 64);

                lv = new ListView();
                for (int i = 0; i < dsmon.Length; i++)
                {
                    lv = (ListView)tctrMonAn.Controls.Find("lv" + l[0].ToString(), true).FirstOrDefault();
                    lvitem = new ListViewItem();

                    if (dsmon[i].MaLoaiSanPham == int.Parse(l[0].ToString()))
                    {
                        if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh\\" + dsmon[i].HinhAnh))
                        {
                            lv.LargeImageList = templist;
                            lvitem.ImageIndex = 0;
                        }
                        else
                        {
                            bm = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh\\" + dsmon[i].HinhAnh);
                            imageListLarge.Images.Add(bm);
                            lv.LargeImageList = imageListLarge;
                            lvitem.ImageIndex = i;
                        }
                        lvitem.Text = dsmon[i].TenMonAn;
                        lvitem.Name = "MA" + dsmon[i].ID;

                        lv.Items.Add(lvitem);
                    }
                }

                lv.ItemActivate += new System.EventHandler(this.lvMonAn_SelectedIndexChanged);
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            SLMon.DonGia = int.Parse(txtGia.Text);
            SLMon.HinhAnh = txtHinh.Text;
            SLMon.MaLoaiSanPham = (int)cbxLoai.SelectedValue;

            for (int i = 0; i < dsmon.Length; i++)
            {
                if (dsmon[i].ID == SLMon.ID)
                {
                    dsmon[i] = SLMon;
                    break;
                }
            }

            //Cap nhap csdl
            if (menubus.CapNhapTTMon(SLMon))
            {
                MessageBox.Show("Câp nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDuLieu();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            ThucAnUong tmon = new ThucAnUong();
            tmon.ShowDialog();
            LayDuLieu();
        }

        private void btnHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Picture Files (.png)|*.png|(.jpg)|*.jpg|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Chọn hình đại diện";

            DialogResult result = openFileDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {
                string sourcepath = openFileDialog1.FileName;
                
                string name = DateTime.Now.ToString("yyyyMMddHHmmss");

                bool exists = Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh");

                if (!exists)
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh");

                File.Copy(sourcepath, AppDomain.CurrentDomain.BaseDirectory + "\\HinhAnh\\" + name + ".png");

                txtHinh.Text = name + ".png";
            }
        }
    }
}
