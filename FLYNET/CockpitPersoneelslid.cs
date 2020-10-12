using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FLYNET.Personeel
{
    public class CockpitPersoneelslid : VliegendPersoneelslid
    {
        public int VliegUren { get; set; }
        public CockpitPersoneelslid(string personeelsID, string naam, decimal basisKostprijsPerDag, Graad graad,int vlieguren, List<Certificaat> certificaats) : base(personeelsID, naam, basisKostprijsPerDag,graad,certificaats)
        {
            VliegUren = vlieguren;
            if (graad != Graad.Captain && graad != Graad.SeniorFlightOfficer && graad != Graad.SecondOfficer && graad != Graad.juniorFlightOfficer)
            {
                throw new Exception($"Verkeerde graad ({graad}), kies één van de mogelijke graden van een cockpitpersoneelslid");
            }
            else
                Graad = graad;

            

        }
       public override decimal BerekenTotaleKostprijsPerDag()
        {
            decimal basisKostprijsPerDag = BasisKostprijsPerDag;
            switch ((Graad)
)
            {
                case Graad.Captain:
                    basisKostprijsPerDag = basisKostprijsPerDag * 1.3m; break;
                case Graad.SeniorFlightOfficer:
                    basisKostprijsPerDag = basisKostprijsPerDag * 1.2m; break;
                case Graad.SecondOfficer:
                    basisKostprijsPerDag = basisKostprijsPerDag * 1.1m; break;
                default:

                    break;
            }

            Certificaat CPL = new Certificaat
            {
                CertificaatAfkorting = "CPL",
                CertificaatOmschrijving = "Commercial Pilot License"
            };

            if (Certificaten.Any(cert => cert.CertificaatAfkorting == CPL.CertificaatAfkorting))
                return (basisKostprijsPerDag + 50m);
            else
                return basisKostprijsPerDag;
        }
    }
}