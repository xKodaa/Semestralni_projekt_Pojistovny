using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdravotni_pojistovna
{
    public class PojistovnaEntries
    {
        public PojistovnaEntry[] entries = new PojistovnaEntry[50];
        public int entriesCount = 0;

        public PojistovnaEntries(PojistovnaEntry entry)
        {
            entries[entriesCount] = entry;
            this.entriesCount++;
        }
    }
}
