using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    internal class Wielopak : Produkt
    {
        public Produkt Produkt = new Produkt();
        public ushort Ilość;
        decimal cenaBrutto;

        public decimal CenaNetto
        { 
            get => (Produkt.CenaNetto * Ilość);
        }
        public decimal CenaBrutto
        { 
            get => (Produkt.CenaBrutto * Ilość);
            set => cenaBrutto = value;
        }
    }
}
