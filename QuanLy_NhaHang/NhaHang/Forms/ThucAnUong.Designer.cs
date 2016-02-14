namespace NhaHang.Forms
{
    partial class ThucAnUong
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
            this.btnThemThucAn = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.tctrContent = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbxLoai1 = new System.Windows.Forms.ComboBox();
            this.btnHinh = new System.Windows.Forms.Button();
            this.lbTenMon = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxThucAn = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbThucUong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHinh2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxThucUong = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThucUong = new System.Windows.Forms.Button();
            this.tctrContent.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemThucAn
            // 
            this.btnThemThucAn.Location = new System.Drawing.Point(293, 312);
            this.btnThemThucAn.Name = "btnThemThucAn";
            this.btnThemThucAn.Size = new System.Drawing.Size(75, 50);
            this.btnThemThucAn.TabIndex = 0;
            this.btnThemThucAn.Text = "Thêm";
            this.btnThemThucAn.UseVisualStyleBackColor = true;
            this.btnThemThucAn.Click += new System.EventHandler(this.btnThemThucAn_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(193, 312);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 50);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // tctrContent
            // 
            this.tctrContent.Controls.Add(this.tabPage1);
            this.tctrContent.Controls.Add(this.tabPage2);
            this.tctrContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrContent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrContent.Location = new System.Drawing.Point(0, 0);
            this.tctrContent.Name = "tctrContent";
            this.tctrContent.SelectedIndex = 0;
            this.tctrContent.Size = new System.Drawing.Size(569, 415);
            this.tctrContent.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbxLoai1);
            this.tabPage1.Controls.Add(this.btnHinh);
            this.tabPage1.Controls.Add(this.lbTenMon);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtGia);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtHinh);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbxThucAn);
            this.tabPage1.Controls.Add(this.btnDong);
            this.tabPage1.Controls.Add(this.btnThemThucAn);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thức ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbxLoai1
            // 
            this.cbxLoai1.FormattingEnabled = true;
            this.cbxLoai1.Location = new System.Drawing.Point(296, 146);
            this.cbxLoai1.Name = "cbxLoai1";
            this.cbxLoai1.Size = new System.Drawing.Size(216, 27);
            this.cbxLoai1.TabIndex = 13;
            // 
            // btnHinh
            // 
            this.btnHinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinh.Location = new System.Drawing.Point(457, 232);
            this.btnHinh.Name = "btnHinh";
            this.btnHinh.Size = new System.Drawing.Size(55, 26);
            this.btnHinh.TabIndex = 14;
            this.btnHinh.Text = "Chọn";
            this.btnHinh.UseVisualStyleBackColor = true;
            this.btnHinh.Click += new System.EventHandler(this.btnHinh_Click);
            // 
            // lbTenMon
            // 
            this.lbTenMon.AutoSize = true;
            this.lbTenMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMon.Location = new System.Drawing.Point(292, 106);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(0, 19);
            this.lbTenMon.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(204, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tên món";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(296, 189);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(216, 26);
            this.txtGia.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(204, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Loại món";
            // 
            // txtHinh
            // 
            this.txtHinh.Enabled = false;
            this.txtHinh.Location = new System.Drawing.Point(296, 232);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.Size = new System.Drawing.Size(155, 26);
            this.txtHinh.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(204, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Giá bán";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(204, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "Hình ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thêm thức ăn";
            // 
            // lbxThucAn
            // 
            this.lbxThucAn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxThucAn.FormattingEnabled = true;
            this.lbxThucAn.ItemHeight = 23;
            this.lbxThucAn.Location = new System.Drawing.Point(24, 78);
            this.lbxThucAn.Name = "lbxThucAn";
            this.lbxThucAn.Size = new System.Drawing.Size(160, 211);
            this.lbxThucAn.TabIndex = 3;
            this.lbxThucAn.SelectedIndexChanged += new System.EventHandler(this.lbxThucAn_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnChon);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbThucUong);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtGia2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtHinh2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbxThucUong);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnThucUong);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thức uống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(457, 232);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(55, 26);
            this.btnChon.TabIndex = 23;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bia - nước giải khát";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 15;
            // 
            // lbThucUong
            // 
            this.lbThucUong.AutoSize = true;
            this.lbThucUong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThucUong.Location = new System.Drawing.Point(292, 106);
            this.lbThucUong.Name = "lbThucUong";
            this.lbThucUong.Size = new System.Drawing.Size(0, 19);
            this.lbThucUong.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên món";
            // 
            // txtGia2
            // 
            this.txtGia2.Location = new System.Drawing.Point(296, 189);
            this.txtGia2.Name = "txtGia2";
            this.txtGia2.Size = new System.Drawing.Size(216, 26);
            this.txtGia2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Loại món";
            // 
            // txtHinh2
            // 
            this.txtHinh2.Enabled = false;
            this.txtHinh2.Location = new System.Drawing.Point(296, 232);
            this.txtHinh2.Name = "txtHinh2";
            this.txtHinh2.Size = new System.Drawing.Size(155, 26);
            this.txtHinh2.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hình ảnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thêm thức uống";
            // 
            // lbxThucUong
            // 
            this.lbxThucUong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxThucUong.FormattingEnabled = true;
            this.lbxThucUong.ItemHeight = 23;
            this.lbxThucUong.Location = new System.Drawing.Point(24, 78);
            this.lbxThucUong.Name = "lbxThucUong";
            this.lbxThucUong.Size = new System.Drawing.Size(160, 211);
            this.lbxThucUong.TabIndex = 4;
            this.lbxThucUong.SelectedIndexChanged += new System.EventHandler(this.lbxThucUong_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThucUong
            // 
            this.btnThucUong.Location = new System.Drawing.Point(293, 312);
            this.btnThucUong.Name = "btnThucUong";
            this.btnThucUong.Size = new System.Drawing.Size(75, 50);
            this.btnThucUong.TabIndex = 2;
            this.btnThucUong.Text = "Thêm";
            this.btnThucUong.UseVisualStyleBackColor = true;
            this.btnThucUong.Click += new System.EventHandler(this.btnThucUong_Click);
            // 
            // ThucAnUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(569, 415);
            this.ControlBox = false;
            this.Controls.Add(this.tctrContent);
            this.Name = "ThucAnUong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ThucAnUong_Load);
            this.tctrContent.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemThucAn;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TabControl tctrContent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThucUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxThucAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxThucUong;
        private System.Windows.Forms.ComboBox cbxLoai1;
        private System.Windows.Forms.Button btnHinh;
        private System.Windows.Forms.Label lbTenMon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label lbThucUong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHinh2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}