using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitorlaverseny.tarolo;

namespace Vitorlaverseny
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarolo t = new Tarolo();
            t.beolvas();
            Console.WriteLine("1. feladat");
            Console.WriteLine("Versenyzők száma: "+t.getVersenyzokSzama());
            Console.WriteLine("2. feladat");
            Console.WriteLine("Klubok száma: " + t.getKlubokSzama());
            Console.WriteLine("3. feladat");
            Console.WriteLine("Kategóriák száma: " + t.getKategoriakSzama());
            Console.WriteLine("4. feladat");
            Console.WriteLine(t.getAdatokKormanyosAlapjan());
            Console.WriteLine("5. feladat");
            Console.WriteLine(t.getAdatokHajoAlapjan());
            Console.WriteLine("6. feladat");
           Console.WriteLine("KYK VSE klub legjobb időeredménye: "+t.getKlubLegjobbIdoeredmeny("KYK VSE")+" perc");
            Console.WriteLine("7. feladat");
            Console.WriteLine("Yardstick I/1 kategória legjobb időeredménye: " + t.getKatogoriaLegjobbIdoeredmeny("Yardstick I/1") + " perc");

            Console.ReadKey();
        }
    }
}
