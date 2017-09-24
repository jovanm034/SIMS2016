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
    public partial class DijalogTimskiIzgubljneLopte : Form
    {
        public Cetvrtina cetvrtina;
        public String domacinGost;
        public ServisiStatisticara servisS;
        public DijalogTimskiIzgubljneLopte(Cetvrtina cetvrtina, String domacinGost, ServisiStatisticara servisS)
        {
            this.cetvrtina = cetvrtina;
            this.domacinGost = domacinGost;
            this.servisS = servisS;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Odabrani tip timski izubljene lopte u dijalogu
            TipTimskeIzgubljeneLopte tip = new TipTimskeIzgubljeneLopte();
            if (this.radioButton1.Checked == true) tip = TipTimskeIzgubljeneLopte.TriSekundeReket;
            else if (this.radioButton2.Checked == true) tip = TipTimskeIzgubljeneLopte.PetSekundiAut;
            else if (this.radioButton3.Checked == true) tip = TipTimskeIzgubljeneLopte.PetSekundiMesto;
            else if (this.radioButton4.Checked == true) tip = TipTimskeIzgubljeneLopte.OsamSekundiPrevodjenje;
            else if (this.radioButton5.Checked == true) tip = TipTimskeIzgubljeneLopte.DvadesetCetiriSekundeNapad;

            this.servisS.timskiIzgubljenaLopta(this.cetvrtina, this.domacinGost, tip);
            this.Close();
        }

        private void DijalogTimskiIzgubljneLopte_Load(object sender, EventArgs e)
        {

        }
    }
}
