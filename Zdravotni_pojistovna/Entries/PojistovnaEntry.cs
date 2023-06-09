﻿using Entities;

namespace Zdravotni_pojistovna
{
    public class PojistovnaEntry
    {
        public Osoba osoba { get; set; }
        public Adresa adresa { get; set; }
        public Pojistovny pojistovna { get; set; }

        public PojistovnaEntry(Osoba osoba, Adresa adresa, Pojistovny pojistovna)
        {
            this.osoba = osoba;
            this.adresa = adresa;
            this.pojistovna = pojistovna;
        }

    }
}
