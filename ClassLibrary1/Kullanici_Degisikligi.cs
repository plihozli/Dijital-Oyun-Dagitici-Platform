using System.Runtime.CompilerServices;

namespace ClassLibrary1
{

    public class Kullanici_Degisikligi:Kullanici_Islemleri,Ikart_bilgileri
    {
        
        static public List<Kullanici_Islemleri> Kul_list = new List<Kullanici_Islemleri>();
        public List<Kullanici_Islemleri> Kullanicilar_List= new List<Kullanici_Islemleri> ();
        

        
        string Ikart_bilgileri.kart_ismi { get; set; }
        string Ikart_bilgileri.kart_sahibi_ismi { get; set; }
        int Ikart_bilgileri.kart_numarasi {get;set; }
        int Ikart_bilgileri.Ccv { get; set; }
        
    }
}
  
               
    
 

   


 