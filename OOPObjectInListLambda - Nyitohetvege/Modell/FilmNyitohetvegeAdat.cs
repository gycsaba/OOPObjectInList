using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaGyakorloFeladatokNyitohetvege.Modell
{
    class FilmNyitohetvegeAdat
    {
        private string eredetiCim;
        private string magyarCim;
        private string bemutato;
        private string forgalmazo;
        private long bevetelForint;
        private int latogato;

        public FilmNyitohetvegeAdat(string sor)
        {
            string[] adat = sor.Split(';');
            this.EredetiCim = adat[0];
            this.MagyarCim = adat[1];
            this.Bemutato = adat[2];
            this.Forgalmazo = adat[3];
            this.BevetelForint = Convert.ToInt64(adat[4]);
            this.Latogato = Convert.ToInt32(adat[5]);
        }

        public FilmNyitohetvegeAdat(string eredetiCim, string magyarCim, string bemutato, string forgalmazo, long bevetelForint, int latogato)
        {
            this.EredetiCim = eredetiCim;
            this.MagyarCim = magyarCim;
            this.Bemutato = bemutato;
            this.Forgalmazo = forgalmazo;
            this.BevetelForint = bevetelForint;
            this.Latogato = latogato;
        }

        public string EredetiCim { get => eredetiCim; set => eredetiCim = value; }
        public string MagyarCim { get => magyarCim; set => magyarCim = value; }
        public string Bemutato { get => bemutato; set => bemutato = value; }
        public string Forgalmazo { get => forgalmazo; set => forgalmazo = value; }
        public long BevetelForint { get => bevetelForint; set => bevetelForint = value; }
        public int Latogato { get => latogato; set => latogato = value; }

        public override string ToString()
        {
            return
                "Eredeti cím:" + eredetiCim + "\n" +
                "Magyar cím:" + magyarCim + "\n" +
                "Forgalmazo:" + forgalmazo + "\n" +
                "Bevétel az első héten:" + bevetelForint + "\n" +
                "Látogatók száma:" + latogato;

        }
    }
}
