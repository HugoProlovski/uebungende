using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Schulklasse
    {
        private List<Schueler> liSchueler;
        public int anzahlSchueler
        {
            get { return liSchueler.Count; }
        }

        public Schulklasse()
        {
            liSchueler = new List<Schueler>(); 
        }

        public void AddSchueler(string aName, string aVorname, string aStrasse, string aHNr, string aPLZ, string aOrt, string aTelNr, DateTime aGebDatum)
        {
            Schueler aSchueler = new Schueler(aName, aVorname, aStrasse, aHNr, aPLZ, aOrt, aTelNr, aGebDatum);
            liSchueler.Add(aSchueler);
        }

        public void DeleteSchueler(Schueler aSchueler)
        {
            liSchueler.Remove(aSchueler);
        }

        public void DeleteSchueler(int iIndex)
        {
            liSchueler.RemoveAt(iIndex);
        }

        public Schueler GetSchueler(int iIndex)
        {
            return liSchueler[iIndex];
        }
    }
}
