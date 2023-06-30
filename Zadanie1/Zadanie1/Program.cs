using Zadanie1;

Osoba p1 = new Osoba(" ");
Console.WriteLine("Imię: {0}\nNazwisko: {1}\nImię i Nazwisko: {2}", p1.Imię, p1.Nazwisko, p1.ImięNazwisko);
p1.DataUrodzenia = new DateTime(2003, 5, 12);
p1.DataŚmierci = new DateTime(2023, 6, 21);
Console.WriteLine("Czas od urodzenia {0}", p1.Wiek());