using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOPObjectInList.modell;

namespace OOPObjectInList
{
    class Tura
    {
        static int KezdetiTengerszintMagassag = 192;
        List<TuraSzakasz> tura;

        public Tura()
        {
            this.tura = new List<TuraSzakasz>();
            feltoltAdatokat();
        }

        public List<TuraSzakasz> getTura()
        {
            return tura;
        }

        public void feltoltAdatokat()
        {
            tura.Add(new TuraSzakasz("Sumeg, vasutallomas", "Sumeg, buszpalyaudvar", 1.208, 16, 6, false));
            tura.Add(new TuraSzakasz("Sumeg, buszpalyaudvar", "Mogyorosi-domb, geologiai bemutatohely", 1.512,24, 8,false));
            tura.Add(new TuraSzakasz("Mogyorosi-domb, geologiai bemutatohely", "Sumegi bazaltbanya vasutallomas", 1.576,13, 43,false));
            tura.Add(new TuraSzakasz("Sumegi bazaltbanya vasutallomas", "Sarvaly erdeszhaz, pecsetelohely", 2.101,69,18,true));
            tura.Add(new TuraSzakasz("Sarvaly erdeszhaz, pecsetelohely", "Leteres a foldutrol a romos vadaszhaznal", 4.250, 82, 66,false));
            tura.Add(new TuraSzakasz("Leteres a foldutrol a romos vadaszhaznal", "Kek rom jelzes kezdete Tatika varahoz", 2.686,172, 29, false));
            tura.Add(new TuraSzakasz("Kek rom jelzes kezdete Tatika varahoz", "Hidegkuti major", 1.614,9,135,false));
            tura.Add(new TuraSzakasz("Hidegkuti major", "Leteres a Sztupahoz", 3.903,153, 53,false));
            tura.Add(new TuraSzakasz("Leteres a Sztupahoz", "Zalaszanto, romai katolikus templom", 2.747,14, 148, true));
            tura.Add(new TuraSzakasz("Zalaszanto, romai katolikus templom", "Leteres az orszagutrol Rezi fele", 2.396,26, 51,false));
            tura.Add(new TuraSzakasz("Leteres az orszagutrol Rezi fele", "Rezi, leteres a pecsetelohelyhez", 3.328,112, 13, true));
            tura.Add(new TuraSzakasz("Rezi, leteres a pecsetelohelyhez", "Gyongyosi csarda", 2.535,31, 173, true));
            tura.Add(new TuraSzakasz("Gyongyosi csarda", "Egregy, arpad-kori templom", 5.239, 134,109,false));
            tura.Add(new TuraSzakasz("Egregy, arpad-kori templom", "Heviz, leteres az autobuszallomashoz", 2.595,20, 49,true));
            tura.Add(new TuraSzakasz("Heviz, leteres az autobuszallomashoz", "Keszthely, Festetics kastely eszaki kapuja", 5.114, 58, 32, false));
            tura.Add(new TuraSzakasz("Keszthely, Festetics kastely eszaki kapuja", "Keszthely, leteres a vasutallomashoz", 1.820,3, 36, true));
        }
    }
}
