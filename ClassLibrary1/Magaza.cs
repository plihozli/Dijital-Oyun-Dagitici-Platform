using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
       public class Magaza:kutuphane
    {
        public string oyun_id { get; set; }
        public string oyun_adi {  get; set; }
        
        public int Fiyat {  get; set; }
        public static List<Magaza> Sepet_List = new List<Magaza>();
        public static List<Magaza> Oyunlarım = new List<Magaza>();
        
        public int The_Last_of_Us()
        {
            this.oyun_id = "thelastofus";
            this.oyun_adi = "THELASTOFUS";
            this.Fiyat = 120;
            Magaza.Sepet_List.Add(this);
            return this.Fiyat;
        }
        public int Spiderman()
        {
            this.oyun_id = "spiderman";
            this.oyun_adi = "spiderman";
            this.Fiyat = 150;
            Magaza.Sepet_List.Add(this);
            return this.Fiyat;
        }
        public int Read_Dead_Redemption()
        {
            this.oyun_id = "rdr2";
            this.oyun_adi = "RDR2";
            this.Fiyat = 120;
            Magaza.Sepet_List.Add(this);
            return this.Fiyat;
        }
        public int The_Starwars_jedi()
        {
            this.oyun_id = "ths";
            this.oyun_adi = "The_starwars_Jedi";
            this.Fiyat = 120;
            Magaza.Sepet_List.Add(this);
            return this.Fiyat;
        }
        public int Rust()
        {
            this.oyun_id = "rust";
            this.oyun_adi = "RUST";
            this.Fiyat = 120;
            Magaza.Sepet_List.Add(this);
            return this.Fiyat;
        }
        public int Detroit()
        {
            this.oyun_id = "detroit";
            this.oyun_adi = "DETROIT";
            this.Fiyat = 140;
            Magaza.Sepet_List.Add(this);
            return this.Fiyat;
        }
        
        
        
    }
        
        
    
   
}
  
               
    
 

   


 