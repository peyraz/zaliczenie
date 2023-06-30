using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal class Prostokąt
    {
        private double bokA, bokB;
        static double pierwiastekZDwóch = Math.Sqrt(2);

        public static Dictionary<char, decimal> wysokośćArkusza0 = new Dictionary<char, decimal>
        {
            ['A'] = 1189,
            ['B'] = 1414,
            ['C'] = 1297
        };
        public double BokA
        {
            get => bokA;
            set
            {
                if (value < 0 || !double.IsFinite(value))
                    throw new ArgumentException();
                bokA = value;
            }
        }
        public double BokB
        {
            get => bokB;
            set
            {
                if (value < 0 || !double.IsFinite(value))
                    throw new ArgumentException();
                bokB = value;
            }
        }

        public static Prostokąt ArkuszPapieru(string Xi)
        {
            char X = Xi[0];
            byte i = byte.Parse(Xi.Substring(1));
            if (!wysokośćArkusza0.ContainsKey(X))
                throw new ArgumentException();

            Prostokąt kartka = new Prostokąt();
            double wysokość = (double)wysokośćArkusza0[X];

            kartka.bokA = wysokość / Math.Pow(pierwiastekZDwóch, i);
            kartka.bokB = kartka.bokA / pierwiastekZDwóch;

            return kartka;
        }
    }
}
