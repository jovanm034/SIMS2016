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
        public static List<Takmicenje> Takmicenja { get; set; }
        public static List<Tim> Klubovi { get; set; }
        public static List<Igrac> Igraci { get; set; }
        public static Korisnik PrijavljeniKorisnik { get; set; }
    }
}
