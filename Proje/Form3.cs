using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Proje
{
    public partial class Form3 : Form
    {

        public string kullanici_ad;
        public Form3()
        {

            InitializeComponent();

        }



        public List<Ikart_bilgileri> kart_liste = new List<Ikart_bilgileri>();


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }
        public int Fiyat = 0;
        public int i = 0;


        public int z = 0;

        private void button1_Click_4(object sender, EventArgs e)
        {
            // data gridviewe değerleri attım
            Form5 form = new Form5();
            DataTable tablo = new DataTable();
            form.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablo.Columns.Add("Oyun Adi", typeof(string));
            tablo.Columns.Add("Fiyat", typeof(int));
            form.dataGridView1.DataSource = tablo;
            for (z = 0; z < Magaza.Sepet_List.Count; z++)
            {
                tablo.Rows.Add(Magaza.Sepet_List[z].oyun_adi, Magaza.Sepet_List[z].Fiyat);
                if (Bakiye.Bakiye_List.Count == 0)
                {
                    Bakiye.Bakiye_List.Add(new Bakiye());
                    Bakiye.Bakiye_List[0].Kullaniciadi = Kullanici_Degisikligi.Kul_list[0].Kullaniciadi;
                    Bakiye.Bakiye_List[0].bakiye = 0;
                    form.label4.Text = Bakiye.Bakiye_List[0].bakiye.ToString();
                }
                else
                {
                    form.label4.Text = Bakiye.Bakiye_List[0].bakiye.ToString();
                }
            }

            form.ShowDialog();

        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            Magaza magaza = new Magaza();


            if (Magaza.Sepet_List.Any(p => p.oyun_id == "thelastofus"))
            {
                button3.Text = "Satın Al";
                i--;
                Magaza.Sepet_List.Remove(Magaza.Sepet_List.Find(p => p.oyun_id == "thelastofus"));

            }
            else
            {
                magaza.The_Last_of_Us();
                Fiyat = Magaza.Sepet_List[i].Fiyat;
                button3.Text = "Satın Alındı";
                i++;


            }
            if (i != 0)
            {
                label28.Visible = true;
                label28.Text = Convert.ToString(i);
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Magaza magaza = new Magaza();
            if (Magaza.Sepet_List.Any(p => p.oyun_id == "spiderman"))
            {
                button4.Text = "Satın Al";
                i--;
                Magaza.Sepet_List.Remove(Magaza.Sepet_List.Find(p => p.oyun_id == "spiderman"));

            }
            else
            {
                magaza.Spiderman();
                Fiyat = Magaza.Sepet_List[i].Fiyat;
                button4.Text = "Satın Alındı";
                i++;

            }
            if (i != 0)
            {
                label28.Visible = true;
                label28.Text = Convert.ToString(i);
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Magaza magaza = new Magaza();
            if (Magaza.Sepet_List.Any(p => p.oyun_id == "rdr2"))
            {
                button12.Text = "Satın Al";
                i--;
                Magaza.Sepet_List.Remove(Magaza.Sepet_List.Find(p => p.oyun_id == "rdr2"));

            }
            else
            {
                magaza.Read_Dead_Redemption();
                Fiyat = Magaza.Sepet_List[i].Fiyat;
                button12.Text = "Satın Alındı";
                i++;

            }
            if (i != 0)
            {
                label28.Visible = true;
                label28.Text = Convert.ToString(i);
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Magaza magaza = new Magaza();
            if (Magaza.Sepet_List.Any(p => p.oyun_id == "ths"))
            {
                button13.Text = "Satın Al";
                i--;
                Magaza.Sepet_List.Remove(Magaza.Sepet_List.Find(p => p.oyun_id == "ths"));

            }
            else
            {
                magaza.The_Starwars_jedi();
                Fiyat = Magaza.Sepet_List[i].Fiyat;
                button13.Text = "Satın Alındı";
                i++;

            }
            if (i != 0)
            {
                label28.Visible = true;
                label28.Text = Convert.ToString(i);
            }

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Magaza magaza = new Magaza();
            if (Magaza.Sepet_List.Any(p => p.oyun_id == "rust"))
            {
                button11.Text = "Satın Al";
                i--;
                Magaza.Sepet_List.Remove(Magaza.Sepet_List.Find(p => p.oyun_id == "rust"));

            }
            else
            {
                magaza.Rust();
                Fiyat = Magaza.Sepet_List[i].Fiyat;
                button11.Text = "Satın Alındı";
                i++;

            }
            if (i != 0)
            {
                label28.Visible = true;
                label28.Text = Convert.ToString(i);
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Magaza magaza = new Magaza();
            if (Magaza.Sepet_List.Any(p => p.oyun_id == "detroit"))
            {
                button10.Text = "Satın Al";
                i--;
                Magaza.Sepet_List.Remove(Magaza.Sepet_List.Find(p => p.oyun_id == "detroit"));

            }
            else
            {
                magaza.Detroit();
                Fiyat = Magaza.Sepet_List[i].Fiyat;
                button10.Text = "Satın Alındı";
                i++;

            }

            if (i != 0)
            {
                label28.Visible = true;
                label28.Text = Convert.ToString(i);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            Ikart_bilgileri KD = new Kullanici_Degisikligi();

            KD.kart_ismi = textBox8.Text;
            KD.kart_sahibi_ismi = textBox9.Text;
            KD.kart_numarasi = int.Parse(textBox10.Text);
            KD.Ccv = int.Parse(textBox11.Text);
            kart_liste.Add(KD);
            var Kl = kart_liste;
            comboBox2.DataSource = Kl.ToList();
            comboBox2.DisplayMember = "kart_ismi";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public List<Bakiye> BKlist = new List<Bakiye>();

        Bakiye bk = new Bakiye();

        private void button19_Click(object sender, EventArgs e)
        {
            //Kart seçilmemişse işlemi devam bu mesajı ver.Burda p yi değiştirmek lazım adam ürün aldığında parası otamatik olarak bu atmasın
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }
            else
            {
                Form5 form = new Form5();
                //Direk bakiyeListten işlemleri hallediyorum
                //Kullanıcı adını ekliyorum.Sadece bunu kullanan kullacının eğer eklenmemişse ekle yoksa bakiyeyi değiştir.
                if (Bakiye.Bakiye_List.Count == 0)
                {
                    bk.kullanici_id = Kullanici_Degisikligi.Kul_list[0].kullanici_id;
                    bk.bakiye = 0;
                    Bakiye.Bakiye_List.Add(bk);
                    Bakiye.Bakiye_List[0].kullanici_id = Kullanici_Degisikligi.Kul_list[0].kullanici_id;
                    Bakiye.Bakiye_List[0].bakiye += int.Parse(textBox7.Text);
                    form.label4.Text = Bakiye.Bakiye_List[0].bakiye.ToString();
                }
                else
                {
                    Bakiye.Bakiye_List[0].kullanici_id = Kullanici_Degisikligi.Kul_list[0].kullanici_id;
                    Bakiye.Bakiye_List[0].bakiye += int.Parse(textBox7.Text);
                    Bakiye.Bakiye_List[0].bakiye += int.Parse(textBox7.Text);
                }


            }
            label22.Text = Convert.ToString(Bakiye.Bakiye_List[0].bakiye) + "TL";
        }
        public int Uyelik_fiyati = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Uyelik_Ayarlari uyelik = new Uyelik_Ayarlari();

        public List<Uyelik_Ayarlari> UyeList = new List<Uyelik_Ayarlari>();
        private void button23_Click(object sender, EventArgs e)
        {

            Uyelik_fiyati += uyelik.Ay_fiyat;
            uyelik.Kullanici_id = kullanici_ad;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Uyelik_fiyati += uyelik.Yıl_fiyat;
            uyelik.Kullanici_id = kullanici_ad;
        }

        private void button7_Click(object sender, EventArgs e)
        {



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                textBox1.Cursor = default;
                textBox2.Enabled = true;
                textBox2.Cursor = default;
                textBox3.Enabled = true;
                textBox3.Cursor = default;
                textBox4.Enabled = true;
                textBox4.Cursor = default;
                textBox5.Enabled = true;
                textBox5.Cursor = default;
                textBox6.Enabled = true;
                textBox6.Cursor = default;
            }
            else
            {
                textBox1.Enabled = false;

                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
            }
        }
        public List<Kullanici_Islemleri> deList = new List<Kullanici_Islemleri>();
        private void button8_Click(object sender, EventArgs e)
        {
            Kullanici_Degisikligi.Kul_list[0].Kullaniciadi = textBox1.Text;
            Kullanici_Degisikligi.Kul_list[0].sifre = textBox2.Text;
            Kullanici_Degisikligi.Kul_list[0].telefon_no = int.Parse(textBox4.Text);
            Kullanici_Degisikligi.Kul_list[0].Dogum_tarihi = textBox3.Text;
        }


    }
}
