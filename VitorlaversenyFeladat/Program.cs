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
           
            Console.ReadKey();
        }
    }
}
