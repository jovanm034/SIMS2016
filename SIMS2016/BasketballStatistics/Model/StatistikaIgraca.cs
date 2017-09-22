using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum TipIzgubljeneLopte { Koraci, Dupla, LoseDodavanje, LoseHvatanje,
        PetSekundiBacanje, PrekoPola, FaulNapadSaLoptom, FaulNapadBezLopte, Tehnicka, Nesportska, Tuca, LoseVodjenje }

    public enum TipLicneGreske { B1, B2, B3 }
    public enum TipNesportskeGreske { U1, U2, U3 }

    public class StatistikaIgraca
    {
        private List<SutNaKos> sutevi;
        private int skokOdbrana;
        private int skokNapad;
        private int asistencija;
        private Dictionary<TipIzgubljeneLopte, int> izgubljenaLopta;
        private Dictionary<TipLicneGreske, int> licnaGreska;
        private Dictionary<TipNesportskeGreske, int> nesportskaGreska;
        private int tehnickaGreska;
        private int blokada;
        
        // TODO: Konstruktori, geteri i seteri
    }
}
