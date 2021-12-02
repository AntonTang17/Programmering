using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FrågesportAG
{
    class Quiz
    {
        private List<MainCard> questions;
        private int rätt;
        private int fråga;

        public Quiz()
        {

            questions = new List<MainCard>();
            // List<string> flera;
            //flera = new List<string>();
            //flera.Add("Stockholm");
            //flera.Add("Göteborg");
            //flera.Add("Malmö");
            //List<string> flera2;
            //flera2 = new List<string>();
            //flera2.Add("61");
            //flera2.Add("135");
            //flera2.Add("2");
            //flera2.Add("58");
            //flera2.Add("17");

            //questions.Add(new QuestionCard("Vilken fotbollsklubb är störst London?", "Arsenal"));
            //questions.Add(new QuestionCard("Vilken fotbollsklubb är bäst i Sverige?", "IFK"));
            //questions.Add(new MultiAnswer("Vilken stad är Sveriges huvudstad?", flera));
            //questions.Add(new MultiAnswer("Vad är rätt svar?", flera2));

            DatabaseHandler databaseHandler = new DatabaseHandler();

        
            questions = databaseHandler.GetQusetions();



        }

        internal MainCard NextCard()
        {
            fråga++;
           
            if (fråga > 4)
            {
                return null;
            }
            return questions[fråga - 1];

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
