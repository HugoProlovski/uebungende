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

        private void ShowList()
        {
            liwSchueler.Items.Clear();
            for (int i = 0; i < TSE2.anzahlSchueler; i++)
            {
                Schueler EinSchueler = TSE2.GetSchueler(i);
                
                ListViewItem lwItem = new ListViewItem(EinSchueler.Name);
                lwItem.SubItems.Add(EinSchueler.Vorname);
                lwItem.SubItems.Add(EinSchueler.Strasse + " " + EinSchueler.Hausnummer);
                lwItem.SubItems.Add(EinSchueler.PLZ);
                lwItem.SubItems.Add(EinSchueler.Ort);
                lwItem.SubItems.Add(EinSchueler.Telefon);
                lwItem.SubItems.Add(EinSchueler.GebDatum.ToShortDateString());

                liwSchueler.Items.Add(lwItem);

            }

        }

        private void bnSchuelerLoeschen_Click(object sender, EventArgs e)
        {
            if(liwSchueler.SelectedItems.Count == 1)
            {
                int iSelIndex = liwSchueler.SelectedIndices[0];
                TSE2.DeleteSchueler(iSelIndex);
                ShowList();

            }
        }

        private void bnDatenUebernehmen_Click(object sender, EventArgs e)
        {
            if (liwSchueler.SelectedItems.Count == 1)
            {
                int iSelIndex = liwSchueler.SelectedIndices[0];
                Schueler EinSchueler = TSE2.GetSchueler(iSelIndex);

                EinSchueler.Name = textBox1.Text;
                EinSchueler.Vorname = textBox2.Text;
                EinSchueler.Strasse = textBox3.Text;
                EinSchueler.Hausnummer = textBox7.Text;
                EinSchueler.PLZ = textBox4.Text;
                EinSchueler.Ort = textBox5.Text;
                EinSchueler.Telefon = textBox6.Text;
                EinSchueler.GebDatum = Convert.ToDateTime(textBox8.Text);

                ShowList();
            }

        }

        private void bnNeuerSchueler_Click(object sender, EventArgs e)
        {
            TSE2.AddSchueler(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text,Convert.ToDateTime(textBox8.Text));
            ShowList();
        }

        private void liwSchueler_Click(Object sender, EventArgs e)
        {
            if (liwSchueler.SelectedItems.Count == 1)
            {
                int iSelIndex = liwSchueler.SelectedIndices[0];
                Schueler EinSchueler = TSE2.GetSchueler(iSelIndex);

                textBox1.Text = EinSchueler.Name;
                textBox2.Text = EinSchueler.Vorname;
                textBox3.Text = EinSchueler.Strasse;
                textBox7.Text = EinSchueler.Hausnummer;
                textBox4.Text = EinSchueler.PLZ;
                textBox5.Text = EinSchueler.Ort;
                textBox6.Text = EinSchueler.Telefon;
                textBox8.Text = EinSchueler.GebDatum.ToShortDateString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void liwSchueler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
