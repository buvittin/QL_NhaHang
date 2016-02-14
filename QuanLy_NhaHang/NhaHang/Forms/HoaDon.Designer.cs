namespace NhaHang.Forms
{
    partial class HoaDon
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
            this.crpHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpHoaDon
            // 
            this.crpHoaDon.ActiveViewIndex = -1;
            this.crpHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpHoaDon.Location = new System.Drawing.Point(0, 0);
            this.crpHoaDon.Name = "crpHoaDon";
            this.crpHoaDon.Size = new System.Drawing.Size(702, 568);
            this.crpHoaDon.TabIndex = 0;
            this.crpHoaDon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 568);
            this.Controls.Add(this.crpHoaDon);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpHoaDon;
    }
}