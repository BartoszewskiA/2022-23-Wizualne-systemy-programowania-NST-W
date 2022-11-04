namespace w02p03.cpp
{
    public partial class Form1 : Form
    {

        const int MAX = 500;
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = MAX;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(progressBar1.Value < MAX)
                progressBar1.Value = progressBar1.Value + 1;
            else
                timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 110-  trackBar1.Value * 10;
        }
    }
}