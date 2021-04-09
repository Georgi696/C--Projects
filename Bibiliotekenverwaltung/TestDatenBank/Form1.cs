using System;
using System.Windows.Forms;

namespace TestDatenBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kundendaten kd = new Kundendaten();
            kd.ShowDialog();
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            Mediumliste ml = new Mediumliste();
            ml.ShowDialog();
        }

        private void vertragButton_Click(object sender, EventArgs e)
        {
            Vertrag vertragListe = new Vertrag();
            vertragListe.ShowDialog();
        }

        private void reservierungButton_Click(object sender, EventArgs e)
        {
            Reservierung reserv = new Reservierung();
            reserv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kundensuche ks = new Kundensuche();
            ks.ShowDialog();
        }
    }
}
