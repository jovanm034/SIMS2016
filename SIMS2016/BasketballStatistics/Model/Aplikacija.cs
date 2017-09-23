using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Aplikacija
    {
        public static Dictionary<String, Korisnik> Korisnici { get; set; }
        public static Dictionary<String, Takmicenje> Takmicenja { get; set; }
        public static Dictionary<String, Tim> Timovi { get; set; }
        public static Dictionary<int, Igrac> Igraci { get; set; }
        public static List<Sudija> Sudije { get; set; }
        public static Korisnik PrijavljeniKorisnik { get; set; }
        public static Utakmica utakmicaNaAnalizi { get; set; }
    }
}
