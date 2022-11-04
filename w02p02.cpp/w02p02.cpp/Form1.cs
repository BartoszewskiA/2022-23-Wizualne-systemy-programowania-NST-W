namespace w02p02.cpp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "Klik ";
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "DoubleKlik ";
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text= e.X.ToString() + ":"+e.Y.ToString();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            panel1.BackColor= Color.Green;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor=Color.Green;
        }
    }
}