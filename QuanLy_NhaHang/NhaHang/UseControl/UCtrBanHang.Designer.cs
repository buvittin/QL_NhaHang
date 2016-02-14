namespace NhaHang.UseControl
{
    partial class UCtrBanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tCtrKhuBan = new System.Windows.Forms.TabControl();
            this.tp_KhuThuong = new System.Windows.Forms.TabPage();
            this.lvBanThuong = new System.Windows.Forms.ListView();
            this.tp_KhuVIP = new System.Windows.Forms.TabPage();
            this.lvBanVIP = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plgoimon = new System.Windows.Forms.Panel();
            this.btnHuygoi = new System.Windows.Forms.Button();
            this.btnInbep = new System.Windows.Forms.Button();
            this.btngoimon = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.btnMoBan = new System.Windows.Forms.Button();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.lbBan = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.btnHuyBan = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tctrMonAn = new System.Windows.Forms.TabControl();
            this.tCtrKhuBan.SuspendLayout();
            this.tp_KhuThuong.SuspendLayout();
            this.tp_KhuVIP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.plgoimon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.tctrMonAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCtrKhuBan
            // 
            this.tCtrKhuBan.Controls.Add(this.tp_KhuThuong);
            this.tCtrKhuBan.Controls.Add(this.tp_KhuVIP);
            this.tCtrKhuBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.tCtrKhuBan.Location = new System.Drawing.Point(0, 0);
            this.tCtrKhuBan.Name = "tCtrKhuBan";
            this.tCtrKhuBan.SelectedIndex = 0;
            this.tCtrKhuBan.Size = new System.Drawing.Size(252, 534);
            this.tCtrKhuBan.TabIndex = 0;
            // 
            // tp_KhuThuong
            // 
            this.tp_KhuThuong.BackColor = System.Drawing.SystemColors.Control;
            this.tp_KhuThuong.Controls.Add(this.lvBanThuong);
            this.tp_KhuThuong.Location = new System.Drawing.Point(4, 28);
            this.tp_KhuThuong.Name = "tp_KhuThuong";
            this.tp_KhuThuong.Padding = new System.Windows.Forms.Padding(3);
            this.tp_KhuThuong.Size = new System.Drawing.Size(244, 502);
            this.tp_KhuThuong.TabIndex = 0;
            this.tp_KhuThuong.Text = "Khu thường";
            // 
            // lvBanThuong
            // 
            this.lvBanThuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBanThuong.Location = new System.Drawing.Point(3, 3);
            this.lvBanThuong.MultiSelect = false;
            this.lvBanThuong.Name = "lvBanThuong";
            this.lvBanThuong.Size = new System.Drawing.Size(238, 496);
            this.lvBanThuong.TabIndex = 0;
            this.lvBanThuong.UseCompatibleStateImageBehavior = false;
            this.lvBanThuong.SelectedIndexChanged += new System.EventHandler(this.lvBanThuong_SelectedIndexChanged);
            // 
            // tp_KhuVIP
            // 
            this.tp_KhuVIP.BackColor = System.Drawing.SystemColors.Control;
            this.tp_KhuVIP.Controls.Add(this.lvBanVIP);
            this.tp_KhuVIP.Location = new System.Drawing.Point(4, 28);
            this.tp_KhuVIP.Name = "tp_KhuVIP";
            this.tp_KhuVIP.Padding = new System.Windows.Forms.Padding(3);
            this.tp_KhuVIP.Size = new System.Drawing.Size(244, 502);
            this.tp_KhuVIP.TabIndex = 1;
            this.tp_KhuVIP.Text = "Khu V.I.P";
            // 
            // lvBanVIP
            // 
            this.lvBanVIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBanVIP.Location = new System.Drawing.Point(3, 3);
            this.lvBanVIP.MultiSelect = false;
            this.lvBanVIP.Name = "lvBanVIP";
            this.lvBanVIP.Size = new System.Drawing.Size(238, 496);
            this.lvBanVIP.TabIndex = 0;
            this.lvBanVIP.UseCompatibleStateImageBehavior = false;
            this.lvBanVIP.SelectedIndexChanged += new System.EventHandler(this.lvBanVIP_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.plgoimon);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.lbThoiGian);
            this.panel1.Controls.Add(this.btnMoBan);
            this.panel1.Controls.Add(this.btnChuyenBan);
            this.panel1.Controls.Add(this.lbBan);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnHuyBan);
            this.panel1.Controls.Add(this.btnInHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(252, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 534);
            this.panel1.TabIndex = 1;
            // 
            // plgoimon
            // 
            this.plgoimon.Controls.Add(this.btnHuygoi);
            this.plgoimon.Controls.Add(this.btnInbep);
            this.plgoimon.Controls.Add(this.btngoimon);
            this.plgoimon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plgoimon.Location = new System.Drawing.Point(0, 421);
            this.plgoimon.Name = "plgoimon";
            this.plgoimon.Size = new System.Drawing.Size(430, 113);
            this.plgoimon.TabIndex = 4;
            this.plgoimon.Visible = false;
            // 
            // btnHuygoi
            // 
            this.btnHuygoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuygoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuygoi.Location = new System.Drawing.Point(292, 36);
            this.btnHuygoi.Name = "btnHuygoi";
            this.btnHuygoi.Size = new System.Drawing.Size(125, 45);
            this.btnHuygoi.TabIndex = 1;
            this.btnHuygoi.Text = "Hủy";
            this.btnHuygoi.UseVisualStyleBackColor = true;
            this.btnHuygoi.Click += new System.EventHandler(this.btnHuygoi_Click);
            // 
            // btnInbep
            // 
            this.btnInbep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInbep.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbep.Location = new System.Drawing.Point(153, 36);
            this.btnInbep.Name = "btnInbep";
            this.btnInbep.Size = new System.Drawing.Size(125, 45);
            this.btnInbep.TabIndex = 1;
            this.btnInbep.Text = "In ở bếp";
            this.btnInbep.UseVisualStyleBackColor = true;
            this.btnInbep.Click += new System.EventHandler(this.btnInbep_Click);
            // 
            // btngoimon
            // 
            this.btngoimon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btngoimon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngoimon.Location = new System.Drawing.Point(14, 36);
            this.btngoimon.Name = "btngoimon";
            this.btngoimon.Size = new System.Drawing.Size(125, 45);
            this.btngoimon.TabIndex = 1;
            this.btngoimon.Text = "Gọi món";
            this.btngoimon.UseVisualStyleBackColor = true;
            this.btngoimon.Click += new System.EventHandler(this.btngoimon_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(300, 480);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 45);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Location = new System.Drawing.Point(195, 4);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(212, 19);
            this.lbThoiGian.TabIndex = 3;
            this.lbThoiGian.Text = "Thời Gian : 00/00/0000 -  00 : 00";
            // 
            // btnMoBan
            // 
            this.btnMoBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMoBan.Location = new System.Drawing.Point(6, 429);
            this.btnMoBan.Name = "btnMoBan";
            this.btnMoBan.Size = new System.Drawing.Size(125, 45);
            this.btnMoBan.TabIndex = 1;
            this.btnMoBan.Text = "Mở bàn";
            this.btnMoBan.UseVisualStyleBackColor = true;
            this.btnMoBan.Click += new System.EventHandler(this.btnMoBan_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChuyenBan.Location = new System.Drawing.Point(153, 429);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(125, 45);
            this.btnChuyenBan.TabIndex = 1;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // lbBan
            // 
            this.lbBan.AutoSize = true;
            this.lbBan.Location = new System.Drawing.Point(23, 5);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(136, 19);
            this.lbBan.TabIndex = 2;
            this.lbBan.Text = "Bàn : 00 Khu thường";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThanhToan.Location = new System.Drawing.Point(300, 429);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(125, 45);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dgvThucDon);
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvThucDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Location = new System.Drawing.Point(6, 43);
            this.dgvThucDon.MultiSelect = false;
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.ReadOnly = true;
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucDon.Size = new System.Drawing.Size(406, 354);
            this.dgvThucDon.TabIndex = 0;
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyBan.Location = new System.Drawing.Point(6, 480);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(125, 45);
            this.btnHuyBan.TabIndex = 1;
            this.btnHuyBan.Text = "Hủy bàn";
            this.btnHuyBan.UseVisualStyleBackColor = true;
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInHoaDon.Location = new System.Drawing.Point(153, 480);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(125, 45);
            this.btnInHoaDon.TabIndex = 1;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tctrMonAn
            // 
            this.tctrMonAn.Controls.Add(this.tabPage1);
            this.tctrMonAn.Controls.Add(this.tabPage2);
            this.tctrMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrMonAn.Location = new System.Drawing.Point(682, 0);
            this.tctrMonAn.Name = "tctrMonAn";
            this.tctrMonAn.SelectedIndex = 0;
            this.tctrMonAn.Size = new System.Drawing.Size(388, 534);
            this.tctrMonAn.TabIndex = 2;
            // 
            // UCtrBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tctrMonAn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tCtrKhuBan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCtrBanHang";
            this.Size = new System.Drawing.Size(1070, 534);
            this.Load += new System.EventHandler(this.UCtrBanHang_Load);
            this.tCtrKhuBan.ResumeLayout(false);
            this.tp_KhuThuong.ResumeLayout(false);
            this.tp_KhuVIP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plgoimon.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.tctrMonAn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCtrKhuBan;
        private System.Windows.Forms.TabPage tp_KhuThuong;
        private System.Windows.Forms.TabPage tp_KhuVIP;
        private System.Windows.Forms.ListView lvBanThuong;
        private System.Windows.Forms.ListView lvBanVIP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnHuyBan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Button btnMoBan;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tctrMonAn;
        private System.Windows.Forms.Panel plgoimon;
        private System.Windows.Forms.Button btngoimon;
        private System.Windows.Forms.Button btnHuygoi;
        private System.Windows.Forms.Button btnInbep;
    }
}
