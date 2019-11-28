using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitorlaverseny.modell;

namespace Vitorlaverseny.tarolo
{
    class Tarolo
    {
        private List<Helyezes> helyezesek;

        public Tarolo()
        {
            helyezesek = new List<Helyezes>();
        }

        public void beolvas()
        {
            StreamReader sr = new StreamReader("../../kekszalag.csv");
            string line = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                Helyezes h = new Helyezes(line);
                helyezesek.Add(h);
            }
            sr.Close();
        }

        public int getVersenyzokSzama()
        {
            return helyezesek.Count;
        }
    }
}
