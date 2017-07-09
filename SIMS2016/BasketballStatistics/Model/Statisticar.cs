using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Statisticar : Korisnik
    {
        private String ime;
        private String prezime;
        private int brojOdradjenihStatistika;

        public Statisticar() :base(null, null)
        {
            this.ime = null;
            this.prezime = null;
            this.brojOdradjenihStatistika = 0;
        }
        
        public Statisticar(String korisnickoIme, String lozinka, String ime, String prezime, int brojOdradjenihStatistika) :base(korisnickoIme, lozinka)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojOdradjenihStatistika = brojOdradjenihStatistika;
        }

        public String Ime { get { return this.ime; } set { this.ime = value; } }
        public String Prezime { get { return this.prezime; } set { this.prezime = value; } }
        public int BrojOdradjenihStatistika { get { return this.brojOdradjenihStatistika; } set { this.brojOdradjenihStatistika = value; } }
    }
}
