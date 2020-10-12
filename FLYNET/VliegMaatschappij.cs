using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    public enum VliegMaatschappijNaam { BrusselsAirlines, Jetairfly, ThomasCook, TNTAirways }
    class VliegMaatschappij
    {
        public int VliegMaatschappijID { get; set; }
        public VliegMaatschappijNaam VliegMaatschappijNaam { get; set; }
        public List<LuchtVaartuig> Vloot { get; set; }

        public VliegMaatschappij(int vliegMaatschappijID, VliegMaatschappijNaam vliegMaatschappijNaam, List<LuchtVaartuig> vloot)
        {
            VliegMaatschappijID = vliegMaatschappijID;
            VliegMaatschappijNaam = vliegMaatschappijNaam;
            Vloot = vloot;
        }
        public VliegMaatschappij()
        {

        }
    }
}
