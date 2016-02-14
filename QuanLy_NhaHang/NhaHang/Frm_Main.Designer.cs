namespace NhaHang
{
    partial class Frm_Main
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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.mbBaoCao = new NhaHang.UseControl.MenuButton();
            this.mbQLBanHang = new NhaHang.UseControl.MenuButton();
            this.nbBanHang = new NhaHang.UseControl.MenuButton();
            this.plContent = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_Menu.Controls.Add(this.mbBaoCao);
            this.panel_Menu.Controls.Add(this.mbQLBanHang);
            this.panel_Menu.Controls.Add(this.nbBanHang);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(1070, 80);
            this.panel_Menu.TabIndex = 0;
            // 
            // mbBaoCao
            // 
            this.mbBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.mbBaoCao.Dock = System.Windows.Forms.DockStyle.Left;
            this.mbBaoCao.HinhAnh = global::NhaHang.Properties.Resources.noimage;
            this.mbBaoCao.Location = new System.Drawing.Point(160, 0);
            this.mbBaoCao.Name = "mbBaoCao";
            this.mbBaoCao.Nhan = "Báo cáo";
            this.mbBaoCao.Size = new System.Drawing.Size(80, 80);
            this.mbBaoCao.TabIndex = 2;
            this.mbBaoCao.ToaDoNhan = new System.Drawing.Point(0, 61);
            this.mbBaoCao.ButtonClick += new System.EventHandler(this.mbBaoCao_ButtonClick);
            // 
            // mbQLBanHang
            // 
            this.mbQLBanHang.BackColor = System.Drawing.Color.Transparent;
            this.mbQLBanHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.mbQLBanHang.HinhAnh = global::NhaHang.Properties.Resources.document_line_chart_01;
            this.mbQLBanHang.Location = new System.Drawing.Point(80, 0);
            this.mbQLBanHang.Name = "mbQLBanHang";
            this.mbQLBanHang.Nhan = "Báo Cáo";
            this.mbQLBanHang.Size = new System.Drawing.Size(80, 80);
            this.mbQLBanHang.TabIndex = 1;
            this.mbQLBanHang.ToaDoNhan = new System.Drawing.Point(0, 61);
            this.mbQLBanHang.ButtonClick += new System.EventHandler(this.mbQLBanHang_ButtonClick);
            // 
            // nbBanHang
            // 
            this.nbBanHang.BackColor = System.Drawing.Color.Transparent;
            this.nbBanHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.nbBanHang.HinhAnh = global::NhaHang.Properties.Resources._1451894096_bill;
            this.nbBanHang.Location = new System.Drawing.Point(0, 0);
            this.nbBanHang.Name = "nbBanHang";
            this.nbBanHang.Nhan = "Nhandasdaa";
            this.nbBanHang.Size = new System.Drawing.Size(80, 80);
            this.nbBanHang.TabIndex = 0;
            this.nbBanHang.ToaDoNhan = new System.Drawing.Point(7, 60);
            this.nbBanHang.ButtonClick += new System.EventHandler(this.nbBanHang_ButtonClick);
            // 
            // plContent
            // 
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(0, 80);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(1070, 543);
            this.plContent.TabIndex = 1;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1070, 623);
            this.Controls.Add(this.plContent);
            this.Controls.Add(this.panel_Menu);
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private UseControl.MenuButton nbBanHang;
        private UseControl.MenuButton mbQLBanHang;
        private System.Windows.Forms.Panel plContent;
        private UseControl.MenuButton mbBaoCao;
    }
}

