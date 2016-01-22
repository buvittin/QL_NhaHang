using System;
using System.Drawing;
using System.Windows.Forms;

namespace NhaHang.UseControl
{
    public partial class MenuButton : UserControl
    {
        public Bitmap _HinhAnh;
        public Bitmap HinhAnh
        {
            get
            {
                return _HinhAnh;
            }
            set
            {
                _HinhAnh = value;
            }
        }

        public String _Nhan;
        public String Nhan
        {
            get
            {
                return _Nhan;
            }
            set
            {
                _Nhan = value;
            }
        }

        public Point _ToaDoNhan;
        public Point ToaDoNhan
        {
            get
            {
                return _ToaDoNhan;
            }
            set
            {
                _ToaDoNhan = value;
            }
        }
        public event EventHandler ButtonClick;
        public event EventHandler ButtonHover;
        public event EventHandler ButtonLeave;

        public MenuButton()
        {
            InitializeComponent();
            ToaDoNhan = lb_nhan.Location;
        }

        private void MenuButton_Load(object sender, EventArgs e)
        {
            pbx_icon.Image = HinhAnh;
            lb_nhan.Text = Nhan;
            lb_nhan.Location = ToaDoNhan;
        }

        public void MenuButton_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void MenuButton_MouseHover(object sender, EventArgs e)
        {
            if (this.ButtonHover != null)
                this.ButtonHover(this, e);
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            if (this.ButtonLeave != null)
                this.ButtonLeave(this, e);
        }
    }
}
