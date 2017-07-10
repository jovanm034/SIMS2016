using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Klub: Tim
    {
        private String grad;
        private String drzava;
        private int godinaOsnivanja;

        public Klub() : base()
        {
            this.grad = null;
            this.drzava = null;
            this.godinaOsnivanja = 0;
        }

        public Klub(String naziv, String grad, String drzava, int godinaOsnivanja, Dictionary<String, Igrac> igraci, Trener trener, Dictionary<String, Takmicenje> takmicenja) : base(naziv, igraci, trener, takmicenja)
        {
            this.grad = grad;
            this.drzava = drzava;
            this.godinaOsnivanja = godinaOsnivanja;
        }

        public String Grad { get { return this.grad; } set { this.grad = value; } }
        public String Drzava { get { return this.drzava; } set { this.drzava = value; } }
        public int GodinaOsnivanja { get { return this.godinaOsnivanja; } set { this.godinaOsnivanja = value; } }
    }
}
