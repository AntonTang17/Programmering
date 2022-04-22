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

namespace WpfAppÄventyrsspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Room currentRoom;
        private Room hall;
        public MainWindow()
        {
            InitializeComponent();
            currentRoom = new Room("Du är i hallen!");
            Room hall = currentRoom;
            Room ut = new Room("Du är ute!");
            Room vardagsrum = new Room("Du är i vardagsrummet!");
            Room kök = new Room("Du är i köket!");
            Room toa = new Room("Du är i badrummet!");
            Room sovrum = new Room("Du är i sovrummet!");

            currentRoom.Norr = ut;
            currentRoom.Syd = vardagsrum;
            currentRoom.Öst = kök;
            currentRoom.Väst = toa;

            ut.Syd = currentRoom;
            vardagsrum.Norr = currentRoom;
            vardagsrum.Öst = sovrum;
            sovrum.Väst = vardagsrum;
            kök.Väst = currentRoom;
            kök.Syd = sovrum;
            sovrum.Norr = kök;
            toa.Öst = currentRoom;


            rum.Text = "Du är i hallen!" + Environment.NewLine + "Ta dig ut!";
            norr.Content = "Låst!";

            sovrum.MyItem = new Item(Environment.NewLine + "Du hittade nyckeln! Ta dig ut!");


        }

        private void norr_Click(object sender, RoutedEventArgs e)
        {
           

            if (currentRoom.NorrLåst == true)
            {
                norr.Content = "Låst!";
                rum.Text = currentRoom.GetBeskrivning();
                checkButton();
            }

            else
            {
                currentRoom = currentRoom.Norr;

                rum.Text = currentRoom.GetBeskrivning();

                checkButton(); 
            }

            if (currentRoom == hall)
            {
                norr.Content = "Låst!";
            }

            else
            {
                norr.Content = "Norr";
                rum.Text = currentRoom.GetBeskrivning();
            }
        }

        private void syd_Click(object sender, RoutedEventArgs e)
        {
            //finns rum åt söder?

            currentRoom = currentRoom.Syd;

            rum.Text = currentRoom.GetBeskrivning();

            checkButton();

           
        }

        

        private void öst_Click(object sender, RoutedEventArgs e)
        {
            currentRoom = currentRoom.Öst;

            rum.Text = currentRoom.GetBeskrivning();

            checkButton();
        }

        private void väst_Click(object sender, RoutedEventArgs e)
        {
            currentRoom = currentRoom.Väst;

            rum.Text = currentRoom.GetBeskrivning();

            checkButton();

        }

        private void checkButton()
        {

            if (currentRoom.Norr == null)
            {
                //nu saknas utgång åt norr

                norr.Visibility = Visibility.Hidden;



            }

            else
            {
                //finns utgång åt norr

                norr.Visibility = Visibility.Visible;


            }
            if (currentRoom.Syd == null)
            {
                //nu saknas utgång åt syd

                syd.Visibility = Visibility.Hidden;



            }

            else
            {
                //finns utgång åt syd

                syd.Visibility = Visibility.Visible;


            }

            if (currentRoom.Öst == null)
            {
                //nu saknas utgång åt öst

                öst.Visibility = Visibility.Hidden;



            }

            else
            {
                //finns utgång åt öst

                öst.Visibility = Visibility.Visible;


            }

            if (currentRoom.Väst == null)
            {
                //nu saknas utgång åt väst

                väst.Visibility = Visibility.Hidden;



            }

            else
            {
                //finns utgång åt väst

                väst.Visibility = Visibility.Visible;


            }
        }
    }
}
