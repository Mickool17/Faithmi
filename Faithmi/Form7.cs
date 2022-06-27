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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

    

            DialogResult dialog = MessageBox.Show("Thanks you for Ordering from Avengers FOOd App. Your order will be ready and delivered in 15 minutes, Sit back and relax. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {

                    bbsf f = new bbsf();
                    f.Show();
                    this.Hide();
                }

                else if (dialog == DialogResult.No)
                {
                    this.Close();
                }
            
        }
        private void sTextBox8__TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (sTextBox1.Text == "" || sTextBox2.Text == "" || sTextBox3.Text == "" || sTextBox4.Text == "" || sTextBox5.Text == "" || sTextBox6.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }
        }

        private void bunifuAppBar1_IconClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            Signin f = new Signin();
            f.Show();
            this.Hide();
        }
    }
}
