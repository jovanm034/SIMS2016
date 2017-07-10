using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Utakmica
    {
        private Tim domaciTim;
        private Tim gostujuciTim;
        private List<Sudija> sudije;
        private Dictionary<int, Igrac> domaciIgraci;
        private Dictionary<int, Igrac> domaciPetorka;
        private Dictionary<int, Igrac> domaciKlupa;
        private Dictionary<int, Igrac> gostujuciIgraci;
        private Dictionary<int, Igrac> gostujuciPetorka;
        private Dictionary<int, Igrac> gostujuciKlupa;
        private Trener domaciTrener;
        private Trener gostujuciTrener;
        private StatistikaUtakmice statistika;

        public Utakmica()
        {
            this.domaciTim = null;
            this.gostujuciTim = null;
            this.sudije = new List<Sudija>();
            this.domaciIgraci = new Dictionary<int, Igrac>();
            this.domaciPetorka = new Dictionary<int, Igrac>();
            this.domaciKlupa = new Dictionary<int, Igrac>();
            this.gostujuciIgraci = new Dictionary<int, Igrac>();
            this.gostujuciPetorka = new Dictionary<int, Igrac>();
            this.gostujuciKlupa = new Dictionary<int, Igrac>();
            this.domaciTrener = null;
            this.gostujuciTrener = null;
            this.statistika = null;
        }

        public Utakmica(Tim domaciTim, Tim gostujuciTim, List<Sudija> sudije, Dictionary<int, Igrac> domaciIgraci, Dictionary<int, Igrac> domaciPetorka, Dictionary<int, Igrac> domaciKlupa, Dictionary<int, Igrac> gostujuciIgraci, Dictionary<int, Igrac> gostujuciPetorka, Dictionary<int, Igrac> gostujuciKlupa, Trener domaciTrener, Trener gostujuciTrener, StatistikaUtakmice statistika)
        {
            this.domaciTim = domaciTim;
            this.gostujuciTim = gostujuciTim;
            this.sudije = sudije;
            this.domaciIgraci = domaciIgraci;
            this.domaciPetorka = domaciPetorka;
            this.domaciKlupa = domaciKlupa;
            this.gostujuciIgraci = gostujuciIgraci;
            this.gostujuciPetorka = gostujuciPetorka;
            this.gostujuciKlupa = gostujuciKlupa;
            this.domaciTrener = domaciTrener;
            this.gostujuciTrener = gostujuciTrener;
            this.statistika = statistika;
        }

        public Tim DomaciTim { get { return this.domaciTim; } set { this.domaciTim = value; } }
        public Tim GostujuciTim { get { return this.gostujuciTim; } set { this.gostujuciTim = value; } }
        public List<Sudija> Sudije { get { return this.sudije; } set { this.sudije = value; } }
        public Dictionary<int, Igrac> DomaciIgraci { get { return this.domaciIgraci; } set { this.domaciIgraci = value; } }
        public Dictionary<int, Igrac> DomaciPetorka { get { return this.domaciPetorka; } set { this.domaciPetorka = value; } }
        public Dictionary<int, Igrac> DomaciKlupa { get { return this.domaciKlupa; } set { this.domaciKlupa = value; } }
        public Dictionary<int, Igrac> GostujuciIgraci { get { return this.gostujuciIgraci; } set { this.gostujuciIgraci = value; } }
        public Dictionary<int, Igrac> GostujuciPetorka { get { return this.gostujuciPetorka; } set { this.gostujuciPetorka = value; } }
        public Dictionary<int, Igrac> GostujuciKlupa { get { return this.gostujuciKlupa; } set { this.gostujuciKlupa = value; } }
        public Trener DomaciTrener { get { return this.domaciTrener; } set { this.domaciTrener = value; } }
        public Trener GostujuciTrener { get { return this.gostujuciTrener; } set { this.gostujuciTrener = value; } }
        public StatistikaUtakmice Statistika { get { return this.statistika; } set { this.statistika = value; } }
    }
}
