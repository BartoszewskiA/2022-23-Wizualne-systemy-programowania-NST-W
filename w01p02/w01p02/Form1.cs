namespace w01p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
         //   x = int.Parse(textBox1.Text);
         //   y= int.Parse(textBox2.Text);
         if (int.TryParse(textBox1.Text, out x)) { }
            else { 
                x = 0;
                textBox1.Text = "0";
            }
         if (int.TryParse(textBox2.Text, out y)) { }
            else
            {
                y = 0;
                textBox2.Text="0";
            }
            int wynik = x + y;
            textBox3.Text = wynik.ToString();

            int licznik = progressBar1.Value;
            if (licznik < 10)
            {
                progressBar1.Value = licznik + 1;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }
    }
}