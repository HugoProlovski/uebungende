using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Schulklasse TSE2;

        public Form1()
        {
            InitializeComponent();
            TSE2 = new Schulklasse();
        }

        private void bnSchuelerLoeschen_Click(object sender, EventArgs e)
        {

        }

        private void bnDatenUebernehmen_Click(object sender, EventArgs e)
        {

        }

        private void bnNeuerSchueler_Click(object sender, EventArgs e)
        {
            string aName = textBox1.Text;
            string aVorname = textBox2.Text;
            string aStrasse = textBox3.Text;
            string aHNr = textBox7.Text;
            string aPLZ = textBox4.Text;
            string aOrt = textBox5.Text;
            string aTelefon = textBox6.Text;
            string aGebDatum = textBox7.Text;

        }

        private void liSchueler_SelectedIndexChanged(object sender, EventArgs e)
        {
            hallo warum geht das netz
        }
    }
}
