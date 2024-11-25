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

namespace Demo02Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Déclaration des membres privés

        // result: résultat que l'on stocke après une opération
        private double result;

        // nombre que l'on stocke AVANT de faire une opération
        private double lastNumber;

        // Opération stockée, elle sera utilisée lors du calcul du résultat
        Operation CurrentOperation { get; set; }


        // Constructeur de base
        public MainWindow()
        {
            InitializeComponent();
        }

        // Fonction qui gère la partie nombre de la calculatrice et met à jour le label
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {

            int selectedValue = 0;

            if(sender is Button button)
            {
                int.TryParse(button.Content.ToString(), out selectedValue);
            }


            if(labelResult.Content.ToString() == "0")
            {
                labelResult.Content = selectedValue.ToString();
            }
            else
            {
                labelResult.Content += selectedValue.ToString();
            }

        }

        /// <summary>
        /// Récupère la dernière valeur du label et stocke l'opération souhaitée
        /// </summary>
        /// <param name="sender">Bouton d'opération: +, -, x, /</param>
        /// <param name="e"></param>
        public void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            // On caste le sender qui est de type object vers un type plus précis : Button
            var operationButton = (Button)sender;

            // Si le contenu du bouton d'opération est null, on met addition par défaut
            string operation = operationButton.Content.ToString() ?? "+";

            // On converti le nombre affiché en double et on stocke sa valeur dans le membre lastNumber
            if (double.TryParse(labelResult.Content.ToString(), out lastNumber))
            {
                // On remet le label à 0 pour sélectionner le nombre suivant
                labelResult.Content = "0";
            }

            // Selon la valeur du bouton d'opération, on stocke l'opération liée
            switch (operation)
            {
                case "+":
                    CurrentOperation = Operation.Addition;
                    break;
                case "-":
                    CurrentOperation = Operation.Substraction;
                    break;
                case "÷":
                    CurrentOperation = Operation.Division;
                    break;
                case "×":
                    CurrentOperation = Operation.Multiplication;
                    break;
                default:
                    break;
            }
        }

        // Bouton de réinitialisation
        private void ACButton_Click(object sender, RoutedEventArgs e)
        {
            labelResult.Content = "0";
            result = 0;
            lastNumber = 0;
        }

        // Bouton qui permet le calcule de l'opération ainsi que la valeur calculée
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if(double.TryParse(labelResult.Content.ToString(), out newNumber))
            {
                switch (CurrentOperation)
                {
                    case Operation.Addition:
                        result = Math.add(lastNumber, newNumber);
                        break;
                    case Operation.Substraction:
                        result = Math.substract(lastNumber, newNumber);
                        break;
                    case Operation.Multiplication:
                        result = Math.multiply(lastNumber, newNumber);
                        break;
                    case Operation.Division:
                        try
                        {
                            result = Math.divide(lastNumber, newNumber);
                        } catch (DivideByZeroException)
                        {
                            MessageBox.Show($"Impossible diviser {lastNumber} par 0");
                        }
                        break;
                    default:
                        break;
                }

                labelResult.Content = result.ToString();
            }
        }

        // Obtenir l'inverse d'un nombre
        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(labelResult.Content.ToString(), out lastNumber))
            {
                lastNumber *= -1;
                labelResult.Content = lastNumber.ToString();
            }
        }

        // Permet de calculer un pourcentage
        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            double currentNumber;
            if(double.TryParse(labelResult.Content.ToString(), out currentNumber))
            {
                currentNumber /= 100;
                if (lastNumber != 0)
                    currentNumber *= lastNumber;

                labelResult.Content = currentNumber.ToString();

            }
        }
    }
}