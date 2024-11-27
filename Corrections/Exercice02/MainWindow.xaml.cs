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

namespace Exercice02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Chargement du dictionnaire
            var genericDictionnary = new Uri("Themes/Generic.xaml", UriKind.Relative);
            var dictionnary = new ResourceDictionary() { Source = genericDictionnary };
            Resources.MergedDictionaries.Add(dictionnary);
        }

        private void NavigateToAlternative(object sender, RoutedEventArgs e)
        {
            var window = new AnimationCodeBehindWindow();
            window.Show();
            Close();
        }
    }
}