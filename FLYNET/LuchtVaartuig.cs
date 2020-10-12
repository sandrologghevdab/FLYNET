using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    class LuchtVaartuig : IKost
    {
        public string Type { get; set; }
        public int Kruissnelheid { get; set; }
        public int Vliegbereik { get; set; }
        public decimal BasisKostprijsPerDag { get ; set ; }

        public virtual decimal BerekenTotaleKostprijsPerDag()
        {
            throw new NotImplementedException();
        }

        public LuchtVaartuig(string Type, int Vliegbereik, int Kruissnelheid,  decimal BasisKostprijsPerDag)
        {
            this.Type = Type;
            this.Kruissnelheid = Kruissnelheid;
            this.Vliegbereik = Vliegbereik;
            this.BasisKostprijsPerDag = BasisKostprijsPerDag;
        }
        public LuchtVaartuig()
        {

        }
    }
}
