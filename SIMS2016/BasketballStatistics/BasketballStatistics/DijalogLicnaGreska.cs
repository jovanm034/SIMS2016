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
    public partial class DijalogLicnaGreska : Form
    {
        public Cetvrtina cetvrtina;
        public String domacinGost;
        public String brojDresa;
        public ServisiStatisticara servisS;

        public DijalogLicnaGreska(Cetvrtina cetvrtina, String domacinGost, String brojDresa, ServisiStatisticara servisS)
        {
            this.cetvrtina = cetvrtina;
            this.domacinGost = domacinGost;
            this.brojDresa = brojDresa;
            this.servisS = servisS;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipLicneGreske tip = new TipLicneGreske();
            if (radioButton1.Checked == true) tip = TipLicneGreske.B1;
            else if (radioButton2.Checked == true) tip = TipLicneGreske.B2;
            else if (radioButton3.Checked == true) tip = TipLicneGreske.B3;
            this.servisS.licnaGreska(this.cetvrtina, this.domacinGost, this.brojDresa, tip);
            this.Close();
        }
    }
}
