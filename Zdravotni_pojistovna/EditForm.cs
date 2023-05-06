﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Semestralni_projekt
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            pojistovnaBox.DataSource = Enum.GetValues(typeof(Pojistovny));
            pojistovnaBox.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

    }
}