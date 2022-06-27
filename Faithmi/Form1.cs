namespace Faithmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100) {
                timer1.Stop();
                Signin f = new Signin();
                f.Show();
                this.Hide();
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                label1.Text = "Loading...." + guna2CircleProgressBar1.Value.ToString() + "%";
            }
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}