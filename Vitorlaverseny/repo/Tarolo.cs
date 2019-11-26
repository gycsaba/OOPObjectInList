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

        public int getKlubokSzama()
        {
            HashSet<string> klubok = new HashSet<string>();
            foreach (Helyezes h in helyezesek)
                klubok.Add(h.Klub);
            return klubok.Count;
        }

        public int getKategoriakSzama()
        {
            HashSet<string> kategoriak = new HashSet<string>();
            foreach (Helyezes h in helyezesek)
                kategoriak.Add(h.Kategoria);
            return kategoriak.Count;
        }
        public Helyezes getAdatokKormanyosAlapjan()
        {
            return helyezesek.Find(x => x.Kormanyos == "Paulovics Dénes");
        }

        public Helyezes getAdatokHajoAlapjan()
        {
            return helyezesek.Find(x => x.Hajo == "AMINA");
        }

        public int getKlubLegjobbIdoeredmeny(string klub)
        {
            List<Helyezes> klubok = new List<Helyezes>();
            klubok = helyezesek.FindAll(x => x.Klub == klub);
            return klubok.Min(x => x.getIdoeredmeny());            
        }
        public int getKatogoriaLegjobbIdoeredmeny(string kategoria)
        {
            List<Helyezes> kategoriak = new List<Helyezes>();
            kategoriak = helyezesek.FindAll(x => x.Kategoria == kategoria);
            return kategoriak.Min(x => x.getIdoeredmeny());
        }
    }
}
