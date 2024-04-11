namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double misir, su, kola, bilet, toplam = 0;

            misir = Convert.ToDouble(txtMisir.Text);
            su = Convert.ToDouble(txtSu.Text);
            kola = Convert.ToDouble(txtKola.Text);
            bilet = Convert.ToDouble(txtBilet.Text);

            toplam = misir * 50 + su * 5 + kola * 20 + bilet * 100;
            lblOdenecek.Text = toplam.ToString();
            kasaTutar += toplam;
            lblKasa.Text = kasaTutar.ToString() + "TL";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMisir.Text = " ";
            txtSu.Text = " ";   
            txtKola.Text = " "; 
            txtBilet.Text = " ";
            txtMisir.Focus();
        }
    }
}
