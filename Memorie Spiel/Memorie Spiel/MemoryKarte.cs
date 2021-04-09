using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace Memorie_Spiel
{
    //die Classe für eine karte des Memory Spiels
    //Sie erbd von Button
    class MemoryKarte : Button
    {
        //eine eindeuteige ID zur Identiefizierung des Bildes
        int bildID;
        //für die Vorder und Rückseite
        Image bildVorne, bildHinten;

        //wo liegt die KArte im Spielfeld?
        int bildPos;

        //ist die Karte umgedreht?
        bool umgedreht;
        //ist die Karte noch im Spiel
        bool nochImSpiel;

        //für das Spielfeld für die Karte
        MemoryFeld spiel;

        public bool NochImSpiel()
        {
                return nochImSpiel;
        }

        public bool Umgedreht()
        {   
                return umgedreht;   
        }

        //der Konstruktor er setzt die Große, die Bilder und die Position
        public MemoryKarte(string vorne, int bildID, MemoryFeld spiel)
        {
            //die Vorderseite, der Dateinamen des Bildes wird an der Konstruktor übergeben
            bildVorne = new Image();
            bildVorne.Source = new BitmapImage(new Uri(vorne, UriKind.Relative));
            //die rückseite sie wird fest gesetzt
            bildHinten = new Image();
            bildHinten.Source = new BitmapImage(new Uri("pics/verdeckt.bmp",UriKind.Relative));
            //die eigenschaften zuweißen
            Content = bildHinten;
            //die Bild ID
            this.bildID = bildID;
            //die Karte ist erst einmal umgedreht und noch im feld
            umgedreht = false;
            nochImSpiel = true;
            //mit dem Spielfeld verbinden
            this.spiel = spiel;
            //die methode mit dem ereignis verbinden
            Click += new RoutedEventHandler(ButtonClick);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            //ist die Karte noch im spiel?
            if ((nochImSpiel == false) || (spiel.ZugErlaubt() == false))
                return;
            //if die rückseite zu sehen ist die Vorder seite anzeigen 
            if(umgedreht == false)
            {
                Content = bildVorne;
                umgedreht = true;
                //die Methode Karteöffnen im Spielfeld aufrufen, übergeben wird die Karte also "this" referenz
                spiel.KarteOeffen(this); 
            }
        }

        //die Methode zeigt die rückseite der Karte an
        public void RückseiteZeigen(bool rausnehmen)
        {
            //soll die Karte komplett aus dem Spiel rausgenommen werden
            if (rausnehmen == true)
            {
                //das Bild aufgedreht zeigen und die Karte aus dem Spiel raus nehmen
                Image bildRausgenommen = new Image();
                bildRausgenommen.Source = new BitmapImage(new Uri("pics/aufgedeckt.bmp", UriKind.Relative));
                Content = bildRausgenommen;
                nochImSpiel = false;
            }
            else
            {
                //sonst nur die Rückseite zeigen
                Content = bildHinten;
                umgedreht = false;
            }
        }
        
        //die Methode liefert ein BIld einer Karte
        public int getBild()
        {
            return bildID;
        }
        //die Methode liefert die Position eine Karte
        public int getBildPos()
        {
            return bildPos;
        }
        //die Methode setzt die Position einer Karte
        public void setBildPos(int bildPos)
        {
            this.bildPos = bildPos;
        }
        //Die Methode liefert den Wert des Felds umgedreht
        public bool IsUmgedreth()
        {
            return umgedreht;
        } 
        //Die Methode liefert den Wert des Felds nochImSpiel
        public bool IsNochImSpiel()
        {
            return nochImSpiel;
        }
        //die Methode zeigt die Vorderseite der Karte an
        public void VorderSeiteZeigen()
        {
            Content = bildVorne;
            umgedreht = true;
        } 
    }
}
