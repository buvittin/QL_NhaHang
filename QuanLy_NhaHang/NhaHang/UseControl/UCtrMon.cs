using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaHang.UseControl
{
    public partial class UCtrMon : UserControl
    {
        private MenuBUS menubus = new MenuBUS();
        private DataTable dsmon = new DataTable();
        private DataTable nguyenlieumn = new DataTable();
        private DataTable dsnglieu = new DataTable();

        public UCtrMon()
        {
            InitializeComponent();
        }

        private void UCtrMon_Load(object sender, EventArgs e)
        {
            LayDuLieu();
        }

        private void LayDuLieu()
        {
            dsmon = menubus.DSMonAn();
            lbxDSMon.DataSource = dsmon;
            lbxDSMon.DisplayMember = "TenMon";
            lbxDSMon.ValueMember = "ID";
        
            dsnglieu = menubus.DSNgLieu();

            lbcNguyenLieu.DataSource = dsnglieu;
            lbcNguyenLieu.DisplayMember = "TenNguyenLieu";
            lbcNguyenLieu.ValueMember = "ID";
        }

        private void lbxDSMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idmon = int.Parse(dsmon.Rows[lbxDSMon.SelectedIndex][0].ToString());
            txtTenMon.Text = dsmon.Rows[lbxDSMon.SelectedIndex][1].ToString();

            nguyenlieumn = menubus.LayNgLieuMon(idmon);
            CaiDGV();
            dgvNguyenLieuMon.DataSource = nguyenlieumn;
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            String tenmon = txtTenMon.Text;
            NguyenLieu[] nl = GetDataFromTable(nguyenlieumn);

            if (menubus.ThemMon(tenmon, nl))
            {
                MessageBox.Show("Thêm món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm món thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CaiDGV()
        {
            dgvNguyenLieuMon.Columns.Clear();

            DataGridViewTextBoxColumn dgvcl = new DataGridViewTextBoxColumn();
            dgvcl.HeaderText = "ID";
            dgvcl.DataPropertyName = "MaNguyenLieu";
            dgvcl.Width = 70;
            dgvNguyenLieuMon.Columns.Add(dgvcl);

            dgvcl = new DataGridViewTextBoxColumn();
            dgvcl.HeaderText = "Tên Nguyên Liệu";
            dgvcl.DataPropertyName = "TenNguyenLieu";
            dgvcl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNguyenLieuMon.Columns.Add(dgvcl);

            dgvcl = new DataGridViewTextBoxColumn();
            dgvcl.HeaderText = "Đơn vị";
            dgvcl.DataPropertyName = "DonViTinh";
            dgvcl.Width = 50;
            dgvNguyenLieuMon.Columns.Add(dgvcl);

            dgvcl = new DataGridViewTextBoxColumn();
            dgvcl.HeaderText = "Số lượng";
            dgvcl.DataPropertyName = "SoLuong";
            dgvcl.Width = 70;
            dgvNguyenLieuMon.Columns.Add(dgvcl);
        }

        private void btnThemNL_Click(object sender, EventArgs e)
        {
            if (lbcNguyenLieu.CheckedItems.Count < 1)
            {
                return;
            }

            NguyenLieu[] nglchon = new NguyenLieu[lbcNguyenLieu.CheckedItems.Count];

            for (int i = 0; i < nglchon.Length; i++)
            {
                nglchon[i] = new NguyenLieu();
                nglchon[i].ID = int.Parse((lbcNguyenLieu.CheckedItems[i] as DataRowView).Row[0].ToString());
                nglchon[i].TenNguyenLieu = (lbcNguyenLieu.CheckedItems[i] as DataRowView).Row[1].ToString();
                nglchon[i].DonViTinh = (lbcNguyenLieu.CheckedItems[i] as DataRowView).Row[2].ToString();
            }

            for (int i = 0; i < nglchon.Length; i++)
            {
                int j = 0;
                for (; j < nguyenlieumn.Rows.Count; j++)
                {
                    int id = int.Parse(nguyenlieumn.Rows[j][0].ToString());

                    if (id == nglchon[i].ID)
                    {
                        int sl = int.Parse(nguyenlieumn.Rows[j][3].ToString());
                        nguyenlieumn.Rows[j].SetField(3 , sl + 1);
                        break;
                    }
                }

                if (j == nguyenlieumn.Rows.Count)
                {
                    DataRow dr = nguyenlieumn.NewRow();
                    dr["MaNguyenLieu"] = nglchon[i].ID;
                    dr["TenNguyenLieu"] = nglchon[i].TenNguyenLieu;
                    dr["DonViTinh"] = nglchon[i].DonViTinh;
                    dr["SoLuong"] = 1;

                    nguyenlieumn.Rows.Add(dr);
                }
            }

            CaiDGV();
            dgvNguyenLieuMon.DataSource = nguyenlieumn;
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lbxDSMon.SelectedValue.ToString());
            NguyenLieu[] nl = GetDataFromTable(nguyenlieumn);

            if (menubus.CapNhapNLMon(id, nl))
            {
                MessageBox.Show("Cập nhập món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDuLieu();
            }
            else
            {
                MessageBox.Show("Cập nhập món thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public NguyenLieu[] GetDataFromTable(DataTable data)
        {
            NguyenLieu[] result = new NguyenLieu[data.Rows.Count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new NguyenLieu();

                result[i].ID = int.Parse(data.Rows[i][0].ToString());
                result[i].TenNguyenLieu = data.Rows[i][1].ToString();
                result[i].DonViTinh = data.Rows[i][2].ToString();
                result[i].SoLuong = float.Parse(data.Rows[i][3].ToString());
            }

            return result;
        }
    }
}
