using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Adresa
    {
        public String mesto { get; set; }
        public String ulice { get; set; }
        public String cisloPopisne { get; set; }
        public int psc { get; set; }

        public Adresa(String mesto, String ulice, String cisloPopisne, int psc) 
        {
            this.cisloPopisne = cisloPopisne;
            this.mesto = mesto;
            this.ulice = ulice;
            this.cisloPopisne = cisloPopisne;
            this.psc = psc;
        }

        public override string ToString()
        {
            return "Město: " + mesto + ", ulice: " + ulice + ", č.p. " + cisloPopisne;
        }
    }
}
