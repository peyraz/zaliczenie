using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    internal class Wielopak
    {
        public Produkt Produkt;
        public ushort Ilość;
        private decimal cenaNetto;
        private string kategoriaVat = "";
        private string krajPochodzenia = "";

        public string KategoriaVat
        {
            get => kategoriaVat;
            set
            {
                if (Produkt.stawkiVat.ContainsKey(value))
                    kategoriaVat = value;
            }
        }
        public decimal CenaNetto
        {
            get => cenaNetto;
            set
            {
                if (value > 0)
                    cenaNetto = value * Ilość;
            }
        }
        public decimal CenaBrutto
        {
            get => cenaNetto * (Produkt.stawkiVat[kategoriaVat] + 1);
        }

        public string KrajPochodzenia
        {
            get => krajPochodzenia;
            set
            {
                if (Produkt.kraje.Contains(value))
                    krajPochodzenia = value;
            }
        }
    }
}
