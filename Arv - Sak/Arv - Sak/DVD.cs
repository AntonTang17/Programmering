using System;
using System.Collections.Generic;
using System.Text;

namespace Arv___Sak
{
    class DVD : Sak
    {
        protected string regisör;
        public DVD(string filmTitel, string filmRegisör)
        {
            titel = filmTitel;
            regisör = filmRegisör;
        }
        public override void SkrivUt()
        {
            Console.WriteLine("DVD, Namn:" + titel);
            Console.WriteLine("Regisör:" + regisör);
        }
    }
}
