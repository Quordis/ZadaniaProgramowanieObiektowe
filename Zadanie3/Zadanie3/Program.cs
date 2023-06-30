using Zadanie3;

Wektor v1 = new Wektor(1, 2, 3);
Wektor v2 = new Wektor(4, 5, 6);
Wektor v3 = new Wektor(7, 8, 9);
Wektor v4 = v1 + v2;
Console.WriteLine(string.Join(", ", v4.współrzędne));
Wektor v5 = v1 - v2;
Console.WriteLine(string.Join(", ", v5.współrzędne));
Wektor v6 = v1 * 2;
Console.WriteLine(string.Join(", ", v6.współrzędne));
Wektor v7 = v1 / 2;
Console.WriteLine(string.Join(", ", v7.współrzędne));

Wektor suma = Wektor.Suma(v1, v2, v3);
Console.WriteLine("Suma wektorów: " + string.Join(", ", suma.współrzędne));
