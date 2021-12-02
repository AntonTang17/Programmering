using System;
using System.Collections.Generic;
using System.Text;

namespace FrågesportAG
{
    abstract class MainCard
    {
        protected string question;

        public string Question
        {
            get
            {
                return question;
            }
        }


        public abstract bool SkrivUt();

        public MainCard(string q)
        {
            question = q;
        }

        abstract internal bool IsCorrect(string text);
        
            
        
    }
}
