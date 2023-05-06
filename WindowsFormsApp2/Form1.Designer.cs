
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.liwSchueler = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Strasse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PLZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Geburtstag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bnSchuelerLoeschen = new System.Windows.Forms.Button();
            this.bnDatenUebernehmen = new System.Windows.Forms.Button();
            this.bnNeuerSchueler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liwSchueler
            // 
            this.liwSchueler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Vorname,
            this.Strasse,
            this.PLZ,
            this.Ort,
            this.Tel,
            this.Geburtstag});
            this.liwSchueler.FullRowSelect = true;
            this.liwSchueler.GridLines = true;
            this.liwSchueler.HideSelection = false;
            this.liwSchueler.Location = new System.Drawing.Point(281, 205);
            this.liwSchueler.MultiSelect = false;
            this.liwSchueler.Name = "liwSchueler";
            this.liwSchueler.Size = new System.Drawing.Size(424, 233);
            this.liwSchueler.TabIndex = 0;
            this.liwSchueler.UseCompatibleStateImageBehavior = false;
            this.liwSchueler.View = System.Windows.Forms.View.Details;
            this.liwSchueler.SelectedIndexChanged += new System.EventHandler(this.liwSchueler_Click);
            // 
            // Name
            // 
            this.Name.DisplayIndex = 1;
            this.Name.Text = "Name";
            // 
            // Vorname
            // 
            this.Vorname.DisplayIndex = 0;
            this.Vorname.Text = "Vorname";
            // 
            // Strasse
            // 
            this.Strasse.Text = "Strasse";
            // 
            // PLZ
            // 
            this.PLZ.Text = "PLZ";
            // 
            // Ort
            // 
            this.Ort.Text = "Ort";
            // 
            // Tel
            // 
            this.Tel.Text = "Tel";
            // 
            // Geburtstag
            // 
            this.Geburtstag.Text = "Geburtstag";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(91, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(91, 186);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(91, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(197, 134);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(96, 241);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(42, 20);
            this.textBox8.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vorname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Strasse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "PLZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "TelefonNr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Geb. Datum";
            // 
            // bnSchuelerLoeschen
            // 
            this.bnSchuelerLoeschen.Location = new System.Drawing.Point(384, 118);
            this.bnSchuelerLoeschen.Name = "bnSchuelerLoeschen";
            this.bnSchuelerLoeschen.Size = new System.Drawing.Size(130, 23);
            this.bnSchuelerLoeschen.TabIndex = 16;
            this.bnSchuelerLoeschen.Text = "Schüler löschen";
            this.bnSchuelerLoeschen.UseVisualStyleBackColor = true;
            this.bnSchuelerLoeschen.Click += new System.EventHandler(this.bnSchuelerLoeschen_Click);
            // 
            // bnDatenUebernehmen
            // 
            this.bnDatenUebernehmen.Location = new System.Drawing.Point(384, 147);
            this.bnDatenUebernehmen.Name = "bnDatenUebernehmen";
            this.bnDatenUebernehmen.Size = new System.Drawing.Size(130, 23);
            this.bnDatenUebernehmen.TabIndex = 17;
            this.bnDatenUebernehmen.Text = "Daten übernehmen";
            this.bnDatenUebernehmen.UseVisualStyleBackColor = true;
            this.bnDatenUebernehmen.Click += new System.EventHandler(this.bnDatenUebernehmen_Click);
            // 
            // bnNeuerSchueler
            // 
            this.bnNeuerSchueler.Location = new System.Drawing.Point(384, 176);
            this.bnNeuerSchueler.Name = "bnNeuerSchueler";
            this.bnNeuerSchueler.Size = new System.Drawing.Size(130, 23);
            this.bnNeuerSchueler.TabIndex = 18;
            this.bnNeuerSchueler.Text = "Neuen Schüler anlegen";
            this.bnNeuerSchueler.UseVisualStyleBackColor = true;
            this.bnNeuerSchueler.Click += new System.EventHandler(this.bnNeuerSchueler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnNeuerSchueler);
            this.Controls.Add(this.bnDatenUebernehmen);
            this.Controls.Add(this.bnSchuelerLoeschen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.liwSchueler);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView liwSchueler;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Vorname;
        private System.Windows.Forms.ColumnHeader Strasse;
        private System.Windows.Forms.ColumnHeader PLZ;
        private System.Windows.Forms.ColumnHeader Ort;
        private System.Windows.Forms.ColumnHeader Tel;
        private System.Windows.Forms.ColumnHeader Geburtstag;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bnSchuelerLoeschen;
        private System.Windows.Forms.Button bnDatenUebernehmen;
        private System.Windows.Forms.Button bnNeuerSchueler;
    }
}

