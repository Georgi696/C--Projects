using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Ribbon;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Brush = System.Windows.Media.Brush;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;
using MouseEventArgs = System.Windows.Input.MouseEventArgs;
using Point = System.Windows.Point;
using Rectangle = System.Drawing.Rectangle;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;
using System.Diagnostics.Contracts;
using System.Threading;
using System.Windows.Media.Animation;

namespace Mal_Programm
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private Point position;
        private Point start;
        private SolidColorBrush pinselBrush;
        private int werkzeug;

        public MainWindow()
        {
            InitializeComponent();
            pinselBrush = System.Windows.Media.Brushes.Black;
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            label.Content = "Die linke Maustaste wurde " + e.ClickCount.ToString() + " mal gedrückt";
            if (e.RightButton == MouseButtonState.Pressed)
                label.Content = "Die rechte Mousetaste " + e.ClickCount.ToString() + " mal gedrückt";
            Point position = e.GetPosition(canvas);
            label.Content = label.Content + position.X.ToString() + " , " + position.Y.ToString();

        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point position = e.GetPosition(canvas);
            label.Content = position.X.ToString() + " , " + position.Y.ToString();
        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            start = e.GetPosition(canvas);
        }

        private void canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (werkzeug == 1)
            {
                Linie((int)e.GetPosition(canvas).X,(int)e.GetPosition(canvas).Y);
            }
            if (werkzeug == 2)
            {
                Rechteck((int) (e.GetPosition(canvas).X - start.X), (int) (e.GetPosition(canvas).Y - start.Y));
            }
            if (werkzeug == 3)
            {
                Kreis((int)(e.GetPosition(canvas).X - start.X), (int)(e.GetPosition(canvas).Y - start.Y));
            }

        }
        //****Die Methode zeichnet und animieret einen Rechteck****//
        void Rechteck(int breite, int hoehe)
        {
            try
            {
                System.Windows.Shapes.Rectangle rechteck = new System.Windows.Shapes.Rectangle();
                Canvas.SetLeft(rechteck,start.X);
                Canvas.SetRight(rechteck,start.Y);
                //breite und hohe
                rechteck.Width = breite;
                rechteck.Height = hoehe;
                rechteck.Stroke = pinselBrush;
                //und hinzufügen
                canvas.Children.Add(rechteck);
                rechteck.Fill = pinselBrush;
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = rechteck.Width;
                animation.To = rechteck.Width / 2;
                animation.AutoReverse = true;
                animation.RepeatBehavior = new RepeatBehavior(10);
                rechteck.BeginAnimation(WidthProperty, animation);
                rechteck.BeginAnimation(HeightProperty, animation);

            }
            catch (Exception)
            {
                Console.WriteLine("Es hat ein problem gegeben");
            }
        }

        //****Die methode zeichnet und animieret einen Kreis****//
        void Kreis(int breite, int hoehe)
        {
            try
            {
                Ellipse kreis = new Ellipse();
                Canvas.SetLeft(kreis,start.X);
                Canvas.SetRight(kreis, start.Y);
                //die breite und hoehe
                kreis.Width = breite;
                kreis.Height = hoehe;
                kreis.Stroke = pinselBrush;
                //und hinzufügen
                canvas.Children.Add(kreis);
                kreis.Fill = pinselBrush;
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = kreis.Width;
                animation.To = kreis.Width * 2;
                animation.AutoReverse = true;
                animation.RepeatBehavior = new RepeatBehavior(10);
                kreis.BeginAnimation(WidthProperty,animation);
                kreis.BeginAnimation(HeightProperty,animation);
            }
            catch (Exception)
            {
                Console.WriteLine("Es hat ein problem gegeben");
            }
        }
        //****Die Methode zeichnet eine Linie****//
        void Linie(int x2, int y2)
        {
            Line linie = new Line();
            linie.X1 = start.X;
            linie.Y1 = start.Y;
            linie.X2 = x2;
            linie.Y2 = y2;
            linie.Stroke = pinselBrush;
            canvas.Children.Add(linie);
        }

        

        private void buttonLinie_Click(object sender, RoutedEventArgs e)
        {
            werkzeug = 1;
        }

        private void buttonRechteck_Click(object sender, RoutedEventArgs e)
        {
            werkzeug = 2;
        }

        private void buttonKreis_Click(object sender, RoutedEventArgs e)
        {
            werkzeug = 3;
        }

        private void buttonFarbe_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog newColorDialog = new ColorDialog();
            if (newColorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Windows.Media.Color farbeWPF = System.Windows.Media.Color.FromArgb(newColorDialog.Color.A,newColorDialog.Color.B,newColorDialog.Color.G,newColorDialog.Color.R);
                pinselBrush = new SolidColorBrush(farbeWPF);
            }

        }

        private void buttonNew_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog newSaveDialog = new SaveFileDialog();
            newSaveDialog.FileName = String.Empty;
            newSaveDialog.Filter = "Text-Datei | *.mml";

            if (newSaveDialog.ShowDialog() == true) {
                using (FileStream newFile = new FileStream(newSaveDialog.FileName,FileMode.Create))
                {
                    System.Windows.Markup.XamlWriter.Save(canvas,newFile);
                }
                canvas.Children.Clear();
            }
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e) => canvas.Children.Clear();

        private void buttonAnim_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
