using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faithmi
{
    public partial class resturant : Form
    {
        public resturant()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            bbsf f = new bbsf();
            f.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            bbsf f = new bbsf();
            f.Show();
            this.Hide();

        }

      

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            bbsf f = new bbsf();
            f.Show();
            this.Hide();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            bbsf f = new bbsf();
            f.Show();
            this.Hide();
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            kemmyb f = new kemmyb();
            f.Show();
            this.Hide();
        }

        private void sButton1_Click(object sender, EventArgs e)
        {
           newhome f = new newhome();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            newhome f = new newhome();
            f.Show();
            this.Hide();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Signin f = new Signin();
            f.Show();
            this.Hide();
        }
    }
}
