using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Snake_Spiel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Die Felder für die Punkte
        int punkte;
        //für die Zeit
        int zeit;
        //für die Rcihtung der Schlange
        int richtung;
        //für die Breite der Spielfeldbegrenzung
        int balkenBreite;
        public MainWindow()
        {
            InitializeComponent();
        }

        void Start()
        {
            punkte = 0;
            zeit = 0;
            richtung = 0;
            balkenBreite = 25;
        }

        //eine Hilfsmethode zum Zeichen ger Begrenzug
        void ZeichneRechteck(Point position, double laenge, double breite)
        {
            //einen neuen Balkan erzeugen
            Rectangle balken = new Rectangle();
            Canvas.SetLeft(balken, position.X);
            Canvas.SetTop(balken, position.Y);
            balken.Width = laenge;
            balken.Height = breite;
            SolidColorBrush fuellung = new SolidColorBrush(Colors.Red);
            balken.Fill = fuellung;
            spielfeld.Children.Add(balken);    
        }

        //zum Erstelen der Begrenzungen
        void ZeichneSpielfeld()
        {
            //der Balken oben
            ZeichneRechteck(new Point(0, 0), spielfeld.ActualWidth, balkenBreite);
            //der balken Rechts
            ZeichneRechteck(new Point(spielfeld.ActualWidth - balkenBreite, 0), balkenBreite, spielfeld.ActualHeight);
            //der Balken unten
            ZeichneRechteck(new Point(0, spielfeld.ActualHeight - balkenBreite), spielfeld.ActualWidth, balkenBreite);
            //der Balken Links
            ZeichneRechteck(new Point(0, 0), balkenBreite, spielfeld.ActualHeight);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Start();
            ZeichneSpielfeld();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
