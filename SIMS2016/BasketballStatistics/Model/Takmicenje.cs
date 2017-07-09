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
        private Dictionary<String, List<Tim>> timovi;
        private Dictionary<String, List<Utakmica>> utakmice;
        private OrganizacijaTakmicenja organizacija;
        private TipTakmicenja tip;

        public Takmicenje()
        {
            this.naziv = null;
            this.timovi = new Dictionary<String, List<Tim>>();
            this.utakmice = new Dictionary<String, List<Utakmica>>();
            this.organizacija = OrganizacijaTakmicenja.Liga;
            this.tip = TipTakmicenja.Nacionalno;
        }

        public Takmicenje(String naziv, Dictionary<String, List<Tim>> timovi, Dictionary<String, List<Utakmica>> utakmice, OrganizacijaTakmicenja organizacija, TipTakmicenja tip)
        {
            this.naziv = naziv;
            this.timovi = timovi;
            this.utakmice = utakmice;
            this.organizacija = organizacija;
            this.tip = tip;
        }

        public String Naziv { get { return this.naziv; } set { this.naziv = value; } }
        public Dictionary<String, List<Tim>> Timovi { get { return this.timovi; } set { this.timovi = value; } }
        public Dictionary<String, List<Utakmica>> Utakmice { get { return this.utakmice; } set { this.utakmice = value; } }
        public OrganizacijaTakmicenja Organizacija { get { return this.organizacija; } set { this.organizacija = value; } }
        public TipTakmicenja Tip { get { return this.tip; } set { this.tip = value; } }
    }

}
