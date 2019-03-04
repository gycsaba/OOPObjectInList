using OOPObjectInList.modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPObjectInList
{
    class Program
    {
        private static List<TuraSzakasz> tura;
        static void Main(string[] args)
        {
            Tura t = new Tura();
            tura = t.getTura();
            foreach(TuraSzakasz tsz in tura)
            {
                Console.WriteLine(tsz.Hossz + "km: " + tsz.KiinduloPont + "   -    " + tsz.VegPont);
            }
            Console.ReadKey();
        }
    }
}
