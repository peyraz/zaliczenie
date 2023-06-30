using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    internal class Macierz<T> : IEquatable<Macierz<T>>
    {
        T[,] macierz;
        internal Macierz(int wiersze, int kolumny)
        {
            macierz = new T[wiersze, kolumny];
        }

        public T this[uint i, uint j]
        {
            get => macierz[i, j];
            set
            {
                macierz[i, j] = value;
            }
        }

        public bool Equals(Macierz<T>? other)
        {
            if (other is null)
                return false;

            return this == other;
        }

        public static bool operator ==(Macierz<T> V, Macierz<T> W)
        {
            int wierszeV = V.macierz.GetLength(0),
                wierszeW = W.macierz.GetLength(0),
                kolumnyV = V.macierz.GetLength(1),
                kolumnyW = W.macierz.GetLength(1);

            if (wierszeV != wierszeW || kolumnyV != kolumnyW)
                return false;

            for (int i = 0; i < wierszeV; i++)
                for (int j = 0; j < kolumnyV; j++)
                {
                    if (!EqualityComparer<T>.Default.Equals(V.macierz[i, j], W.macierz[i, j]))     //porównanie każdego pola macierzy
                        return false;
                }

            return true;
        }
        public static bool operator !=(Macierz<T> V, Macierz<T> W)
        {
            return !(V == W);
        }
    }
}
