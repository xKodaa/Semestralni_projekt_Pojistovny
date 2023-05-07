using System;

namespace Entities
{
    public class Osoba
    {
        public String jmeno { get; set; }
        public String prijmeni { get; set; }

        public Osoba(String jmeno, String prijmeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
        }

        public override string ToString()
        {
            return "Jméno: " + jmeno + ", příjmení: " + prijmeni;
        }
    }
}
