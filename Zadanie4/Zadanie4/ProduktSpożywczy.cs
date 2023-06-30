using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    internal class ProduktSpożywczy : Produkt
    {
        string kategoriaVat;
        static Dictionary<string, decimal> Vat = new Dictionary<string, decimal>()
        {
            { "pierwsza", 5 },
            { "druga", 7 },
        };

         public uint Kalorie;
         HashSet<string> alergeny = new HashSet<string>();

        static string[] przewidywaneAlergeny = 
        {
            "mleko krowie",
            "jaja",
            "ryby",
            "orzechy"
        };

        public string KategoriaVat
        {
            get => kategoriaVat;
            set
            {
                if (value != string.Empty && Vat.ContainsKey(value))
                {
                    kategoriaVat = value;
                }
                else
                {
                    throw new ArgumentException("Nieprawidłowa kategoria VAT");
                }
            }
        }

        public HashSet<string> Alergeny
        { 
            get => alergeny;
            set 
            {
                foreach (string alergen in value)
                {
                    if (!przewidywaneAlergeny.Contains(alergen))
                    {
                        throw new ArgumentException($"Nieprawidłowy alergen: {alergen}");
                    }
                }
                alergeny = value;
            }
        }
    }
}
