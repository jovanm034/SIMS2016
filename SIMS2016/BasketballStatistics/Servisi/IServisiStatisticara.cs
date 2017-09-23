using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Servisi
{
    interface IServisiStatisticara
    {
        // Tim
        void timskiSkokUNapadu(Cetvrtina cetvrtina, String domacinGost);
        void timskiSkokUOdbrani(Cetvrtina cetvrtina, String domacinGost);
        void timskiOsvojenaLopta(Cetvrtina cetvrtina, String domacinGost);
        void timskiIzgubljenaLopta(Cetvrtina cetvrtina, String domacinGost, TipTimskeIzgubljeneLopte tip); // TODO: 
        void tehnickaTrenera(Cetvrtina cetvrtina, String domacinGost);
        void tehnickaKlupe(Cetvrtina cetvrtina, String domacinGost);
        void timskiNapad(Cetvrtina cetvrtina, String domacinGost);
        bool timeOut(Cetvrtina cetvrtina, String domacinGost);

        // Igrac
        void sutNaKos(Cetvrtina cetvrtina, String domacinGost, String brojDresa, SutNaKos sut); // TODO: 
        void asistencija(Cetvrtina cetvrtina, String domacinGost, String brojDresa);
        void blokada(Cetvrtina cetvrtina, String domacinGost, String brojDresa);
        void izgubljenaLopta(Cetvrtina cetvrtina, String domacinGost, String brojDresa, TipIzgubljeneLopte tip); // TODO: 
        void skokUNapadu(Cetvrtina cetvrtina, String domacinGost, String brojDresa);
        void skokUOdbrani(Cetvrtina cetvrtina, String domacinGost, String brojDresa);
        bool licnaGreska(Cetvrtina cetvrtina, String domacinGost, String brojDresa, TipLicneGreske tip); // TODO: 
        void tehnickaGreska(Cetvrtina cetvrtina, String domacinGost, String brojDresa);
        void nesportska(Cetvrtina cetvrtina, String domacinGost, String brojDresa, TipNesportskeGreske tip); // TODO: 

    }
}
