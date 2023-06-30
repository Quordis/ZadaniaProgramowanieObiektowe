using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
     class Produkt
    {

        string nazwa;
        decimal cenaNetto;
        string kategoriaVat;
        string krajPochodzenia;


        public static Dictionary<string, decimal> Vat = new Dictionary<string, decimal>()
        {
            { "pierwsza", 5 },
            { "druga", 7 },
            { "trzecia", 9 },
            { "czwarta", 12 }
        };

        public static string[] Kraj = new string[]
        {
            "Polska",
            "Niemcy",
            "Francja",
            "Wielka Brytania",
            "Czechy"
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
        public decimal CenaBrutto
        { 
            get => (cenaNetto + (cenaNetto * (Vat[kategoriaVat]/100)));
        }
        public string KrajPochodzenia
        {
            get => krajPochodzenia;
            set 
            {
                if (krajPochodzenia != string.Empty)
                {
                   if (Kraj.Contains(value))
                    {
                        krajPochodzenia = value;
                    }
                   else
                    {
                        throw new ArgumentException("Nie ma takiego kraju na liście");
                    }
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public decimal CenaNetto { get => cenaNetto;
            set
            {
                if (value >= 0)
                { 
                    cenaNetto = value;
                }
                else throw new ArgumentException("Cena Netto nie może być ujemna");
            }
        }
    }
}
