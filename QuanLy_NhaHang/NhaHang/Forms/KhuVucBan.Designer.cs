namespace NhaHang.Forms
{
    partial class KhuVucBan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.rbxThuong = new System.Windows.Forms.RadioButton();
            this.rbxVIP = new System.Windows.Forms.RadioButton();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lvBanThuong = new System.Windows.Forms.ListView();
            this.lvBanVIP = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvBanThuong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 350);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khu thường";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvBanVIP);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(230, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khu V.I.P";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(283, 448);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 50);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rbxThuong
            // 
            this.rbxThuong.AutoSize = true;
            this.rbxThuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbxThuong.Location = new System.Drawing.Point(71, 416);
            this.rbxThuong.Name = "rbxThuong";
            this.rbxThuong.Size = new System.Drawing.Size(97, 23);
            this.rbxThuong.TabIndex = 4;
            this.rbxThuong.TabStop = true;
            this.rbxThuong.Text = "Bàn thường";
            this.rbxThuong.UseVisualStyleBackColor = true;
            // 
            // rbxVIP
            // 
            this.rbxVIP.AutoSize = true;
            this.rbxVIP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbxVIP.Location = new System.Drawing.Point(286, 416);
            this.rbxVIP.Name = "rbxVIP";
            this.rbxVIP.Size = new System.Drawing.Size(86, 23);
            this.rbxVIP.TabIndex = 4;
            this.rbxVIP.TabStop = true;
            this.rbxVIP.Text = "Bàn V.I.P";
            this.rbxVIP.UseVisualStyleBackColor = true;
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhap.Location = new System.Drawing.Point(177, 448);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(100, 50);
            this.btnCapNhap.TabIndex = 3;
            this.btnCapNhap.Text = "Cập nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý bàn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvBanThuong
            // 
            this.lvBanThuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBanThuong.FullRowSelect = true;
            this.lvBanThuong.GridLines = true;
            this.lvBanThuong.Location = new System.Drawing.Point(3, 22);
            this.lvBanThuong.MultiSelect = false;
            this.lvBanThuong.Name = "lvBanThuong";
            this.lvBanThuong.Size = new System.Drawing.Size(204, 325);
            this.lvBanThuong.TabIndex = 1;
            this.lvBanThuong.UseCompatibleStateImageBehavior = false;
            this.lvBanThuong.SelectedIndexChanged += new System.EventHandler(this.lvBanThuong_SelectedIndexChanged);
            // 
            // lvBanVIP
            // 
            this.lvBanVIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBanVIP.FullRowSelect = true;
            this.lvBanVIP.GridLines = true;
            this.lvBanVIP.Location = new System.Drawing.Point(3, 22);
            this.lvBanVIP.MultiSelect = false;
            this.lvBanVIP.Name = "lvBanVIP";
            this.lvBanVIP.Size = new System.Drawing.Size(204, 325);
            this.lvBanVIP.TabIndex = 1;
            this.lvBanVIP.UseCompatibleStateImageBehavior = false;
            this.lvBanVIP.SelectedIndexChanged += new System.EventHandler(this.lvBanVIP_SelectedIndexChanged);
            // 
            // KhuVucBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(454, 510);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbxVIP);
            this.Controls.Add(this.rbxThuong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCapNhap);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KhuVucBan";
            this.Load += new System.EventHandler(this.KhuVucBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rbxThuong;
        private System.Windows.Forms.RadioButton rbxVIP;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvBanThuong;
        private System.Windows.Forms.ListView lvBanVIP;
    }
}