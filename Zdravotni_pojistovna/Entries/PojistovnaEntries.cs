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
        public PojistovnaEntry[] entries;
        public int entriesCount;

        public PojistovnaEntries()
        {
            entries = new PojistovnaEntry[50];
            entriesCount = 0;
        }

        public void addEntry(PojistovnaEntry entry)
        { 
            entries[entriesCount++] = entry; 
        }
    }
}
