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
    public partial class FormVozac : Form
    {
        public FormVozac()
        {
            InitializeComponent();
        }

        public Vozac vozac
        {
            get;
            set;
        }

        public FormVozac(Vozac v)
            :this()
        {
            vozac = v;
            btnProsledi.Text = "Izmeni";
        }

        bool Validacija()
        {
            if(String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Polje ime ne sme biti prazno",
                    "Obavestenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
                
            }

            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Polje ime ne sme biti prazno",
                    "Obavestenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;

            }

            if (txtBr_vozacke_dozvole.Text.Length < 9)
            {
                MessageBox.Show("Polje broj vozacke dozvole mora sadrzati 9 cifara",
                    "Obavestenje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;

            }

            return true;
        }

        void UcitajPOdatkeUKontrole()
        {
            txtIme.Text = vozac.Ime;
            txtPrezime.Text = vozac.Prezime;
            dtpDatumRodjenja.Value = vozac.Datum_rodjenja;
            dtpVazenjeOd.Value = vozac.Vazenje_od;
            dtpVazenjeDo.Value = vozac.Vazenje_do;
            txtBr_vozacke_dozvole.Text = vozac.Broj_vozacke;
            txtMestoIzdavanja.Text = vozac.Mesto_Izdavanja;
            cbxPol.Text = vozac.Pol;

            btnProsledi.Text = "Izmeni";
        }

        bool Izmeni ()
        {
            var v = new Vozac();
            {
                v.Ime = txtIme.Text;
                v.Prezime = txtPrezime.Text;
                v.Datum_rodjenja = dtpDatumRodjenja.Value;
                v.Vazenje_od = dtpVazenjeOd.Value;
                v.Vazenje_do = dtpVazenjeDo.Value;
                v.Broj_vozacke = txtBr_vozacke_dozvole.Text;
                v.Mesto_Izdavanja = txtMestoIzdavanja.Text;
                v.Pol = cbxPol.Text;
            };

            return ListaVozaca.Instance.IzmeniVozaca(v);

        }

        bool Dodaj()
        {
            var v = new Vozac();
            {
                v.Ime = txtIme.Text;
                v.Prezime = txtPrezime.Text;
                v.Datum_rodjenja = dtpDatumRodjenja.Value;
                v.Vazenje_od = dtpVazenjeOd.Value;
                v.Vazenje_do = dtpVazenjeDo.Value;
                v.Broj_vozacke = txtBr_vozacke_dozvole.Text;
                v.Mesto_Izdavanja = txtMestoIzdavanja.Text;
                v.Pol = cbxPol.Text;
            };

            return ListaVozaca.Instance.DodajVozaca(v);

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FormVozac_Load(object sender, EventArgs e)
        {
            btnObrisisKategoriju.Visible = false;
            btnObrisiZAbranu.Visible = false;
            if (vozac != null)
                UcitajPOdatkeUKontrole();
            UcitavanjeKategorija();
            UcitajZabranu();
        }

        private void txtIme_Leave(object sender, EventArgs e)
        {
            txtIme.Text = txtIme.Text.PostaviPrvoVelikoSlovo();
        }

        private void txtPrezime_Leave(object sender, EventArgs e)
        {
            txtPrezime.Text = txtPrezime.Text.PostaviPrvoVelikoSlovo();
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;

            if(vozac == null)
            {
                if(!Dodaj())
                {
                    MessageBox.Show("Greska u dodavanju , pokusajte ponovo",
                        "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIme.Focus();
                    return;

                }
            }
            else
            {
                if(!Izmeni())
                {
                    MessageBox.Show("Greska u izmnei, pokusajte ponovo",
                        "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIme.Focus();
                    return;
                }
            }
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        void UcitavanjeKategorija()
        {
            dgvKategorija.DataSource = ListaKategorija.Instance_k.ListaKategorijaValues.ToList();
            dgvKategorija.Columns["zaPrikaz"].Visible = false;

            if(dgvKategorija.RowCount > 0)
            {
                btnDodajKategoriju.Visible = true;
                btnObrisisKategoriju.Visible = true;

            }
            else
            {
                btnDodajKategoriju.Visible = true;
                btnObrisisKategoriju.Visible = false;
            }
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otvaramo formu za dodavanje kategorije",
                                                "Obavestenje",
                                                MessageBoxButtons.OK);
            var form = new FormKategorija();
            DialogResult dlg = form.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitavanjeKategorija();
        }

        private void btnObrisisKategoriju_Click(object sender, EventArgs e)
        {
            if (dgvKategorija.SelectedRows.Count == 0)
                return;
            DialogResult dlg = MessageBox.Show("Da li ste sigurno da zelite da obrisete izabranu stavku? ",
                "Obavestenje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int selectedRow = dgvKategorija.SelectedRows[0].Index;
            String oznaka = (String)dgvKategorija["Oznaka_kategorije", selectedRow].Value;

            var k = ListaKategorija.Instance_k.GetKategorija(oznaka);
            if(ListaKategorija.Instance_k.ObrisiKategorije(k))
            {
                MessageBox.Show("Izabrana akcija je uspesno obavljena.",
                               "Obavestenje",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Izabrana akcija nije uspesno obavljena. Pokusajte ponovo.",
                               "Obavestenje",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            UcitavanjeKategorija();


        }

        void UcitajZabranu()
        {
            dgvZabranaUpravljanja.DataSource = ListaZabrana.Instance_z.ListaZabranaUpravljanjaValues.ToList();
            dgvZabranaUpravljanja.Columns["zaPrikaz"].Visible = false;

            if(dgvZabranaUpravljanja.RowCount > 0)
            {
                btnDodajNovuZabranu.Visible = true;
                btnObrisiZAbranu.Visible = true;
            }
            else
            {
                btnDodajNovuZabranu.Visible = true;
                btnObrisiZAbranu.Visible = false;
            }
        }

        private void btnDodajNovuZabranu_Click(object sender, EventArgs e)
        {
            var frm = new FormZabrana();
            DialogResult dlg = frm.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajZabranu();
        }


    }
}
