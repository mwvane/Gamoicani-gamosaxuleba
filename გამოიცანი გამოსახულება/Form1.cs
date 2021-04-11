using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Mwvane_UI;

namespace გამოიცანი_გამოსახულება
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pointForImage = new Point(10,20);
            Base.TestCategory = Category.NoCategory;
        }
        Point pointForImage;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Animals":
                    Base.TestCategory = Category.Animals;
                    break;
                case "Flags":
                    Base.TestCategory = Category.Flags;
                    break;
                case "Sports":
                    Base.TestCategory = Category.Sports;
                    break;
                case "Retro":
                    Base.TestCategory = Category.Retro;
                    break;
                case "Professions":
                    Base.TestCategory = Category.Professions;
                    break;
                case "NoCategory":
                    Base.TestCategory = Category.NoCategory;
                    break;

                default:
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtContains.Text.Length == 14 && txtLength.MaxLength!= 0)
            {
                List<string> l = Search.Result(int.Parse(txtLength.Text), txtContains.Text);
                if (l.Count > 0)
                {
                    PrintResult(l);
                    tmrSlider.Start();
                }
                else
                {
                    Alert.Show("Check fields", Alert.AlertType.Information);
                }
            }
            else
            {
                Alert.Show("fill all fields", Alert.AlertType.Warning); 
            }
        }
        private void PrintResult(List<string> result)
        {
            pnlResult.Controls.Clear();
            pointForImage = new Point(10, 20);
            for (int i = 0; i < result.Count; i++)
            {
                PictureWithLabel p = new PictureWithLabel();
                p.Location = pointForImage;
                p.Size = new Size(450,450);
                p.Label = Base._dictionary[result[i]];
                p.Image = new Bitmap(@"Images\" + result[i]);
                p.ForeColor = Color.Black;
                p.Zoom = 0;
                pnlResult.Controls.Add(p);
                pointForImage.Y += 460;
            }
        }

        private void tmrSlider_Tick(object sender, EventArgs e)
        {
            if(this.Height < 580)
            {
                this.Height += 50;
            }
            else
            {
                tmrSlider.Stop();
            }
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContains_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.KeyChar = '\0';
                return;
            }
            e.KeyChar = Typing.ConvertToGeorgian(e.KeyChar);
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Typing.IsDigit(e.KeyChar))
            {
                e.KeyChar = '\0';
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtContains.Clear();
            txtLength.Clear();
            txtLength.Focus();
            timer1.Start();
            pnlResult.Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Height > 80)
            {
                this.Height -= 50;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
