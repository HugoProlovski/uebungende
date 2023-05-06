using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Schulklasse
    {
        private List<schueler> liSchueler;
        public int anzahlSchueler
        {
            get { return liSchueler.Count; }
        }

        public Schulklasse()
        {
            liSchueler = new List<schueler>(); 
        }

        public void AddSchueler(string aName, string aVorname, string aStrasse, string aHNr, string aPLZ, string aOrt, string aTelNr, DateTime aGebDatum)
        {
            schueler aSchueler = new schueler(aName, aVorname, aStrasse, aHNr, aPLZ, aOrt, aTelNr, aGebDatum);
            liSchueler.Add(aSchueler);
        }

        public void DeleteSchueler(schueler aSchueler)
        {
            liSchueler.Remove(aSchueler);
        }

        public void DeleteSchueler(int iIndex)
        {
            liSchueler.RemoveAt(iIndex);
        }

        public schueler GetSchueler(int iIndex)
        {
            return liSchueler[iIndex];
        }
    }
}
