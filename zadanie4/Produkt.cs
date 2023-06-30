using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    internal class Produkt
    {
        public readonly static string[] kraje =
        {
            "Polska",
            "Niemcy",
            "Francja",
            "Portugalia",
            "Hiszpania"
        };
        public readonly static Dictionary<string, decimal> stawkiVat = new Dictionary<string, decimal>()
        {
            ["rtv"] = 0.23m,
            ["agd"] = 0.23m,
            ["odzież"] = 0.23m,
            ["zabiegMed"] = 0.08m,
            ["badanieDiag"] = 0.08m,
            ["transport"] = 0.08m,
            ["pieczywo"] = 0m,
            ["mięso"] = 0m,
            ["owoce"] = 0m,
            ["warzywa"] = 0m,
            ["napoje"] = 0m,
        };

        public string Nazwa = "";
        protected string kategoriaVat = "";
        protected decimal cenaNetto;
        protected decimal cenaBrutto;
        protected string krajPochodzenia = "";

        public virtual string KategoriaVat
        {
            get => kategoriaVat;
            set
            {
                if (stawkiVat.ContainsKey(value))
                    kategoriaVat = value;
            }
        }
        public decimal CenaNetto
        {
            get => cenaNetto;
            set
            {
                if (value > 0)
                    cenaNetto = value;
            }
        }
        public decimal CenaBrutto
        {
            get => cenaNetto * (stawkiVat[kategoriaVat] + 1m);
        }

        public string KrajPochodzenia
        {
            get => krajPochodzenia;
            set
            {
                if (kraje.Contains(value))
                    krajPochodzenia = value;
            }
        }
    }
}
