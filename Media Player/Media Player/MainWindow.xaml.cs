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
using Microsoft.Win32;

namespace Media_Player
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OpenFileDialog open;
        Duration time;
        private TimeSpan vor, zurueck;

        public MainWindow()
        {
            InitializeComponent();
            open = new OpenFileDialog();
            time = mediaElement.NaturalDuration;
            vor = new TimeSpan(0);
            zurueck = new TimeSpan(0);
            label1.Content = mediaElement.NaturalDuration;
        }
        private void open1_Click(object sender, RoutedEventArgs e)
        {
            open.FileName = String.Empty;
            if (open.ShowDialog() == true)
            {
                mediaElement.Source = new Uri(open.FileName);
                mediaElement.Play();
                label.Content = open.FileName;
            }

        }

        private void pause1_Click(object sender, RoutedEventArgs e) => mediaElement.Pause();

        private void vor1_Click(object sender, RoutedEventArgs e)
        {
            vor = TimeSpan.FromSeconds(100);
            mediaElement.Position += vor;
        }

        private void stop1_Click(object sender, RoutedEventArgs e) => mediaElement.Stop();

        private void slider_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                //mouse wheel nach vorne drehen
                mediaElement.Volume += 0.1;
                slider.Value += 1;
            }
            else
            {
                mediaElement.Volume -= 0.1;
                slider.Value -= 1;
            }
        }

        private void zurueck1_Click(object sender, RoutedEventArgs e)
        {
            zurueck = TimeSpan.FromSeconds(100);
            mediaElement.Position -= zurueck;
        }
    }
}
