using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Prostokąt
    {
        public Prostokąt(double bokA, double bokB)
        {
            this.bokA = bokA;
            this.bokB = bokB;
        }

        double bokA;
        double bokB;

        public double BokA
        { 
            get => bokA;
            set 
            { 
                    if (double.IsFinite(value) && value >= 0) 
                {
                    bokA= value;
                }
                    else
                {
                    throw new ArgumentException("Nieprawidłowa wartośc");
                }
            }
        }
        public double BokB 
        { 
            get => bokB;
            set
            {
                if (double.IsFinite(value) && value >= 0)
                {
                    bokB = value;
                }
                else
                {
                    throw new ArgumentException("Nieprawidłowa wartośc");
                }
            }
        }

        static Dictionary<char, decimal> wysokoścArkusza0 = new Dictionary<char, decimal>() 
        {
            { 'A', 1189 },
            { 'B', 1414 },
            { 'C', 1297 }
        };

        public static Prostokąt ArkuszPapieru(string Xi)
        {
            char X = Convert.ToChar(Xi.Substring(0, 1));
            byte i = byte.Parse(Xi.Substring(1, 1));
            
            //var  rozbicie = wysokoścArkusza0[X].ToString().Substring(i, 1);
            //decimal wysokość = decimal.Parse(rozbicie);
            decimal wysokość = wysokoścArkusza0[X];

            double pierwiastekZDwóch = Math.Sqrt(2);
            double bokA = (double)wysokość / (Math.Pow(pierwiastekZDwóch, i));
            double bokB = bokA / pierwiastekZDwóch;
            return new Prostokąt(bokA, bokB);
        }
    }
}
