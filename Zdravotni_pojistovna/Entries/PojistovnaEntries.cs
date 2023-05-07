namespace Zdravotni_pojistovna
{
    public class PojistovnaEntries
    {
        public PojistovnaEntry[] entries;
        public int entriesCount;

        public PojistovnaEntries()
        {
            entries = new PojistovnaEntry[10];
            entriesCount = 0;
        }

        public void addEntry(PojistovnaEntry entry)
        { 
            entries[entriesCount++] = entry; 
        }
    }
}
