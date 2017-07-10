using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reprezentacija: Tim
    {
        public Reprezentacija() : base() { }
        public Reprezentacija(String naziv, Dictionary<String, Igrac> igraci, Trener trener, Dictionary<String, Takmicenje> takmicenja) : base(naziv, igraci, trener, takmicenja) { }
    }
}
