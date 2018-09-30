using System;
using System.Collections.Generic;
using System.Text;

namespace WeLeaseIT
{
    class Contract
    {
        private int _id;
        private int _leasePeriode;
        private string _afsluitDatum;
        private int _klantId;
        private int _aantalApparaten;
        private int _maandBedrag;
        public List<Apparaat> ApparaatSet = new List<Apparaat>();

        public Contract(int id, int leasePeriode, string afsluitDatum, int klantId, int aantalApparaten, int maandBedrag)
        {
            _id = id;
            _leasePeriode = leasePeriode;
            _afsluitDatum = afsluitDatum;
            _klantId = klantId;
            _aantalApparaten = aantalApparaten;
            _maandBedrag = maandBedrag;
        }

        public void VoegApparaatToe(Apparaat apparaat)
            { 
                ApparaatSet.Add(apparaat);
            }

        public int GetId()
        {
            return _id;
        }

        public int GetLeasePer()
        {
            return _leasePeriode;
        }

        public string GetAfsluitDatum()
        {
            return _afsluitDatum;
        }

        public int GetKlantId()
        {
            return _klantId;
        }

        public int GetAantalApp()
        {
            return _aantalApparaten;
        }

        public int GetMaandBedrag()
        {
            return _maandBedrag;
        }
    }
}
