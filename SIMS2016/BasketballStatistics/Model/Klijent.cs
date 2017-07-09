using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Klijent : Korisnik
    {
        private String ime;
        private String prezime;
        private bool aktivan;

        public Klijent() :base(null, null)
        {
            this.ime = null;
            this.prezime = null;
            this.aktivan = false;
        }

        public Klijent(String korisnickoIme, String lozinka, String ime, String prezime, bool aktivan) :base(korisnickoIme, lozinka)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.aktivan = aktivan;
        }

        public String Ime { get { return this.ime; } set { this.ime = value; } }
        public String Prezime { get { return this.prezime; } set { this.prezime = value; } }
        public bool Aktivan { get { return this.aktivan; } set { this.aktivan = value; } }
    }
}
