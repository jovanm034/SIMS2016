using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StatistikaUtakmice
    {
        // TODO
        private bool odradjena;
        private Dictionary<int, StatistikaIgraca> statistikaDomacihIgraca;
        private Dictionary<int, StatistikaIgraca> statistikaGostujucihIgraca;

        public StatistikaUtakmice()
        {
            this.odradjena = false;
            this.statistikaDomacihIgraca = new Dictionary<int, StatistikaIgraca>();
            this.statistikaGostujucihIgraca = new Dictionary<int, StatistikaIgraca>();
        }

        public bool Odradjena { get { return this.odradjena; } set { this.odradjena = value; } }
        public Dictionary<int, StatistikaIgraca> StatistikaDomacihIgraca { get { return this.statistikaDomacihIgraca; } set { this.statistikaDomacihIgraca = value; } }
        public Dictionary<int, StatistikaIgraca> StatistikaGostujucihIgraca { get { return this.statistikaGostujucihIgraca; } set { this.statistikaGostujucihIgraca = value; } }
    }
}
