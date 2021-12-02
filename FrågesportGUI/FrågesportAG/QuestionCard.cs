using System;
using System.Collections.Generic;
using System.Text;

namespace FrågesportAG
{
    class QuestionCard : MainCard
    {

        private string answer;
        

        public QuestionCard(string q, string a) : base(q)
        {

            answer = a;
        }

        internal override bool IsCorrect(string text)
        {
           
            if (text == answer)
            {
                
                return true;
            }

            else
            {
                return false;
            }
           
        }
        

        

        public override bool SkrivUt()
        {
            Console.WriteLine(question);
            String guess = Console.ReadLine();

            if (guess == answer)
            {
                Console.WriteLine("Rätt svar!");
                return true;
            }
            else
            {
                Console.WriteLine("Fel svar!");
                Console.WriteLine("Rätt svar: " + answer);
                return false;
            }
        }
    }
}

