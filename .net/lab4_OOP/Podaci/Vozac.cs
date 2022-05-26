using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Vozac : Object
    {
        String ime;
        String prezime;
        DateTime datum_rodjenja;
        DateTime vazenje_od;
        DateTime vazenje_do;
        String broj_vozacke;
        String mesto_izdavanja;
        String pol;

        public Vozac()
        {

        }

        public Vozac(String ime, String prezime, DateTime datum_rodjenja, DateTime vazenje_od, DateTime vazenje_do, 
            String broj_vozacke, String mesto_izdavanja, String pol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datum_rodjenja = datum_rodjenja;
            this.vazenje_od = vazenje_od;
            this.vazenje_do = vazenje_do;
            this.broj_vozacke = broj_vozacke;
            this.mesto_izdavanja = mesto_izdavanja;
            this.pol = pol;
        }

        public String Ime
        {
            get
            {
                return this.ime;
            }
            set
            {
                this.ime = value;
            }
        }

        public String Prezime
        {
            get
            {
                return this.prezime;
            }
            set
            {
                this.prezime = value;
            }
        }

        [Browsable(false)]
        public DateTime Datum_rodjenja
        {
            get
            {
                return this.datum_rodjenja;
            }
            set
            {
                this.datum_rodjenja = value;
            }
        }

        [Browsable(false)]
        public DateTime Vazenje_od
        {
            get
            {
                return this.vazenje_od;
            }
            set
            {
                this.vazenje_od = value;
            }
        }

        [Browsable(false)]
        public DateTime Vazenje_do
        {
            get
            {
                return this.vazenje_do;
            }
            set
            {
                this.vazenje_do = value;
            }
        }

        public String Broj_vozacke
        {
            get
            {
                return this.broj_vozacke;
            }

            set
            {
                this.broj_vozacke = value;
            }
        }

        [Browsable(false)]
        public String Mesto_Izdavanja
        {
            get
            {
                return this.mesto_izdavanja;
            }
            set
            {
                this.mesto_izdavanja = value;
            }
        }

        [Browsable(false)]
        public String Pol
        {
            get
            {
                return this.pol;
            }
            set
            {
                this.pol = value;
            }
        }

        public String zaPrikaz
        {
            get
            {
                return ime + " " + prezime + " " + broj_vozacke;
            }
        }

    


    }
}
