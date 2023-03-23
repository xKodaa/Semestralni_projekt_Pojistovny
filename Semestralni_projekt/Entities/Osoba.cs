using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestralni_projekt
{
    public class Osoba
    {
        String jmeno { get; set; }
        String prijmeni { get; set; }

        public Osoba(String jmeno, String prijmeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
        }
    }
}
