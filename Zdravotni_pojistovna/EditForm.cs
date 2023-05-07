using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Zdravotni_pojistovna;
using Logging;

namespace Semestralni_projekt
{
    public partial class EditForm : Form
    {
        public PojistovnaEntry entry;
        public PojistovnaEntries entries;
        private bool newEntry;

        public EditForm()
        {
            InitializeComponent();
            pojistovnaBox.DataSource = Enum.GetValues(typeof(Pojistovny));
            pojistovnaBox.SelectedIndex = 0;
            entries = new PojistovnaEntries();
            newEntry = true;
        }

        public EditForm(Osoba osoba, Adresa adresa, Pojistovny pojistovna)
        {
            InitializeComponent();
            jmenoBox.Text = osoba.jmeno;
            prijmeniBox.Text = osoba.prijmeni;
            mestoBox.Text = adresa.mesto;
            uliceBox.Text = adresa.ulice;
            cpBox.Text = adresa.cisloPopisne;
            pscBox.Text = adresa.cisloPopisne;
            pojistovnaBox.DataSource = Enum.GetValues(typeof(Pojistovny));
            switch (pojistovna)
            {
                case Pojistovny.VZP:
                    pojistovnaBox.SelectedIndex = 0;
                    break;
                case Pojistovny.OZP:
                    pojistovnaBox.SelectedIndex = 1;
                    break;
                case Pojistovny.ZPMV:
                    pojistovnaBox.SelectedIndex = 2;
                    break;
                default:
                    break;
            }
            newEntry = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Osoba osoba = null;
            Adresa adresa = null;
            Pojistovny pojistovna = Pojistovny.VZP;
            String jmeno = jmenoBox.Text;
            String prijmeni = prijmeniBox.Text;
            String mesto = mestoBox.Text;
            String ulice = uliceBox.Text;
            String cisloPopisne = cpBox.Text;
            int psc;
            try 
            {
                psc = Int32.Parse(pscBox.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("PSČ musí být číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            osoba = new Osoba(jmeno, prijmeni);
            adresa = new Adresa(mesto, ulice, cisloPopisne, psc);
            Enum.TryParse(pojistovnaBox.SelectedValue.ToString(), out pojistovna);
            entry = new PojistovnaEntry(osoba, adresa, pojistovna);
            if (newEntry == true) //pokud to není novy zaznam nechci ho přidat znovu do pole
            {
                try
                {
                    Logger.sendLog(Log.ENTRY_ADDED, entries.entriesCount);
                    entries.addEntry(entry);
                }
                catch (Exception ex)
                {
                    Logger.sendLog(Log.ENTRY_ADD_FAILED, entries.entriesCount);
                }
            }
            DialogResult = DialogResult.OK;
            clearBoxes();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            clearBoxes();
        }

        private void clearBoxes()
        {
            jmenoBox.Text = "";
            prijmeniBox.Text = "";
            mestoBox.Text = "";
            uliceBox.Text = "";
            cpBox.Text = "";
            pscBox.Text = "";
            pojistovnaBox.SelectedIndex = 0;
        }
    }
}
