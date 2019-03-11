using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPObjectInList___PekingiTorna.model
{
    class Versenyzo 
    {
        public int Rajtszam { set; get; }
        public string Nev { set; get; }
        public string Orszag { set; get; }
        public string Foldresz { set; get; }

        public Versenyzo()
        { }

        public Versenyzo(int rajtszam, string nev, string orszag, string foldresz)
           
        {
            Rajtszam = rajtszam;
            Nev = nev;
            Orszag = orszag;
            Foldresz = foldresz;
        }
    }
}
