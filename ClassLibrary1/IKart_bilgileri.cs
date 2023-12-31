using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Ikart_bilgileri
    {
        string kart_ismi { get; set; }
        string kart_sahibi_ismi { get; set; }
        int kart_numarasi { get; set; }
        int Ccv { get; set; }

    }
}


