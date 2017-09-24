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
        
        public StatistikaIgraca()
        {
            this.sutevi = new List<SutNaKos>();
            this.skokOdbrana = 0;
            this.skokNapad = 0;
            this.asistencija = 0;
            this.izgubljenaLopta = new Dictionary<TipIzgubljeneLopte, int>();
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.Koraci, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.Dupla, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.LoseDodavanje, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.LoseHvatanje, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.PetSekundiBacanje, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.PrekoPola, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.FaulNapadBezLopte, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.FaulNapadSaLoptom, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.Tehnicka, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.Nesportska, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.Tuca, 0);
            this.izgubljenaLopta.Add(TipIzgubljeneLopte.LoseVodjenje, 0);
            this.licnaGreska = new Dictionary<TipLicneGreske, int>();
            this.licnaGreska.Add(TipLicneGreske.B1, 0);
            this.licnaGreska.Add(TipLicneGreske.B2, 0);
            this.licnaGreska.Add(TipLicneGreske.B3, 0);
            this.nesportskaGreska = new Dictionary<TipNesportskeGreske, int>();
            this.nesportskaGreska.Add(TipNesportskeGreske.U1, 0);
            this.nesportskaGreska.Add(TipNesportskeGreske.U2, 0);
            this.nesportskaGreska.Add(TipNesportskeGreske.U3, 0);
            this.tehnickaGreska = 0;
            this.blokada = 0;
        }
        // TODO: Konstruktori, geteri i seteri
        public List<SutNaKos> Sutevi { get { return this.sutevi; } set { this.sutevi = value; } }
        public int SkokOdbrana { get; set; }
        public int SkokNapad { get; set; }
        public int Asistencija { get; set; }
        public Dictionary<TipIzgubljeneLopte, int> IzgubljenaLopta { get { return this.izgubljenaLopta; } set { this.izgubljenaLopta = value; } }
        public Dictionary<TipLicneGreske, int> LicnaGreska { get { return this.licnaGreska; } set { this.licnaGreska = value; } }
        public Dictionary<TipNesportskeGreske, int> NesportskaGreska { get { return this.nesportskaGreska; } set { this.nesportskaGreska = value; } }
        public int TehnickaGreska { get; set; }
        public int Blokada { get; set; }
    }
}
