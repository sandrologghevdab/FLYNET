using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    class VrachtVliegtuig:LuchtVaartuig
    {
        public VrachtVliegtuig(string type,int laadvermogen, int vliegbereik, int kruissnelheid, decimal basisKostprijsPerDag) : base(type, vliegbereik, kruissnelheid,  basisKostprijsPerDag)
        {
            LaadVermogen = laadvermogen;
        }

        public int LaadVermogen { get; set; }
        public VrachtVliegtuig()
        {

        }
        public override decimal BerekenTotaleKostprijsPerDag()
        {
            return BasisKostprijsPerDag + (LaadVermogen * 100m); 
        }
    }
}
