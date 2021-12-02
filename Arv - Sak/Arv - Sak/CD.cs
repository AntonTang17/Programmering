using System;
using System.Collections.Generic;
using System.Text;

namespace Arv___Sak
{
    class CD : Sak
    {
        protected string artist;
        public CD(string skivTitel, string skivArtist)
        {
            titel = skivTitel;
            artist = skivArtist;
        }
        public override void SkrivUt()
        {
            Console.WriteLine("CD, Namn:" + titel);
            Console.WriteLine("Artist:" + artist);
        }

    }
}
