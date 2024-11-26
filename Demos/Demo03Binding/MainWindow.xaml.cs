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

namespace Demo03Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        public string FirstName { get; set; }
        public string Message { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            FirstName = "Jean";
            Message = "Coucou";
            DataContext = this;
        }

        private void ShowMessage(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Message);
        }
    }
}