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

namespace FrågesportAG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Quiz myQuiz = new Quiz();
        private MainCard currentCard;
        private int numberOfCorrect;
        private int numberOfQ;
        private string SenasteSvar;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            textTitle.Visibility = Visibility.Collapsed;
            buttonStart.Visibility = Visibility.Collapsed;
            buttonSkip.Visibility = Visibility.Visible;
            fel.Visibility = Visibility.Hidden;
            currentCard = myQuiz.NextCard();
            if (currentCard == null)
            {
                slut();

            }
            else
            {
                qOne.Text = currentCard.Question;
                qOne.Visibility = Visibility.Visible;
                svar.Visibility = Visibility.Visible;
            }

        }

        private void enterDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                numberOfQ++;
                //rätta frågan
                if (currentCard.IsCorrect(svar.Text))
                {
                    numberOfCorrect++;
                    // nästa fråga
                    currentCard = myQuiz.NextCard();
                    if (currentCard == null)
                    {
                        slut();

                    }
                    else
                    {
                        MA();
                       
                    }
                }
                else
                {
                    svar.Clear();
                    fel.Visibility = Visibility.Visible;
                }
            }
        }

        private void buttonSkip_Click(object sender, RoutedEventArgs e)
        {
            numberOfQ++;
            currentCard = myQuiz.NextCard();
            if (currentCard == null)
            {
                slut();

            }


            else
            {
                MA();
            }


        }

        private void slut()
        {

            klar.Visibility = Visibility.Visible;
            antal.Visibility = Visibility.Visible;
            qOne.Visibility = Visibility.Collapsed;
            qMulti.Visibility = Visibility.Collapsed;
            buttonSkip.Visibility = Visibility.Collapsed;
            svar.Visibility = Visibility.Collapsed;
            fel.Visibility = Visibility.Collapsed;
            Lista.Visibility = Visibility.Collapsed;
            antal.Text = "Du fick " + numberOfCorrect + " av " + numberOfQ + " antal rätt";
        }

        private void Lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem myListBoxItem = (ListBoxItem)Lista.SelectedItem;
            if (myListBoxItem != null)
            {
                string text = (string)myListBoxItem.Content;
                
                Lista.UnselectAll();

                if (SenasteSvar != (string)myListBoxItem.Content)
                {
                    numberOfQ++;
                }

                SenasteSvar = (string)myListBoxItem.Content;

                if (currentCard.IsCorrect(text))
                {


                    
                    numberOfCorrect++;
                    // nästa fråga
                    currentCard = myQuiz.NextCard();
                    if (currentCard == null)
                    {
                        slut();

                    }
                    else
                    {

                        MA();
                    }
                }
                else
                {
                    svar.Clear();
                    fel.Visibility = Visibility.Visible;
                }
            }
        }

        private void MA()
        {
            if (currentCard is MultiAnswer)
            {
                string options;
                options = ((MultiAnswer)currentCard).HämtaSvar();
                string[] options2 = options.Split(new char[] { ',' });
                Alt1.Content = options2[0].Trim();
                String text2 = options2[1].Trim();
                Alt2.Content = text2;
                Alt3.Content = options2[2].Trim();

                Lista.Visibility = Visibility.Visible;
                svar.Visibility = Visibility.Collapsed;
                qMulti.Visibility = Visibility.Collapsed;
                qMulti.Text = ((MultiAnswer)currentCard).HämtaSvar();


            }

            qOne.Text = currentCard.Question;
            svar.Clear();
            fel.Visibility = Visibility.Hidden;
        }

        private void admin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

