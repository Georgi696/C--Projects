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
    public partial class Kundensuche : Form
    {
        public Kundensuche()
        {
            InitializeComponent();
        }

        private void Kundensuche_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "testDatenBank2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.testDatenBank2020DataSet.Kunde);

        }

        private void sucheKunde_Click(object sender, EventArgs e)
        {
            Kundeanzeige kz = new Kundeanzeige();
            kz.ShowDialog();
        }
    }
}
