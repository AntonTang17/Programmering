using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
   class QuestionCard : MainCard
    {
       

        private string answer;

        public QuestionCard(string q, string a) : base(q)
        {
            
            answer = a;
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
