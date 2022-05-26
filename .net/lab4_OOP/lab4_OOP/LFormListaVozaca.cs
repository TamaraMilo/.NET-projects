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
    public partial class LFormListaVozaca : Form
    {
        public LFormListaVozaca()
        {
            InitializeComponent();
        }

        DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("DA LI STE SIGURNI DA ZELITE DA IZVRSITE IZABRANU AKCIJU?",
                "Obavestenje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        void UcitajPodatke()
        {
            dgvListaVozaca.DataSource = ListaVozaca.Instance.ListaVozacaValues.ToList();
            dgvListaVozaca.Columns["zaPrikaz"].Visible = false;

            if(dgvListaVozaca.RowCount > 0)
            {
                btnObrisiVozaca.Visible = true;
                btnIzmeniVozaca.Visible = true;
            }
            else
            {
                btnObrisiVozaca.Visible = false;
                btnIzmeniVozaca.Visible = false;
            }

            if(dgvListaVozaca.RowCount > 1)
            {
                btnSortiraj.Visible = true;
                cmbPodaci.Visible = true;
            }
            else
            {
                btnSortiraj.Visible = false;
                cmbPodaci.Visible = false;
            }
        }

        private void LFormListaVozaca_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ZatvoriFormu() == DialogResult.No)
          
                e.Cancel = true;
        }

        private void LFormListaVozaca_Load(object sender, EventArgs e)
        {
            lblTrenutnoVreme.Text = String.Empty;
            tmrTacnoVreme.Start();
            UcitajPodatke();
        }

        private void tmrTacnoVreme_Tick(object sender, EventArgs e)
        {
            String str = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy.");
            lblTrenutnoVreme.Text = str;
        }

        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otvaramo formu za dodavanje novog vozaca",
                                                "Obavestenje",
                                                MessageBoxButtons.OK);

            var v = new FormVozac();
            DialogResult dlg = v.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajPodatke();
        }

        private void btnIzmeniVozaca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otvaramo formu za izmenu podataka",
                                                "Obavestenje",
                                                MessageBoxButtons.OK);
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;
            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            String brojVozacke = (String)dgvListaVozaca["Broj_vozacke", selectedRow].Value;
            var o = ListaVozaca.Instance.GetVozac(brojVozacke);

            var form = new FormVozac();
            form.vozac = o;

            DialogResult dlg = form.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                UcitajPodatke();
        }

        private void btnObrisiVozaca_Click(object sender, EventArgs e)
        {
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obriste", 
                "Obavestenje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;
            int SelectedRow = dgvListaVozaca.SelectedRows[0].Index;
            String brojVozacke = (String)dgvListaVozaca["Broj_vozacke", SelectedRow].Value;

            var v = ListaVozaca.Instance.GetVozac(brojVozacke);
            if(ListaVozaca.Instance.ObrisiVozaca(v))
            {
                MessageBox.Show("Izabrana akcija je uspesno obavljena.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Greska pri brisanju. Pokusajte ponovo.",
                                               "Obavestenje",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
            }
            UcitajPodatke();
        }
    }
}
