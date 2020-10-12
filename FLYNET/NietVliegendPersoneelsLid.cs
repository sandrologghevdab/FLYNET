using FLYNET.Personeel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Personeel
{
    public class NietVliegendPersoneelsLid : Personeelslid
    {
        public int UrenPerWeek { get; set; }
        public Afdeling Afdeling { get; set; }
        public NietVliegendPersoneelsLid(string personeelsID, string naam, decimal basisKostprijsPerDag) : base(personeelsID, naam, basisKostprijsPerDag)
        {
            PersoneelsID = personeelsID;
            Naam = naam;
            BasisKostprijsPerDag = basisKostprijsPerDag;
        }

        
        



    }
}
