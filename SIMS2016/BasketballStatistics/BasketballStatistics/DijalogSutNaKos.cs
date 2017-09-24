using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Servisi;

namespace BasketballStatistics
{
    public delegate void pracenjeRezultata(String domacinGost);

    public partial class DijalogSutNaKos : Form
    {
        public Cetvrtina cetvrtina;
        public String domacinGost;
        public String brojDresa;
        public ServisiStatisticara servisi;
        public SutNaKos sut;
        public event pracenjeRezultata rezultatPromenjen;

        public DijalogSutNaKos(Cetvrtina cetvrtina, String domacinGost, String brojDresa, ServisiStatisticara servisS, SutNaKos sut)
        {
            this.cetvrtina = cetvrtina;
            this.domacinGost = domacinGost;
            this.brojDresa = brojDresa;
            this.servisi = servisS;
            this.sut = sut;
            InitializeComponent();
            
        }

        private void naPromenuRezultata()
        {
            if (rezultatPromenjen != null)
            {
                rezultatPromenjen(this.domacinGost);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sut.Pozicija = this.odrediPoziciju();
            this.sut.Pogodak = true;
            this.servisi.sutNaKos(this.cetvrtina, this.domacinGost, this.brojDresa, this.sut);
            this.naPromenuRezultata();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sut.Pozicija = this.odrediPoziciju();
            this.sut.Pogodak = false;
            this.servisi.sutNaKos(this.cetvrtina, this.domacinGost, this.brojDresa, this.sut);
            this.naPromenuRezultata();
            this.Close();
        }

        private PozicijaSuta odrediPoziciju()
        {
            PozicijaSuta pozicija = new PozicijaSuta();
            if (this.radioButton1.Checked == true) pozicija = PozicijaSuta.SB;
            else if (this.radioButton2.Checked == true && this.radioButton9.Checked == true) pozicija = PozicijaSuta.P12;
            else if (this.radioButton2.Checked == true && this.radioButton10.Checked == true) pozicija = PozicijaSuta.P13;
            else if (this.radioButton3.Checked == true && this.radioButton9.Checked == true) pozicija = PozicijaSuta.P22;
            else if (this.radioButton3.Checked == true && this.radioButton10.Checked == true) pozicija = PozicijaSuta.P23;
            else if (this.radioButton4.Checked == true && this.radioButton9.Checked == true) pozicija = PozicijaSuta.P32;
            else if (this.radioButton4.Checked == true && this.radioButton10.Checked == true) pozicija = PozicijaSuta.P33;
            else if (this.radioButton5.Checked == true && this.radioButton9.Checked == true) pozicija = PozicijaSuta.P42;
            else if (this.radioButton5.Checked == true && this.radioButton10.Checked == true) pozicija = PozicijaSuta.P43;
            else if (this.radioButton6.Checked == true && this.radioButton9.Checked == true) pozicija = PozicijaSuta.P52;
            else if (this.radioButton7.Checked == true && this.radioButton10.Checked == true) pozicija = PozicijaSuta.P62;
            else if (this.radioButton7.Checked == true && this.radioButton9.Checked == true) pozicija = PozicijaSuta.P63;
            return pozicija;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton8.Enabled = true;
                radioButton8.Checked = true;
                radioButton9.Enabled = false;
                radioButton10.Enabled = false;
            }
            else
            {
                radioButton8.Enabled = false;
                radioButton9.Enabled = true;
                radioButton10.Enabled = true;
                radioButton9.Checked = true;
            }
        }
    }
}
