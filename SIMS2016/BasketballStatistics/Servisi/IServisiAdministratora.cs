using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Servisi
{
    interface IServisiAdministratora
    {
        bool registracijaKluba();
        bool registracijaReprezentacije();
        bool registracijaLige();
        bool registracijaKupa();
        bool registracijaIgraca();
        bool registracijaSudije();
        bool registracijaTrenera();
        bool registracijaStatisticara();

        void izmenaKluba();
        void izmenaReprezentacije();
        void izmenaLige();
        void izmenaKupa();
        void izmenaIgraca();
        void izmenaSudije();
        void izmenaTrenera();
        void izmenaStatisticara();

        void brisanjeKluba();
        void brisanjeReprezentacije();
        void brisanjeLige();
        void brisanjeKupa();
        void brisanjeIgraca();
        void brisanjeSudije();
        void brisanjeTrenera();
        void brisanjeStatisticara();

        void aktivacijaKlijenata();
        void deaktivacijaKlijenata();

    }
}
