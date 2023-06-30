using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Osoba
    {
        public Osoba(string imięNazwisko)
        {
            ImięNazwisko = imięNazwisko;
        }

        string imię;
        public string Nazwisko;
        public DateTime? DataUrodzenia = null;
        public DateTime? DataŚmierci = null;

        public string Imię 
        { 
            get => imię;
            set
            {
                if (value == string.Empty)
                {
                    Exception exception = new Exception("Pole nie może być puste");
                    throw exception;
                }
                else
                imię = value;
            }
        }
        public string ImięNazwisko 
        {
            get
            {
                return $"{imię} {Nazwisko}";
            }
            set
            {
                var imienazwisko = value.Split(' ');
                Imię = imienazwisko[0];
                if (imienazwisko.Length == 1) 
                {
                    Nazwisko = string.Empty;
                }
                else
                Nazwisko = imienazwisko[1];
                
            } 
        }
        
        public TimeSpan? Wiek()
        {
           if (DataUrodzenia == null) return null;
            if (DataŚmierci != null) 
            {
                return (DataŚmierci - DataUrodzenia)/365;
            }
            else
            {
                return (DateTime.Now - DataUrodzenia)/365;
            }
        }
    }
}
