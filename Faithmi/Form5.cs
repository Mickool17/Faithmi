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
    public partial class forget : Form
    {
        public forget()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
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
