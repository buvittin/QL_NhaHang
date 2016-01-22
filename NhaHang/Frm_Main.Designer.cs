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
            this.menuButton2 = new NhaHang.UseControl.MenuButton();
            this.menuButton1 = new NhaHang.UseControl.MenuButton();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_Menu.Controls.Add(this.menuButton2);
            this.panel_Menu.Controls.Add(this.menuButton1);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(1070, 80);
            this.panel_Menu.TabIndex = 0;
            // 
            // menuButton2
            // 
            this.menuButton2.BackColor = System.Drawing.Color.Transparent;
            this.menuButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuButton2.HinhAnh = global::NhaHang.Properties.Resources.document_line_chart_01;
            this.menuButton2.Location = new System.Drawing.Point(80, 0);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Nhan = "Báo Cáo";
            this.menuButton2.Size = new System.Drawing.Size(80, 80);
            this.menuButton2.TabIndex = 1;
            this.menuButton2.ToaDoNhan = new System.Drawing.Point(0, 61);
            // 
            // menuButton1
            // 
            this.menuButton1.BackColor = System.Drawing.Color.Transparent;
            this.menuButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuButton1.HinhAnh = global::NhaHang.Properties.Resources._1451894096_bill;
            this.menuButton1.Location = new System.Drawing.Point(0, 0);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Nhan = "Nhandasdaa";
            this.menuButton1.Size = new System.Drawing.Size(80, 80);
            this.menuButton1.TabIndex = 0;
            this.menuButton1.ToaDoNhan = new System.Drawing.Point(7, 60);
            this.menuButton1.ButtonClick += new System.EventHandler(this.menuButton1_Click);
            this.menuButton1.ButtonHover += new System.EventHandler(this.menuButton1_ButtonHover);
            this.menuButton1.ButtonLeave += new System.EventHandler(this.menuButton1_ButtonLeave);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 623);
            this.Controls.Add(this.panel_Menu);
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private UseControl.MenuButton menuButton1;
        private UseControl.MenuButton menuButton2;
    }
}

