﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDatenBank
{
    public partial class Reservierung : Form
    {
        public Reservierung()
        {
            InitializeComponent();
        }

        private void Reservierung_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "testDatenBank2020DataSet.Reservierung". Sie können sie bei Bedarf verschieben oder entfernen.
            this.reservierungTableAdapter.Fill(this.testDatenBank2020DataSet.Reservierung);


        }

        private void reservierungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservierungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDatenBank2020DataSet);

        }
    }
}
