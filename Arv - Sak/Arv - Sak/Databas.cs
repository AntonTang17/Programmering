using System;
using System.Collections.Generic;
using System.Text;

namespace Arv___Sak
{
    class Databas
    {
        private List<Sak> saker;

        public Databas()
        {
            saker = new List<Sak>();

            saker.Add(new CD("sång", "Big Ed"));
            saker.Add(new CD("låt", "Big Ed"));
            saker.Add(new DVD("skitfilm", "Scorsese"));
            saker.Add(new DVD("film", "Scorsese"));
            saker.Add(new DVD("bra film", "Scorsese"));
        }
            public void Add(Sak enSak)
            {
                saker.Add(enSak);
            }
            public void Run()
            {
                foreach (Sak saken in saker)
                {
                    saken.SkrivUt();
                }

            }
        
    } 
}

