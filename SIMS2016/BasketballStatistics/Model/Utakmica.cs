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
        private Dictionary<int, Igrac> domaciPetorka;
        private Dictionary<int, Igrac> domaciKlupa;
        private Dictionary<int, Igrac> gostujuciPetorka;
        private Dictionary<int, Igrac> gostujuciKlupa;
        private StatistikaUtakmice statistika;

        public Utakmica()
        {
            this.domaciTim = null;
            this.gostujuciTim = null;
            this.sudije = new List<Sudija>();
            this.domaciPetorka = new Dictionary<int, Igrac>();
            this.domaciKlupa = new Dictionary<int, Igrac>();
            this.gostujuciPetorka = new Dictionary<int, Igrac>();
            this.gostujuciKlupa = new Dictionary<int, Igrac>();
            this.statistika = null;
        }

        public Utakmica(Tim domaciTim, Tim gostujuciTim, List<Sudija> sudije, Dictionary<int, Igrac> domaciPetorka, Dictionary<int, Igrac> domaciKlupa, Dictionary<int, Igrac> gostujuciPetorka, Dictionary<int, Igrac> gostujuciKlupa, StatistikaUtakmice statistika)
        {
            this.domaciTim = domaciTim;
            this.gostujuciTim = gostujuciTim;
            this.sudije = sudije;
            this.domaciPetorka = domaciPetorka;
            this.domaciKlupa = domaciKlupa;
            this.gostujuciPetorka = gostujuciPetorka;
            this.gostujuciKlupa = gostujuciKlupa;
            this.statistika = statistika;
        }

        public Tim DomaciTim { get { return this.domaciTim; } set { this.domaciTim = value; } }
        public Tim GostujuciTim { get { return this.gostujuciTim; } set { this.gostujuciTim = value; } }
        public List<Sudija> Sudije { get { return this.sudije; } set { this.sudije = value; } }
        public Dictionary<int, Igrac> DomaciPetorka { get { return this.domaciPetorka; } set { this.domaciPetorka = value; } }
        public Dictionary<int, Igrac> DomaciKlupa { get { return this.domaciKlupa; } set { this.domaciKlupa = value; } }
        public Dictionary<int, Igrac> GostujuciPetorka { get { return this.gostujuciPetorka; } set { this.gostujuciPetorka = value; } }
        public Dictionary<int, Igrac> GostujuciKlupa { get { return this.gostujuciKlupa; } set { this.gostujuciKlupa = value; } }
        public StatistikaUtakmice Statistika { get { return this.statistika; } set { this.statistika = value; } }
    }
}
