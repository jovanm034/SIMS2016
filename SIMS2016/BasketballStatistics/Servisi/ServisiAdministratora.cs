using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Servisi
{
    public class ServisiAdministratora : Servisi, IServisiAdministratora
    {
        public void aktivacijaKlijenata()
        {
            throw new NotImplementedException();
        }

        public void brisanjeIgraca()
        {
            throw new NotImplementedException();
        }

        public void brisanjeKluba()
        {
            throw new NotImplementedException();
        }

        public void brisanjeKupa()
        {
            throw new NotImplementedException();
        }

        public void brisanjeLige()
        {
            throw new NotImplementedException();
        }

        public void brisanjeReprezentacije()
        {
            throw new NotImplementedException();
        }

        public void brisanjeStatisticara()
        {
            throw new NotImplementedException();
        }

        public void brisanjeSudije()
        {
            throw new NotImplementedException();
        }

        public void brisanjeTrenera()
        {
            throw new NotImplementedException();
        }

        public void deaktivacijaKlijenata()
        {
            throw new NotImplementedException();
        }

        public void izmenaIgraca()
        {
            throw new NotImplementedException();
        }

        public void izmenaKluba()
        {
            throw new NotImplementedException();
        }

        public void izmenaKupa()
        {
            throw new NotImplementedException();
        }

        public void izmenaLige()
        {
            throw new NotImplementedException();
        }

        public void izmenaReprezentacije()
        {
            throw new NotImplementedException();
        }

        public void izmenaStatisticara()
        {
            throw new NotImplementedException();
        }

        public void izmenaSudije()
        {
            throw new NotImplementedException();
        }

        public void izmenaTrenera()
        {
            throw new NotImplementedException();
        }

        public bool registracijaIgraca()
        {
            throw new NotImplementedException();
        }

        public bool registracijaKluba()
        {
            throw new NotImplementedException();
        }

        public bool registracijaKupa()
        {
            throw new NotImplementedException();
        }

        public bool registracijaLige(String naziv, List<Tim> timovi, TipTakmicenja tip)
        {
            if (Aplikacija.Takmicenja.ContainsKey(naziv)) { return false; }
            Dictionary<String, Tim> timovirecnik = new Dictionary<String, Tim>();
            Dictionary<String, Utakmica> utakmice = new Dictionary<String, Utakmica>();
            for (int i = 0; i < timovi.Count; i++)
            {
                timovirecnik.Add(timovi[i].Naziv, timovi[i]);
                for (int j = 0; j < timovi.Count; j++)
                {
                    if (i != j)
                    {
                        Utakmica u = new Utakmica();
                        u.DomaciTim = timovi[i];
                        u.GostujuciTim = timovi[j];
                        u.DomaciTrener = timovi[i].Trener;
                        u.GostujuciTrener = timovi[j].Trener;
                        foreach (Igrac di in timovi[i].Igraci.Values)
                        {
                            u.DomaciIgraci.Add(di.RegistarskiBroj, di);
                            foreach (StatistikaTima st in u.Statistika.StatistikaDomacegTima.Values)
                            {
                                st.StatistikeIgraca.Add(di.RegistarskiBroj, new StatistikaIgraca());
                            }
                        }
                        foreach (Igrac gi in timovi[j].Igraci.Values)
                        {
                            u.GostujuciIgraci.Add(gi.RegistarskiBroj, gi);
                            foreach (StatistikaTima st in u.Statistika.StatistikaGostujucegTima.Values)
                            {
                                st.StatistikeIgraca.Add(gi.RegistarskiBroj, new StatistikaIgraca());
                            }
                        }
                        utakmice.Add(timovi[i].Naziv + " - " + timovi[j].Naziv, u);
                    }
                }
            }
            Takmicenje liga = new Takmicenje(naziv, timovirecnik, utakmice, OrganizacijaTakmicenja.Liga, tip);
            Aplikacija.Takmicenja.Add(naziv, liga);
            return true;
        }

        public bool registracijaReprezentacije()
        {
            throw new NotImplementedException();
        }

        public bool registracijaStatisticara()
        {
            throw new NotImplementedException();
        }

        public bool registracijaSudije()
        {
            throw new NotImplementedException();
        }

        public bool registracijaTrenera()
        {
            throw new NotImplementedException();
        }
    }
}
