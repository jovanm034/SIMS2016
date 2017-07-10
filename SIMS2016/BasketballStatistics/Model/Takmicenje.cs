using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum OrganizacijaTakmicenja { Liga, Kup }
    public enum TipTakmicenja { Nacionalno, Internacionalno }

    public class Takmicenje
    {
        private String naziv;
        private Dictionary<String, Tim> timovi;
        private Dictionary<String, Utakmica> utakmice;
        private OrganizacijaTakmicenja organizacija;
        private TipTakmicenja tip;

        public Takmicenje()
        {
            this.naziv = null;
            this.timovi = new Dictionary<String, Tim>();
            this.utakmice = new Dictionary<String, Utakmica>();
            this.organizacija = OrganizacijaTakmicenja.Liga;
            this.tip = TipTakmicenja.Nacionalno;
        }

        public Takmicenje(String naziv, Dictionary<String, Tim> timovi, Dictionary<String, Utakmica> utakmice, OrganizacijaTakmicenja organizacija, TipTakmicenja tip)
        {
            this.naziv = naziv;
            this.timovi = timovi;
            this.utakmice = utakmice;
            this.organizacija = organizacija;
            this.tip = tip;
        }

        public String Naziv { get { return this.naziv; } set { this.naziv = value; } }
        public Dictionary<String, Tim> Timovi { get { return this.timovi; } set { this.timovi = value; } }
        public Dictionary<String, Utakmica> Utakmice { get { return this.utakmice; } set { this.utakmice = value; } }
        public OrganizacijaTakmicenja Organizacija { get { return this.organizacija; } set { this.organizacija = value; } }
        public TipTakmicenja Tip { get { return this.tip; } set { this.tip = value; } }
    }

}
