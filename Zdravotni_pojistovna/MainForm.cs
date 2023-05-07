using Entities;
using Logging;
using System;
using System.IO;
using System.Windows.Forms;
using Zdravotni_pojistovna;
using Newtonsoft.Json;

namespace Semestralni_projekt
{
    public partial class MainForm : Form
    {
        public PojistovnaEntry entry;
        public PojistovnaEntries entries;
        private EditForm editForm = new EditForm();
        private readonly string backup;
        private readonly string logs;

        public MainForm()
        {
            InitializeComponent();
            backup = "backup.json";
            logs = "logs.txt";
            listBox.Items.Add("ID\tJméno\t\tPříjmení\t\tMěsto\t\tUlice\t\tČ.P.\tPSČ\t\tPojišťovna");
            clearFiles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                entry = editForm.entry;
                entries = editForm.entries;
                refreshItems();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listBox.SelectedIndex;
                if (selectedIndex != 0)
                {
                    int fixedIndex = selectedIndex - 1;
                    Osoba osoba = entries.entries[fixedIndex].osoba;
                    Adresa adresa = entries.entries[fixedIndex].adresa;
                    Pojistovny pojistovna = entries.entries[fixedIndex].pojistovna;
                    editForm = new EditForm(osoba, adresa, pojistovna);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        entry = editForm.entry;
                        entries.entries[fixedIndex].osoba.jmeno = entry.osoba.jmeno;
                        entries.entries[fixedIndex].osoba.prijmeni = entry.osoba.prijmeni;
                        entries.entries[fixedIndex].adresa.mesto = entry.adresa.mesto;
                        entries.entries[fixedIndex].adresa.ulice = entry.adresa.ulice;
                        entries.entries[fixedIndex].adresa.cisloPopisne = entry.adresa.cisloPopisne;
                        entries.entries[fixedIndex].adresa.psc = entry.adresa.psc;
                        entries.entries[fixedIndex].pojistovna = entry.pojistovna;
                        Logger.sendLog(Log.ENTRY_MODIFIED, fixedIndex);
                        refreshItems();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try 
            {
                int selectedIndex = listBox.SelectedIndex;
                if (selectedIndex != 0)
                {
                    int fixedIndex = selectedIndex - 1;
                    entries.entries[fixedIndex] = null;
                    entries.entriesCount--;
                    sortArray();
                    refreshItems();
                    Logger.sendLog(Log.ENTRY_REMOVED, fixedIndex);
                }
            } catch (Exception ex) { }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try 
            {
                string jsonString = File.ReadAllText(backup);
                entries = JsonConvert.DeserializeObject<PojistovnaEntries>(jsonString);
                refreshItems();
                Logger.sendLog(Log.DATA_LOADED, entries.entriesCount);
            } catch (Exception) { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                if (entries.entriesCount != 0)
                {
                    using (StreamWriter sw = new StreamWriter(backup))
                    {
                        using (JsonWriter writer = new JsonTextWriter(sw))
                        {
                            JsonSerializer serializer = new JsonSerializer();
                            serializer.Serialize(writer, entries);
                        }
                    }
                    Logger.sendLog(Log.DATA_SAVED, entries.entriesCount);
                }
            } catch (Exception) { }
        }
    

        private void btnLogs_Click(object sender, EventArgs e)
        {
            LogForm logForm = new LogForm();
            if (logForm.ShowDialog() == DialogResult.OK) 
            { 
                logForm.Close();
            }
        }

        public void refreshItems() 
        {
            listBox.Items.Clear();
            listBox.Items.Add("ID\tJméno\t\tPříjmení\t\tMěsto\t\tUlice\t\tČ.P.\tPSČ\t\tPojišťovna");
            for (int i = 0; i < entries.entriesCount; i++)
            { 
                PojistovnaEntry entry = entries.entries[i];
                String jmeno = entry.osoba.jmeno;
                String prijmeni = entry.osoba.prijmeni;
                String mesto = entry.adresa.mesto;
                String ulice = entry.adresa.ulice;
                String cp = entry.adresa.cisloPopisne;
                int psc = entry.adresa.psc;
                String pojistovna = Pojistovna.GetName(entry.pojistovna);
                String tab = "\t\t";

                listBox.Items.Add(i + "\t" + jmeno + tab + prijmeni + tab + mesto + tab + ulice + tab + cp + "\t" + psc + tab + pojistovna);
            }
        }

        private void clearFiles()
        {
            File.WriteAllText(backup, string.Empty);
            File.WriteAllText(logs, string.Empty);
        }

        private void sortArray() 
        {
            for (int i = 0;i < entries.entriesCount;i++) 
            { 
                if (entries.entries[i] == null && entries.entries[i+1] != null)
                {
                    entries.entries[i] = entries.entries[i + 1];
                }
            }
        }
    }
}
