using OOPObjectInList___PekingiTorna.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPObjectInList___PekingiTorna.repository
{
    class PekingiTornaszTorna
    {
        List<Versenyzo> versenyzok;

        public PekingiTornaszTorna()
        {
            versenyzok = new List<Versenyzo>();

            versenyzok.Add(new Versenyzo(178, "YANG Wei", "CHN", "Ázsia" , 15.400, 15.425, 16.225,16.550, 15.350, 14.925));
        }
    }
}
