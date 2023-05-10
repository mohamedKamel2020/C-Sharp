namespace Misbaha
{
    public partial class Form1 : Form
    {
        int sbhan = 0;
        int alhamd = 0;
        int takber = 0;
        int all = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sbhan = sbhan + 1;
            label1.Text = sbhan.ToString();
            if (sbhan == 33)
            {
              sbhan=0;
            }
            all=all + 1;
            label4.Text = all.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            alhamd = alhamd + 1;
            label2.Text = alhamd.ToString();
            if (alhamd == 33)
            {
                alhamd = 0;
            }
            all = all + 1;
            label4.Text = all.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            takber = takber + 1;
            label3.Text = takber.ToString();
            if (takber == 33)
            {
                takber=0;
            }
            all = all + 1;
            label4.Text = all.ToString();

        }
    }
}