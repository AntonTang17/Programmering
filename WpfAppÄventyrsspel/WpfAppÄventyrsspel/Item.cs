using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppÄventyrsspel
{
    public class Item
    {
        private string beskrivning;

        public Item (string b)
        {
            beskrivning = b;
        }

        public string Beskrivning
        {
            get
            {
                return beskrivning;
            }
        }
    }
}
