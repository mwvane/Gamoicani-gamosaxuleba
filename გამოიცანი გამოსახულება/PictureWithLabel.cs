using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace გამოიცანი_გამოსახულება
{
    public partial class PictureWithLabel : UserControl
    {
        public PictureWithLabel()
        {
            InitializeComponent();
            this.Zoom = 60;
        }
        public Image Image
        {
            get
            {
                return picPicture.Image;
            }
            set
            {
                picPicture.Image = value;
                picPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        public string Label
        {
            get
            {
                return lblText.Text;
            }
            set
            {
                lblText.Text = value;
            }
        }
        public new Color ForeColor
        {
            get
            {
                return lblText.ForeColor;
            }

            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }
        public int Zoom { get; set; }

        private void picPicture_MouseEnter(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X - (Zoom / 2), this.Location.Y - (Zoom / 2));
            this.Height += Zoom;
            this.Width += Zoom;
        }

        private void picPicture_MouseLeave(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + Zoom / 2, this.Location.Y + Zoom / 2);
            this.Height -= Zoom;
            this.Width -= Zoom;
        }
    }
    
}
