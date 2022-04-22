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

namespace DrillWpfFordon
{ 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // lista med alla fordon
        private List<Vehicle> vehicles = new List<Vehicle>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // skriv kod här för att spara fordon i lista

            String decimalNumberAsText = Owner.Text;
            double time = Convert.ToDouble(decimalNumberAsText);

            Vehicle vehicle = new Vehicle(RegistrationNumber.Text);
            vehicle.Owner = time;
            vehicles.Add(vehicle);
            RegistrationNumber.Clear();
            Owner.Clear();

            vehicles.Sort();



            Vehicles.Text = "";

            int x = 0;

            foreach(Vehicle v in vehicles)
            {
                x = x + 1;
                Vehicles.Text += x + " Bilmodell:" + Environment.NewLine + v.Reg + Environment.NewLine + "Tid 0-100kmh (s):" + Environment.NewLine + v.Owner + Environment.NewLine + Environment.NewLine;
            }
        }


    }
}
