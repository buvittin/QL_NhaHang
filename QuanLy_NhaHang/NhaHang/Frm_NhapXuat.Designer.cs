namespace NhaHang
{
    partial class Frm_NhapXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhapXuat));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NLMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLSoL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuButton2 = new NhaHang.UseControl.MenuButton();
            this.menuButton1 = new NhaHang.UseControl.MenuButton();
            this.menuButton5 = new NhaHang.UseControl.MenuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NLMa,
            this.NLTen,
            this.NLSoL,
            this.NLDonVi,
            this.NLLoai,
            this.NLNCC});
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(414, 446);
            this.dataGridView1.TabIndex = 7;
            // 
            // NLMa
            // 
            this.NLMa.DataPropertyName = "ID";
            this.NLMa.FillWeight = 20F;
            this.NLMa.HeaderText = "Mã";
            this.NLMa.Name = "NLMa";
            this.NLMa.ReadOnly = true;
            // 
            // NLTen
            // 
            this.NLTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NLTen.DataPropertyName = "TenNguyenLieu";
            this.NLTen.HeaderText = "Tên";
            this.NLTen.Name = "NLTen";
            this.NLTen.ReadOnly = true;
            // 
            // NLSoL
            // 
            this.NLSoL.DataPropertyName = "SoLuong";
            this.NLSoL.FillWeight = 30F;
            this.NLSoL.HeaderText = "Số lượng";
            this.NLSoL.Name = "NLSoL";
            this.NLSoL.ReadOnly = true;
            // 
            // NLDonVi
            // 
            this.NLDonVi.DataPropertyName = "DonViTinh";
            this.NLDonVi.FillWeight = 30F;
            this.NLDonVi.HeaderText = "Đơn vị";
            this.NLDonVi.Name = "NLDonVi";
            this.NLDonVi.ReadOnly = true;
            // 
            // NLLoai
            // 
            this.NLLoai.DataPropertyName = "TenLoai";
            this.NLLoai.FillWeight = 30F;
            this.NLLoai.HeaderText = "Loại";
            this.NLLoai.Name = "NLLoai";
            this.NLLoai.ReadOnly = true;
            // 
            // NLNCC
            // 
            this.NLNCC.DataPropertyName = "TenNhaCungCap";
            this.NLNCC.FillWeight = 150F;
            this.NLNCC.HeaderText = "Nhà cung cấp";
            this.NLNCC.Name = "NLNCC";
            this.NLNCC.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.Location = new System.Drawing.Point(528, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(422, 454);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.FillWeight = 20F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNguyenLieu";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.FillWeight = 30F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonViTinh";
            this.dataGridViewTextBoxColumn4.FillWeight = 30F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn vị";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenLoai";
            this.dataGridViewTextBoxColumn5.FillWeight = 30F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Loại";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TenNhaCungCap";
            this.dataGridViewTextBoxColumn6.FillWeight = 150F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Nhà cung cấp";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(438, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 26);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số lượng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(962, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(142, 22);
            this.toolStripButton1.Text = "Thêm nguyên liệu mới";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(154, 22);
            this.toolStripButton2.Text = "Thêm nhà cung cấp mới";
            // 
            // menuButton2
            // 
            this.menuButton2.BackColor = System.Drawing.Color.Transparent;
            this.menuButton2.HinhAnh = global::NhaHang.Properties.Resources._1451894096_bill;
            this.menuButton2.Location = new System.Drawing.Point(436, 231);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Nhan = "Bớt";
            this.menuButton2.Size = new System.Drawing.Size(80, 80);
            this.menuButton2.TabIndex = 5;
            this.menuButton2.ToaDoNhan = new System.Drawing.Point(0, 61);
            // 
            // menuButton1
            // 
            this.menuButton1.BackColor = System.Drawing.Color.Transparent;
            this.menuButton1.HinhAnh = global::NhaHang.Properties.Resources._1451894096_bill;
            this.menuButton1.Location = new System.Drawing.Point(436, 145);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Nhan = "Thêm";
            this.menuButton1.Size = new System.Drawing.Size(80, 80);
            this.menuButton1.TabIndex = 5;
            this.menuButton1.ToaDoNhan = new System.Drawing.Point(0, 61);
            // 
            // menuButton5
            // 
            this.menuButton5.BackColor = System.Drawing.Color.Transparent;
            this.menuButton5.HinhAnh = global::NhaHang.Properties.Resources._1451894096_bill;
            this.menuButton5.Location = new System.Drawing.Point(436, 388);
            this.menuButton5.Name = "menuButton5";
            this.menuButton5.Nhan = "Hoàn tất";
            this.menuButton5.Size = new System.Drawing.Size(80, 80);
            this.menuButton5.TabIndex = 5;
            this.menuButton5.ToaDoNhan = new System.Drawing.Point(0, 61);
            // 
            // Frm_NhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 486);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuButton2);
            this.Controls.Add(this.menuButton1);
            this.Controls.Add(this.menuButton5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(968, 510);
            this.MinimumSize = new System.Drawing.Size(968, 510);
            this.Name = "Frm_NhapXuat";
            this.Text = "Frm_NhapXuat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UseControl.MenuButton menuButton5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLSoL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLNCC;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private UseControl.MenuButton menuButton1;
        private UseControl.MenuButton menuButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;

    }
}