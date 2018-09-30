using System;
using System.Collections.Generic;
using System.Text;

namespace WeLeaseIT
{
    class Apparaat
    {
        private int _id;
        private int _waarde;
        private int _leasePrijs;
        private string _merkNaam;
        private string _modelNummer;
        private string _serieNummer;
        private string _levensDuur;
        private int _huurPeriode;
        private string _aanschafDatum;

        public Apparaat(int id, int waarde, int leasePrijs, string merkNaam, string modelNummer, string serieNummer, string levensDuur, int huurPeriode, string aanschafDatum)
        {
            _id = id;
            _waarde = waarde;
            _leasePrijs = leasePrijs;
            _merkNaam = merkNaam;
            _modelNummer = modelNummer;
            _serieNummer = serieNummer;
            _levensDuur = levensDuur;
            _huurPeriode = huurPeriode;
            _aanschafDatum = aanschafDatum;
        }

        public int GetId()
        {
            return _id;
        }

        public int GetWaarde()
        {
            return _waarde;
        }

        public int GetLeasePrijs()
        {
            return _leasePrijs;
        }

        public string GetMerkNaam()
        {
            return _merkNaam;
        }

        public string GetModelNummer()
        {
            return _modelNummer;
        }

        public string GetSerieNummer()
        {
            return _serieNummer;
        }

        public string GetLevensDuur()
        {
            return _levensDuur;
        }

        public int GetHuurPeriode()
        {
            return _huurPeriode;
        }

        public string GetAanschafDatum()
        {
            return _aanschafDatum;
        }
    }
}
