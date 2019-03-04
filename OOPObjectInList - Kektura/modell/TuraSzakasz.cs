using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPObjectInList.modell
{
    class TuraSzakasz
    {
        public string KiinduloPont { get; set;}
        public string VegPont { get; set; }
        public double Hossz { get; set; }
        public int EmelkedesOsszeg { get; set; }
        public int LejtesOsszeg { get; set; }
        public bool PecsetelohelyE { get; set; }

        public TuraSzakasz(string kiinduloPont, string vegPont, double hossz, int emelkedesOsszeg, int lejtesOsszeg, bool pecsetelohelyE)
        {
            KiinduloPont = kiinduloPont ?? throw new ArgumentNullException(nameof(kiinduloPont));
            VegPont = vegPont ?? throw new ArgumentNullException(nameof(vegPont));
            Hossz = hossz;
            EmelkedesOsszeg = emelkedesOsszeg;
            LejtesOsszeg = lejtesOsszeg;
            PecsetelohelyE = pecsetelohelyE;
        }
    }
}
