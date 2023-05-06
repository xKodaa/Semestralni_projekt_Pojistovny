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
    public partial class LogForm : Form
    {
        public String timeOfLog = "[" + DateTime.Now.ToString("HH:mm:ss") + "] | ";

        public LogForm(String msg)
        {
            InitializeComponent();
            this.logsLb.Items.Add(timeOfLog + msg);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
