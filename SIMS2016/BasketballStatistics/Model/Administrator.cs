using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // postoji samo jedan predefinisan administrator sistema koji se prijavljuje sa podacima admin/admin
    public class Administrator : Korisnik
    {
        public Administrator() : base("admin", "admin") { }
    }

}
