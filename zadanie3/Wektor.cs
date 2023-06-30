using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Wektor
    {
        private double[] współrzędne;

        internal Wektor(byte wymiar)
        {
            współrzędne = new double[wymiar];
        }

        internal Wektor(params double[] współrzędne)
        {
            this.współrzędne = współrzędne;
        }

        public double Długość
        {
            get => Math.Sqrt(IloczynSkalarny(this, this));
        }
        public byte Wymiar
        {
            get => (byte)współrzędne.Length;
        }

        public double this[byte index]
        {
            get => współrzędne[index];
            set
            {
                współrzędne[index] = value;
            }
        }

        public static double IloczynSkalarny(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
                return double.NaN;

            double iloczyn = 0;
            for (byte i = 0; i < V.Wymiar; i++)
                iloczyn += V[i] * W[i];

            return iloczyn;
        }
        public static Wektor Suma(params Wektor[] wektory)
        {

            for (byte i = 1; i < wektory.Length; i++)
                if (wektory[0].Wymiar != wektory[i].Wymiar)
                    throw new Exception("Wymiary wektorów nie są równe");

            Wektor wektor = new Wektor(wektory[0].Wymiar);

            for (byte i = 0; i < wektory[0].Wymiar; i++)     //iteracja po współrzędnych
                for (byte j = 0; j < wektory.Length; j++)   //iteracja po wektorach
                {
                    wektor[i] += wektory[j][i];             //dodanie wartości indeksatorem
                }

            return wektor;
        }

        public static Wektor operator +(Wektor V, Wektor W)
        {
            return Suma(V, W);
        }
        public static Wektor operator -(Wektor V, Wektor W)
        {
            if (V.Wymiar != W.Wymiar)
                throw new Exception("Wymiary wektorów nie są równe");

            Wektor wektor = new Wektor(V.Wymiar);

            for (byte i = 0; i < V.Wymiar; i++)
            {
                wektor[i] = V[i] - W[i];
            }

            return wektor;
        }
        public static Wektor operator *(Wektor V, double x)
        {
            Wektor wektor = new Wektor(V.Wymiar);

            for (byte i = 0; i < V.Wymiar; i++)
            {
                wektor[i] = V[i] * x;
            }

            return wektor;
        }
        public static Wektor operator *(double x, Wektor V)
        {
            return V * x;
        }
        public static Wektor operator /(Wektor V, double x)
        {
            Wektor wektor = new Wektor(V.Wymiar);

            for (byte i = 0; i < V.Wymiar; i++)
            {
                wektor[i] = V[i] / x;
            }

            return wektor;
        }
    }
}
