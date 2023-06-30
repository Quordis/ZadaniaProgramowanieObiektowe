using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    internal class Wektor
    {
        public double[] współrzędne;
        //public Wektor(byte wymiar)
        //{

        //}
        public Wektor(params double[] współrzędne)
        {
            this.współrzędne = współrzędne;
        }

        double Długość
        {
            get => IloczynSkalarny(this, this);
        }
        byte Wymiar
        {
            get => (byte)współrzędne.Length;
        }
        public double this[byte index]
        {
            get => współrzędne[index];
            set => współrzędne[index] = value;
        }

        public static double IloczynSkalarny(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
            {
                return double.NaN;
            }
            else
            {
                double iloczyn = 0;
                for (byte i = 0; i < V.Wymiar; i++)
                {
                    iloczyn += V[i] * W[i];
                }
                return iloczyn;
            }
        }
        public static Wektor Suma(params Wektor[] Wektory)
        {
            if (Wektory.Length == 0)
            {
                throw new ArgumentException("Brak wektorów do zsumowania");
            }

            int wymiar = Wektory[0].Wymiar;
            for (int i = 1; i < Wektory.Length; i++)
            {
                if (Wektory[i].Wymiar != wymiar)
                {
                    throw new ArgumentException("Wektory mają różne wymiary");
                }
            }

            Wektor suma = new Wektor(new double[wymiar]);
            for (byte i = 0; i < wymiar; i++)
            {
                for (int j = 0; j < Wektory.Length; j++)
                {
                    suma[i] += Wektory[j][i];
                }
            }

            return suma;
        }
        public static Wektor operator +(Wektor a, Wektor b)
        {
            if (a.Wymiar != b.Wymiar)
            {
                throw new ArgumentException("Wektory mają różne wymiary");
            }

            Wektor Suma = new Wektor(new double[a.Wymiar]);
            for (byte i = 0; i < a.Wymiar; i++)
            {
                Suma[i] = a[i] + b[i];
            }
            return Suma;
        }

        public static Wektor operator -(Wektor a, Wektor b)
        {
            if (a.Wymiar != b.Wymiar)
            {
                throw new ArgumentException("Wektory mają różne wymiary");
            }

            Wektor Różnica = new Wektor(new double[a.Wymiar]);
            for (byte i = 0; i < a.Wymiar; i++)
            {
                Różnica[i] = a[i] - b[i];
            }
            return Różnica;
        }

        public static Wektor operator *(Wektor a , double b)
        {
            Wektor Iloczyn = new Wektor(new double[a.Wymiar]);
            for (byte i = 0; i < a.Wymiar; i++)
            {
                Iloczyn[i] = a[i] * b;
            }
            return Iloczyn;
        }

        public static Wektor operator *(double a, Wektor b)
        {
            Wektor Iloczyn = new Wektor(new double[b.Wymiar]);
            for (byte i = 0; i < b.Wymiar; i++)
            {
                Iloczyn[i] = a * b[i];
            }
            return Iloczyn;
        }

        public static Wektor operator /(Wektor a, double b)
        {
            Wektor Iloraz = new Wektor(new double[a.Wymiar]);
            for (byte i = 0; i < a.Wymiar; i++)
            {
                Iloraz[i] = a[i] / b;
            }
            return Iloraz;
        }
    }
}
