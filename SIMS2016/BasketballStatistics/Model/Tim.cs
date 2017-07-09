using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tim
    {
        private String naziv;
        private Dictionary<String, Igrac> igraci;
        private Trener trener;
        private Dictionary<String, List<Takmicenje>> takmicenja;

        public Tim()
        {
            this.naziv = null;
            this.igraci = new Dictionary<String, Igrac>();
            this.trener = new Trener();
            this.takmicenja = new Dictionary<String, List<Takmicenje>>();
        }

        public Tim(String naziv, Dictionary<String, Igrac> igraci, Trener trener, Dictionary<String, List<Takmicenje>> takmicenja)
        {
            this.naziv = naziv;
            this.igraci = igraci;
            this.trener = trener;
            this.takmicenja = takmicenja;
        }

        public String Naziv { get { return this.naziv; } set { this.naziv = value; } }
        public Dictionary<String, Igrac> Igraci { get { return this.igraci; } set { this.igraci = value; } }
        public Trener Trener { get { return this.trener; } set { this.trener = value; } }
        public Dictionary<String, List<Takmicenje>> Takmicenja { get { return this.takmicenja; } set { this.takmicenja = value; } }

    }
}
