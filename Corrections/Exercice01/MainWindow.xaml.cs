using Exercice01.Classes;
using System.Globalization;
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

namespace Exercice01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Reservation> Reservations { get; set; } = [];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddReservation(object sender, RoutedEventArgs e)
        {
            Reservations.Add(new Reservation() { FirstName = FirstName.Text, LastName = LastName.Text, ArrivalDate = DateTime.Parse(ArrrivalDate.Text)});

            UpdateReservations();
        }

        private void UpdateReservations()
        {
            ReservationsList.Items.Clear();
            foreach (Reservation reservation in Reservations)
            {
                ReservationsList.Items.Add(reservation);
            }
        }

        private void DeleteReservation(object sender, RoutedEventArgs e)
        {
            if (Reservations.Count > 0) 
            {
                Reservations.RemoveAt(ReservationsList.SelectedIndex);
                UpdateReservations();
            }
        }
    }
}