using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    internal class Osoba
    {
        private string imię;
        public string Nazwisko;
        public DateTime? DataUrodzenia = null;
        public DateTime? DataŚmierci = null;
        public string Imię
        {
            get => imię;
            set
            {
                if (value == null)
                    throw new ArgumentException();
                imię = value;
            }
        }
        public string ImięNazwisko
        {
            get => $"{imię} {Nazwisko}";
            set
            {
                string[] rozbicie = value.Split(" ");
                imię = rozbicie[0];
                if (rozbicie.Length == 1)
                    Nazwisko = "";
                else
                    Nazwisko = rozbicie[^1];
            }
        }
        public TimeSpan? Wiek
        {
            get
            {
                if (DataUrodzenia == null)
                    return null;
                if (DataŚmierci == null)
                    return DateTime.Now - DataUrodzenia;
                return DataŚmierci - DataUrodzenia;
            }
        }

        internal Osoba(string imięNazwisko)
        {
            ImięNazwisko = imięNazwisko;
        }
    }
}
