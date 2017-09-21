using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefOppervlakte
{
    class Cirkel
    {
        private double _straal;

        public double Straal
        {
            get => _straal;
            set
            {
                if (value > 0)
                {
                    _straal = value;
                }
            }
        }

        public Cirkel(double straal) { this.Straal = straal; }

        public string FormattedOmtrek()
        {
            return berekenOmtrek().ToString();
        }

        public double berekenOmtrek()
        {
            double omtrek = 2 * Straal * Math.PI;
            return Math.Round(omtrek, 2);
        }

        public string FormattedOppervlakte()
        {
            return berekenOppervlakte().ToString();
        }

        public double berekenOppervlakte()
        {
            double oppervlakte = Straal * Straal * Math.PI;
            return Math.Round(oppervlakte, 2);
        }

        public override string ToString()
        {
            return string.Format("{0}{1}\n{2}{3}", "Omtrek:".PadRight(20) , FormattedOmtrek().PadLeft(10), "Oppervlakte:".PadRight(20), FormattedOppervlakte().PadLeft(10));
        }
    }
}
