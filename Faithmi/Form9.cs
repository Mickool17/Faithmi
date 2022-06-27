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
    public partial class bbsf : Form
    {
        int rice = 100;
        int ofada = 150;
        int chinese = 300;
        int j = 0;
        int f = 0;
        int o = 0;
        int c = 0;
        public bbsf()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonmjoll_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                j = 0;
            }
            else
            {
                j--;
            }
            labeljollof.Text = j.ToString();
            textBoxjoll.Text = (j * rice).ToString();
        }

        private void buttonpjoll_Click(object sender, EventArgs e)
        {
            j++;
            labeljollof.Text = j.ToString();
            textBoxjoll.Text = (j * rice).ToString();
        }

        private void buttonmfried_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                f = 0;
            }
            else
            {
                f--;
            }
            labelfried.Text = f.ToString();
            textBoxfried.Text = (f * rice).ToString();
        }

        private void buttonpfried_Click(object sender, EventArgs e)
        {
            f++;
            labelfried.Text = f.ToString();
            textBoxfried.Text = (f * rice).ToString();
        }

        private void buttonmofada_Click(object sender, EventArgs e)
        {
            if (o == 0)
            {
                o = 0;
            }
            else
            {
                o--;
            }
            labelofada.Text = o.ToString();
            textBoxofada.Text = (o * ofada).ToString();
        }

        private void buttonpofada_Click(object sender, EventArgs e)
        {
            o++;
            labelofada.Text = o.ToString();
            textBoxofada.Text = (o * ofada).ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        

            if (guna2CheckBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem(" jollof rice ");
                item.SubItems.Add("");
                item.SubItems.Add(textBoxjoll.Text);
                listView1.Items.Add(item);

            }
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2CheckBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem(" Fried rice ");
                item.SubItems.Add("");
                item.SubItems.Add(textBoxfried.Text);
                listView1.Items.Add(item);

            }


        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {



            if (guna2CheckBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem(" ofada rice ");
                item.SubItems.Add("");
                item.SubItems.Add(textBoxofada.Text);
                listView1.Items.Add(item);

            }
           


        }


        private void sTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            int hst = 0;
            int totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += int.Parse(item.SubItems[2].Text);
            }

             
            totaldue = hst + total;

            string hstDisplay = hst.ToString("N");
            string totalDisplay = totaldue.ToString("N");
            string amount = total.ToString("N");

            textBox1.Text = amount;
            textBox2.Text = hstDisplay;
            textBox3.Text = totalDisplay;


        }

        private void bbsf_Load(object sender, EventArgs e)
        {
            //Other Items Selection

          



        }

        private void textBoxofada_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuAppBar1_IconClick(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

           Form7 f = new Form7();
            f.Show();
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                c = 0;
            }
            else
            {
                c--;
            }
            label61.Text = c.ToString();
            textBox4.Text = (c * chinese).ToString();
        }
    }
    
}
