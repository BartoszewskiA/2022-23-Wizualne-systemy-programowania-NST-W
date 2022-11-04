namespace w02p04
{
    public partial class Form1 : Form
    {
        int licznik = 0;
        Boolean up = false;
        Boolean down = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode==Keys.Up)
            {
                up = true;
                timer1.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;
                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (up) licznik++;
            else if(down) licznik--;
            label1.Text= licznik.ToString();
            if(timer1.Interval>30)
               timer1.Interval -= 15;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                timer1.Stop();
                up = false;
                timer1.Interval = 500;
            }
            if (e.KeyCode == Keys.Down)
            {
                timer1.Stop();
                down = false;
                timer1.Interval = 500;
            }

        }
    }
}