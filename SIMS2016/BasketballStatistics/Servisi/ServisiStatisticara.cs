using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Servisi
{
    public class ServisiStatisticara : IServisiStatisticara
    {
        public void asistencija(Cetvrtina cetvrtina, string domacinGost, string brojDresa)
        {
            if(domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].StatistikeIgraca[brojDresa].Asistencija += 1;
            }
            else if(domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].StatistikeIgraca[brojDresa].Asistencija += 1;
            }
            
        }

        public void blokada(Cetvrtina cetvrtina, string domacinGost, string brojDresa)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].StatistikeIgraca[brojDresa].Blokada += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].StatistikeIgraca[brojDresa].Blokada += 1;
            }
        }

        public void izgubljenaLopta(Cetvrtina cetvrtina, string domacinGost, string brojDresa, TipIzgubljeneLopte tip)
        {
            if (domacinGost == "D")
            {
                int i = Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].StatistikeIgraca[brojDresa].IzgubljenaLopta[tip];
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].StatistikeIgraca[brojDresa].IzgubljenaLopta[tip] += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].StatistikeIgraca[brojDresa].IzgubljenaLopta[tip] += 1;
            }
        }

        public bool licnaGreska(Cetvrtina cetvrtina, string domacinGost, string brojDresa, TipLicneGreske tip)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].StatistikeIgraca[brojDresa].LicnaGreska[tip] += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].StatistikeIgraca[brojDresa].LicnaGreska[tip] += 1;
            }
            // TODO: saberi licne greske u svim cetvrtinama - ne moze > 5
            return true;
        }

        public void nesportska(Cetvrtina cetvrtina, string domacinGost, string brojDresa, TipNesportskeGreske tip)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].StatistikeIgraca[brojDresa].NesportskaGreska[tip] += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].StatistikeIgraca[brojDresa].NesportskaGreska[tip] += 1;
            }
        }

        public void skokUNapadu(Cetvrtina cetvrtina, string domacinGost, string brojDresa)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].StatistikeIgraca[brojDresa].SkokNapad += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].StatistikeIgraca[brojDresa].SkokNapad += 1;
            }
        }

        public void skokUOdbrani(Cetvrtina cetvrtina, string domacinGost, string brojDresa)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].StatistikeIgraca[brojDresa].SkokOdbrana += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].StatistikeIgraca[brojDresa].SkokOdbrana += 1;
            }
        }

        public void sutNaKos(Cetvrtina cetvrtina, string domacinGost, string brojDresa, SutNaKos sut)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].StatistikeIgraca[brojDresa].Sutevi.Add(sut);
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].BrojPoena += brojPoenaIzSuta(sut);
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].StatistikeIgraca[brojDresa].Sutevi.Add(sut);
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].BrojPoena += brojPoenaIzSuta(sut);
            }
        }

        public void tehnickaGreska(Cetvrtina cetvrtina, string domacinGost, string brojDresa)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].StatistikeIgraca[brojDresa].TehnickaGreska += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].StatistikeIgraca[brojDresa].TehnickaGreska += 1;
            }
        }

        public void tehnickaKlupe(Cetvrtina cetvrtina, string domacinGost)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].TehnickaGreskaKlupa += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].TehnickaGreskaKlupa += 1;
            }
        }

        public void tehnickaTrenera(Cetvrtina cetvrtina, string domacinGost)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].TehnickaGreskaTrenera += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].TehnickaGreskaTrenera += 1;
            }
        }

        public bool timeOut(Cetvrtina cetvrtina, string domacinGost)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].BrojTimeOuta += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].BrojTimeOuta += 1;
            }
            // TODO: proveri koliko timeouta moze po cetvrtini i ukupno po utakmici
            return true;
        }

        public void timskiNapad(Cetvrtina cetvrtina, string domacinGost)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].BrojNapada += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].BrojNapada += 1;
            }
        }

        public void timskiOsvojenaLopta(Cetvrtina cetvrtina, string domacinGost)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].TimskiOsvojenaLopta += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].TimskiOsvojenaLopta += 1;
            }
        }

        public void timskiSkokUNapadu(Cetvrtina cetvrtina, string domacinGost)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].TimskiSkokNapad += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].TimskiSkokNapad += 1;
            }
        }

        public void timskiSkokUOdbrani(Cetvrtina cetvrtina, string domacinGost)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].TimskiSkokOdbrana += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].TimskiSkokOdbrana += 1;
            }
        }

        public int brojPoenaIzSuta(SutNaKos sut)
        {
            if (sut.Pogodak && (sut.Pozicija == PozicijaSuta.P12 || sut.Pozicija == PozicijaSuta.P22
                || sut.Pozicija == PozicijaSuta.P32 || sut.Pozicija == PozicijaSuta.P42
                || sut.Pozicija == PozicijaSuta.P52 || sut.Pozicija == PozicijaSuta.P62))
            {
                return 2;
            }
            else if (sut.Pogodak && (sut.Pozicija == PozicijaSuta.P13 || sut.Pozicija == PozicijaSuta.P23
                || sut.Pozicija == PozicijaSuta.P33 || sut.Pozicija == PozicijaSuta.P43 || sut.Pozicija == PozicijaSuta.P63))
            {
                return 3;
            }
            else if (sut.Pogodak && sut.Pozicija == PozicijaSuta.SB)
            {
                return 1;
            }
            return 0;
        }

        public void timskiIzgubljenaLopta(Cetvrtina cetvrtina, string domacinGost, TipTimskeIzgubljeneLopte tip)
        {
            if (domacinGost == "D")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaDomacegTima[cetvrtina].TimskiIzgubljenaLopta[tip] += 1;
            }
            else if (domacinGost == "G")
            {
                Aplikacija.utakmicaNaAnalizi.Statistika.StatistikaGostujucegTima[cetvrtina].TimskiIzgubljenaLopta[tip] += 1;
            }
        }
    }
}
