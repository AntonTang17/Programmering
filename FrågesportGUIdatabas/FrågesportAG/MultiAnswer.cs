using System;
using System.Collections.Generic;
using System.Text;

namespace FrågesportAG
{
    class MultiAnswer : MainCard
    {

        private string multi;
        private string answer;
        private int numberOfCorrect;





        public MultiAnswer(string q, string mA, string a) : base(q)
        {
            
            multi = mA;
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

        public string HämtaSvar()
        {
           

            return multi;
        }


        public override bool SkrivUt()
        {
            Console.WriteLine(question);
            Console.WriteLine(multi);
            String guess = Console.ReadLine();

            if (guess == answer)
            {
                Console.WriteLine("Rätt svar!");
                return true;
            }
            else
            {
                Console.WriteLine("Fel svar!");
                Console.WriteLine("Rätt svar: " + multi[0]);
                return false;
            }
        }
    }
}
