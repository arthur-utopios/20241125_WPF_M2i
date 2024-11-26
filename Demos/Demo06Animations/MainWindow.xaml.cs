using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo06Animations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            redctangle.RenderTransformOrigin = new Point(0.5, 0.5);
            redctangle.RenderTransform = new RotateTransform(0);
        }

        public void Rotate360 (object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation() 
            { 
                From = 0, 
                To = 360, 
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };

            var rotateTransform = (RotateTransform)redctangle.RenderTransform;

            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, doubleAnimation);

        }
    }
}