namespace NhaHang.UseControl
{
    partial class MenuButton
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
            this.pbx_icon = new System.Windows.Forms.PictureBox();
            this.lb_nhan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_icon
            // 
            this.pbx_icon.Location = new System.Drawing.Point(13, 1);
            this.pbx_icon.Name = "pbx_icon";
            this.pbx_icon.Size = new System.Drawing.Size(55, 55);
            this.pbx_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_icon.TabIndex = 0;
            this.pbx_icon.TabStop = false;
            this.pbx_icon.Click += new System.EventHandler(this.MenuButton_Click);
            this.pbx_icon.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            this.pbx_icon.MouseHover += new System.EventHandler(this.MenuButton_MouseHover);
            // 
            // lb_nhan
            // 
            this.lb_nhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_nhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhan.Location = new System.Drawing.Point(0, 61);
            this.lb_nhan.Name = "lb_nhan";
            this.lb_nhan.Size = new System.Drawing.Size(80, 19);
            this.lb_nhan.TabIndex = 1;
            this.lb_nhan.Text = "sdasdasd";
            this.lb_nhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_nhan.Click += new System.EventHandler(this.MenuButton_Click);
            this.lb_nhan.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            this.lb_nhan.MouseHover += new System.EventHandler(this.MenuButton_MouseHover);
            // 
            // MenuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_nhan);
            this.Controls.Add(this.pbx_icon);
            this.Name = "MenuButton";
            this.Size = new System.Drawing.Size(80, 80);
            this.Load += new System.EventHandler(this.MenuButton_Load);
            this.Click += new System.EventHandler(this.MenuButton_Click);
            this.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            this.MouseHover += new System.EventHandler(this.MenuButton_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_icon;
        private System.Windows.Forms.Label lb_nhan;
    }
}
