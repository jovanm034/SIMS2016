using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum PozicijaSuta { P12, P13, P22, P23, P32, P33, P42, P43, P52, P62, P63, SB }

    public class SutNaKos
    {
        private bool pogodak;
        private PozicijaSuta pozicija;

        public SutNaKos()
        {
            this.pogodak = false;
            this.pozicija = new PozicijaSuta();
        }

        public bool Pogodak { get { return this.pogodak; } set { this.pogodak = value; } }
        public PozicijaSuta Pozicija { get { return this.pozicija; } set { this.pozicija = value; } }
    }
}
