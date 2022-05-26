using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci;
using Extensions;

namespace lab4_OOP
{
    public partial class FormKategorija : Form
    {
        public FormKategorija()
        {
            InitializeComponent();
        }

        public Kategorija kategorija
        {
            get;
            set;
        }

        public FormKategorija(Kategorija k)
            :this()
        {
            kategorija = k;
            btnProsledi.Text = "Dodaj";
        }

        bool Validacija()
        {
            if(String.IsNullOrEmpty(cmbKategorija.Text))
            {
                MessageBox.Show("Polje Ime ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        void UcitajPodatkeUKontrole()
        {
            cmbKategorija.Text = kategorija.Oznaka_kategorije;
            dtmDatumOd.Value = kategorija.Vazenje_kategorije_od;
            dtmDAtumDo.Value = kategorija.Vazenje_kategorije_do;

            btnProsledi.Text = "Dodaj";
        }

        bool Dodaj()
        {
            var k = new Kategorija
            {
                Oznaka_kategorije = cmbKategorija.Text,
                Vazenje_kategorije_od = dtmDatumOd.Value,
                Vazenje_kategorije_do = dtmDAtumDo.Value
            };

            return ListaKategorija.Instance_k.DodajKategorije(k);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;
            if(kategorija == null)
            {
                if(!Dodaj())
                {
                    MessageBox.Show("Greska u dodavanju",
                        "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbKategorija.Focus();
                    return;
                }
               
            }
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FormKategorija_Load(object sender, EventArgs e)
        {
            if (kategorija != null)
                UcitajPodatkeUKontrole();
        }
    }
}
