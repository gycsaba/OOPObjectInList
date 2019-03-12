﻿using OOPObjectInList___PekingiTorna.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPObjectInList___PekingiTorna.repository
{
    class PekingiTornaszok
    {
        List<Tornasz> tornaszok;

        public List<Tornasz> getPekingiTornaszok()
        {
            return tornaszok;
        }

        public PekingiTornaszok()
        {
            tornaszok = new List<Tornasz>();

            tornaszok.Add(new Tornasz(178, "YANG Wei", "CHN", "Ázsia" , 15.400, 15.425, 16.225,16.550, 15.350, 14.925));
            tornaszok.Add(new Tornasz(107, "HAMBUECHEN Fabian","GER","Európa",15.800,13.100,14.975,16.300,16.050,16.200));
            tornaszok.Add(new Tornasz(197, "KIM Daeeun","KOR", "Ázsia", 15.500, 14.725, 15.450, 16.050, 16.050, 14.625));
            tornaszok.Add(new Tornasz(168, "UCHIMURA Kohei", "JPN", "Ázsia", 15.725, 14.100, 14.675, 16.200, 16.025, 15.325));
            tornaszok.Add(new Tornasz(179, "SAKAMOTO Koki","JPN","Ázsia",14.950,14.925,15.525,16.200,15.625,14.725));
            tornaszok.Add(new Tornasz(192, "TOMITA Hiroyuki","JPN","Ázsia",15.175,15.175,15.025,15.200,15.775,15.550));
            tornaszok.Add(new Tornasz(182, "KHOROKHORDIN Sergey","RUS","Európa",14.975,14.800,15.075,15.725,15.875,15.350));
            tornaszok.Add(new Tornasz(138, "HORTON Jonathan", "USA", "Észak - Amerika", 15.350, 13.925, 15.325, 15.950, 15.525, 15.575));
            tornaszok.Add(new Tornasz(139, "CHEN Yibing","CHN", "Ázsia", 14.725, 14.475, 16.525, 16.275, 15.075, 14.525));
            tornaszok.Add(new Tornasz(198, "CARANOBE Benoit","FRA","Európa",15.125,14.250,15.100,16.500,15.275,14.675));
            tornaszok.Add(new Tornasz(120, "MARTINEZ Rafael", "ESP", "Európa", 15.550, 14.800, 14.325, 15.750, 15.100, 15.275));
            tornaszok.Add(new Tornasz(200, "SAVITSKI Dmitry","BLR","Európa",14.375,14.525,15.175,16.300,15.700,14.575));
            tornaszok.Add(new Tornasz(170, "RIVERA RIVERA Luis", "BRA", "Dél - Amerika", 15.125, 14.750, 15.250, 16.225, 14.575, 14.675));
            tornaszok.Add(new Tornasz(145, "DEVYATOVSKIY Maxim", "RUS", "Európa", 15.300, 13.300, 15.375, 15.825, 15.425, 15.125));
            tornaszok.Add(new Tornasz(154, "FUENTES BUSTAMANTE Jose Luis", "VEN", "Dél - Amerika", 14.150, 15.525, 14.850, 15.675, 15.375, 14.750));
            tornaszok.Add(new Tornasz(138, "KOCZI Flavius","ROU","Európa",15.125,14.400,13.950,16.600,15.075,15.025));
            tornaszok.Add(new Tornasz(171, "RYAZANOV Yury", "RUS", "Európa", 14.600, 14.450, 15.100, 15.550, 15.625, 14.800));
            tornaszok.Add(new Tornasz(153, "KIM Soomyun","KOR", "Ázsia", 15.575, 13.800, 14.175, 16.025, 15.350, 14.975));
            tornaszok.Add(new Tornasz(191, "ARTEMEV Alexander", "USA", "Észak - Amerika", 14.875, 15.250, 13.675, 15.825, 15.175, 14.925));
            tornaszok.Add(new Tornasz(111, "GAFUIK Nathan", "CAN","Észak-Amerika",15.225,13.800,14.250,16.175,15.450,14.825));
            tornaszok.Add(new Tornasz(124, "BOY Philipp", "GER", "Európa", 14.450, 14.675, 14.650, 16.200, 15.125, 14.375));
            tornaszok.Add(new Tornasz(183, "YANG Taeyoung", "KOR","Ázsia",13.850,15.000,14.875,16.000,16.100,13.475));
            tornaszok.Add(new Tornasz(184, "FOKIN Anton", "UZB", "Ázsia", 14.325, 14.725, 14.825, 15.625, 16.150, 13.625));
            tornaszok.Add(new Tornasz(147, "WONG Adam", "CAN","Észak-Amerika",14.900,14.375,14.500,15.650,15.125,14.575));
            tornaszok.Add(new Tornasz(180, "KEATINGS Daniel","GBR","Európa",14.900,15.175,13.775,15.625,14.900,14.575));
            tornaszok.Add(new Tornasz(193, "POZZO Enrico","ITA","Európa",14.800,14.325,14.250,15.700,14.750,14.850));
            tornaszok.Add(new Tornasz(121, "BOUHAIL Thomas", "FRA", "Európa", 15.125, 13.850, 13.700, 16.625, 14.675, 14.575));
            tornaszok.Add(new Tornasz(151, "KARBANENKO Dimitri","FRA","Európa",14.050,13.700,13.675,16.125,15.500,15.450));
            tornaszok.Add(new Tornasz(179, "SHATILOV Alexandr","ISR","Ázsia",15.600,13.825,14.075,15.575,14.500,14.225));
            tornaszok.Add(new Tornasz(148, "SABOT Hamilton","FRA","Európa",14.575,14.025,14.375,15.400,15.400,13.975));
            tornaszok.Add(new Tornasz(188, "MORANDI Matteo", "ITA", "Európa", 14.175, 13.700, 16.025, 16.100, 13.725, 13.850));
            tornaszok.Add(new Tornasz(122, "POPESCU Daniel","ROU","Európa",14.575,14.500,13.975,16.400,14.525,13.325));
        }
    }
}
