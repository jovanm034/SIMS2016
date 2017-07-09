using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Servisi
{
    public class ServisiGosta : Servisi, IServisiGosta
    {
        public Korisnik prijava(String korisnickoIme, String lozinka)
        {
            Korisnik korisnik = null;
            foreach (KeyValuePair<String, Korisnik> kv in Aplikacija.Korisnici)
            {
                if (kv.Value.KorisnickoIme == korisnickoIme && kv.Value.Lozinka == lozinka)
                {
                    korisnik = kv.Value;
                }
            }
            return korisnik;
        }

        public Klijent registracijaKlijenta()
        {
            throw new NotImplementedException();
        }
    }
}
