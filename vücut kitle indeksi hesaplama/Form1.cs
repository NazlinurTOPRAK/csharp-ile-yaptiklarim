namespace vücut_kitle_indeksi_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Boy = Convert.ToDouble(textBox4.Text);
            double Ağırlık = Convert.ToDouble(textBox3.Text);

            double vki = ((Ağırlık) / (Boy * Boy));
            textBox2.Text = vki.ToString();
            if (vki < 16)
            {
                textBox1.Text = " zayıf";
            }
            else if (vki > 16 && vki < 16.99)
            {
                textBox1.Text = "orta  düzey zayıf";
            }
            else if (vki > 17 && vki < 18.49)
            {
                textBox1.Text = "hafif düzey zayıf";
            }
            else if (vki > 18.50 && vki < 24.99)
            {
                textBox1.Text = "normal";
            }
            else if (vki > 25 && vki < 29.99)
            {
                textBox1.Text = "şişmanlık öncesi";
            }

            else if (vki > 30 && vki < 34.99)
            {
                textBox1.Text = "şişman 1. derece";
            }
            else if (vki > 35 && vki < 39.99)
            {
                textBox1.Text = "şişman 2. derece";
            }
            else
            {
                textBox1.Text = "şişman 3. derece";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
