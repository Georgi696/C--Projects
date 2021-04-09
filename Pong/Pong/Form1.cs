using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        private struct Spielball
        {
            //die Felder
            //eine Struktur für die richtung des Balls
            //wenn die richtung auf True ist geht der Ball nach oben,bzw nach rechts, sonst nach unten bzw nach lins 
            public bool richtungX;
            public bool richtungY;
            //für die veränderung des bewegungswinkels
            public int winkel;
        }
        //für die zeichenfläsche
        private Graphics zeichenflaesche;
        //für das spelfeld
        private Rectangle spielfeldGroesse;
        //für die Rechtecke des spielfeldes
        private int spielfeldMinX, spielfeldMaxX, spielfeldMinY, spielfeldMaxY;

        private int spielfeldLinienBreite;
        //für den Schläger grösse
        private int schlaegerGrösse;
        //für den Ballposition
        private Spielball ballPosition;
        //zum zeichnen
        private SolidBrush pinsel;
        //für die spiel Pause
        private bool spielPause;
        //für die verbleibende Spielzeit
        private int aktueleSpielzeit;
        //neuer schrift
        private Font schrift;

        private Score spielpunkten;
        //für die Punkten
        private int punkteMehr, punkteWeniger;
        //für die veränderung des winkels
        private int winkelZufall;

        private void spielfeld_Paint(object sender, PaintEventArgs e)
        {
            zeichneSpielfeld();
        }

        public Form1()
        { 
            InitializeComponent();
            //die Breite der Linie
            spielfeldLinienBreite = 10;
            //die Größe des Schlägers
            schlaegerGrösse = 50;
            //erst einmal geht der Ball nach recht und oben
            ballPosition.richtungX = true;
            ballPosition.richtungY = true;
            ballPosition.winkel = 0;
            //den Pinsel erzeugen
            pinsel = new SolidBrush(Color.Black);
            //di Zeichenfläsche erzeugen
            zeichenflaesche = spielfeld.CreateGraphics();
            //das Spielfeld bekommt einen Schwarzen hintergrund
            spielfeld.BackColor = Color.Black;
            //die Spiel pause auf true setzen
            spielPause = true;
            //für die Spielzeit mit TimerSpiel-Interval zuweisen
            schrift = new Font("Arial", 12, FontStyle.Bold);
            spielpunkten = new Score();
            setzeSpielfeld();
            NeuerBall();
            //die werte für die neue Felder zuweisen
            punkteMehr = 1;
            punkteWeniger = -5;
            winkelZufall = 5;

        }

        private void Schwierigkeitsgrad(int Schlaeger,int mehr,int weniger,int winkel)
        {
            schlaegerGrösse = Schlaeger;
            punkteMehr = mehr;
            punkteWeniger = weniger;
            winkelZufall = winkel;

        }

        private void setzeSpielfeld()
        {
            spielfeldGroesse = spielfeld.ClientRectangle;
            //die minimalen und maximalen Ränder festlegendabei werden die linien berücksichtigt
            spielfeldMaxX = spielfeldGroesse.Right - spielfeldLinienBreite;
            //den linen rand verschieben wir mit einen Pixel nach rechts
            spielfeldMinX = spielfeldGroesse.Left + spielfeldLinienBreite + 1;
            spielfeldMaxY = spielfeldGroesse.Bottom - spielfeldLinienBreite;
            spielfeldMinY = spielfeldGroesse.Top + spielfeldLinienBreite;
        }

        private void zeichneSpielfeld()
        {
            
                //die weißen begrenzungen
                pinsel.Color = Color.White;
                //ein Rechteck oben(links)
                zeichenflaesche.FillRectangle(pinsel, 0, 0, spielfeldMaxX, spielfeldLinienBreite);
                //ein Rechteck rechts(oben)
                zeichenflaesche.FillRectangle(pinsel, spielfeldMaxX, 0, spielfeldLinienBreite,
                    spielfeldMaxY + spielfeldLinienBreite);
                //und noch eins unten
                zeichenflaesche.FillRectangle(pinsel, 0, spielfeldMaxY, spielfeldMaxX, spielfeldLinienBreite);
                //und eine graue linie in der mitte zeichen
                pinsel.Color = Color.Gray;
                zeichenflaesche.FillRectangle(pinsel, spielfeldMaxX / 2, spielfeldMinY, spielfeldLinienBreite,
                    spielfeldMaxY - spielfeldLinienBreite);
            
        }

        private void schlaeger_MouseMove(object sender, MouseEventArgs e)
        {
            //für die bewegung des schlägers
            if (e.Button == MouseButtons.Left)
                ZeichneSchlaeger(e.Y + schlaeger.Top);
            if (spielPause == true)
                return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int neuX, neuY;
            //abhängig von der Bewegungsrichtung die koordinaten neu setzen
            if (ballPosition.richtungX == true)
                neuX = ball.Left + 10;
            else
                neuX = ball.Left - 10;
            if (ballPosition.richtungY == true)
                neuY = ball.Top - ballPosition.winkel;
            else
                neuY = ball.Top + ballPosition.winkel;
            //den Ball neu Zeichnen
            ZeichneBall(new Point(neuX, neuY));
        }

        //die Position des Balls setzen
        private void ZeichneBall (Point position)
        {
            //für die zufallzahl
            Random zufall = new Random();
            ball.Location = position;
            //wenn der ball rechts anstoßt ändern wir die richtung
            if ((position.X + 10) >= spielfeldMaxX)
                ballPosition.richtungX = false;
            //stoßst er unten bzw. oben an, ebenfalls
            if ((position.Y + 10) >= spielfeldMaxY)
                ballPosition.richtungY = true;
            else
                if (position.Y <= spielfeldMinY)
                    ballPosition.richtungY = false;
            //ist der wieder links prüfen wir ob der schläger in der nähe ist
            if ((position.X == spielfeldMinX) && 
                (schlaeger.Top <= position.Y) && 
                (schlaeger.Bottom >= position.Y))
            {
                if (ballPosition.richtungX == false)
                    //einen punkt dazu rechnen
                    ZeichnePunkte(Convert.ToString(spielpunkten.VeraenderePunkte(punkteMehr)));
                //die richtung ändern
                ballPosition.richtungX = true;
                //und der zufall winkel
                ballPosition.winkel = zufall.Next(winkelZufall);
            }
            if(position.X < spielfeldMinX)
            {
                //wenn der ball hinter dem schläger ist 5 Punkten abziehn
                ZeichnePunkte(Convert.ToString(spielpunkten.VeraenderePunkte(punkteWeniger)));
                //eine kurze pause einlegen
                System.Threading.Thread.Sleep(1000);
                //und alles von vorne
                ZeichneBall(new Point(spielfeldMinX, position.Y));
                ballPosition.richtungX = true;
            }
        }

        private void timerSekunde_Tick(object sender, EventArgs e)
        {
            //eine sekunde abziehen
            aktueleSpielzeit = aktueleSpielzeit - 1;
            //die restzeit ausgeben
            ZeichneZeit(Convert.ToString(aktueleSpielzeit));

        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zuerst prüfen wir ob das spiel läuft
            if(spielPause == false)
            {
                //aller timer anhalten
                timerBall.Enabled = false;
                timerSpiel.Enabled = false;
                timerSekunde.Enabled = false;
                //die markierung im menü einschalten
                pauseToolStripMenuItem.Checked = true;
                //den text in der titelliste ändern
                this.Text = "Pong - Das Spiel ist angehalten";
                //die pause einschalten
                spielPause = true;
            }
            else
            {
                //das interval für die verbleibende spielzeit ändern
                timerSpiel.Interval = aktueleSpielzeit * 1000;
                //aller timer einschalten
                timerBall.Enabled = true;
                timerSpiel.Enabled = true;
                timerSekunde.Enabled = true;
                //die markierung im menü abschalten
                pauseToolStripMenuItem.Checked = false;
                this.Text = "Pong";
                //die pause ausschalten
                spielPause = false;
            }
        }

        //die Y-Position des Schlägers
        private void ZeichneSchlaeger (int y)
        {
            //befindet sich der schläger im spielfeld?
            if(((y + schlaegerGrösse) < spielfeldMaxY) && (y > spielfeldMinY))
                schlaeger.Top = y;
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //läuft ein Spiel? Dann erst einmal pausieren
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                //den Dialog anzeigen 
                NeuesSpiel();
                //und weiter spielen
                pauseToolStripMenuItem_Click(sender, e);
            }
            //wenn kein Spiel läuft starten wir ein neues
            //wenn im dialog auf ja geklickt wird
            if (NeuesSpiel() == true)
                pauseToolStripMenuItem_Click(sender, e);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerSpiel_Tick(object sender, EventArgs e)
        {
            //Das Spiel anhalten
            pauseToolStripMenuItem_Click(sender, e);
            //eine meldung anzeigen
            MessageBox.Show("Die Zeit ist rum", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //abfrage ob ein neues Spiel gestartet werden soll
            if (NeuesSpiel() == true)
                pauseToolStripMenuItem_Click(sender, e);
            else
                beendenToolStripMenuItem_Click(sender, e);
        }

        //die Einstellungen für einen neuen ball und schlaeger setzen
        private void NeuerBall()
        {
            
            //die Größe des Balles setzen
            ball.Width = 10;
            ball.Height = 10;
            //die Größe des Schlägers setzen
            schlaeger.Width = spielfeldLinienBreite;
            schlaeger.Height = schlaegerGrösse;
            //beide Panels in Weiß setzen
            ball.BackColor = Color.White;
            schlaeger.BackColor = Color.White;
            //den schlaeger Positionieren links an der Rand
            schlaeger.Left = 2;
            //ungefär in der mitte
            ZeichneSchlaeger((spielfeldMaxY / 2) - schlaegerGrösse / 2);
            //der Ball kommt vor den schläger ungefähr in der mitte
            ZeichneBall(new Point(spielfeldMinX, spielfeldMaxY / 2));
        }
        //für die schwierigkeitsgrad jeweils 5 einträge
        private void sehrEinfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //für den timer.interval
            timerBall.Interval = 200;
            //die einstellungen setzen
            Schwierigkeitsgrad(100, 1, -20, 2);
            sehrEinfachToolStripMenuItem.Checked = true;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void einfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //für den timer.interval
            timerBall.Interval = 100;
            //die einstellungen setzen
            Schwierigkeitsgrad(50, 1, -5, 5);
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = true;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;

        }

        private void mittelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //für den timer.interval
            timerBall.Interval = 50;
            //die einstellungen setzen
            Schwierigkeitsgrad(50, 3, -5, 15);
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = true;
            schwerToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;

        }

        private void schwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //für den timer.interval
            timerBall.Interval = 10;
            //die einstellungen setzen
            Schwierigkeitsgrad(50, 10, -5, 25);
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = true;
            sehrSchwerToolStripMenuItem.Checked = false;

        }

        private void sehrSchwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //für den timer.interval
            timerBall.Interval = 25;
            //die einstellungen setzen
            Schwierigkeitsgrad(20, 20, -5, 40);
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            schwerToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = true;

        }

        private void spielfeldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point neueGroesse = new Point(0, 0);
            //der zugriff  ins Formular "Einstellungen" erschaffen 
            EinstellungenDIalog neueWerte = new EinstellungenDIalog();
            
            if (neueWerte.ShowDialog() == DialogResult.OK)
            {
                //die neue groesse holen
                neueGroesse = neueWerte.LieferWerte();
                //das Formular schließen
                neueWerte.Close();  
                //das Formular ändern
                this.Width = neueGroesse.X;
                this.Height = neueGroesse.Y;
                //neu Ausrichten
                this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
                this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                //die zeichenfläsche neu beschaffen 
                zeichenflaesche = spielfeld.CreateGraphics();
                //das Spielfeld neu setzen
                setzeSpielfeld();
                //zeichenfläche löschen 
                zeichenflaesche.Clear(spielfeld.BackColor);
                //und einen neuen Ball und Schläger zeichen
                neueWerte.NeuerBall();
                //das spielfeld neu zeichnen
                zeichneSpielfeld();
            }

        }

        private void druckenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        //die bestenliste
        private void bestenListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zur unterscheidung zwiechen einem laufendem und einem nicht gestarteten spiel
            bool weiter = false;
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                weiter = true;
            }
            //ball und schläger verstecken
            ball.Hide();
            schlaeger.Hide();
            //die Liste ausgeben
            spielpunkten.ListeAusgabe(zeichenflaesche, spielfeldGroesse);
            //funf sekunden warten
            System.Threading.Thread.Sleep(5000);
            //die zeichenfläsche löschen
            zeichenflaesche.Clear(spielfeld.BackColor);
            //ball und schläger wieder anzeigen
            ball.Show();
            schlaeger.Show();
            //das spiel wieder fortsetzen, wenn wir es angehalten haben
            if (weiter == true)
                pauseToolStripMenuItem_Click(sender, e);
        }

        private void ZeichneZeit(string restzeit)
        {
            //zuerst die alte anzeige überschreiben
            pinsel.Color = spielfeld.BackColor;
            zeichenflaesche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 20, 30, 20);
            //in weißer schrift
            pinsel.Color = Color.White;
            //das Zeichnen der Spielzeit
            zeichenflaesche.DrawString(restzeit, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 20));
           
        }
        //erzeugt einen dialog und liefert das ergebnis zurück
        private bool NeuesSpiel()
        {
            bool ergebnis = false;
            if (MessageBox.Show("Neues Spiel starten?","Neues Spiel",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //die Spielzeit neue setzen
                aktueleSpielzeit = 120;
                //alles neue Zeichnen
                zeichneSpielfeld();
                NeuerBall();
                ZeichneZeit(Convert.ToString(aktueleSpielzeit));
                spielpunkten.LoeschePunkte();
                ZeichnePunkte("0");
                pauseToolStripMenuItem.Enabled = true;
                ergebnis = true;
            }
            return ergebnis;

        }
        //Die Punkten ausgeben bzw. zeichnen
        private void ZeichnePunkte(string punkte)
        {
            
            pinsel.Color = spielfeld.BackColor;
            zeichenflaesche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 40, 30, 20);
            pinsel.Color = Color.White;
            zeichenflaesche.DrawString(punkte,schrift,pinsel,new Point(spielfeldMaxX - 50, spielfeldMinY + 40));
        }
        
    }
    
}
