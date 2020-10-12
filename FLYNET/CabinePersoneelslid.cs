using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FLYNET.Personeel
{
    class CabinePersoneelslid : VliegendPersoneelslid
    {
        public string Werpositie { get; set; }
        public CabinePersoneelslid(string personeelsID, string naam, decimal basisKostprijsPerDag,Graad graad,List<Certificaat>certificaats,string werkpositie) : base(personeelsID, naam, basisKostprijsPerDag,graad,certificaats)
        {
            Werpositie = werkpositie;
            if (graad != Graad.Purser && graad != Graad.Steward)
                throw new Exception($"verkeerde graad opgegeven{graad}");
            
        }
        public override Decimal BerekenTotaleKostprijsPerDag()
        {
            decimal BasisKostprijsPerDag = this.BasisKostprijsPerDag;
            if (Graad == Graad.Purser)
                BasisKostprijsPerDag *= 1.2m;
            if (Certificaten.Any(cert=>cert.CertificaatAfkorting =="EHBO"))
                BasisKostprijsPerDag += 5m;
            return BasisKostprijsPerDag;
        }

    }
}
