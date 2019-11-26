using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitorlaverseny.modell
{
    class Helyezes
    {
        private int eredmeny;
        private string kategoria;
        private string hajo;
        private string klub;
        private string kormanyos;
        private int nap;
        private int ora;
        private int perc;

        public int Eredmeny { get => eredmeny; set => eredmeny = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public string Hajo { get => hajo; set => hajo = value; }
        public string Klub { get => klub; set => klub = value; }
        public string Kormanyos { get => kormanyos; set => kormanyos = value; }
        public int Nap { get => nap; set => nap = value; }
        public int Ora { get => ora; set => ora = value; }
        public int Perc { get => perc; set => perc = value; }

        public Helyezes(string sor)
        {
            string[] adat = sor.Split(';');
            eredmeny = Convert.ToInt32(adat[0]);
            kategoria = adat[1];
            hajo = adat[2];
            klub = adat[3];
            kormanyos = adat[4];
            nap = Convert.ToInt32(adat[5]);
            ora = Convert.ToInt32(adat[6]);
            perc = Convert.ToInt32(adat[7]);
        }

        public override string ToString()
        {
            return eredmeny+". "+kategoria+" kategóriában+"+hajo+"\n"+
                "Klub:"+klub+". Kormányos:"+kormanyos+".\n"+
                "Időeredmény (nap,óra,perc): "+nap+":"+ora+":"+perc;
        }
    }
}
