using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        int z = 0;
        Uyelik_Ayarlari Uyelik = new Uyelik_Ayarlari();
        public int ToplamFiyat = 0;
        public int y = 0;
        public int i = 0;

        //Form3 teki Bakiye yükleme ekranından eklediğin bakiyeyi çağırdım
        //Magaza Sepet_Listen aldığım ürünlerin toplam Fiyatını For döngüsüyle Toplattım
        //buttonda sürekli değişmesin diye y ekledim daha kolay yolu olabilir ama aklıma bu geldi
        private void button2_Click(object sender, EventArgs e)
        {

            for (z = y; z < Magaza.Sepet_List.Count; z++)
            {
                ToplamFiyat += Magaza.Sepet_List[z].Fiyat;

            }
            label2.Text = Convert.ToString(ToplamFiyat);
            //linq sorgusuyla kütüphaneye eklediğin oyunları kontrol et kütüphaneye eklenmişse if'i çalıştırma
            if (Bakiye.Bakiye_List[0].bakiye <= ToplamFiyat)
            {
                MessageBox.Show("Yetersiz Bakiye");
            }
            else
            {
                // mağaza sepetindeki oyunları içinden kütüphanede varsa message döndür yoksa ödeme yap
                // (burda direk buton kütüphane var diye ekleyebilirdim ama hediye oyun için almak için mantıklı olabilir)
                foreach (var oyun in Magaza.Sepet_List)
                {
                    if (Magaza.Oyunlarım.Exists(item => item == oyun))
                    {
                        MessageBox.Show("Sepetteki Ürünler Kütüphanede mevcut");
                        i = 1;
                        break;
                    }
                    else
                    {
                        // Oyun, Magaza.Sepet_List listesinde yok
                        continue;
                    }
                }
                if (i != 1)
                {
                    Bakiye.Bakiye_List[0].bakiye = Bakiye.Bakiye_List[0].bakiye - ToplamFiyat;
                    label4.Text = Convert.ToString(Bakiye.Bakiye_List[0].bakiye);
                    Magaza.Oyunlarım.Add(new Magaza());
                    Magaza.Oyunlarım[0] = Magaza.Sepet_List[0];
                    MessageBox.Show("Ödeme Yapıldı");

                }
            }

            y = 4;
        }
        // Form5 in comboboxsına oyunları atıyorum
        // Kütüphaneye oyunların butonunu değiştiriyorum
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            if (Magaza.Oyunlarım.Any(p => p.oyun_adi == "THELASTOFUS"))
            {
                form.button30.Text = "Oyna";
            }
            if (Magaza.Oyunlarım.Any(p => p.oyun_adi == "The_starwars_Jedi"))
            {
                form.button28.Text = "Oyna";
            }
            if (Magaza.Oyunlarım.Any(p => p.oyun_adi == "RDR2"))
            {
                form.button14.Text = "Oyna";
            }
            if (Magaza.Oyunlarım.Any(p => p.oyun_adi == "spiderman"))
            {
                form.button28.Text = "Oyna";
            }
            if (Magaza.Oyunlarım.Any(p => p.oyun_adi == "RUST"))
            {
                form.button24.Text = "Oyna";
            }
            if (Magaza.Oyunlarım.Any(p => p.oyun_adi == "DETROIT"))
            {
                form.button16.Text = "Oyna";
            }



            var atama = Magaza.Oyunlarım;

            form.comboBox3.DataSource = atama.ToList();
            form.comboBox3.DisplayMember = "oyun_adi";
            form.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
