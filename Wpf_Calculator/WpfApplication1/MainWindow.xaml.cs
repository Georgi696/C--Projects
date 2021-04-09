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

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
            
                MessageBox.Show("Eingabe fehlt", "Fehler", MessageBoxButton.OK);
            
            if ((bool) radioButton.IsChecked == true)
            
                ergebnis.Content = Convert.ToSingle(textBox1.Text) + Convert.ToSingle(textBox2.Text);
            
            if ((bool) radioButton1.IsChecked == true)
            
                ergebnis.Content = Convert.ToSingle(textBox1.Text) - Convert.ToSingle(textBox2.Text);
            
            if ((bool)radioButton2.IsChecked == true)
            
                ergebnis.Content = Convert.ToSingle(textBox1.Text) * Convert.ToSingle(textBox2.Text);
            
            if ((bool)radioButton3.IsChecked == true)

                ergebnis.Content = Convert.ToSingle(textBox1.Text) / Convert.ToSingle(textBox2.Text);
        }
        

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
