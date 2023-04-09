using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rate_image
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            initImage();
        }

        private void initImage()
        {
            pb_img.Image = Image.FromFile("C:\\Users\\khoam\\source\\repos\\rate_image\\rate_image\\img\\163_img_.png");
            pb_img.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
