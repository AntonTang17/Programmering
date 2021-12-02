using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Quiz
    {
        private List<MainCard> questions;
        private int rätt;
        private int fråga;

        public Quiz()
        {

            questions = new List<MainCard>();

            questions.Add(new QuestionCard("Vilken fotbollsklubb är störst London?", "Arsenal"));
            questions.Add(new QuestionCard("Vilken fotbollsklubb är finast i Sverige?", "IFK Göteborg"));
            questions.Add(new QuestionCard("Vart ligger Sveriges stolthet?", "Ödsmål"));
            questions.Add(new MultiAnswer("Vilken stad är Sveriges huvudstad?", "Stockholm", "Göteborg", "Malmö"));
        }

        public void Run()
        {
            foreach (MainCard frågor in questions)
            {
                fråga = fråga + 1;
                bool r = frågor.SkrivUt();
                if (r == true)
                {
                    rätt = rätt + 1;
                    Console.WriteLine(rätt + " av " + fråga + " rätt ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(rätt + " av " + fråga + " rätt ");
                    Console.WriteLine();
                }
            }
        }

    }
}
