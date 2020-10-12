using FLYNET.Personeel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET.Personeel
{
    public class VliegendPersoneelslid : Personeelslid
    {
        public VliegendPersoneelslid(string personeelsID, string naam, decimal basisKostprijsPerDag, Graad graad,List<Certificaat>certificaats) : base(personeelsID, naam, basisKostprijsPerDag)
        {
            Graad = graad;
            Certificaten = certificaats;
        }

        public Graad Graad { get; set; }
        public List<Certificaat> Certificaten { get; set; }
    }
}
