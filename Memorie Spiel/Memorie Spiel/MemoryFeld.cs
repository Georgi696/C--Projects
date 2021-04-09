using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace Memorie_Spiel
{
    class MemoryFeld
    {
        //das Array für die Karten
        MemoryKarte[] karten;

        //das Array für die Namen der Grafiken
        string[] bilder =
        {"pics/apfel.bmp", "pics/birne.bmp","pics/blume.bmp",
        "pics/blume2.bmp","pics/ente.bmp","pics/fisch.bmp","pics/fuchs.bmp",
        "pics/igel.bmp","pics/kaenguruh.bmp","pics/katze.bmp","pics/kuh.bmp",
        "pics/maus1.bmp","pics/maus2.bmp","pics/maus3.bmp","pics/maus4.bmp",
        "pics/melone.bmp","pics/pilz.bmp","pics/ronny.bmp","pics/schmetterling.bmp",
        "pics/sonne.bmp","pics/wolke.bmp"};

        //für die Punkte
        int menschPunkte, computerPunkte;
        Label menschPunkteLabel, computerPunkteLabel;

        //wie viele Karten sind aktuel umgedreht
        int umgedrehteKarten;

        //für das aktuell umdrehte Paar
        MemoryKarte[] paar;

        //für den aktuellen Spieler
        int spieler;

        //das "Gedächtnis" für den Conputer er speichert hier wo das Gegenstück liegt
        int[,] gemerkteKarten;

        //für das eigentliche Spielfeld
        UniformGrid feld;

        //für die zufälligezahlen
        Random zufallZahl = new Random();

        //der Timer setzen
        DispatcherTimer timer;

        Button schummel;

        //der Konstruktor
        public MemoryFeld(UniformGrid feld)
        {
            //zum Zählen für die Bilder
            int count = 0;

            //das Array für die Karten erstellen insgesamt 42
            karten = new MemoryKarte[42];

            //für das Paar
            paar = new MemoryKarte[2];

            //für das Gedächtnis er speichert für jede Karte paarweise die Position im spielfeld
            gemerkteKarten = new int[2, 21];

            //keiner hat zu beginn punkte
            menschPunkte = 0;
            computerPunkte = 0;

            //es sind keine Karte umgedreht
            umgedrehteKarten = 0;

            //der Mensch fängt an
            spieler = 0;

            //das Spielfeld setzen 
            this.feld = feld;


            //es gibt keine gemerkte Karten
            for (int aussen = 0; aussen < 2; aussen++)
                for (int innen = 0; innen < 21; innen++)
                    gemerkteKarten[aussen, innen] = -1;

            //das eigentliche Spielfeld erstellen 
            for (int i = 0; i <= 41; i++)
            {
                //eine neue Karten erzeugen
                karten[i] = new MemoryKarte(bilder[count], count, this);
                //die Position der Karte setzen 
                //bei jeder zweiten Karten kommt auch ein neues Bild
                if ((i + 1) % 2 == 0)
                    count++;
            }
            //die Karten mischen
            for (int i = 0; i <= 41; i++)
            {
                int temp1;
                MemoryKarte temp2;
                //eine zufällige zahl von 0 bis 41 erzeugen
                temp1 = zufallZahl.Next(42);
                //den alten wert in sicherheit bringen
                temp2 = karten[temp1];
                //die werte tauchen
                karten[temp1] = karten[i];
                karten[i] = temp2;
            }
            //die karten ins spielfeld bringen
            for (int i = 0; i <= 41; i++)
            {
                //die Position der Karte setzen
                karten[i].setBildPos(i);
                //die Karte hinzufügen
                feld.Children.Add(karten[i]);
            }
            //die Labels für die Punkte
            Label mensch = new Label();
            mensch.Content = "Mensch";
            feld.Children.Add(mensch);
            menschPunkteLabel = new Label();
            menschPunkteLabel.Content = 0;
            feld.Children.Add(menschPunkteLabel);

            Label computer = new Label();
            computer.Content = "Computer";
            feld.Children.Add(computer);
            computerPunkteLabel = new Label();
            computerPunkteLabel.Content = 0;
            feld.Children.Add(computerPunkteLabel);

            schummel = new Button();
            schummel.Content = "Schummel";
            feld.Children.Add(schummel);
            schummel.IsEnabled = true;
            schummel.Click += Schummel_Click;

            //der Timer initialisieren
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(2000);
            timer.Tick += Timer_Tick;
        }
        

        private void Schummel_Click(object sender, RoutedEventArgs e)
        {
            schummel.IsEnabled = false;
            if (spieler == 0 || umgedrehteKarten == 0)
            {
                schummel.IsEnabled = true;
                timer.Start();
                Random zuffalzahl = new Random();
                int zuffal = 0;

                zuffal = zuffalzahl.Next(42);
                karten[zuffal].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                //di Vorder seite zeigen
                karten[zuffal].VorderSeiteZeigen();
                //und karten öffnen
                AlleKarteOpen(karten[zuffal]);
            }
            
        }
       
        public void AlleKarteOpen(MemoryKarte karte)
        {
            int kartenID, kartenPos;

            kartenID = karte.getBild();
            kartenPos = karte.getBildPos();
        }

        //die Methode liefert ob züge des Menschen erlaubt sind die rückgabe ist false wenn gerade der Computer 
        //zieht oder wenn schon 2 karten umgedrehet sind sonst ist die rückgabe true
        public bool ZugErlaubt()
        {
            bool erlaubt = true;
            //zieht der Computer
            if (spieler == 1)
                erlaubt = false;
            //sind schon 2 karten umgedrehet
            if (umgedrehteKarten == 2)
                erlaubt = false;
            return erlaubt;
        }     
           
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            KarteSchliessen();
        }

        public void KarteOeffen(MemoryKarte karte)
        {
            //zum zwiechenspeichern der ID und der Position
            int kartenID, kartenPos;

            //die Karten zwiechenspeichern
            paar[umgedrehteKarten] = karte;

            //die ID und die Position beschaffen
            kartenID = karte.getBild();
            kartenPos = karte.getBildPos();

            //die Karte in das Gedächnis des Computer eintragen aber nur dann wenn keinen Eintrag an der
            //entsprechende stelle gibt
            if ((gemerkteKarten[0, kartenID]) == -1)
                gemerkteKarten[0, kartenID] = kartenPos;
            else if (gemerkteKarten[0, kartenID] != kartenPos)
                gemerkteKarten[1, kartenID] = kartenPos;
            umgedrehteKarten++;

            //sind 2 karten umgedreht worden
            if(umgedrehteKarten == 2)
            {
                //dann prüfen wir ob es ein paar ist
                PaarPruefen(kartenID);
                //die Karten wieder schließen
                timer.Start();
            }
            //haben wir zusamen 21 paare, dann ist das SPiel vorbei
            if(computerPunkte + menschPunkte == 21)
            {
                if (menschPunkte < computerPunkte)
                {
                    MessageBox.Show(computerPunkte.ToString(), "Computer gewinnt", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                    Application.Current.Shutdown();
                }
                if (menschPunkte > computerPunkte)
                {
                    MessageBox.Show(menschPunkte.ToString(), "Du gewinnst", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                    Application.Current.Shutdown();
                }
            }
        }
        //die Methode dreht die karten wieder auf die rückseite
        private void KarteSchliessen()
        {
            bool raus = false;
            //is es ein paar?
            if (paar[0].getBild() == paar[1].getBild())
                raus = true;
            //wenn es ein paar war nehmen wir die karten aus dem spiel sonst drehen wir sie wieder um 
            paar[0].RückseiteZeigen(raus);
            paar[1].RückseiteZeigen(raus);
            //es ist keine Karte mehr geöffnet 
            umgedrehteKarten = 0;
            //hat der spieler keine Paar gefunden ?
            if (raus == false)
                //dan wird der Spieler gewechselt
                SpielerWechsel();
            else
                //hat den Computer ein paar gefunden? 
                if (spieler == 1)
                ComputerZug();
        }

        private void ComputerZug()
        {
            int kartenZaehler = 0;
            int zufall = 0;
            bool treffer = false;
            Random zuffalzahl = new Random();
            //erst einmal nach ein Paar suchen
            //dazu durchsuchen wir das Array gemerktekarten, bis wir in beiden Dimensionen einen wert fur eine 
            //karten finden

            while((kartenZaehler < 21) && (treffer == false))
            {
                //gibt es in beiden Dimensionen einen wert großer oder gleich 0?
                if((gemerkteKarten[0,kartenZaehler] >= 0) && (gemerkteKarten[1,kartenZaehler] >= 0))
                {
                    //dann haben wir ein Paar
                    treffer = true;
                    //die erste Karte umdrehen durch einen simulierten Klick auf die Karte
                    karten[gemerkteKarten[0, kartenZaehler]].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                    //di Vorder seite zeigen
                    karten[gemerkteKarten[0, kartenZaehler]].VorderSeiteZeigen();
                    //und karten öffnen
                    KarteOeffen(karten[gemerkteKarten[0,kartenZaehler]]);
                    //die zweite Karte auch
                    karten[gemerkteKarten[1, kartenZaehler]].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                    karten[gemerkteKarten[1, kartenZaehler]].VorderSeiteZeigen();
                    //und karten öffnen
                    KarteOeffen(karten[gemerkteKarten[1,kartenZaehler]]);
                }
                kartenZaehler++;
            }
            //wenn wir kein paar gefunden haben, drehen wir zuffälig 2 karten um
            if(treffer == false)
            {
                //so lange eine Zuffallzahl suchen bis eine karte gefunden wird die noch im spiel ist
                do
                {
                    zufall = zufallZahl.Next(42);
                } while (karten[zufall].IsNochImSpiel() == false);
                //und die zweite karte umdrehen
                karten[zufall].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                //die Vorderseite zeigen
                karten[zufall].VorderSeiteZeigen();
                //und die Karten öffnen
                KarteOeffen(karten[zufall]);
                //für die zweite Karte müssen wir prüfen, ob sie nicht gerade angezeigt ist
                do
                {
                    zufall = zufallZahl.Next(42);
                } while ((karten[zufall].IsNochImSpiel() == false) || (karten[zufall].IsUmgedreth() == true));
                karten[zufall].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                //die Vorderseite zeigen
                karten[zufall].VorderSeiteZeigen();
                //und die Karten öffnen
                KarteOeffen(karten[zufall]);
                //für die zweite Karte müssen wir prüfen, ob sie nicht gerade angezeigt ist

            }
        }

        private void SpielerWechsel()
        {
            if (spieler == 0)
            {
                spieler = 1;
                ComputerZug();
            }
            else
                spieler = 0;
        }

        //die Methode prüft ob ein paar gefunden wurde
        private void PaarPruefen(int kartenID)
        {
            if(paar[0].getBild() == paar[1].getBild())
            {
                //die punkte setzen 
                paarGefunden();
                //die Karten aus dem gedechtnis prüfen 
                gemerkteKarten[0, kartenID] = -2;
                gemerkteKarten[1, kartenID] = -2;
            }
        }

        private void paarGefunden()
        {
           if(spieler == 0)
            {
                menschPunkte++;
                menschPunkteLabel.Content = menschPunkte.ToString();
            }
            else
            {
                computerPunkte++;
                computerPunkteLabel.Content = computerPunkte.ToString();
            }
        }

    }
}
