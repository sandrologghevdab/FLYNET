using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Vloot
{
    class PassagiersVliegtuig : LuchtVaartuig
    {
        public int AantalPassagiers { get; set; }
        public PassagiersVliegtuig(string Type, int AantalPassagiers, int Vliegbereik, int Kruissnelheid, decimal BasisKostprijsPerDag) : base(Type, Vliegbereik, Kruissnelheid,  BasisKostprijsPerDag)
        {
            this.AantalPassagiers = AantalPassagiers;
        }
        public PassagiersVliegtuig()
        {

        }
        public override decimal BerekenTotaleKostprijsPerDag()
        {
            return BasisKostprijsPerDag + (AantalPassagiers * 10m);
        }
    }
}
