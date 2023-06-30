using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    internal class ProduktSpożyczyPaczka : ProduktSpożywczy
    {
        decimal waga;

        public decimal Waga
        { 
            get => waga;
            set 
            {
                if (value >= 0)
                {
                    waga = value;
                }
                else
                {
                    throw new ArgumentException("Nieprawidłowa waga");
                }
            }
        }
    }
}
