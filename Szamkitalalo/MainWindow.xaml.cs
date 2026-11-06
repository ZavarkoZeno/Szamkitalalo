using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Szamkitalalo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int gondoltSzam;
        int proba = 0;
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
            gondoltSzam = r.Next(1, 101);
        }

        private void tippeles(object sender, RoutedEventArgs e)
        {
            int tipp;
            if (int.TryParse(textBox.Text, out tipp))
            {
                if (tipp < 1 || tipp > 100)
                {
                    MessageBox.Show("Adj meg 1 és 100 közötti számot!");
                }
                else
                {
                    proba++;

                    lista.Items.Add(tipp);
                    if (tipp < gondoltSzam)
                    {
                        MessageBox.Show("A gondolt szám nagyobb!");
                    }
                    else if (tipp > gondoltSzam)
                    {
                        MessageBox.Show("A gondolt szám kisebb!");
                    }
                    else
                    {
                        MessageBox.Show($"Kitaláltad a számot {proba} próbálkozásból!");
                    }
                }
                textBox.Clear();
            }

        }

        private void ujjatek(object sender, RoutedEventArgs e)
        {
            gondoltSzam = r.Next(1, 101);
            proba = 0;
            lista.Items.Clear();
            textBox.Clear();
            MessageBox.Show("Új játék kezdődött");
        }

        private void kilepes(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}