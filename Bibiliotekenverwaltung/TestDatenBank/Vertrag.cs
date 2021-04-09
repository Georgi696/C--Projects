using System;
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
    public partial class Vertrag : Form
    {
        public Vertrag()
        {
            InitializeComponent();
        }

        private void Vertrag_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "testDatenBank2020DataSet.Vertrag". Sie können sie bei Bedarf verschieben oder entfernen.
            this.vertragTableAdapter.Fill(this.testDatenBank2020DataSet.Vertrag);

        }

        private void vertragBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vertragBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDatenBank2020DataSet);

        }
    }
}
