using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    //die Klase für die Liste
    //sie muss die Schnittstelle IComparable implementieren 
    internal class Liste : IComparable
    {
        //die Fleder
        private int ListePunkte;
        private string ListeName;

        //die Methoden und der Konstruktor
        public Liste()
        {
            //er setz die Punkten und der Listennamen auf standartwerte
            ListePunkte = 0;
            ListeName = "Nobody";
        }
        //die Vergleichsmethode
        public int CompareTo(object objekt)
        {
            Liste tempListe = (Liste)(objekt);
            if (this.ListePunkte < tempListe.ListePunkte)
                return 1;
            if (this.ListePunkte > tempListe.ListePunkte)
                return -1;
            else
                return 0;
        }
        //die Methode zum Setzen von einträgrn
        public void SetzeEintrag (int punkte,string name)
        {
            ListePunkte = punkte;
            ListeName = name;
        }
        //die Methode um liesfern der Punkte
        public int GetPunkte()
        {
            return ListePunkte;
        }
        //die Methode zum liefern der Namen
        public string GetName()
        {
            return ListeName;
        }
    }

    internal class Score
    {
        //Die Felder
        private int punkte;
        private int anzahl = 10;
        private Liste[] bestenListe;

        public Score()
        {
            bestenListe = new Liste[anzahl];
            for (int i = 0; i < anzahl; i++)
                bestenListe[i] = new Liste();
            punkte = 0;
        }
        //zum verändern der punkten
        public int VeraenderePunkte(int anzahl)
        {
            punkte += anzahl;
            return punkte;
        }
        //zum zurücksetzen der punkte
        public void LoeschePunkte()
        {
            punkte = 0;
        }
        public bool NeuerEintrag()
        {
            string tempName = String.Empty;
            //wenn die akltuelle punktzahl größer ist als der letzte eintrag der Liste,
            //wird der letze eintrag überschrieben und neu Sortirert
            if (punkte > bestenListe[anzahl - 1].GetPunkte())
            { 
            NameDialog neueName = new NameDialog();
            if (neueName.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tempName = neueName.LieferName();
            neueName.Close();
                bestenListe[anzahl - 1].SetzeEintrag(punkte, tempName);
                Array.Sort(bestenListe);
                return true;
            }
            else
            return false;
        }
        public void ListeAusgabe(System.Drawing.Graphics zeichenflaeche,System.Drawing.RectangleF flaesche)
        {
            //ein Temporär Pinsel erzeugen
            System.Drawing.SolidBrush tempPinsle = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            //die schriftart setzen
            System.Drawing.Font tempSchrift = new System.Drawing.Font("Arial", 12,System.Drawing.FontStyle.Bold);

            //für die zentrierte ausgabe
            System.Drawing.StringFormat ausrichtung = new System.Drawing.StringFormat();
            //Koordinaten für die ausgabe
            float punkteX, nameX, y;
            punkteX = flaesche.Left + 50;
            nameX = flaesche.Left + 250;
            y = flaesche.Top + 50;
            //die ausrichtung ist zentriert
            ausrichtung.Alignment = System.Drawing.StringAlignment.Center;
            //die zeichenflaeche löschen
            zeichenflaeche.Clear(System.Drawing.Color.Black);
            //den Titel ausgeben
            zeichenflaeche.DrawString("Bestenliste", tempSchrift, tempPinsle, flaesche.Width / 2, y , ausrichtung);
            //und nun die liste selbst
            for (int i = 0;i < anzahl; i++)
            {
                y += 20;
                zeichenflaeche.DrawString(Convert.ToString(bestenListe[i].GetPunkte()), tempSchrift, tempPinsle, punkteX, y);
                zeichenflaeche.DrawString(Convert.ToString(bestenListe[i].GetName()), tempSchrift, tempPinsle, nameX, y);

            }
        }
    }
}
