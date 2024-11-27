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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Exercice02
{
    /// <summary>
    /// Logique d'interaction pour AnimationCodeBehind.xaml
    /// </summary>
    public partial class AnimationCodeBehindWindow : Window
    {

        private static Duration defaultDuration = new Duration(TimeSpan.FromSeconds(0.3));

        public AnimationCodeBehindWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if(sender is Button button)
            {
                var widthAnimation = new DoubleAnimation() { To = 130, Duration = defaultDuration };
                var heigthAnimation = new DoubleAnimation() { To = 150, Duration = defaultDuration };
                var colorAnimation = new ColorAnimation() { To = Colors.Aqua, Duration = defaultDuration };

                button.BeginAnimation(Button.WidthProperty, widthAnimation);
                button.BeginAnimation(Button.HeightProperty, heigthAnimation);

                var brush = new SolidColorBrush(Colors.White);
                button.Background = brush;
                brush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);

            }

        }
        
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            if(sender is Button button)
            {
                var widthAnimation = new DoubleAnimation() { To = 100, Duration = defaultDuration };
                var heigthAnimation = new DoubleAnimation() { To = 120, Duration = defaultDuration };
                var colorAnimation = new ColorAnimation() { To = Colors.White, Duration = defaultDuration };

                button.BeginAnimation(Button.WidthProperty, widthAnimation);
                button.BeginAnimation(Button.HeightProperty, heigthAnimation);

                var brush = new SolidColorBrush(Colors.Aqua);
                button.Background = brush;
                brush.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);

            }

        }
    }
}
