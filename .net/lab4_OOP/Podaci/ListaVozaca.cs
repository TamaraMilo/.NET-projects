using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ListaVozaca
    {
        public delegate void SortDelegate(List<Vozac> v);

        public SortDelegate SortListDelegate { get; set; }

        private List<Vozac> listaVozaca;

        public List<Vozac> ListaVozacaValues
        {
            get
            {
                return listaVozaca;
            }
        }

        public ListaVozaca()
        {
            listaVozaca = new List<Vozac>();
        }

        public bool DodajVozaca(Vozac v)
        {
            if (PostojiVozacUListi(v))
                return false;
            listaVozaca.Add(v);
            return true;
        }

        public bool IzmeniVozaca(Vozac v)
        {
            var pom = GetVozac(v.Broj_vozacke);

            if (pom == null)
                return false;
            pom.Ime = v.Ime;
            pom.Prezime = v.Prezime;
            pom.Datum_rodjenja = v.Datum_rodjenja;
            pom.Vazenje_od = v.Vazenje_od;
            pom.Vazenje_do = v.Vazenje_do;
            pom.Broj_vozacke = v.Broj_vozacke;
            pom.Mesto_Izdavanja = v.Mesto_Izdavanja;
            pom.Pol = v.Pol;

            return true;
        }

        public bool ObrisiVozaca(String brojVozacke)
        {
            Vozac tmpVozac = null;

            foreach(var v in listaVozaca)
            {
                if(v.Broj_vozacke == brojVozacke)
                {
                    tmpVozac = v;
                    break;
                }
            }

            if(tmpVozac != null)
            {
                listaVozaca.Remove(tmpVozac);
                return true;
            }
            return false;
        }

        public bool ObrisiVozaca(Vozac v)
        {
            if (!PostojiVozacUListi(v))
                return false;
            listaVozaca.Remove(v);
            return true;

        }

        public bool PostojiVozacUListi(Vozac o)
        {
            foreach (var v in listaVozaca)
            {
                if (v.Broj_vozacke == o.Broj_vozacke)
                    return true;
            }

            return false;
        }

        public bool PostojiVozacUListi(String brojVozacke)
        {
            foreach (var v in listaVozaca)
            {
                if (v.Broj_vozacke == brojVozacke)
                    return true;
            }

            return false;
        }

        public Vozac GetVozac(String brojVozacke)
        {
            foreach (var v in listaVozaca)
            {
                if (v.Broj_vozacke == brojVozacke)
                    return v;
            }
            return null;
        }

        public void SortListVAlue()
        {
            if (SortListDelegate != null)
                SortListDelegate(listaVozaca);
        }

        private static ListaVozaca instance = null;
        public static ListaVozaca Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListaVozaca();
                return instance;
            }
        }


    }
}
