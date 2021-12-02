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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            textTitle.Visibility = Visibility.Collapsed;
            buttonStart.Visibility = Visibility.Collapsed;
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

                        if (currentCard is MultiAnswer)
                        {

                            qMulti.Visibility = Visibility.Visible;
                            qMulti.Text = ((MultiAnswer)currentCard).HämtaSvar();


                        }

                        qOne.Text = currentCard.Question;
                        svar.Clear();
                        fel.Visibility = Visibility.Hidden;
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
                if (currentCard is MultiAnswer)
                {
                   
                    qMulti.Visibility = Visibility.Visible;
                    qMulti.Text = ((MultiAnswer)currentCard).HämtaSvar();


                }
           
                qOne.Text = currentCard.Question;
                svar.Clear();
                fel.Visibility = Visibility.Hidden;
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
            antal.Text = "Du fick " + numberOfCorrect + " av " + numberOfQ + " antal rätt";
        }
    }
}
