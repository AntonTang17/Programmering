using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class MultiAnswer : MainCard
    {

        private List<string> multi;
       


        

        public MultiAnswer(string q, List <string> m) : base(q)
        {
            multi = m;
           
            
        }

        public override bool SkrivUt()
        {
            Console.WriteLine(question);
            foreach (string svar in multi)
            {
                Console.WriteLine(svar);
            }
            String guess = Console.ReadLine();

            if (guess == multi[0])
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
