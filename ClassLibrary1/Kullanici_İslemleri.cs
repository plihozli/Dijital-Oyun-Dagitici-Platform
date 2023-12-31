using System.Runtime.CompilerServices;

namespace ClassLibrary1
{

    

     public abstract class  Kullanici_Islemleri
    {
        
        public Guid kullanici_id { get; set; }
        private String Kullanici_Adi {  get; set; }
        public int telefon_no { get; set; }
        String Isim {  get; set; }
        private String Sifre {  get; set; }
        public string E_posta{  get; set; }
       public string Dogum_tarihi{  get; set; }
       

        public string Kullaniciadi
        {
            get { return Kullanici_Adi; }
            set
            {
                if (value.Length < 12)
                {
                    Kullanici_Adi = value;
                }
                else
                {
                    string hata = "Fazla girdin";
                }
            }

        }
        public string sifre
        {
            get { return Sifre; }
            set
            {
                if (value.Length < 14)
                {
                    Sifre = value;
                }
                else
                {
                    string hata2 = "Sifre 14 karakterden büyük olamaz";
                }
            }
        }

       
    }
    
        
    }
   
   

    
  
               
    
 

   


 