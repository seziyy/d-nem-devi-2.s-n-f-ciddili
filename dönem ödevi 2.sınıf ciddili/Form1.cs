namespace dönem_ödevi_2.sınıf_ciddili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public List<dönem_ödevi_2.sınıf_ciddili.giris> Okul_List = new List<Proje.Sinif.Okul>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dönem_ödevi_2.sınıf_ciddili.giris entity = new dönem_ödevi_2.sınıf_ciddili.giris();
            entity.SehirAdi = textBox1.Text;
            entity.IlceAdi = textBox2.Text;
            entity.CafeAdi = textBox3.Text;
            giris.Add(entity);


            MessageBox.Show("Bilgiler Eklenmiştir...");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}