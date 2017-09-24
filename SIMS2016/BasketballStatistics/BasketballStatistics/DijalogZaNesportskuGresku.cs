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
    public partial class DijalogZaNesportskuGresku : Form
    {
        public Cetvrtina cetvrtina;
        public String domacinGost;
        public String brojDresa;
        public ServisiStatisticara servisS;
        public DijalogZaNesportskuGresku(Cetvrtina cetvrtina, String domacinGost, String brojDresa, ServisiStatisticara servisS)
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DijalogZaNesportskuGresku_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Odabrani tip nesportske greske u dijalogu
            TipNesportskeGreske tip = new TipNesportskeGreske();
            if (this.radioButton1.Checked == true) tip = TipNesportskeGreske.U1;
            else if (this.radioButton2.Checked == true) tip = TipNesportskeGreske.U2;
            else if (this.radioButton3.Checked == true) tip = TipNesportskeGreske.U3;
            this.servisS.nesportska(this.cetvrtina, this.domacinGost, this.brojDresa, tip);
            this.Close();
        }
    }
}
