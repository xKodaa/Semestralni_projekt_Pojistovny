using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestralni_projekt
{
    public partial class MainForm : Form
    {
        EditForm editForm = new EditForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (editForm.ShowDialog() == DialogResult.OK)
            {
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
            LogForm logForm = new LogForm("TEST");
            if (logForm.ShowDialog() == DialogResult.OK) 
            { 
                logForm.Close();
            }

        }
    }
}
