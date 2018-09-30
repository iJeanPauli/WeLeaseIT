using System;
using System.Collections.Generic;
using System.Text;

namespace WeLeaseIT
{
    class Medewerker
    {
        private int _id;
        private string _naam;
        private string _adres;
        private int _telefoonNummer;
        private string _email;
        private string _geboorteDatum;
        private int _BSN;
        public List<Contract> ContractSet = new List<Contract>();

        public Medewerker(int id, string naam, string adres, int telefoonNummer, string email, string geboorteDatum, int BSN)
        {
            _id = id;
            _naam = naam;
            _adres = adres;
            _telefoonNummer = telefoonNummer;
            _email = email;
            _geboorteDatum = geboorteDatum;
            _BSN = BSN;
        }

        public void VoegContractToe(Contract contract)
            { 
                ContractSet.Add(contract);
            }

        public int GetId()
        {
            return _id;
        }

        public string GetNaam()
        {
            return _naam;
        }

        public string GetAdres()
        {
            return _adres;
        }

        public int GetTele()
        {
            return _telefoonNummer;
        }

        public string GetEmail()
        {
            return _email;
        }

        public string GetGeboorte()
        {
            return _geboorteDatum;
        }

        public int GetBSN()
        {
            return _BSN;
        }
    }
}
