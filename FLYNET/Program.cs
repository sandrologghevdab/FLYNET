using FLYNET.Personeel;
using FLYNET.Vloot;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FLYNET
{
    class Program
    {
        static void Main(string[] args)
        {
            PassagiersVliegtuig test = new PassagiersVliegtuig { Type="test",AantalPassagiers=3,BasisKostprijsPerDag=350m,Kruissnelheid=230,Vliegbereik=350};
            //****************************************************************************************
            //Vliegtuigen
            //****************************************************************************************

            //Passagiersvliegtuigen
            //****************************************************************************************
            PassagiersVliegtuig airbusA319 = new PassagiersVliegtuig
            {
                Type = "AirbusA319",
                AantalPassagiers = 141,
                Vliegbereik = 6850,
                Kruissnelheid = 880,
                BasisKostprijsPerDag = 1000m
            };


            PassagiersVliegtuig boeing737 = new PassagiersVliegtuig
            {
                Type = "Boeing737 ",
                AantalPassagiers = 190,
                Vliegbereik = 12500,
                Kruissnelheid = 850,
                BasisKostprijsPerDag = 1500m
            };

            PassagiersVliegtuig boeing787 = new PassagiersVliegtuig
            {
                Type = "Boeing787",
                AantalPassagiers = 330,
                Vliegbereik = 15700,
                Kruissnelheid = 913,
                BasisKostprijsPerDag = 2000m
            };


            //VrachtVliegtuigen
            //****************************************************************************************

            VrachtVliegtuig antonovAn30 = new VrachtVliegtuig
            {
                Type = "AntonovAn-30",
                LaadVermogen = 8,
                Vliegbereik = 1600,
                Kruissnelheid = 430,
                BasisKostprijsPerDag = 300m
            };

            VrachtVliegtuig britishAerospace146 = new VrachtVliegtuig
            {
                Type = "BritishAerospace146",
                LaadVermogen = 42,
                Vliegbereik = 1600,
                Kruissnelheid = 750,
                BasisKostprijsPerDag = 600m
            };


            VrachtVliegtuig antonovAn225 = new VrachtVliegtuig
            {
                Type = "AntonovAn-225",
                LaadVermogen = 425,
                Vliegbereik = 15400,
                Kruissnelheid = 800,
                BasisKostprijsPerDag = 1500m
            };





            //****************************************************************************************
            //Personeel
            //****************************************************************************************
            Certificaat PPL = new Certificaat
            {
                CertificaatAfkorting = "PPL",
                CertificaatOmschrijving = "Private Pilot License"
            };


            Certificaat ATPL = new Certificaat
            {
                CertificaatAfkorting = "ATPL",
                CertificaatOmschrijving = "Airline Transport Pilot License"
            };

            Certificaat IR = new Certificaat
            {
                CertificaatAfkorting = "IR",
                CertificaatOmschrijving = "Instrument Rating"
            };

            Certificaat CPL = new Certificaat
            {
                CertificaatAfkorting = "CPL",
                CertificaatOmschrijving = "Commercial Pilot License"
            };

            Certificaat ME = new Certificaat
            {
                CertificaatAfkorting = "ME",
                CertificaatOmschrijving = "Multi Engine"
            };

            Certificaat MCC = new Certificaat
            {
                CertificaatAfkorting = "MCC",
                CertificaatOmschrijving = "Multi Crew Concept"
            };

            Certificaat EHBO = new Certificaat
            {
                CertificaatAfkorting = "EHBO",
                CertificaatOmschrijving = "First Aid"
            };

            Certificaat EVAC = new Certificaat
            {
                CertificaatAfkorting = "EVAC",
                CertificaatOmschrijving = "Evacution Procedures"
            };

            Certificaat FIRE = new Certificaat
            {
                CertificaatAfkorting = "FIRE",
                CertificaatOmschrijving = "Fire Fighting"
            };


            Certificaat SURV = new Certificaat
            {
                CertificaatAfkorting = "SURV",
                CertificaatOmschrijving = "Survival"
            };


            Certificaat IFS = new Certificaat
            {
                CertificaatAfkorting = "IFS",
                CertificaatOmschrijving = "In Flight Service"
            };

            
            CockpitPersoneelslid CK = new CockpitPersoneelslid("001", "Captain Kirk", 500m, Graad.Captain,5000, new List<Certificaat> { PPL, ATPL, CPL, SURV });
            CockpitPersoneelslid SPock = new CockpitPersoneelslid("002", "Spock", 400m, Graad.SecondOfficer,4500, new List<Certificaat> { PPL, ATPL, CPL, IFS });
            CockpitPersoneelslid McCoy = new CockpitPersoneelslid("003", "McCoy", 400m, Graad.SeniorFlightOfficer,4500, new List<Certificaat> { PPL, ME, MCC, EHBO });
            CabinePersoneelslid Pavel = new CabinePersoneelslid("004", "Pavel Chekov", 300m, Graad.Purser, new List<Certificaat> {  ME, MCC, EHBO,IFS },"deur1");
            CabinePersoneelslid Hikaru = new CabinePersoneelslid("005", "Hikaru Sulu", 300m, Graad.Steward, new List<Certificaat> { ME, MCC,FIRE, SURV, IFS },"deur2");
            CabinePersoneelslid SkyWalker = new CabinePersoneelslid("004", "SkyWalker", 300m, Graad.Steward, new List<Certificaat> { FIRE,SURV,IFS,EHBO },"nooduitgang");

            VliegMaatschappij BrusselsAirlines = new VliegMaatschappij(1, VliegMaatschappijNaam.BrusselsAirlines, new List<LuchtVaartuig> { airbusA319, boeing737, boeing787, britishAerospace146 });
            VliegMaatschappij TNTAirways = new VliegMaatschappij(2, VliegMaatschappijNaam.TNTAirways, new List<LuchtVaartuig> { antonovAn30, antonovAn225, antonovAn30 });
            VliegMaatschappij Jetairfly = new VliegMaatschappij(3, VliegMaatschappijNaam.Jetairfly, new List<LuchtVaartuig> {boeing737,boeing787 });
            VliegMaatschappij ThomasCook = new VliegMaatschappij(4, VliegMaatschappijNaam.ThomasCook, new List<LuchtVaartuig> { airbusA319, boeing787 });

            Vlucht vl1 = new Vlucht(1, "New York", 2, BrusselsAirlines, boeing787, new List<VliegendPersoneelslid> {CK,SPock,Pavel,Hikaru });
            Vlucht vl2 = new Vlucht { VluchtID = 2, Bestemming = "Beijing", VliegMaatschappij = TNTAirways, Toestel = antonovAn225,Personeel= new List<VliegendPersoneelslid> {CK,SkyWalker },DuurtijdInDagen=1 };
            Vlucht vl3 = new Vlucht(3, "Sydney", 3, ThomasCook, airbusA319, new List<VliegendPersoneelslid> { CK, SPock, Pavel, Hikaru });
            Vlucht vl4 = new Vlucht(4, "Singapore", 2, BrusselsAirlines, britishAerospace146, new List<VliegendPersoneelslid> { McCoy,Hikaru,SkyWalker });
            Vlucht vl5 = new Vlucht(5, "Malta", 1, Jetairfly, boeing737, new List<VliegendPersoneelslid> { CK,SPock,SkyWalker });

            List<Vlucht> vluchten = new List<Vlucht> { vl1, vl2, vl3, vl4, vl5 };
            

            Console.WriteLine("Vrachtvluchten: ");
            Console.WriteLine("");
            foreach(Vlucht vlucht in vluchten.Where(v => v.Toestel is VrachtVliegtuig).ToList())
            {
                Decimal personeelskosten = 0m;
                foreach (Personeelslid personeelslid in vlucht.Personeel)
                    personeelskosten += personeelslid.BerekenTotaleKostprijsPerDag();
                Console.WriteLine($"{vlucht.VluchtID}: { vlucht.Bestemming} ({ vlucht.VliegMaatschappij.VliegMaatschappijNaam}) - {vlucht.Toestel.Type} ({vlucht.Toestel.BerekenTotaleKostprijsPerDag()*vlucht.DuurtijdInDagen}) - vluchtprijs {(vlucht.Toestel.BerekenTotaleKostprijsPerDag()+personeelskosten)*vlucht.DuurtijdInDagen}" );
                Console.WriteLine($"Totale Personeelskost voor deze vlucht: {personeelskosten * vlucht.DuurtijdInDagen}");
                Console.WriteLine();
                Console.WriteLine("Cockpitpersoneel");
                foreach (CockpitPersoneelslid personeelslid in vlucht.Personeel.Where(p => p is CockpitPersoneelslid).ToList())
                {
                    Console.WriteLine();
                    Console.WriteLine($"{personeelslid.PersoneelsID}: {personeelslid.Naam} - {personeelslid.Graad}");
                    foreach (Certificaat certificaat in personeelslid.Certificaten)
                        Console.Write(certificaat.CertificaatAfkorting + " ");
                    Console.WriteLine();
                    Console.WriteLine("vlieguren: " + personeelslid.VliegUren);
                    Console.WriteLine("Kostprijs voor deze vlucht: " + personeelslid.BerekenTotaleKostprijsPerDag()*vlucht.DuurtijdInDagen );
                }
                Console.WriteLine();
                Console.WriteLine("Cabinepersoneel");
                foreach (CabinePersoneelslid personeelslid in vlucht.Personeel.Where(p => p is CabinePersoneelslid).ToList())
                {
                    Console.WriteLine();
                    Console.WriteLine($"{personeelslid.PersoneelsID}: {personeelslid.Naam} - {personeelslid.Graad}");
                    foreach (Certificaat certificaat in personeelslid.Certificaten)
                        Console.Write(certificaat.CertificaatAfkorting + " ");
                    Console.WriteLine();
                    Console.WriteLine("werkpositie: " + personeelslid.Werpositie);
                    Console.WriteLine("Kostprijs voor deze vlucht: " + personeelslid.BerekenTotaleKostprijsPerDag() * vlucht.DuurtijdInDagen);
                }
                Console.WriteLine("");
            }
            
            Console.WriteLine("");

            Console.WriteLine("Passagiersvluchten: ");
            Console.WriteLine("");
            foreach (Vlucht vlucht in vluchten.Where(v => v.Toestel is PassagiersVliegtuig).ToList())
            {
                Decimal personeelskosten = 0m;
                foreach (Personeelslid personeelslid in vlucht.Personeel)
                    personeelskosten += personeelslid.BerekenTotaleKostprijsPerDag();
                Console.WriteLine($"{vlucht.VluchtID}: { vlucht.Bestemming} ({ vlucht.VliegMaatschappij.VliegMaatschappijNaam}) - {vlucht.Toestel.Type} ({vlucht.Toestel.BerekenTotaleKostprijsPerDag() * vlucht.DuurtijdInDagen}) - vluchtprijs {(vlucht.Toestel.BerekenTotaleKostprijsPerDag() + personeelskosten) * vlucht.DuurtijdInDagen}");
                Console.WriteLine($"Totale Personeelskost voor deze vlucht: {personeelskosten * vlucht.DuurtijdInDagen}");
                Console.WriteLine();
                Console.WriteLine("Cockpitpersoneel");
                foreach (CockpitPersoneelslid personeelslid in vlucht.Personeel.Where(p => p is CockpitPersoneelslid).ToList())
                {
                    Console.WriteLine();
                    Console.WriteLine($"{personeelslid.PersoneelsID}: {personeelslid.Naam} - {personeelslid.Graad}");
                    foreach (Certificaat certificaat in personeelslid.Certificaten)
                        Console.Write(certificaat.CertificaatAfkorting + " ");
                    Console.WriteLine();
                    Console.WriteLine("vlieguren: " + personeelslid.VliegUren);
                    Console.WriteLine("Kostprijs voor deze vlucht: " + personeelslid.BerekenTotaleKostprijsPerDag() * vlucht.DuurtijdInDagen);
                }
                Console.WriteLine();
                Console.WriteLine("Cabinepersoneel");
                foreach (CabinePersoneelslid personeelslid in vlucht.Personeel.Where(p => p is CabinePersoneelslid).ToList())
                {
                    Console.WriteLine();
                    Console.WriteLine($"{personeelslid.PersoneelsID}: {personeelslid.Naam} - {personeelslid.Graad}");
                    foreach (Certificaat certificaat in personeelslid.Certificaten)
                        Console.Write(certificaat.CertificaatAfkorting + " ");
                    Console.WriteLine();
                    Console.WriteLine("werkpositie: " + personeelslid.Werpositie);
                    Console.WriteLine("Kostprijs voor deze vlucht: " + personeelslid.BerekenTotaleKostprijsPerDag() * vlucht.DuurtijdInDagen);
                }
                Console.WriteLine("");
            }
        }
    }
}
