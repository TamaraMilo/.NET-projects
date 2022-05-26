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
    public partial class FormZabrana : Form
    {
        public FormZabrana()
        {
            InitializeComponent();
        }

        public ZabranaUpravljanja zabrana
        {
            get;
            set;
        }

        public FormZabrana(ZabranaUpravljanja z)
            :this()
        {
            zabrana = z;
            btnProsledi.Text = "Dodaj";

        }

        bool Validacija()
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Polje Ime ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
        }

    }
}
