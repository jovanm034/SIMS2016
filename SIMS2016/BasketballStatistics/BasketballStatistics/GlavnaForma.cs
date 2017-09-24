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
            Aplikacija.Korisnici.Add("statisticar", new Statisticar("s", "s", "pera", "peric", 0));
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
            Aplikacija.Timovi["RADNICKI KG"].Igraci.Add("10", Aplikacija.Igraci[1]);
            Aplikacija.Timovi["RADNICKI KG"].Igraci.Add("5", Aplikacija.Igraci[2]);
            Aplikacija.Timovi["RADNICKI KG"].Igraci.Add("7", Aplikacija.Igraci[3]);
            Aplikacija.Timovi["C. ZVEZDA"].Igraci.Add("10", Aplikacija.Igraci[4]);
            Aplikacija.Timovi["C. ZVEZDA"].Igraci.Add("12", Aplikacija.Igraci[5]);
            Aplikacija.Timovi["C. ZVEZDA"].Igraci.Add("4", Aplikacija.Igraci[6]);
            List<Tim> tt = new List<Tim>(); tt.Add(Aplikacija.Timovi["RADNICKI KG"]); tt.Add(Aplikacija.Timovi["C. ZVEZDA"]);
            this.servisiAdministratora.registracijaLige("Liga Srbije 2017", tt, TipTakmicenja.Nacionalno);
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
                    //Prikazi panel za administratora
                }
                else if (Aplikacija.PrijavljeniKorisnik.GetType().Equals(typeof(Statisticar)))
                {
                    this.Controls.Add(this.panel2);
                    if (Aplikacija.Takmicenja.Count == 0) { this.panel2.Controls.Add(this.panel4); }
                    else { this.pripremiPanel5(); }
                    
                    //Prikazi panel za statisticara
                }
                else if (Aplikacija.PrijavljeniKorisnik.GetType().Equals(typeof(Klijent)))
                {
                    //Prikazi panel za klijenta
                }
            }
        }
    
        private void pripremiPanel5()
        {
            this.panel2.Controls.Add(this.panel5);
            foreach(KeyValuePair<String, Takmicenje> t in Aplikacija.Takmicenja)
            {
                this.comboBox1.Items.Add(t.Key);
            }

        }

        private void pripremiPanel6(String takmicenje, String utakmica)
        {
            // label21 - naziv domaceg tima
            // label22 - naziv gostujuceg tima
            this.panel2.Controls.Remove(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            Aplikacija.utakmicaNaAnalizi = Aplikacija.Takmicenja[takmicenje].Utakmice[utakmica];
            this.label21.Text = Aplikacija.utakmicaNaAnalizi.DomaciTim.Naziv;
            this.label22.Text = Aplikacija.utakmicaNaAnalizi.GostujuciTim.Naziv;
            foreach(KeyValuePair<String, Igrac> i in Aplikacija.utakmicaNaAnalizi.DomaciTim.Igraci)
            {
                this.comboBox3.Items.Add("#" + i.Key + " " + i.Value.Ime + " " + i.Value.Prezime);
            }
            this.comboBox3.SelectedIndex = 0;
            foreach (KeyValuePair<String, Igrac> i in Aplikacija.utakmicaNaAnalizi.GostujuciTim.Igraci)
            {
                this.comboBox4.Items.Add("#" + i.Key + " " + i.Value.Ime + " " + i.Value.Prezime);
            }
            this.comboBox4.SelectedIndex = 0;
            Aplikacija.utakmicaNaAnalizi.Statistika.Odradjena = true;
        }

        private Cetvrtina trenutnaCetvrtina()
        {
            Cetvrtina c = new Cetvrtina();
            if (this.radioButton1.Checked == true) { c = Cetvrtina.Prva; }
            else if (this.radioButton2.Checked == true) { c = Cetvrtina.Druga; }
            else if(this.radioButton3.Checked == true) { c = Cetvrtina.Treca; }
            else if(this.radioButton4.Checked == true) { c = Cetvrtina.Cetvrta; }
            return c;
        }

        private String dresIgraca(String domaciGost)
        {
            if (domaciGost == "D")
            {
                String zapis = this.comboBox3.SelectedItem.ToString();
                return zapis.Substring(1, zapis.IndexOf(' ', 0) - 1);
            }
            else if (domaciGost == "G")
            {
                String zapis = this.comboBox4.SelectedItem.ToString();
                return zapis.Substring(1, zapis.IndexOf(' ', 0) - 1);
            }
            else return null;      
        }

        private void konzolniIzvestaj(String tekst)
        {
            this.textBox3.Text = tekst + System.Environment.NewLine + this.textBox3.Text;
            //this.textBox3.AppendText(Environment.NewLine);
            //this.textBox3.AppendText(tekst);
        }

        private void ispisRezultat(String domacinGost, int brojPoena)
        {
            String brPoena = brojPoena.ToString();
            String rezultat = "";
            for(int i = 0; i < 3 - brPoena.Length;  i++)
            {
                rezultat += 0;
            }
            rezultat += brPoena;

            if (domacinGost == "D")
            {
                this.label23.Text = rezultat;                
            }else if(domacinGost == "G")
            {
                this.label24.Text = rezultat;
            }
        }

        private void promenaRezultataPrikaz(String domacinGost)
        {
            if (domacinGost == "D")
            {
                int rezultat = 0;
                foreach (StatistikaTima stat in Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima.Values)
                {

                    rezultat += stat.BrojPoena;
                }
                this.ispisRezultat("D", rezultat);
            }
            else if(domacinGost == "G")
            {
                int rezultat = 0;
                foreach (StatistikaTima stat in Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima.Values)
                {

                    rezultat += stat.BrojPoena;
                }
                this.ispisRezultat("G", rezultat);
            }
           

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.panel1);
            //Prikazi panel za registraciju klijenta
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // odjava
            this.panel2.Controls.Remove(this.panel3);
            this.panel2.Controls.Remove(this.panel4);
            this.panel2.Controls.Remove(this.panel5);
            this.panel2.Controls.Remove(this.panel6);
            this.comboBox3.Items.Clear();
            this.comboBox4.Items.Clear();
            Aplikacija.PrijavljeniKorisnik = null;
            this.Controls.Remove(this.panel2);
            this.Controls.Add(this.panel1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Inicijalizacija utakmica pri odabiru lige
            this.comboBox2.Items.Clear();
            String selektovan = this.comboBox1.SelectedItem.ToString();
            Takmicenje odabrano = Aplikacija.Takmicenja[selektovan];
            foreach(KeyValuePair<String, Utakmica> u in odabrano.Utakmice)
            {
                this.comboBox2.Items.Add(u.Key);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            // 
           
            if(this.comboBox2.SelectedItem != null)
            {
                // inicijalizacija panela za vodjenje statistike
                this.pripremiPanel6(this.comboBox1.SelectedItem.ToString(), this.comboBox2.SelectedItem.ToString());
            }
            else
            {
                // ispisi poruku o gresci
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            // otvori snimak
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            // timski skok u napadu, domaci
            this.servisiStatisticara.timskiSkokUNapadu(this.trenutnaCetvrtina(), "D");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] Timski skok u napadu");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            // sut na kos, domacin
            SutNaKos sut = new SutNaKos();
            DijalogSutNaKos dijalog = new DijalogSutNaKos(this.trenutnaCetvrtina(), "D", this.dresIgraca("D"), this.servisiStatisticara, sut);
            dijalog.Show();

            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] [" + this.dresIgraca("D") + "] Sut na kos");
            dijalog.rezultatPromenjen += new pracenjeRezultata(promenaRezultataPrikaz);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            // izgubljena lopta, domacin
            DijalogIgracIzgubljeneLopte dijalog = new DijalogIgracIzgubljeneLopte(this.trenutnaCetvrtina(), "D", this.dresIgraca("D"), this.servisiStatisticara);
            dijalog.Show();
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] [" + this.dresIgraca("D") + "] Izgubljena lopta");
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            // timski skok u odbrani, domacin
            this.servisiStatisticara.timskiSkokUOdbrani(this.trenutnaCetvrtina(), "D");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] Timski skok u odbrani");

        }

        private void button33_Click(object sender, EventArgs e)
        {
            // timski osvojena lopta, domacin
            this.servisiStatisticara.timskiOsvojenaLopta(this.trenutnaCetvrtina(), "D");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] Timski osvojena lopta");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            // timski izgubljena lopta, domacin
            DijalogTimskiIzgubljneLopte dijalog = new DijalogTimskiIzgubljneLopte(this.trenutnaCetvrtina(), "D", this.servisiStatisticara);
            dijalog.Show();
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] Timski izgubljena lopta");

        }

        private void button35_Click(object sender, EventArgs e)
        {
            // tehnicka trenera, domacin
            this.servisiStatisticara.tehnickaTrenera(this.trenutnaCetvrtina(), "D");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] Tehnicka greska trenera");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            // tehnicka klupe, domacin
            this.servisiStatisticara.tehnickaKlupe(this.trenutnaCetvrtina(), "D");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] Tehnicka greska sa klupe");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            // napad, domacin
            this.servisiStatisticara.timskiNapad(this.trenutnaCetvrtina(), "D");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] Novi napad");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            // time-out, domacin
            this.servisiStatisticara.timeOut(this.trenutnaCetvrtina(), "D");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] Time-out");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            // time-out, gost
            this.servisiStatisticara.timeOut(this.trenutnaCetvrtina(), "G");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] Time-out");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            // napad, gost
            this.servisiStatisticara.timskiNapad(this.trenutnaCetvrtina(), "G");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] Novi napad");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            // tehnicka klupe, gost
            this.servisiStatisticara.tehnickaKlupe(this.trenutnaCetvrtina(), "G");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] Tehnicka greska sa klupe");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            // tehnicka trenera, gost
            this.servisiStatisticara.tehnickaTrenera(this.trenutnaCetvrtina(), "G");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] Tehnicka greska trenera");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            // timski izgubljena lopta, gost
            DijalogTimskiIzgubljneLopte dijalog = new DijalogTimskiIzgubljneLopte(this.trenutnaCetvrtina(), "G", this.servisiStatisticara);
            dijalog.Show();
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] Timski izgubljena lopta");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            // timski osvojena lopta, gost
            this.servisiStatisticara.timskiOsvojenaLopta(this.trenutnaCetvrtina(), "G");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] Timski osvojena lopta");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            // timski skok u odbrani, gost
            this.servisiStatisticara.timskiSkokUOdbrani(this.trenutnaCetvrtina(), "G");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] Timski skok u odbrani");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            // timski skok u napadu, gost
            this.servisiStatisticara.timskiSkokUNapadu(this.trenutnaCetvrtina(), "G");
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] Timski skok u napadu");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            // asistencija, domacin
            this.servisiStatisticara.asistencija(this.trenutnaCetvrtina(),"D",  this.dresIgraca("D"));
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] [" + this.dresIgraca("D") + "] Asistencija");

        }

        private void button52_Click(object sender, EventArgs e)
        {
            // blokada, domacin
            this.servisiStatisticara.blokada(this.trenutnaCetvrtina(), "D", this.dresIgraca("D"));
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] [" + this.dresIgraca("D") + "] Blokada");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            // skok u napadu, domacin
            this.servisiStatisticara.skokUNapadu(this.trenutnaCetvrtina(), "D", this.dresIgraca("D"));
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] [" + this.dresIgraca("D") + "] Skok u napadu");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            // skok u odbrani, domacin
            this.servisiStatisticara.skokUOdbrani(this.trenutnaCetvrtina(), "D", this.dresIgraca("D"));
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] [" + this.dresIgraca("D") + "] Skok u odbrani");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            // licna greska, domacin
            DijalogLicnaGreska dijalog = new DijalogLicnaGreska(this.trenutnaCetvrtina(), "D", this.dresIgraca("D"), this.servisiStatisticara);
            dijalog.Show();
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] [" + this.dresIgraca("D") + "] Licna greska");

        }

        private void button47_Click(object sender, EventArgs e)
        {
            // tehnicka greska, domacin
            this.servisiStatisticara.tehnickaGreska(this.trenutnaCetvrtina(), "D", this.dresIgraca("D"));
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] [" + this.dresIgraca("D") + "] Tehnicka greska");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            // nesportska greska, domacin
            DijalogZaNesportskuGresku dijalog = new DijalogZaNesportskuGresku(this.trenutnaCetvrtina(), "D", this.dresIgraca("D"), this.servisiStatisticara);
            dijalog.Show();
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [D] [" + this.dresIgraca("D") + "] Nesportska greska");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            // asistencija, gost
            this.servisiStatisticara.asistencija(this.trenutnaCetvrtina(), "G", this.dresIgraca("G"));
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] [" + this.dresIgraca("G") + "] Asistencija");
        }

        private void button63_Click(object sender, EventArgs e)
        {
            // sut na kos, gost
            SutNaKos sut = new SutNaKos();
            DijalogSutNaKos dijalog = new DijalogSutNaKos(this.trenutnaCetvrtina(), "G", this.dresIgraca("G"), this.servisiStatisticara, sut);
            dijalog.Show();
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] [" + this.dresIgraca("G") + "] Sut na kos");
            dijalog.rezultatPromenjen += new pracenjeRezultata(promenaRezultataPrikaz);

        }

        private void button61_Click(object sender, EventArgs e)
        {
            // blokada, gost
            this.servisiStatisticara.blokada(this.trenutnaCetvrtina(), "G", this.dresIgraca("G"));
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] [" + this.dresIgraca("G") + "] Blokada");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            // igrac izgubljena lopta, gost
            DijalogIgracIzgubljeneLopte dijalog = new DijalogIgracIzgubljeneLopte(this.trenutnaCetvrtina(), "G", this.dresIgraca("G"), this.servisiStatisticara);
            dijalog.Show();
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] [" + this.dresIgraca("G") + "] Izgubljena lopta");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            // skok u napadu, gost
            this.servisiStatisticara.skokUNapadu(this.trenutnaCetvrtina(), "G", this.dresIgraca("G"));
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] [" + this.dresIgraca("G") + "] Skok u napadu");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            // skok u odbrani, gost
            this.servisiStatisticara.skokUOdbrani(this.trenutnaCetvrtina(), "G", this.dresIgraca("G"));
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] [" + this.dresIgraca("G") + "] Skok u odbrani");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            // licna greska, gost
            DijalogLicnaGreska dijalog = new DijalogLicnaGreska(this.trenutnaCetvrtina(), "G", this.dresIgraca("G"), this.servisiStatisticara);
            dijalog.Show();
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] [" + this.dresIgraca("G") + "] Licna greska");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            // tehnicka greska, gost
            this.servisiStatisticara.tehnickaGreska(this.trenutnaCetvrtina(), "G", this.dresIgraca("G"));
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] [" + this.dresIgraca("G") + "] Tehnicka greska");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            // nesportska, gost
            DijalogZaNesportskuGresku dijalog = new DijalogZaNesportskuGresku(this.trenutnaCetvrtina(), "G", this.dresIgraca("G"), this.servisiStatisticara);
            dijalog.Show();
            this.konzolniIzvestaj("[" + (Int32.Parse(this.trenutnaCetvrtina().GetHashCode().ToString()) + 1) + "] [G] [" + this.dresIgraca("G") + "] Nesportska greska");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            // kraj utakmice
            this.comboBox3.Items.Clear();
            this.comboBox4.Items.Clear();
            Aplikacija.utakmicaNaAnalizi = null;
            this.panel2.Controls.Remove(this.panel6);
            this.pripremiPanel5();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
