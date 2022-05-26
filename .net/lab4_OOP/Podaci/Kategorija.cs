using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Kategorija : Object
    {
        String oznaka_kategorije;
        DateTime vazenje_kategorije_od;
        DateTime vazenje_kategorije_do;

        public Kategorija()
        {

        }

        public Kategorija( String oznaka_kategorije,  DateTime vazenje_kategorije_od, DateTime vazenje_kategorije_do)
        { 
            this.oznaka_kategorije = oznaka_kategorije;
            this.vazenje_kategorije_od = vazenje_kategorije_od;
            this.vazenje_kategorije_do = vazenje_kategorije_do;
            
        }

       

        public String Oznaka_kategorije
        {
            get
            {
                return this.oznaka_kategorije;
            }
            set
            {
                this.oznaka_kategorije = value;
            }
        }

       

        public DateTime Vazenje_kategorije_od
        {
            get
            {
                return this.vazenje_kategorije_od;
            }
            set
            {
                this.vazenje_kategorije_od = value;
            }
        }

        public DateTime Vazenje_kategorije_do
        {
            get
            {
                return this.vazenje_kategorije_do;
            }
            set
            {
                this.vazenje_kategorije_do = value;
            }
        }

        public String zaPrikaz
        {
            get
            {
                return oznaka_kategorije;
            }
        }

        



    }
}
