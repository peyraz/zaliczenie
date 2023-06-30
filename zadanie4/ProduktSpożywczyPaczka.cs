using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    internal class ProduktSpożywczyPaczka : ProduktSpożywczy
    {
        private decimal waga;

        public decimal Waga
        {
            get => waga;
            set
            {
                if (value > 0)
                    waga = value;
            }
        }
    }
}
