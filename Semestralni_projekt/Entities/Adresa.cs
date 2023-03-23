using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestralni_projekt.Entities
{
    public class Adresa
    {
        String mesto { get; set; }
        String ulice { get; set; }
        String cisloPopisne { get; set; }
        int[] psc { get; set; }

        public Adresa(String mesto, String ulice, String cisloPopisne, int[] psc) 
        {
            this.mesto = mesto;
            this.ulice = ulice;
            this.cisloPopisne = cisloPopisne;
            this.psc = new int[5];
            this.psc = psc;
        }
    }
}
