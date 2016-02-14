using BUS;
using DTO;
using NhaHang.DataSet;
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
    public partial class ThanhToan : Form
    {
        private MenuBUS menubus = new MenuBUS();
        private BanObject sLBan = new BanObject();

        public ThanhToan(BanObject bn)
        {
            InitializeComponent();
            sLBan = bn;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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
            crp.SetParameterValue("MaBan", sLBan.MaBan);
            crp.SetParameterValue("KhuBan", sLBan.TenLoai);
            crp.SetParameterValue("ThoiGian", sLBan.ThoiGian);
            crp.SetParameterValue("TenKhach", sLBan.TenKhachHang);
            crp.SetParameterValue("DiaChi", sLBan.DiaChi);

            HoaDon frmhd = new HoaDon();
            frmhd.StartPosition = FormStartPosition.CenterScreen;
            frmhd.KhoiTao(crp);
            frmhd.Show();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            lbMaBan.Text = sLBan.MaBan.ToString();
            lbKhuVuc.Text = sLBan.TenLoai;
            lbThoiGian.Text = sLBan.ThoiGian.ToString();
            lbTenKhach.Text = sLBan.TenKhachHang;
            lbDiaChi.Text = sLBan.DiaChi;
            dgvDSMon.DataSource = sLBan.DSGoiMon;
            CaiDatDGV();
        }

        private void CaiDatDGV()
        {
            dgvDSMon.Columns.Clear();
            DataGridViewTextBoxColumn dgvcl = new DataGridViewTextBoxColumn();
            dgvcl.HeaderText = "Tên món";
            dgvcl.DataPropertyName = "TenMonAn";
            dgvcl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSMon.Columns.Add(dgvcl);

            DataGridViewTextBoxColumn dgvcl1 = new DataGridViewTextBoxColumn();
            dgvcl1.HeaderText = "Đơn giá";
            dgvcl1.DataPropertyName = "DonGia";
            dgvcl1.Width = 100;
            dgvDSMon.Columns.Add(dgvcl1);

            DataGridViewTextBoxColumn dgvcl2 = new DataGridViewTextBoxColumn();
            dgvcl2.HeaderText = "Số lượng";
            dgvcl2.DataPropertyName = "SoLuong";
            dgvcl2.Width = 70;
            dgvDSMon.Columns.Add(dgvcl2);

            DataGridViewTextBoxColumn dgvcl3 = new DataGridViewTextBoxColumn();
            dgvcl3.DataPropertyName = "ID";
            dgvcl3.Visible = false;
            dgvDSMon.Columns.Add(dgvcl3);

            DataGridViewTextBoxColumn dgvcl4 = new DataGridViewTextBoxColumn();
            dgvcl4.DataPropertyName = "MaLoaiSanPham";
            dgvcl4.Visible = false;
            dgvDSMon.Columns.Add(dgvcl4);

            DataGridViewTextBoxColumn dgvcl5 = new DataGridViewTextBoxColumn();
            dgvcl5.DataPropertyName = "HinhAnh";
            dgvcl5.Visible = false;
            dgvDSMon.Columns.Add(dgvcl5);

            DataGridViewTextBoxColumn dgvcl6 = new DataGridViewTextBoxColumn();
            dgvcl6.DataPropertyName = "MaSanPham";
            dgvcl6.Visible = false;
            dgvDSMon.Columns.Add(dgvcl6);

            DataGridViewTextBoxColumn dgvcl7 = new DataGridViewTextBoxColumn();
            dgvcl7.DataPropertyName = "TenLoaiSanPham";
            dgvcl7.Visible = false;
            dgvDSMon.Columns.Add(dgvcl7);
        }
    }
}
