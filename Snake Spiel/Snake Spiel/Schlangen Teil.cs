using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Snake_Spiel
{
    class Schlangen_Teil
    {
        //die Felder 
        //Die Position
        protected Point position;
        //die alte Position
        protected Point altePosition;
        //die Farbe;
        protected Color farbe;
        //die Form
        protected Rectangle quadrat;
        //die Grösse
        protected int groesse;

        //Die Methoden
        //der Konstruktor zum setzen der Position und die Farbe
        public Schlangen_Teil(Point position, Color farbe)
        {
            this.position.X = position.X;
            this.position.Y = position.Y;
            //alte und neue position sind erstmals identisch
            altePosition.X = position.X;
            altePosition.Y = position.Y;
            //die farbe setzen
            this.farbe = farbe;
            //die Grösse setzen
            groesse = 20;
            //ein neues rechteck
            quadrat = new Rectangle();
        }

        //eine leere Methode zum Bewegen
        //siw wird in der abgeleitete Klasse überschrieben
        public virtual void Bewegen(int richtung)
        {
        }

        //die neue Position setzen
        public void SetzePosition(Point neuePosition)
        {
            //die alte Position speichern
            altePosition = position;
            position = neuePosition;
        }

        //das Teil anzeigen
        public void ZeichnenTeil(Canvas meinCanvas)
        {
            //das Quadrat löschen
            meinCanvas.Children.Remove(quadrat);
            //positionieren
            Canvas.SetLeft(quadrat, position.X);
            Canvas.SetTop(quadrat, position.Y);
            //die Grösse setzen
            quadrat.Width = groesse;
            quadrat.Height = groesse;
            //farbe und Ramen setzen
            SolidColorBrush fullung = new SolidColorBrush(farbe);
            quadrat.Fill = fullung;
            SolidColorBrush rahmen = new SolidColorBrush(Colors.AntiqueWhite);
            quadrat.Stroke = rahmen;
            //wieder hinzufügen
            meinCanvas.Children.Add(quadrat);
        }

        //die alte Position liefern
        public Point LieferAltePosition()
        {
            return altePosition;
        }

        //die Grösse liefern
        public int LieferGroesse()
        {
            return groesse;
        }

        //die Position lifern
        public virtual Point LieferNeuePosition()
        {
            return position;
        }
    }
}
