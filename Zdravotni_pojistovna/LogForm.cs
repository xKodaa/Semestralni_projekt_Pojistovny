using System;
using System.IO;
using System.Windows.Forms;

namespace Semestralni_projekt
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            String filePath = "logs.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    logsLb.Items.Add(line);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
