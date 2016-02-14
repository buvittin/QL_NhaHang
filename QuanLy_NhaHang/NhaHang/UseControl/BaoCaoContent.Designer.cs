namespace NhaHang.UseControl
{
    partial class BaoCaoContent
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
            this.CRPViews = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRPViews
            // 
            this.CRPViews.ActiveViewIndex = -1;
            this.CRPViews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRPViews.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRPViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRPViews.Location = new System.Drawing.Point(0, 0);
            this.CRPViews.Name = "CRPViews";
            this.CRPViews.Size = new System.Drawing.Size(980, 534);
            this.CRPViews.TabIndex = 0;
            this.CRPViews.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CRPViews);
            this.Name = "DoanhThu";
            this.Size = new System.Drawing.Size(980, 534);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRPViews;
    }
}
