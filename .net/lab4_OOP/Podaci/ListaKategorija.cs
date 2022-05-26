using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ListaKategorija
    {
        public delegate void SortDelegate(List<Kategorija> v);

        public SortDelegate SortListDelegateKategorija { get; set; }

        private List<Kategorija> listaKategorija;

        public List<Kategorija> ListaKategorijaValues
        {
            get
            {
                return listaKategorija;
            }
        }

        public ListaKategorija()
        {
            listaKategorija = new List<Kategorija>();
        }

        public bool DodajKategorije(Kategorija k)
        {
            if (PostojiKategorijaUListi(k))
                return false;
            listaKategorija.Add(k);
            return true;
        }

        public Kategorija GetKategorija(String oznaka)
        {
            foreach (var v in listaKategorija)
            {
                if (v.Oznaka_kategorije == oznaka)
                    return v;
            }

            return null;
        }



        public bool ObrisiKategorije(String oznaka)
        {
            Kategorija tmpKategorija = null;

            foreach (var v in listaKategorija)
            {
                if (v.Oznaka_kategorije == oznaka)
                {
                    tmpKategorija = v;
                    break;
                }
            }

            if (tmpKategorija != null)
            {
                listaKategorija.Remove(tmpKategorija);
                return true;
            }
            return false;
        }

        public bool ObrisiKategorije(Kategorija k)
        {
            if (!PostojiKategorijaUListi(k))
                return false;
            listaKategorija.Remove(k);
            return true;

        }

        public bool PostojiKategorijaUListi(Kategorija o)
        {
            foreach (var v in listaKategorija)
            {
                if (v.Oznaka_kategorije == o.Oznaka_kategorije)
                    return true;
            }

            return false;
        }

        public bool PostojiKategorijaUListi(String oznaka)
        {
            foreach (var v in listaKategorija)
            {
                if (v.Oznaka_kategorije == oznaka)
                    return true;
            }

            return false;
        }

       

        public void SortListVAlue()
        {
            if (SortListDelegateKategorija != null)
                SortListDelegateKategorija(listaKategorija);
        }

        private static ListaKategorija instance_k = null;
        public static ListaKategorija Instance_k
        {
            get
            {
                if (instance_k == null)
                    instance_k = new ListaKategorija();
                return instance_k;
            }
        }

    }
}
