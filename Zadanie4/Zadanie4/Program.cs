
using System.Collections.Concurrent;
using Zadanie4;

Produkt p1 = new Produkt();
ProduktSpożywczy ps1 = new ProduktSpożywczy();
p1.Nazwa = "Ogórek";
p1.CenaNetto = 25;
p1.KategoriaVat = "pierwsza";
p1.KrajPochodzenia = "Polska";
Console.WriteLine("Nazwa: {0}\nCena Netto: {1}\nCena Brutto {2}\nKategoria Vat: {3}\nKraj pochodzenia: {4}",
    p1.Nazwa, p1.CenaNetto, p1.CenaBrutto, p1.KategoriaVat, p1.KrajPochodzenia);

ps1.KategoriaVat = "druga";
ps1.Alergeny.Add("jaja");
ps1.Alergeny.Add("orzechy");

Wielopak w1 = new Wielopak();
w1.Produkt.Nazwa = "Śrubka";
w1.Produkt.CenaNetto = 2;
w1.Ilość = 12;
w1.Produkt.KategoriaVat = "pierwsza";
Console.WriteLine(w1.CenaNetto);
Console.WriteLine(w1.CenaBrutto);
