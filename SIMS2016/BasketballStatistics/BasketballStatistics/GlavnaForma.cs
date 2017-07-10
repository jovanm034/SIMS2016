using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servisi;
using Model;

namespace BasketballStatistics
{
    public partial class GlavnaForma : Form
    {
        public Servisi.ServisiGosta servisiGosta;
        public Servisi.ServisiAdministratora servisiAdministratora;
        public Servisi.ServisiStatisticara servisiStatisticara;
        public Servisi.ServisiKlijenta servisiKlijenta;

        public GlavnaForma()
        {
            this.servisiGosta = new ServisiGosta();
            this.servisiAdministratora = new ServisiAdministratora();
            this.servisiStatisticara = new ServisiStatisticara();
            this.servisiKlijenta = new ServisiKlijenta();
            Aplikacija.Korisnici = new Dictionary<String, Korisnik>();
            Aplikacija.Takmicenja = new Dictionary<String, Takmicenje>();
            Aplikacija.Timovi = new Dictionary<String, Tim>();
            Aplikacija.Igraci = new Dictionary<int, Igrac>();
            Aplikacija.PrijavljeniKorisnik = null;
            //OBRISI OVO KAD URADIS CUVANJE KORISNIKA!
            Aplikacija.Korisnici.Add("admin", new Administrator());
            Aplikacija.Korisnici.Add("statisticar", new Statisticar("statisticar", "pass1", "pera", "peric", 0));
            Aplikacija.Korisnici.Add("klijent1", new Klijent("klijent1", "pass1", "zika", "zikic", false));
            Aplikacija.Korisnici.Add("klijent2", new Klijent("klijent2", "pass1", "zika", "zikic", true));
            //----------------------------------------
            //OBRISI OVO KAD URADIS DODAVANJE I CUVANJE
            Aplikacija.Igraci.Add(1, new Igrac(1, "ime1", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(2, new Igrac(2, "ime2", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(3, new Igrac(3, "ime3", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(4, new Igrac(4, "ime4", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(5, new Igrac(5, "ime5", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(6, new Igrac(6, "ime6", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(7, new Igrac(7, "ime7", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(8, new Igrac(8, "ime8", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(9, new Igrac(9, "ime9", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(10, new Igrac(10, "ime10", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(11, new Igrac(11, "ime11", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(12, new Igrac(12, "ime12", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(13, new Igrac(13, "ime13", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(14, new Igrac(14, "ime14", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(15, new Igrac(15, "ime15", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(16, new Igrac(16, "ime16", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(17, new Igrac(17, "ime17", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(18, new Igrac(18, "ime18", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(19, new Igrac(19, "ime19", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(20, new Igrac(20, "ime20", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(21, new Igrac(21, "ime21", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(22, new Igrac(22, "ime22", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(23, new Igrac(23, "ime23", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            Aplikacija.Igraci.Add(24, new Igrac(24, "ime24", "prezime", new DateTime(), "180cm", "90kg", Pozicija.C, new Dictionary<String, Takmicenje>()));
            //===
            Aplikacija.Timovi.Add("RADNICKI KG", new Klub("RADNICKI KG", "Kragujevac", "Srbija", 1900, new Dictionary<String, Igrac>(), new Trener(), new Dictionary<String, Takmicenje>()));
            Aplikacija.Timovi.Add("C. ZVEZDA", new Klub("C. ZVEZDA", "Beograd", "Srbija", 1900, new Dictionary<String, Igrac>(), new Trener(), new Dictionary<String, Takmicenje>()));
            //----------------------------------------
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String korisnickoIme = this.textBox1.Text;
            String lozinka = this.textBox2.Text;
            Aplikacija.PrijavljeniKorisnik = this.servisiGosta.prijava(korisnickoIme, lozinka);
            if (Aplikacija.PrijavljeniKorisnik == null) //Pogresno korisnicko ime ili lozinka
            {
                //Ispisi poruku o gresci
            }
            else
            {
                this.Controls.Remove(this.panel1);
                this.textBox1.Text = "";
                this.textBox2.Text = "";

                if (Aplikacija.PrijavljeniKorisnik.GetType().Equals(typeof(Administrator)))
                {
                    this.Controls.Add(this.panel2);
                    this.panel2.Controls.Add(this.panel3);
                    Console.WriteLine("ADMIN!");
                    //Prikazi panel za administratora
                }
                else if (Aplikacija.PrijavljeniKorisnik.GetType().Equals(typeof(Statisticar)))
                {
                    this.Controls.Add(this.panel2);
                    this.panel2.Controls.Add(this.panel4);
                    //Prikazi panel za statisticara
                }
                else if (Aplikacija.PrijavljeniKorisnik.GetType().Equals(typeof(Klijent)))
                {
                    //Prikazi panel za klijenta
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.panel1);
            //Prikazi panel za registraciju klijenta
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.panel2);
            this.Controls.Add(this.panel1);
        }
    }
}
