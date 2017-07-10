using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Pozicija { PG, SG, SF, PF, C }

    public class Igrac
    {
        private int registarskiBroj;
        private String ime;
        private String prezime;
        private DateTime datumRodjenja;
        private String visina;
        private String tezina;
        private Pozicija pozicija;
        private Dictionary<String, Takmicenje> takmicenja;

        public Igrac()
        {
            this.registarskiBroj = 0;
            this.ime = null;
            this.prezime = null;
            this.datumRodjenja = new DateTime();
            this.visina = null;
            this.tezina = null;
            this.pozicija = new Pozicija();
            this.takmicenja = new Dictionary<String, Takmicenje>();
        }

        public Igrac(int registarskiBroj, String ime, String prezime, DateTime datumRodjenja, String visina, String tezina, Pozicija pozicija,
            Dictionary<String, Takmicenje> takmicenja)
        {
            this.registarskiBroj = registarskiBroj;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            this.pozicija = pozicija;
            this.takmicenja = takmicenja;
        }

        public int RegistarskiBroj { get { return this.registarskiBroj; } set { this.registarskiBroj = value; } }
        public String Ime { get { return this.ime; } set { this.ime = value; } }
        public String Prezime { get { return this.prezime; } set { this.prezime = value; } }
        public DateTime DatumRodjenja { get { return this.datumRodjenja; } set { this.datumRodjenja = value; } }
        public String Visina { get { return this.visina; } set { this.visina = value; } }
        public String Tezina { get { return this.tezina; } set { this.tezina = value; } }
        public Pozicija Pozicija { get { return this.pozicija; } set { this.pozicija = value; } }
        public Dictionary<String, Takmicenje> Takmicenja { get { return this.takmicenja; } set { this.takmicenja = value; } }


    }
}
