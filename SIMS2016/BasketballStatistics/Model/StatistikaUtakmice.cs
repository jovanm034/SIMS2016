using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Cetvrtina { Prva, Druga, Treca, Cetvrta }

    public class StatistikaUtakmice
    {
        // TODO
        private bool odradjena;
        private Dictionary<Cetvrtina, StatistikaTima> statistikaDomacegTima;
        private Dictionary<Cetvrtina, StatistikaTima> statistikaGostujucegTima;

        public StatistikaUtakmice()
        {
            this.odradjena = false;

            this.statistikaDomacegTima = new Dictionary<Cetvrtina, StatistikaTima>();
            this.statistikaDomacegTima.Add(Cetvrtina.Prva, new StatistikaTima());
            this.statistikaDomacegTima.Add(Cetvrtina.Druga, new StatistikaTima());
            this.statistikaDomacegTima.Add(Cetvrtina.Treca, new StatistikaTima());
            this.statistikaDomacegTima.Add(Cetvrtina.Cetvrta, new StatistikaTima());

            this.statistikaGostujucegTima = new Dictionary<Cetvrtina, StatistikaTima>();
            this.statistikaGostujucegTima.Add(Cetvrtina.Prva, new StatistikaTima());
            this.statistikaGostujucegTima.Add(Cetvrtina.Druga, new StatistikaTima());
            this.statistikaGostujucegTima.Add(Cetvrtina.Treca, new StatistikaTima());
            this.statistikaGostujucegTima.Add(Cetvrtina.Cetvrta, new StatistikaTima());
        }

        // TODO: Konstruktor sa parametrima

        public bool Odradjena { get { return this.odradjena; } set { this.odradjena = value; } }
        public Dictionary<Cetvrtina, StatistikaTima> StatistikaDomacegTima { get { return this.statistikaDomacegTima; } set { this.statistikaDomacegTima = value; } }
        public Dictionary<Cetvrtina, StatistikaTima> StatistikaGostujucegTima { get { return this.statistikaGostujucegTima; } set { this.statistikaGostujucegTima = value; } }
    }
}
