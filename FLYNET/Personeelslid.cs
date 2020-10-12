using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Personeel
{
   public class Personeelslid : IKost
    {
        public string PersoneelsID { get; set; }
        public string Naam { get; set; }
        public Decimal BasisKostprijsPerDag { get ; set; }

        public virtual Decimal BerekenTotaleKostprijsPerDag()
        {
            return BasisKostprijsPerDag;
        }

        public Personeelslid(string personeelsID, string naam, Decimal basisKostprijsPerDag)
        {
            PersoneelsID = personeelsID;
            Naam = naam;
            BasisKostprijsPerDag = basisKostprijsPerDag;
        }
    }
}
