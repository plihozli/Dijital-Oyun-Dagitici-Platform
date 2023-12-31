using ClassLibrary1;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Kullanici_Degisikligi Kullanicilar = new Kullanici_Degisikligi();
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

            panel1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

            panel2.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)

        {
            if (Kullanicilar.Kullanicilar_List.Any(p => p.Kullaniciadi == textBox6.Text && p.sifre == textBox7.Text))
            {
                Form3 form3 = new Form3();
                //Kullanici adi text boxsa eþit olan listenin elamanýný Kullanýcý degisikliðine ekle
                Kullanici_Degisikligi.Kul_list.AddRange(Kullanicilar.Kullanicilar_List.Where(p => p.Kullaniciadi == textBox6.Text));
                form3.textBox1.Text = Kullanici_Degisikligi.Kul_list[0].Kullaniciadi;
                form3.textBox2.Text = Kullanici_Degisikligi.Kul_list[0].sifre;
                form3.textBox3.Text = Kullanici_Degisikligi.Kul_list[0].E_posta;
                form3.textBox4.Text = Kullanici_Degisikligi.Kul_list[0].telefon_no.ToString();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("hatali girdiniz");

            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Kullanici_Degisikligi KI = new Kullanici_Degisikligi();
            KI.kullanici_id = Guid.NewGuid();
            KI.Kullaniciadi = textBox1.Text;
            KI.telefon_no = int.Parse(textBox2.Text);
            if (textBox3.Text == textBox5.Text)
            {
                KI.sifre = textBox3.Text;
            }
            else
            {
                MessageBox.Show("hatalý giris");
            }
            KI.E_posta = textBox4.Text;
            KI.Dogum_tarihi = dateTimePicker1.Value.ToString();
            Kullanicilar.Kullanicilar_List.Add(KI);


        }
    }
}