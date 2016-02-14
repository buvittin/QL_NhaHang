namespace NhaHang.UseControl
{
    partial class UCtrQLBanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKhuVucBan = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.plContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnKhuVucBan);
            this.panel1.Controls.Add(this.btnMon);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 534);
            this.panel1.TabIndex = 0;
            // 
            // btnKhuVucBan
            // 
            this.btnKhuVucBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhuVucBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhuVucBan.Location = new System.Drawing.Point(0, 102);
            this.btnKhuVucBan.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnKhuVucBan.Name = "btnKhuVucBan";
            this.btnKhuVucBan.Size = new System.Drawing.Size(90, 51);
            this.btnKhuVucBan.TabIndex = 4;
            this.btnKhuVucBan.Text = "Khu vực bàn";
            this.btnKhuVucBan.UseVisualStyleBackColor = true;
            this.btnKhuVucBan.Click += new System.EventHandler(this.btnKhuVucBan_Click);
            // 
            // btnMon
            // 
            this.btnMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMon.Location = new System.Drawing.Point(0, 51);
            this.btnMon.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(90, 51);
            this.btnMon.TabIndex = 1;
            this.btnMon.Text = "Món";
            this.btnMon.UseVisualStyleBackColor = true;
            this.btnMon.Click += new System.EventHandler(this.btnMon_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(90, 51);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // plContent
            // 
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(90, 0);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(980, 534);
            this.plContent.TabIndex = 1;
            // 
            // UCtrQLBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plContent);
            this.Controls.Add(this.panel1);
            this.Name = "UCtrQLBanHang";
            this.Size = new System.Drawing.Size(1070, 534);
            this.Load += new System.EventHandler(this.UCtrQLBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel plContent;
        private System.Windows.Forms.Button btnKhuVucBan;
    }
}
