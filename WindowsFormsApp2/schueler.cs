using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class schueler
    {
        private string sName;
        private string sVorname;
        private string sStrasse;
        private string sHNr;
        private string sPLZ;
        private string sOrt;
        private string sTelefon;
        private DateTime dtGebDatum;

        public schueler(string aName, string aVorname, string aStrasse, string aHNr, string aPLZ, string aOrt, string aTelefon, DateTime aGebDatum)
           {
            this.sName = aName;
            this.sVorname = aVorname;
            this.sStrasse = aStrasse;
            this.sHNr = aHNr;
            this.sPLZ = aPLZ;
            this.sOrt = aOrt;
            this.sTelefon = aTelefon;
            this.dtGebDatum = aGebDatum;
           }

        public string Name
        {
            get { return sName; }
            set { sName = value; }
        }

        public string Vorname
        {
            get { return sVorname; }
            set { sVorname = value; }
        }

        public string Strasse
        {
            get { return sStrasse; }
            set { sStrasse = value; }
        }

        public string Hausnummer
        {
            get { return sHNr; }
            set { sHNr = value; }
        }

        public string PLZ
        {
            get { return sPLZ; }
            set { sPLZ = value; }
        }
        
        public string Ort
        {
            get { return sOrt; }
            set { sOrt = value; }
        }

        public string Telefon
        {
            get { return sTelefon; }
            set { sTelefon = value; }

        }

        public DateTime GebDatum
        {
            get { return dtGebDatum; }
            set { dtGebDatum = value; }

        }

    }


}
