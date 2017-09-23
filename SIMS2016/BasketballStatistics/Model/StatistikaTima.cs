using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum TipTimskeIzgubljeneLopte { TriSekudneReket,
        PetSekundiAut, PetSekundiMesto, OsamSekundiPrevodjenje, DvadesetCetiriSekundeNapad }
    
    public class StatistikaTima
    {
        private Dictionary<String, StatistikaIgraca> statistikeIgraca;
        private int timskiSkokNapad;
        private int timskiSkokOdbrana;
        private int timskiOsvojenaLopta;
        private Dictionary<TipTimskeIzgubljeneLopte, int> timskiIzgubljenaLopta;
        private int tehnickaGreskaTrenera;
        private int tehnickaGreskaKlupa;
        private int brojTimeOuta;
        private int brojNapada;
        private int brojPoena;

        public StatistikaTima()
        {
            this.statistikeIgraca = new Dictionary<String, StatistikaIgraca>();
            this.timskiSkokNapad = 0;
            this.timskiSkokOdbrana = 0;
            this.timskiOsvojenaLopta = 0;

            this.timskiIzgubljenaLopta = new Dictionary<TipTimskeIzgubljeneLopte, int>();
            this.timskiIzgubljenaLopta.Add(TipTimskeIzgubljeneLopte.TriSekudneReket, 0);
            this.timskiIzgubljenaLopta.Add(TipTimskeIzgubljeneLopte.PetSekundiAut, 0);
            this.timskiIzgubljenaLopta.Add(TipTimskeIzgubljeneLopte.PetSekundiMesto, 0);
            this.timskiIzgubljenaLopta.Add(TipTimskeIzgubljeneLopte.OsamSekundiPrevodjenje, 0);
            this.timskiIzgubljenaLopta.Add(TipTimskeIzgubljeneLopte.DvadesetCetiriSekundeNapad, 0);

            this.tehnickaGreskaTrenera = 0;
            this.tehnickaGreskaKlupa = 0;
            this.brojTimeOuta = 0;
            this.brojNapada = 0;
            this.brojPoena = 0;
        }

        // TODO: konstruktor sa parametrima

        public Dictionary<String, StatistikaIgraca> StatistikeIgraca { get { return this.statistikeIgraca; } set { this.statistikeIgraca = value; } }
        public int TimskiSkokNapad { get { return this.timskiSkokNapad; } set { this.timskiSkokNapad = value; } }
        public int TimskiSkokOdbrana { get { return this.timskiSkokOdbrana; } set { this.timskiSkokOdbrana = value; } }
        public int TimskiOsvojenaLopta { get { return this.timskiOsvojenaLopta; } set { this.timskiOsvojenaLopta = value; } }
        public Dictionary<TipTimskeIzgubljeneLopte, int> TimskiIzgubljenaLopta { get { return this.timskiIzgubljenaLopta; } set { this.timskiIzgubljenaLopta = value; } }
        public int TehnickaGreskaTrenera { get { return this.tehnickaGreskaTrenera; } set { this.tehnickaGreskaTrenera = value; } }
        public int TehnickaGreskaKlupa { get { return this.tehnickaGreskaKlupa; } set { this.tehnickaGreskaKlupa = value; } }
        public int BrojTimeOuta { get { return this.brojTimeOuta; } set { this.brojTimeOuta = value; } }
        public int BrojNapada { get { return this.brojNapada; } set { this.brojNapada = value; } }
        public int BrojPoena { get { return this.brojPoena; } set { this.brojPoena = value; } }


    }
    
}


