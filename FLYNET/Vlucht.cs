using FLYNET.Personeel;
using FLYNET.Vloot;
using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET
{
    class Vlucht
    {
        public int VluchtID { get; set; }
        public string Bestemming { get; set; }
        public int DuurtijdInDagen { get; set; }
        public VliegMaatschappij VliegMaatschappij { get; set; }
        public LuchtVaartuig Toestel { get; set; }

        public List<VliegendPersoneelslid> Personeel { get; set; }

        public Decimal BerekenVluchtKost()
        {
            decimal personeelKosten=0m;
            foreach(VliegendPersoneelslid p in Personeel)
            {
                personeelKosten += p.BasisKostprijsPerDag;
            }
            return (personeelKosten + Toestel.BasisKostprijsPerDag) * DuurtijdInDagen;
        }

        public Vlucht(int vluchtID, string bestemming, int duurtijdInDagen, VliegMaatschappij vliegMaatschappij, LuchtVaartuig toestel, List<VliegendPersoneelslid> personeel)
        {
            VluchtID = vluchtID;
            Bestemming = bestemming;
            DuurtijdInDagen = duurtijdInDagen;
            VliegMaatschappij = vliegMaatschappij;
            Toestel = toestel;
            Personeel = personeel;
        }
        public Vlucht()
        {

        }
    }
}
