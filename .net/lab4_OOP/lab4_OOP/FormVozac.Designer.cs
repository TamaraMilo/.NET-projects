
namespace lab4_OOP
{
    partial class FormVozac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxOsnovniPodaci = new System.Windows.Forms.GroupBox();
            this.cbxPol = new System.Windows.Forms.ComboBox();
            this.dtpVazenjeDo = new System.Windows.Forms.DateTimePicker();
            this.dtpVazenjeOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.txtMestoIzdavanja = new System.Windows.Forms.TextBox();
            this.txtBr_vozacke_dozvole = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblMestoIzdavanja = new System.Windows.Forms.Label();
            this.lblBrojVozacke = new System.Windows.Forms.Label();
            this.lbldo = new System.Windows.Forms.Label();
            this.lblVazenje = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.gbxKategorija = new System.Windows.Forms.GroupBox();
            this.dgvKategorija = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbxZabranaUpravljanja = new System.Windows.Forms.GroupBox();
            this.dgvZabranaUpravljanja = new System.Windows.Forms.DataGridView();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnDodajNovuZabranu = new System.Windows.Forms.Button();
            this.btnObrisiZAbranu = new System.Windows.Forms.Button();
            this.btnObrisisKategoriju = new System.Windows.Forms.Button();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.pbxSlika = new System.Windows.Forms.PictureBox();
            this.gbxOsnovniPodaci.SuspendLayout();
            this.gbxKategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).BeginInit();
            this.gbxZabranaUpravljanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabranaUpravljanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxOsnovniPodaci
            // 
            this.gbxOsnovniPodaci.Controls.Add(this.pbxSlika);
            this.gbxOsnovniPodaci.Controls.Add(this.cbxPol);
            this.gbxOsnovniPodaci.Controls.Add(this.dtpVazenjeDo);
            this.gbxOsnovniPodaci.Controls.Add(this.dtpVazenjeOd);
            this.gbxOsnovniPodaci.Controls.Add(this.dtpDatumRodjenja);
            this.gbxOsnovniPodaci.Controls.Add(this.btnDodajSliku);
            this.gbxOsnovniPodaci.Controls.Add(this.txtMestoIzdavanja);
            this.gbxOsnovniPodaci.Controls.Add(this.txtBr_vozacke_dozvole);
            this.gbxOsnovniPodaci.Controls.Add(this.txtPrezime);
            this.gbxOsnovniPodaci.Controls.Add(this.txtIme);
            this.gbxOsnovniPodaci.Controls.Add(this.lblPol);
            this.gbxOsnovniPodaci.Controls.Add(this.lblMestoIzdavanja);
            this.gbxOsnovniPodaci.Controls.Add(this.lblBrojVozacke);
            this.gbxOsnovniPodaci.Controls.Add(this.lbldo);
            this.gbxOsnovniPodaci.Controls.Add(this.lblVazenje);
            this.gbxOsnovniPodaci.Controls.Add(this.lblDatumRodjenja);
            this.gbxOsnovniPodaci.Controls.Add(this.lblPrezime);
            this.gbxOsnovniPodaci.Controls.Add(this.lblIme);
            this.gbxOsnovniPodaci.Location = new System.Drawing.Point(0, 0);
            this.gbxOsnovniPodaci.Name = "gbxOsnovniPodaci";
            this.gbxOsnovniPodaci.Size = new System.Drawing.Size(1185, 434);
            this.gbxOsnovniPodaci.TabIndex = 0;
            this.gbxOsnovniPodaci.TabStop = false;
            this.gbxOsnovniPodaci.Text = "Osnovni podaci";
            // 
            // cbxPol
            // 
            this.cbxPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPol.FormattingEnabled = true;
            this.cbxPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cbxPol.Location = new System.Drawing.Point(338, 390);
            this.cbxPol.Name = "cbxPol";
            this.cbxPol.Size = new System.Drawing.Size(474, 39);
            this.cbxPol.TabIndex = 17;
            // 
            // dtpVazenjeDo
            // 
            this.dtpVazenjeDo.CustomFormat = "dd.MM.yyyy.";
            this.dtpVazenjeDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVazenjeDo.Location = new System.Drawing.Point(338, 230);
            this.dtpVazenjeDo.Name = "dtpVazenjeDo";
            this.dtpVazenjeDo.Size = new System.Drawing.Size(474, 38);
            this.dtpVazenjeDo.TabIndex = 16;
            // 
            // dtpVazenjeOd
            // 
            this.dtpVazenjeOd.CustomFormat = "dd.MM.yyyy.";
            this.dtpVazenjeOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVazenjeOd.Location = new System.Drawing.Point(338, 186);
            this.dtpVazenjeOd.Name = "dtpVazenjeOd";
            this.dtpVazenjeOd.Size = new System.Drawing.Size(474, 38);
            this.dtpVazenjeOd.TabIndex = 15;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(338, 142);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(474, 38);
            this.dtpDatumRodjenja.TabIndex = 14;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(848, 301);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(264, 82);
            this.btnDodajSliku.TabIndex = 13;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            // 
            // txtMestoIzdavanja
            // 
            this.txtMestoIzdavanja.Location = new System.Drawing.Point(338, 346);
            this.txtMestoIzdavanja.Name = "txtMestoIzdavanja";
            this.txtMestoIzdavanja.Size = new System.Drawing.Size(474, 38);
            this.txtMestoIzdavanja.TabIndex = 12;
            // 
            // txtBr_vozacke_dozvole
            // 
            this.txtBr_vozacke_dozvole.Location = new System.Drawing.Point(338, 295);
            this.txtBr_vozacke_dozvole.Name = "txtBr_vozacke_dozvole";
            this.txtBr_vozacke_dozvole.Size = new System.Drawing.Size(474, 38);
            this.txtBr_vozacke_dozvole.TabIndex = 11;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(338, 97);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(474, 38);
            this.txtPrezime.TabIndex = 10;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            this.txtPrezime.Leave += new System.EventHandler(this.txtPrezime_Leave);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(338, 48);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(474, 38);
            this.txtIme.TabIndex = 8;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(38, 396);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(65, 32);
            this.lblPol.TabIndex = 7;
            this.lblPol.Text = "Pol:";
            // 
            // lblMestoIzdavanja
            // 
            this.lblMestoIzdavanja.AutoSize = true;
            this.lblMestoIzdavanja.Location = new System.Drawing.Point(38, 352);
            this.lblMestoIzdavanja.Name = "lblMestoIzdavanja";
            this.lblMestoIzdavanja.Size = new System.Drawing.Size(229, 32);
            this.lblMestoIzdavanja.TabIndex = 6;
            this.lblMestoIzdavanja.Text = "Mesto izdavanja:";
            // 
            // lblBrojVozacke
            // 
            this.lblBrojVozacke.AutoSize = true;
            this.lblBrojVozacke.Location = new System.Drawing.Point(38, 301);
            this.lblBrojVozacke.Name = "lblBrojVozacke";
            this.lblBrojVozacke.Size = new System.Drawing.Size(276, 32);
            this.lblBrojVozacke.TabIndex = 5;
            this.lblBrojVozacke.Text = "Br. vozacke dozvole:";
            // 
            // lbldo
            // 
            this.lbldo.AutoSize = true;
            this.lbldo.Location = new System.Drawing.Point(38, 249);
            this.lbldo.Name = "lbldo";
            this.lbldo.Size = new System.Drawing.Size(47, 32);
            this.lbldo.TabIndex = 4;
            this.lbldo.Text = "do";
            // 
            // lblVazenje
            // 
            this.lblVazenje.AutoSize = true;
            this.lblVazenje.Location = new System.Drawing.Point(38, 202);
            this.lblVazenje.Name = "lblVazenje";
            this.lblVazenje.Size = new System.Drawing.Size(264, 32);
            this.lblVazenje.TabIndex = 3;
            this.lblVazenje.Text = "Vazenje dozvole od";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(38, 151);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(216, 32);
            this.lblDatumRodjenja.TabIndex = 2;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(38, 100);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(127, 32);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(38, 54);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(69, 32);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // gbxKategorija
            // 
            this.gbxKategorija.Controls.Add(this.btnObrisisKategoriju);
            this.gbxKategorija.Controls.Add(this.btnDodajKategoriju);
            this.gbxKategorija.Controls.Add(this.dgvKategorija);
            this.gbxKategorija.Controls.Add(this.groupBox3);
            this.gbxKategorija.Location = new System.Drawing.Point(0, 451);
            this.gbxKategorija.Name = "gbxKategorija";
            this.gbxKategorija.Size = new System.Drawing.Size(1185, 357);
            this.gbxKategorija.TabIndex = 0;
            this.gbxKategorija.TabStop = false;
            this.gbxKategorija.Text = "Kategorija";
            // 
            // dgvKategorija
            // 
            this.dgvKategorija.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorija.GridColor = System.Drawing.SystemColors.Window;
            this.dgvKategorija.Location = new System.Drawing.Point(12, 37);
            this.dgvKategorija.Name = "dgvKategorija";
            this.dgvKategorija.RowHeadersWidth = 102;
            this.dgvKategorija.RowTemplate.Height = 40;
            this.dgvKategorija.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvKategorija.Size = new System.Drawing.Size(1173, 183);
            this.dgvKategorija.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 463);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1219, 384);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // gbxZabranaUpravljanja
            // 
            this.gbxZabranaUpravljanja.Controls.Add(this.btnDodajNovuZabranu);
            this.gbxZabranaUpravljanja.Controls.Add(this.btnObrisiZAbranu);
            this.gbxZabranaUpravljanja.Controls.Add(this.dgvZabranaUpravljanja);
            this.gbxZabranaUpravljanja.Location = new System.Drawing.Point(12, 814);
            this.gbxZabranaUpravljanja.Name = "gbxZabranaUpravljanja";
            this.gbxZabranaUpravljanja.Size = new System.Drawing.Size(1173, 389);
            this.gbxZabranaUpravljanja.TabIndex = 1;
            this.gbxZabranaUpravljanja.TabStop = false;
            this.gbxZabranaUpravljanja.Text = "Zabrana upravljanja";
            // 
            // dgvZabranaUpravljanja
            // 
            this.dgvZabranaUpravljanja.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvZabranaUpravljanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZabranaUpravljanja.Location = new System.Drawing.Point(7, 38);
            this.dgvZabranaUpravljanja.Name = "dgvZabranaUpravljanja";
            this.dgvZabranaUpravljanja.RowHeadersWidth = 102;
            this.dgvZabranaUpravljanja.RowTemplate.Height = 40;
            this.dgvZabranaUpravljanja.Size = new System.Drawing.Size(1152, 238);
            this.dgvZabranaUpravljanja.TabIndex = 0;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(125, 1209);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(189, 51);
            this.btnProsledi.TabIndex = 2;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(848, 1209);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(189, 51);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnDodajNovuZabranu
            // 
            this.btnDodajNovuZabranu.Image = global::lab4_OOP.Properties.Resources.add;
            this.btnDodajNovuZabranu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajNovuZabranu.Location = new System.Drawing.Point(7, 300);
            this.btnDodajNovuZabranu.Name = "btnDodajNovuZabranu";
            this.btnDodajNovuZabranu.Size = new System.Drawing.Size(235, 72);
            this.btnDodajNovuZabranu.TabIndex = 2;
            this.btnDodajNovuZabranu.Text = "Dodaj novu zabranu";
            this.btnDodajNovuZabranu.UseVisualStyleBackColor = true;
            this.btnDodajNovuZabranu.Click += new System.EventHandler(this.btnDodajNovuZabranu_Click);
            // 
            // btnObrisiZAbranu
            // 
            this.btnObrisiZAbranu.Image = global::lab4_OOP.Properties.Resources.delete;
            this.btnObrisiZAbranu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiZAbranu.Location = new System.Drawing.Point(836, 291);
            this.btnObrisiZAbranu.Name = "btnObrisiZAbranu";
            this.btnObrisiZAbranu.Size = new System.Drawing.Size(323, 81);
            this.btnObrisiZAbranu.TabIndex = 1;
            this.btnObrisiZAbranu.Text = "Obrisi zabranu";
            this.btnObrisiZAbranu.UseVisualStyleBackColor = true;
            // 
            // btnObrisisKategoriju
            // 
            this.btnObrisisKategoriju.Image = global::lab4_OOP.Properties.Resources.delete;
            this.btnObrisisKategoriju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisisKategoriju.Location = new System.Drawing.Point(848, 258);
            this.btnObrisisKategoriju.Name = "btnObrisisKategoriju";
            this.btnObrisisKategoriju.Size = new System.Drawing.Size(337, 76);
            this.btnObrisisKategoriju.TabIndex = 5;
            this.btnObrisisKategoriju.Text = "Obrisi kategoriju";
            this.btnObrisisKategoriju.UseVisualStyleBackColor = true;
            this.btnObrisisKategoriju.Click += new System.EventHandler(this.btnObrisisKategoriju_Click);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Image = global::lab4_OOP.Properties.Resources.add;
            this.btnDodajKategoriju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(12, 258);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(290, 76);
            this.btnDodajKategoriju.TabIndex = 4;
            this.btnDodajKategoriju.Text = "Dodaj novu kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // pbxSlika
            // 
            this.pbxSlika.Location = new System.Drawing.Point(848, 48);
            this.pbxSlika.Name = "pbxSlika";
            this.pbxSlika.Size = new System.Drawing.Size(264, 220);
            this.pbxSlika.TabIndex = 18;
            this.pbxSlika.TabStop = false;
            // 
            // FormVozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 1272);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.gbxZabranaUpravljanja);
            this.Controls.Add(this.gbxKategorija);
            this.Controls.Add(this.gbxOsnovniPodaci);
            this.Name = "FormVozac";
            this.Text = "Vozac";
            this.Load += new System.EventHandler(this.FormVozac_Load);
            this.gbxOsnovniPodaci.ResumeLayout(false);
            this.gbxOsnovniPodaci.PerformLayout();
            this.gbxKategorija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).EndInit();
            this.gbxZabranaUpravljanja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabranaUpravljanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOsnovniPodaci;
        private System.Windows.Forms.GroupBox gbxKategorija;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblMestoIzdavanja;
        private System.Windows.Forms.Label lblBrojVozacke;
        private System.Windows.Forms.Label lbldo;
        private System.Windows.Forms.Label lblVazenje;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtMestoIzdavanja;
        private System.Windows.Forms.TextBox txtBr_vozacke_dozvole;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.DataGridView dgvKategorija;
        private System.Windows.Forms.Button btnObrisisKategoriju;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.GroupBox gbxZabranaUpravljanja;
        private System.Windows.Forms.Button btnDodajNovuZabranu;
        private System.Windows.Forms.Button btnObrisiZAbranu;
        private System.Windows.Forms.DataGridView dgvZabranaUpravljanja;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.ComboBox cbxPol;
        private System.Windows.Forms.DateTimePicker dtpVazenjeDo;
        private System.Windows.Forms.DateTimePicker dtpVazenjeOd;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.PictureBox pbxSlika;
    }
}