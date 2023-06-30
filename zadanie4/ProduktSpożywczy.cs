using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    internal class ProduktSpożywczy : Produkt
    {
        readonly static string[] stawkiVatSpożywcze =
        {
            "pieczywo",
            "mięso",
            "owoce",
            "warzywa",
        };

        readonly static string[] listaAlergenów =
        {
            "gluten",
            "mleko",
            "soja",
            "seler",
            "sezam",
            "orzechy",
        };

        public uint Kalorie;
        private HashSet<string> Alergeny = new HashSet<string>();

        public void DodajAlergen(string alergen)
        {
            if (listaAlergenów.Contains(alergen))
                Alergeny.Add(alergen);
        }
        public void UsuńAlergen(string alergen)
        {
            Alergeny.Remove(alergen);
        }
        public void WyświetlAlergeny()
        {
            foreach (string alergen in Alergeny)
                Console.WriteLine(alergen);
        }

        public override string KategoriaVat
        {
            get => kategoriaVat;
            set
            {
                if (stawkiVatSpożywcze.Contains(value))
                    kategoriaVat = value;
            }
        }
    }
}
