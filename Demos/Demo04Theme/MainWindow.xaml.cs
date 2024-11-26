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

namespace Demo04Theme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Uri themeUri = new Uri("Themes/Dark.xaml", UriKind.Relative);
            AppThemeSelector.ChangeTheme(themeUri);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Uri themeUri = new Uri("Themes/Light.xaml", UriKind.Relative);
            AppThemeSelector.ChangeTheme(themeUri);
        }
    }
}