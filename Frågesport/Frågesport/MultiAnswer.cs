using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class MultiAnswer : MainCard
    {
        private string multi;
        private string multi2;
        private string multi3; 

        

        public MultiAnswer(string q, string m, string m2, string m3) : base(q)
        {
            multi = m;
            multi2 = m2;
            multi3 = m3;
            
        }

        public override bool SkrivUt()
        {
            Console.WriteLine(question);
            Console.WriteLine(multi + ", " + multi2 + ", " + multi3);
            String guess = Console.ReadLine();

            if (guess == multi)
            {
                Console.WriteLine("Rätt svar!");
                return true;
            }
            else
            {
                Console.WriteLine("Fel svar!");
                Console.WriteLine("Rätt svar: " + multi);
                return false;
            }
        }
    }
}
