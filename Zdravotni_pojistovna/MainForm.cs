using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zdravotni_pojistovna;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Semestralni_projekt
{
    public partial class MainForm : Form
    {
        public PojistovnaEntry entry;
        public PojistovnaEntries entries;
        EditForm editForm = new EditForm();
        LogForm logForm;

        public MainForm()
        {
            InitializeComponent();
            listBox.Items.Add("ID\tJméno\t\tPříjmení\t\tMěsto\t\tUlice\t\tČ.P.\tPSČ\t\tPojišťovna");
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
