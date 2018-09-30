using System;
using System.Linq;

namespace WeLeaseIT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Functie voor een extra whitespace
            void WhiteSpace()
            {
                Console.WriteLine("");
            }

            //While loop
            int redo = 1;
            while (redo == 1)
                { redo = 0;
            //Titel
            Console.WriteLine("WeLeaseIT");
            WhiteSpace();

            //Klanten
            Klant klant1 = new Klant(159, "Peter", "Landgraaf", 0612345678, "Peter@mail.ru", "01/01/1975", 147852369);
            Klant klant2 = new Klant(160, "Jan", "Heerlen", 0687654320, "Jan@mail.ru", "05/08/1980", 164897358);
            Console.WriteLine("Klanten toegevoegd!");

            //Medewerkers
            Medewerker medewerker1 = new Medewerker(260, "Kevin", "Elsloo", 0687654321, "Jan@WeLeaseIT.ru", "05/05/1972", 369258147);
            Medewerker medewerker2 = new Medewerker(261, "Dennis", "Born", 0612345612, "Dennis@WeLeaseIT.ru", "18/09/1985", 349586157);
            Console.WriteLine("Medewerkers toegevoegd!");

            //Contracten
            Contract contract1 = new Contract(012, 365, "25/05/2018", klant1.GetId(), 1, 85);
            Contract contract2 = new Contract(013, 365, "25/05/2018", klant1.GetId(), 1, 90);
            Contract contract3 = new Contract(014, 180, "26/06/2018", klant2.GetId(), 2, 150);
            Contract contract4 = new Contract(015, 200, "26/06/2018", klant2.GetId(), 1, 55);
            Contract contract5 = new Contract(016, 31, "27/06/2018", klant2.GetId(), 1, 30);
            klant1.VoegContractToe(contract1);
            klant1.VoegContractToe(contract2);
            klant2.VoegContractToe(contract3);
            klant2.VoegContractToe(contract4);
            klant2.VoegContractToe(contract5);
            medewerker1.VoegContractToe(contract1);
            medewerker1.VoegContractToe(contract4);
            medewerker2.VoegContractToe(contract2);
            medewerker2.VoegContractToe(contract3);
            medewerker2.VoegContractToe(contract5);
            Console.WriteLine("Contracten toegevoegd!");

            //Apparaten
            Apparaat apparaat1 = new Apparaat(01, 3000, 85, "Cisco", "Catalyst 3000", "126879543", "10 jaar", 365, "20/05/2018");
            Apparaat apparaat2 = new Apparaat(02, 3500, 90, "Cisco", "Catalyst 3500", "126879544", "12 jaar", 365, "20/05/2018");
            Apparaat apparaat3 = new Apparaat(03, 3500, 90, "Cisco", "Catalyst 3500", "126879545", "12 jaar", 180, "20/05/2018");
            Apparaat apparaat4 = new Apparaat(04, 2000, 60, "Cisco", "Catalyst 2000", "126879546", "7 jaar", 180, "21/05/2018");
            Apparaat apparaat5 = new Apparaat(05, 1500, 55, "Cisco", "Catalyst 1500", "126879547", "5 jaar", 200, "21/05/2018");
            Apparaat apparaat6 = new Apparaat(06, 1000, 30, "Cisco", "Catalyst 1000", "126879548", "3 jaar", 31, "21/05/2018");
            contract1.VoegApparaatToe(apparaat1);
            contract2.VoegApparaatToe(apparaat2);
            contract3.VoegApparaatToe(apparaat3);
            contract3.VoegApparaatToe(apparaat4);
            contract4.VoegApparaatToe(apparaat5);
            contract5.VoegApparaatToe(apparaat6);
            Console.WriteLine("Apparaten toegevoegd!");
            WhiteSpace();
            Console.WriteLine("Geef ENTER voor klanten contracten.");
            Console.ReadKey();
            
            //Laat klanten zien met klantnummer
            Console.Clear();
            Console.WriteLine("========");
            Console.WriteLine("Klanten|");
            Console.WriteLine("========");
            WhiteSpace();
            Console.WriteLine(klant1.GetId() + " | " + klant1.GetNaam());
            Console.WriteLine(klant2.GetId() + " | " + klant2.GetNaam());

            //Contracten van klant opvragen
            WhiteSpace();
            Console.WriteLine("==========");
            WhiteSpace();
            Console.WriteLine("Geef klantnummer: ");
            string invoerKlant = Console.ReadLine();
            Console.Clear();
            if (invoerKlant == "159")
                { 
                    Console.WriteLine("=====================");
                    Console.WriteLine("Contracten van Peter|");
                    Console.WriteLine("=====================");
                    for (int i = 0; i < klant1.ContractSet.Count(); i++)
                    { 
                        WhiteSpace();
                        Console.WriteLine("Contractnummer: " + klant1.ContractSet[i].GetId());
                        Console.WriteLine("Afsluitdatum: " + klant1.ContractSet[i].GetAfsluitDatum());
                        Console.WriteLine("Lease periode: " + klant1.ContractSet[i].GetLeasePer() + " dagen");
                        Console.WriteLine("___________________");
                    }
                }
            else if (invoerKlant == "160")
                { 
                    Console.WriteLine("===================");
                    Console.WriteLine("Contracten van Jan|");
                    Console.WriteLine("===================");
                    for (int i = 0; i < klant2.ContractSet.Count(); i++)
                    { 
                        WhiteSpace();
                        Console.WriteLine("Contractnummer: " + klant2.ContractSet[i].GetId());
                        Console.WriteLine("Afsluitdatum: " + klant2.ContractSet[i].GetAfsluitDatum());
                        Console.WriteLine("Lease periode: " + klant2.ContractSet[i].GetLeasePer() + " dagen");
                        Console.WriteLine("___________________");
                    }
                }
            WhiteSpace();
            Console.WriteLine("Geef ENTER voor medewerkers contracten.");
            Console.ReadKey();

            //Laat medewerkers zien met medewerkersnummer
            Console.Clear();
            Console.WriteLine("============");
            Console.WriteLine("Medewerkers|");
            Console.WriteLine("============");
            WhiteSpace();
            Console.WriteLine(medewerker1.GetId() + " | " + medewerker1.GetNaam());
            Console.WriteLine(medewerker2.GetId() + " | " + medewerker2.GetNaam());

            //Contracten van medewerker opvragen
            WhiteSpace();
            Console.WriteLine("==========");
            WhiteSpace();
            Console.WriteLine("Geef medewerkersnummer: ");
            string invoerMedewerker = Console.ReadLine();
            Console.Clear();
            if (invoerMedewerker == "260")
                { 
                    Console.WriteLine("=====================");
                    Console.WriteLine("Contracten van Peter|");
                    Console.WriteLine("=====================");
                    for (int i = 0; i < medewerker1.ContractSet.Count(); i++)
                    { 
                        WhiteSpace();
                        Console.WriteLine("Contractnummer: " + medewerker1.ContractSet[i].GetId());
                        Console.WriteLine("Afsluitdatum: " + medewerker1.ContractSet[i].GetAfsluitDatum());
                        Console.WriteLine("Lease periode: " + medewerker1.ContractSet[i].GetLeasePer() + " dagen");
                        Console.WriteLine("___________________");
                    }
                }
            else if (invoerMedewerker == "261")
                { 
                    Console.WriteLine("===================");
                    Console.WriteLine("Contracten van Jan|");
                    Console.WriteLine("===================");
                    for (int i = 0; i < medewerker2.ContractSet.Count(); i++)
                    { 
                        WhiteSpace();
                        Console.WriteLine("Contractnummer: " + medewerker2.ContractSet[i].GetId());
                        Console.WriteLine("Afsluitdatum: " + medewerker2.ContractSet[i].GetAfsluitDatum());
                        Console.WriteLine("Lease periode: " + medewerker2.ContractSet[i].GetLeasePer() + " dagen");
                        Console.WriteLine("___________________");
                    }
                }
            WhiteSpace();
            Console.WriteLine("Geef 0 om af te sluiten. Geef 1 om opnieuw te beginnen.");
            string keuze = Console.ReadLine();
            if (keuze == "0")
                { 
                    Environment.Exit(0);
                }
            else if (keuze == "1")
                { 
                    Console.Clear();
                    redo = 1;
                }
            }
        }
    }
}
