using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using BUS;
using DTO;
using System.Windows.Forms;
using NhaHang.Properties;
using NhaHang.Forms;
using NhaHang.DataSet;
using System.IO;
using NhaHang.ReportFiles;

namespace NhaHang.UseControl
{
    public partial class UCtrBanHang : UserControl
    {
        private BanBUS banbus = new BanBUS();
        private MenuBUS menubus = new MenuBUS();
        private BanObject[] dsban;
        //Ban duoc chon
        private BanObject sLBan = new BanObject();
        //Danh sach mon an
        private MonAn[] dsmon;
        //Danh Sach mon an da goi
        private List<MonAn> goimon = new List<MonAn>();
        private TaiKhoan nguoidung = new TaiKhoan();

        public UCtrBanHang(TaiKhoan tk)
        {
            InitializeComponent();

            nguoidung = tk;
        }

        private void UCtrBanHang_Load(object sender, EventArgs e)
        {
            CaiDat();
            CaiDatDGV();
            dsban = BanObject.GetArrayData(banbus.DanhSachBan());
            LoadDSBan(dsban);
            dsmon = menubus.DSThucDon();
            LayDanhSachMon();

            if (lvBanThuong.Items.Count > 0)
            {
                lvBanThuong.Items[0].Selected = true;
                lvBanThuong.Select();
            }
        }

        private void LayDanhSachMon()
        {
            tctrMonAn.TabPages.Clear();

            DataTable dsLoaiSP = menubus.DSLoaiSanPham();
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

        private void lvMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = ((sender as ListView).SelectedItems as ListView.SelectedListViewItemCollection);

            if (items.Count > 0)
            {
                dgvThucDon.DataSource = goimon;
                CaiDatDGV();

                plgoimon.Visible = true;

                ListViewItem item = items[0];
                int ID = int.Parse(item.Name.Replace("MA",""));
                MonAn temp = new MonAn();// = dsmon.Where(mons => mons.ID == ID).FirstOrDefault();
                for (int i = 0; i < dsmon.Length; i++)
                {
                    if (dsmon[i].ID == ID)
                    {
                        temp = dsmon[i];
                        break;
                    }
                }
                temp.SoLuong = 1;

                using (var num = new NumberPad())
                {
                    num.StartPosition = FormStartPosition.CenterParent;
                    var result = num.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        temp.SoLuong = num.number;
                    }
                    else
                    {
                        return;
                    }
                }

                if (goimon.Where(mn => mn.ID == temp.ID).ToList().Count > 0)
                {
                    for (int i = 0; i < goimon.Count; i++)
                    {
                        if (goimon[i].ID == temp.ID)
                        {
                            goimon[i].SoLuong += temp.SoLuong;
                            break;
                        }
                    }

                    dgvThucDon.DataSource = null;
                    dgvThucDon.DataSource = goimon;
                    CaiDatDGV();
                }
                else
                {
                    goimon.Add(temp);
                    dgvThucDon.DataSource = null;
                    dgvThucDon.DataSource = goimon;
                    CaiDatDGV();
                }
            }
        }

        private void LoadDSBan(Ban[] dsbans)
        {
            lvBanThuong.Items.Clear();
            lvBanVIP.Items.Clear();

            ListViewItem temp;
            dsbans = banbus.DanhSachBan();

            foreach (var item in dsbans)
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

                lbBan.Text = "Bàn : " + sLBan.MaBan + " Khu thường";

                for (int i = 0; i < dsban.Length; i++)
                {
                    if (dsban[i].MaBan == sLBan.MaBan)
                    {
                        if (dsban[i].IDPhieuGoi > 0)
                        {
                            //Da mo ban
                            sLBan = dsban[i];
                            CaiDatHTTTBan(true);
                            dgvThucDon.DataSource = dsban[i].DSGoiMon;
                            CaiDatDGV();
                            break;
                        }
                        else
                        {
                            //Chua mo ban
                            CaiDatHTTTBan(false);
                            dgvThucDon.DataSource = null;
                            CaiDatDGV();
                            break;
                        }
                    }
                }
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

                lbBan.Text = "Bàn : " + sLBan.MaBan + " Khu VIP";

                for (int i = 0; i < dsban.Length; i++)
                {
                    if (dsban[i].MaBan == sLBan.MaBan)
                    {
                        if (dsban[i].IDPhieuGoi > 0)
                        {
                            //Da mo ban
                            sLBan = dsban[i];
                            CaiDatHTTTBan(true);
                            dgvThucDon.DataSource = dsban[i].DSGoiMon;
                            CaiDatDGV();
                            break;
                        }
                        else
                        {
                            //Chua mo ban
                            CaiDatHTTTBan(false);
                            dgvThucDon.DataSource = null;
                            CaiDatDGV();
                            break;
                        }
                    }
                }
            }
        }

        private void btnMoBan_Click(object sender, EventArgs e)
        {
            if (sLBan.IDPhieuGoi < 1)
            {
                ThongTinBan ttb = new ThongTinBan(sLBan.MaBan.ToString(), sLBan.TenLoai);
                ttb.StartPosition = FormStartPosition.CenterParent;
                var result = ttb.ShowDialog();

                if (result == DialogResult.OK)
                {
                    sLBan.TenKhachHang = ttb.TenKhach;
                    sLBan.DiaChi = ttb.DiaChi;
                    sLBan.ThoiGian = DateTime.Now;
                    sLBan.TaiKhoan = nguoidung;
                }
                else
                {
                    return;
                }

                sLBan =  banbus.MoBan(sLBan);

                if (sLBan.IDPhieuGoi > 0)
                {
                    MessageBox.Show("Mở bàn thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = 0; i < dsban.Length; i++)
                    {
                        if (sLBan.MaBan == dsban[i].MaBan)
                        {
                            dsban[i].MaBan = sLBan.MaBan;
                        }
                    }
                    CaiDatHTTTBan(true);
                }
                else
                {
                    MessageBox.Show("Mở bàn thất bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for(int i = 0; i < dsban.Length; i++)
                {
                    if (dsban[i].MaBan == sLBan.MaBan)
                    {
                        dsban[i] = sLBan;
                    }
                }
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var tt = new ThanhToan(sLBan);
            tt.Show();
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonCRP crp = new HoaDonCRP();
            HoaDonDataSet dts = new HoaDonDataSet();

            DataTable hoadontb = dts.HoaDonTT.Clone();
            //Lay danh sach mon da goi
            DataTable temp = menubus.LayDSMonHoaDon(sLBan.IDPhieuGoi);
            //Do du lieu sang hoadontb
            //DO DO
            hoadontb = temp;

            crp.SetDataSource(hoadontb);
            crp.SetParameterValue("MaBan",sLBan.MaBan);
            crp.SetParameterValue("KhuBan",sLBan.TenLoai);
            crp.SetParameterValue("ThoiGian",sLBan.ThoiGian);
            crp.SetParameterValue("TenKhach",sLBan.TenKhachHang);
            crp.SetParameterValue("DiaChi",sLBan.DiaChi);

            HoaDon frmhd = new HoaDon();
            frmhd.StartPosition = FormStartPosition.CenterScreen;
            frmhd.KhoiTao(crp);
            frmhd.Show();
        }

        private void btnHuygoi_Click(object sender, EventArgs e)
        {
            goimon.Clear();
            plgoimon.Visible = false;
            dgvThucDon.DataSource = sLBan.DSGoiMon;
        }

        private void btngoimon_Click(object sender, EventArgs e)
        {
            if (goimon.Count < 1)
            {
                MessageBox.Show("Không có món nào được chọn !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            MonAn mn;

            foreach (var mon in goimon)
            {
                mn = new MonAn();
                mn = sLBan.DSGoiMon.SingleOrDefault(m => m.ID == mon.ID);

                if (mn != null)
                {
                    //Them sl vao mon cu
                    //foreach (var item in sLBan.DSGoiMon.Where(m => m.ID == mon.ID))
                    //{
                    //    item.SoLuong += mon.SoLuong;                        
                    //}

                    for (int i = 0; i < sLBan.DSGoiMon.Count; i++)
                    {
                        if (mon.ID == sLBan.DSGoiMon[i].ID)
                        {
                            sLBan.DSGoiMon[i].SoLuong += mon.SoLuong;
                        }
                    }

                    for (int i = 0; i < dsban.Length; i++)
                    {
                        if (dsban[i].MaBan == sLBan.MaBan)
                        {
                            dsban[i] = sLBan;
                        }
                    }
                    //Cap nhap xuon csdl
                    menubus.CapnhapSLGoi(sLBan.IDPhieuGoi, mon);
                }
                else
                {
                    //Them mon vao danh sach
                    sLBan.DSGoiMon.Add(mon);
                    for (int i = 0; i < dsban.Length; i++)
                    {
                        if (dsban[i].MaBan == sLBan.MaBan)
                        {
                            dsban[i] = sLBan;
                        }
                    }
                    //Them xuong csdl
                    menubus.GoiMon(sLBan.IDPhieuGoi, mon);
                }
            }

            goimon.Clear();
            plgoimon.Visible = false;
            dgvThucDon.DataSource = sLBan.DSGoiMon;
            CaiDatDGV();
        }

        private void btnInbep_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da in o bep.");
        }

        private void CaiDat()
        {
            //Ban
            ImageList imageListLarge = new ImageList();
            imageListLarge.Images.Add(Resources._1451894096_bill);
            imageListLarge.ImageSize = new Size(64, 64);

            lvBanThuong.LargeImageList = imageListLarge;
            lvBanThuong.View = View.LargeIcon;
            lvBanVIP.LargeImageList = imageListLarge;
            lvBanVIP.View = View.LargeIcon;
        }

        private void CaiDatDGV()
        {
            dgvThucDon.Columns.Clear();
            DataGridViewTextBoxColumn dgvcl = new DataGridViewTextBoxColumn();
            dgvcl.HeaderText = "Tên món";
            dgvcl.DataPropertyName = "TenMonAn";
            dgvcl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvThucDon.Columns.Add(dgvcl);

            DataGridViewTextBoxColumn dgvcl1 = new DataGridViewTextBoxColumn();
            dgvcl1.HeaderText = "Đơn giá";
            dgvcl1.DataPropertyName = "DonGia";
            dgvcl1.Width = 100;
            dgvThucDon.Columns.Add(dgvcl1);

            DataGridViewTextBoxColumn dgvcl2 = new DataGridViewTextBoxColumn();
            dgvcl2.HeaderText = "Số lượng";
            dgvcl2.DataPropertyName = "SoLuong";
            dgvcl2.Width = 70;
            dgvThucDon.Columns.Add(dgvcl2);

            DataGridViewTextBoxColumn dgvcl3 = new DataGridViewTextBoxColumn();
            dgvcl3.DataPropertyName = "ID";
            dgvcl3.Visible = false;
            dgvThucDon.Columns.Add(dgvcl3);

            DataGridViewTextBoxColumn dgvcl4 = new DataGridViewTextBoxColumn();
            dgvcl4.DataPropertyName = "MaLoaiSanPham";
            dgvcl4.Visible = false;
            dgvThucDon.Columns.Add(dgvcl4);

            DataGridViewTextBoxColumn dgvcl5 = new DataGridViewTextBoxColumn();
            dgvcl5.DataPropertyName = "HinhAnh";
            dgvcl5.Visible = false;
            dgvThucDon.Columns.Add(dgvcl5);

            DataGridViewTextBoxColumn dgvcl6 = new DataGridViewTextBoxColumn();
            dgvcl6.DataPropertyName = "MaSanPham";
            dgvcl6.Visible = false;
            dgvThucDon.Columns.Add(dgvcl6);

            DataGridViewTextBoxColumn dgvcl7 = new DataGridViewTextBoxColumn();
            dgvcl7.DataPropertyName = "TenLoaiSanPham";
            dgvcl7.Visible = false;
            dgvThucDon.Columns.Add(dgvcl7);
        }

        private void CaiDatHTTTBan(bool TF)
        {
            if (!TF)
            {
                //Chua mo ban
                btnMoBan.Enabled = true;
                btnThanhToan.Enabled = false;
                btnInHoaDon.Enabled = false;
                btnChuyenBan.Enabled = false;
                btnHuyBan.Enabled = false;
            }
            else
            {
                //Da mo ban
                btnMoBan.Enabled = false;
                btnThanhToan.Enabled = true;
                btnInHoaDon.Enabled = true;
                btnChuyenBan.Enabled = true;
                btnHuyBan.Enabled = true;
            }
        }
    }
}
