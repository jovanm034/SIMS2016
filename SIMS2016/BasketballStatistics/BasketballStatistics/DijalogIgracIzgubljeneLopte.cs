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
    public partial class DijalogIgracIzgubljeneLopte : Form
    {
        public Cetvrtina cetvrtina;
        public String domacinGost;
        public String brojDresa;
        public ServisiStatisticara servisS;
        public DijalogIgracIzgubljeneLopte(Cetvrtina cetvrtina, String domacinGost, String brojDresa, ServisiStatisticara servisS)
        {
            this.cetvrtina = cetvrtina;
            this.domacinGost = domacinGost;
            this.brojDresa = brojDresa;
            this.servisS = servisS;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //Odabrani tip izubljene lopte u dijalogu
            TipIzgubljeneLopte tip = new TipIzgubljeneLopte();
            if (this.radioButton1.Checked == true) tip = TipIzgubljeneLopte.Koraci;
            else if (this.radioButton2.Checked == true) tip = TipIzgubljeneLopte.Dupla;
            else if (this.radioButton3.Checked == true) tip = TipIzgubljeneLopte.LoseDodavanje;
            else if (this.radioButton4.Checked == true) tip = TipIzgubljeneLopte.LoseHvatanje;
            else if (this.radioButton5.Checked == true) tip = TipIzgubljeneLopte.PetSekundiBacanje;
            else if (this.radioButton6.Checked == true) tip = TipIzgubljeneLopte.PrekoPola;
            else if (this.radioButton7.Checked == true) tip = TipIzgubljeneLopte.FaulNapadSaLoptom;
            else if (this.radioButton8.Checked == true) tip = TipIzgubljeneLopte.FaulNapadBezLopte;
            else if (this.radioButton9.Checked == true) tip = TipIzgubljeneLopte.Tehnicka;
            else if (this.radioButton10.Checked == true) tip = TipIzgubljeneLopte.Nesportska;
            else if (this.radioButton11.Checked == true) tip = TipIzgubljeneLopte.Tuca;
            else if (this.radioButton12.Checked == true) tip = TipIzgubljeneLopte.LoseVodjenje;
            
            this.servisS.izgubljenaLopta(this.cetvrtina, this.domacinGost, this.brojDresa, tip);
            this.Close();

        }

        private void DijalogIgracIzgubljeneLopte_Load(object sender, EventArgs e)
        {

        }
    }
}
