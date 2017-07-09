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
            //OBRISI OVO KAD URADIS CUVANJE KORISNIKA!
            Aplikacija.Korisnici = new Dictionary<String, Korisnik>();
            Aplikacija.Korisnici.Add("admin", new Administrator());
            Aplikacija.Korisnici.Add("statisticar", new Statisticar("statisticar", "pass1", "pera", "peric", 0));
            Aplikacija.Korisnici.Add("klijent1", new Klijent("klijent1", "pass1", "zika", "zikic", false));
            Aplikacija.Korisnici.Add("klijent2", new Klijent("klijent2", "pass1", "zika", "zikic", true));
            //----------------------------------------
            InitializeComponent();
            //OBRISI OVO KAD NAPRAVIS SVE PANELE!
            //this.panel1.Show();
            //this.panel2.Hide();
            //----------------------------------------
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
