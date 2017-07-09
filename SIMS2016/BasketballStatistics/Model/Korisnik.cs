using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Korisnik
    {
        private String korisnickoIme;
        private String lozinka;

        public Korisnik()
        {
            this.korisnickoIme = null;
            this.lozinka = null;
        }

        public Korisnik(String korisnickoIme, String lozinka)
        {
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
        }

        public String KorisnickoIme { get { return this.korisnickoIme; } set { this.korisnickoIme = value; } }
        public String Lozinka { get { return this.lozinka; } set { this.lozinka = value; } }
    }


}
