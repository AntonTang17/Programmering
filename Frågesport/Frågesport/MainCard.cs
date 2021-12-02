using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    abstract class MainCard
    {
        protected string question;

        public abstract bool SkrivUt();

        public MainCard(string q)
        {
            question = q;
        }
    }
}
