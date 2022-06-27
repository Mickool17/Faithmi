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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void sTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            
              MessageBox.Show("SIGN UP SUCCESFULL");

                Signin f = new Signin();
                f.Show();
                this.Hide();
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          Signin f = new Signin();
            f.Show();
            this.Hide();
        }

        private void sTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuAppBar1_IconClick(object sender, EventArgs e)
        {

        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            Signin f = new Signin();
            f.Show();
            this.Hide();

        }
    }
}
