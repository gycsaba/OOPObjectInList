using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LambdaGyakorloFeladatokNyitohetvege.Modell;

namespace LambdaGyakorloFeladatokNyitohetvege.Repository
{
    class Tarolo
    {
        List<FilmNyitohetvegeAdat> filmNyitohetvegeAdatok;

        public Tarolo()
        {
            filmNyitohetvegeAdatok = new List<FilmNyitohetvegeAdat>();
        }

        public void beolvas()
        {
            StreamReader sr = new StreamReader("../../nyitohetvege.txt");
            string sor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                FilmNyitohetvegeAdat fnya = new FilmNyitohetvegeAdat(sor);
                filmNyitohetvegeAdatok.Add(fnya);
            }
            sr.Close();
        }

        public int getFilmekSzama()
        {
            return filmNyitohetvegeAdatok.Count;
        }
    }
}
