using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielerei
{
    public partial class Form1 : Form
    {
        int aufrufe; // ein feld für dir aufrufe erzeugen
        Graphics zeichenFlaesche; //die Zeichenfläsche erzeugen
        Color linienFarbe; // die Linienfarbe erzeugen
        Color hinterGrundFarbe; // die Farbe für die Füllung im Figur erzeugen
        Rectangle bereich; // den Bereich von Rechtecke erzeugen
        //die Linienstile erzeugen
        System.Drawing.Drawing2D.DashStyle[] linienstil =
        {
            System.Drawing.Drawing2D.DashStyle.Dash,
            System.Drawing.Drawing2D.DashStyle.DashDot,
            System.Drawing.Drawing2D.DashStyle.DashDotDot,
            System.Drawing.Drawing2D.DashStyle.Dot,
            System.Drawing.Drawing2D.DashStyle.Solid

        };
        //die Musterstile erzeugen
        System.Drawing.Drawing2D.HatchStyle[] hinterGrundStil =
        {
            System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal,
            System.Drawing.Drawing2D.HatchStyle.Cross,
            System.Drawing.Drawing2D.HatchStyle.DarkHorizontal,
            System.Drawing.Drawing2D.HatchStyle.SmallGrid,
            System.Drawing.Drawing2D.HatchStyle.DarkVertical

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // die Farben initialisieren
            hinterGrundFarbe = panelHintergrundFarbe.BackColor;
            linienFarbe = panelLinieColor.BackColor;
            //die Zeichenfläsche im Steuerelement initialisieren, wo die Figuren gezeichnet werden 
            zeichenFlaesche = panelMuster.CreateGraphics();
            //die Linienstile im Steuerelement setzen
            foreach (System.Drawing.Drawing2D.DashStyle element in linienstil)
                listBoxLinieStil.Items.Add("");
            //die Musterstile im Steuerelement setzen
            foreach (System.Drawing.Drawing2D.HatchStyle element in hinterGrundStil)
                listBoxHintergrundStil.Items.Add("");
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            //die Zeichenfläsche zurücksetzen
            zeichenFlaesche.Clear(panelMuster.BackColor);
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            //die Anwendung schließen
            Close();
        }

        private void buttonLos_Click(object sender, EventArgs e)
        {           
            int groesse = 0; // für die Größe der Figuren
            int richtungKlein = -1, richtungGross = 1, abstand = 5; // für die Vergrößern, Verkleinern und Abstand der Figuren initialisieren
            bereich = panelMuster.ClientRectangle; // der Feld - Bereich im Steuerelement initialisieren, wo die Figuren angezeigt werden
            aufrufe = Convert.ToInt32(numericUpDownAufrufe.Value); //für die Anzahl der Wiederholungen
            timer1.Interval = Convert.ToInt32(numericUpDownSpeed.Value); // für die Geschwindigkeit der Animation
            Pen stift = new Pen(linienFarbe); //einen neuen Stift mit dem entschprehender Farbe erzeugen
            SolidBrush pinsel = new SolidBrush(hinterGrundFarbe); //der Pinsel und die Farbe erzeugen
            if (listBoxLinieStil.SelectedIndex >= 0)
                stift.DashStyle = linienstil[listBoxLinieStil.SelectedIndex];
            //die Dicke des Stiftes erzeugen       
            stift.Width = Convert.ToInt32(numericUpDownLinieStaerke.Value);
            //die Größe der Figur setzen
            switch (trackBarGroesse.Value)
            {
                case 1:
                    groesse = 125;
                    break;
                case 2:
                    groesse = 100;
                    break;
                case 3:
                    groesse = 75;
                    break;
            }
            //Figur ermitteln 
            //beim Kreis und beim Rechteck auch die Füllung 
            if (radioButtonKreis.Checked == true)
            {
                zeichenFlaesche.Clear(panelMuster.BackColor);//die Zeichenfäsche zurücksetzen

                if (radioButtonHintergrundOhne.Checked == true)
                    //die Figur-Kreis animieren
                    //die Figur verkleinern
                    for (int wiederholung = 0; wiederholung < aufrufe; wiederholung++)
                    {
                        bereich.Width += richtungKlein * (abstand * 2);
                        bereich.Height += richtungKlein * (abstand * 2);
                        bereich.Location = new Point(bereich.Location.X - (richtungKlein * abstand), bereich.Location.Y - (richtungKlein * abstand));
                        zeichenFlaesche.DrawEllipse(stift, bereich);
                        System.Threading.Thread.Sleep(timer1.Interval);
                        zeichenFlaesche.Clear(panelMuster.BackColor);
                    }
                //die Figur vergrößern
                for (int wiederholung = 0; wiederholung < aufrufe; wiederholung++)
                {
                    bereich.Width += richtungGross * (abstand * 2);
                    bereich.Height += richtungGross * (abstand * 2);
                    bereich.Location = new Point(bereich.Location.X - (richtungGross * abstand), bereich.Location.Y - (richtungGross * abstand));
                    zeichenFlaesche.DrawEllipse(stift, bereich);
                    System.Threading.Thread.Sleep(timer1.Interval);
                    zeichenFlaesche.Clear(panelMuster.BackColor);

                }
                //die Figur-Kreis ohne animation zeichnen
                zeichenFlaesche.DrawEllipse(stift, panelMuster.ClientRectangle.Left + groesse, panelMuster.ClientRectangle.Top + groesse, panelMuster.ClientRectangle.Width - (groesse * 2), panelMuster.ClientRectangle.Height - (groesse * 2));


                if (radioButtonHintergrundFarbe.Checked == true)
                //den Kreis mit Farbe füllen
                    zeichenFlaesche.FillEllipse(pinsel, panelMuster.ClientRectangle.Left + groesse, panelMuster.ClientRectangle.Top + groesse, panelMuster.ClientRectangle.Width - (groesse * 2), panelMuster.ClientRectangle.Height - (groesse * 2));

                    if (radioButtonHintergrundMuster.Checked == true && listBoxHintergrundStil.SelectedIndex >= 0)
                    //den Kreis mit Muster füllen
                    {
                        System.Drawing.Drawing2D.HatchBrush musterPinsel = new System.Drawing.Drawing2D.HatchBrush(hinterGrundStil[listBoxHintergrundStil.SelectedIndex], stift.Color, Color.White);
                        zeichenFlaesche.FillEllipse(musterPinsel, panelMuster.ClientRectangle.Left + groesse, panelMuster.ClientRectangle.Top + groesse, panelMuster.ClientRectangle.Width - (groesse * 2), panelMuster.ClientRectangle.Height - (groesse * 2));
                    }
            }
            if (radioButtonRechteck.Checked == true)
            {
                zeichenFlaesche.Clear(panelMuster.BackColor);//die Zeichenfläsche zurücksetzen
                if (radioButtonHintergrundOhne.Checked == true)
                    //die Figur-Rechecke animieren
                    //die Figur verkleinern
                    for (int wiederholung = 0; wiederholung < aufrufe; wiederholung++)
                    {
                        bereich.Width += richtungKlein * (abstand * 2);
                        bereich.Height += richtungKlein * (abstand * 2);
                        bereich.Location = new Point(bereich.Location.X - (richtungKlein * abstand), bereich.Location.Y - (richtungKlein * abstand));
                        zeichenFlaesche.DrawRectangle(stift, bereich);
                        System.Threading.Thread.Sleep(timer1.Interval);
                        zeichenFlaesche.Clear(panelMuster.BackColor);
                    }
                //die Figur vergrößern
                for (int wiederholung = 0; wiederholung < aufrufe; wiederholung++)
                {
                    bereich.Width += richtungGross * (abstand * 2);
                    bereich.Height += richtungGross * (abstand * 2);
                    bereich.Location = new Point(bereich.Location.X - (richtungGross * abstand), bereich.Location.Y - (richtungGross * abstand));
                    zeichenFlaesche.DrawRectangle(stift, bereich);
                    System.Threading.Thread.Sleep(timer1.Interval);
                    zeichenFlaesche.Clear(panelMuster.BackColor);

                }
                //die Figur-Rechecke ohne animation zeichnen
                zeichenFlaesche.DrawRectangle(stift, panelMuster.ClientRectangle.Left + groesse, panelMuster.ClientRectangle.Top + groesse, panelMuster.ClientRectangle.Width - (groesse * 2), panelMuster.ClientRectangle.Height - (groesse * 2));
                //die Rechtecke mit Farbe füllen
                if (radioButtonHintergrundFarbe.Checked == true)

                    zeichenFlaesche.FillRectangle(pinsel, panelMuster.ClientRectangle.Left + groesse, panelMuster.ClientRectangle.Top + groesse, panelMuster.ClientRectangle.Width - (groesse * 2), panelMuster.ClientRectangle.Height - (groesse * 2));
                //die Rechtecke mit Muster füllen
                if (radioButtonHintergrundMuster.Checked == true && listBoxHintergrundStil.SelectedIndex >= 0)                   
                {
                    System.Drawing.Drawing2D.HatchBrush musterPinsel = new System.Drawing.Drawing2D.HatchBrush(hinterGrundStil[listBoxHintergrundStil.SelectedIndex], stift.Color, Color.White);
                    zeichenFlaesche.FillRectangle(musterPinsel, panelMuster.ClientRectangle.Left + groesse, panelMuster.ClientRectangle.Top + groesse, panelMuster.ClientRectangle.Width - (groesse * 2), panelMuster.ClientRectangle.Height - (groesse * 2));
                }

            }
            if (radioButtonLinie.Checked == true)
            {
                //eine Linie animieren
                for (int wiederholung = 0; wiederholung < aufrufe; wiederholung++)
                {
                    zeichenFlaesche.DrawLine(stift, panelMuster.ClientRectangle.Left + groesse, panelMuster.ClientRectangle.Height / 2, panelMuster.ClientRectangle.Width - groesse, panelMuster.ClientRectangle.Height / 2);
                    System.Threading.Thread.Sleep(timer1.Interval);
                    zeichenFlaesche.Clear(panelMuster.BackColor);
                }
                //eine Linie zeichnen
                zeichenFlaesche.DrawLine(stift, panelMuster.ClientRectangle.Left + groesse, panelMuster.ClientRectangle.Height / 2, panelMuster.ClientRectangle.Width - groesse, panelMuster.ClientRectangle.Height / 2);

            }


        }

        private void buttonLinieFarbe_Click(object sender, EventArgs e)
        {
            //Den Dialog zum Linienfarben auswahl anzeigen
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelLinieColor.BackColor = colorDialog1.Color;
                linienFarbe = colorDialog1.Color;
            }
        }

        private void buttonHintergrundFarbe_Click(object sender, EventArgs e)
        {
            //Den Dialog zum Hintergrundfarben auswahl anzeigen
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                panelHintergrundFarbe.BackColor = colorDialog2.Color;
                hinterGrundFarbe = colorDialog2.Color;
                radioButtonHintergrundFarbe.Checked = true;
            }
        }

        private void listBoxLinieStil_DrawItem(object sender, DrawItemEventArgs e)
        {
            //eine lokale Variable für die Berechnung der Mitte
            int y;
            //ein neuer lokale Stift
            Pen BoxStift = new Pen(Color.Black);
            //die mitte Berechnen
            y = (e.Bounds.Top + e.Bounds.Bottom) / 2;
            //den Hintergrund setzen
            e.DrawBackground();
            //und die Linie
            BoxStift.Width = 5;
            BoxStift.DashStyle = linienstil[e.Index];
            e.Graphics.DrawLine(BoxStift, e.Bounds.Left + 1,y, e.Bounds.Right - 1, y);
        }

        private void listBoxHintergrundStil_DrawItem(object sender, DrawItemEventArgs e)
        {
            System.Drawing.Drawing2D.HatchBrush boxPinsel = new System.Drawing.Drawing2D.HatchBrush(hinterGrundStil[e.Index], Color.Black, Color.White);
            //den Hintergrund setzen
            e.DrawBackground();
            //die Muster
            e.Graphics.FillRectangle(boxPinsel, e.Bounds.Left + 1, e.Bounds.Top + 1, e. Bounds.Width - 1, e.Bounds.Height - 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
