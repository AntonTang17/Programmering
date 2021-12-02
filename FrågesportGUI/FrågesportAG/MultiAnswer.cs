using System;
using System.Collections.Generic;
using System.Text;

namespace FrågesportAG
{
    class MultiAnswer : MainCard
    {

        private List<string> multi;
        private int numberOfCorrect;





        public MultiAnswer(string q, List<string> m) : base(q)
        {
            multi = m;


        }

        internal override bool IsCorrect(string text)
        {
            if (text == multi[0])
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
            string text = "";
            foreach (string svar in multi)
            {
                text = text + svar + "   ";
               
            }

            return text;
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
