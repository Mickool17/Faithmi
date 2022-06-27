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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup f = new signup();
            f.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            String[] usernames = {"Joju", "Mikool", "Fiksss", "theRealAgbaje", "Temidee" };
            String[] passwords = { "1234", "5678", "1234", "1234", "1234" };
            User user1 = new User();


            for (int i = 0; i < usernames.Length; i++)
            {
                if(sTextBox1.Texts == usernames[i] && sTextBox2.Texts == passwords[i]){
                    user1.username = usernames[i];
                    user1.password = passwords[i];
                    break;
        }
            }

            if (user1.username != "" && user1.password != "")
            {
                newhome f = new newhome();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("INCORRECT DETAILS");
            }
          

          
          



        }
            private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget f = new forget();
            f.Show();
            this.Hide();
        }

        private void bunifuAppBar1_IconClick(object sender, EventArgs e)
        {

        }

        private void sTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
