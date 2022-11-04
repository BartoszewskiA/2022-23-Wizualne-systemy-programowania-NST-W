namespace w02p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "Zadzia³a³a metoda Load \n";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "Zadzia³a³a metoda Activated \n";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "Zadzia³a³a metoda Dectivated \n";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "Zadzia³a³a metoda Shown \n";
            label2.Text = "x: " + Form1.ActiveForm.Size.Width.ToString();
            label3.Text = "y: "+ Form1.ActiveForm.Size.Height.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*            DialogResult odpowiedz;

                      odpowiedz = MessageBox.Show("Czy skasowaæ logoi","Okuenko dialogowe",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                        if (odpowiedz == DialogResult.OK)
                            label1.Text = "";*/

            if (MessageBox.Show("Czy skasowaæ logi", "Pytanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                label1.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Czy chcesz opuœciæ proram?","Pytanie",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label2.Text = "x: " + Form1.ActiveForm.Size.Width.ToString();
            label3.Text = "y: " + Form1.ActiveForm.Size.Height.ToString();
        }
    }
}