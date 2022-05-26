using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ListaZabrana
    {
        public delegate void SortDelegate(List<ZabranaUpravljanja> v);

        public SortDelegate SortListDelegateZabranaUpravljanja { get; set; }

        private List<ZabranaUpravljanja> listaZabranaUpravljanja;

        public List<ZabranaUpravljanja> ListaZabranaUpravljanjaValues
        {
            get
            {
                return listaZabranaUpravljanja;
            }
        }

        public ListaZabrana()
        {
            listaZabranaUpravljanja = new List<ZabranaUpravljanja>();
        }

        public bool DodajKategorije(ZabranaUpravljanja k)
        {
            if (PostojiZabranaUpravljanjaUListi(k))
                return false;
            listaZabranaUpravljanja.Add(k);
            return true;
        }



        public bool ObrisiKategorije(String oznaka)
        {
            ZabranaUpravljanja tmpZabranaUpravljanja = null;

            foreach (var v in listaZabranaUpravljanja)
            {
                if (v.Oznaka_kategorije == oznaka)
                {
                    tmpZabranaUpravljanja = v;
                    break;
                }
            }

            if (tmpZabranaUpravljanja != null)
            {
                listaZabranaUpravljanja.Remove(tmpZabranaUpravljanja);
                return true;
            }
            return false;
        }

        public bool ObrisiKategorije(ZabranaUpravljanja k)
        {
            if (!PostojiZabranaUpravljanjaUListi(k))
                return false;
            listaZabranaUpravljanja.Remove(k);
            return true;

        }

        public bool PostojiZabranaUpravljanjaUListi(ZabranaUpravljanja o)
        {
            foreach (var v in listaZabranaUpravljanja)
            {
                if (v.Oznaka_kategorije == o.Oznaka_kategorije)
                    return true;
            }

            return false;
        }

        public bool PostojiZabranaUpravljanjaUListi(String oznaka)
        {
            foreach (var v in listaZabranaUpravljanja)
            {
                if (v.Oznaka_kategorije == oznaka)
                    return true;
            }

            return false;
        }

        public ZabranaUpravljanja GetZabranaUpravljanja(String oznaka)
        {
            foreach (var v in listaZabranaUpravljanja)
            {
                if (v.Oznaka_kategorije == oznaka)
                    return v;
            }
            return null;
        }

        public void SortListVAlue()
        {
            if (SortListDelegateZabranaUpravljanja != null)
                SortListDelegateZabranaUpravljanja(listaZabranaUpravljanja);
        }

        private static ListaZabrana instance_z = null;
        public static ListaZabrana Instance_z
        {
            get
            {
                if (instance_z == null)
                    instance_z = new ListaZabrana();
                return instance_z;
            }
        }

    }
}
