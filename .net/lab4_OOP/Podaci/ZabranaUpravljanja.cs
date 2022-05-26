using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ZabranaUpravljanja : Object
    {
        String oznaka_kategorije;
        DateTime vazenje_zabrane_od;
        DateTime vazenje_zabrane_do;

        public ZabranaUpravljanja()
        {

        }

        public ZabranaUpravljanja(String oznaka_kategorije, DateTime vazenje_zabrane_od, DateTime vazenje_zabrane_do)
        {
            this.oznaka_kategorije = oznaka_kategorije;
            this.vazenje_zabrane_od = vazenje_zabrane_od;
            this.vazenje_zabrane_do = vazenje_zabrane_do;

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



        public DateTime Vazenje_zabrane_od
        {
            get
            {
                return this.vazenje_zabrane_od;
            }
            set
            {
                this.vazenje_zabrane_od = value;
            }
        }

        public DateTime Vazenje_zabrane_do
        {
            get
            {
                return this.vazenje_zabrane_do;
            }
            set
            {
                this.vazenje_zabrane_do = value;
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
