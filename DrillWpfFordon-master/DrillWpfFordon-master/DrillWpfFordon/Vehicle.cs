using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DrillWpfFordon
{
    class Vehicle : IComparable<Vehicle>
    {
        // registratoin number
        // owner

        // konstruktor tar registeringsnummer som parameter
        // bara registreringsnummer

        // property för att läsa registreringsnummer

        // property för att läsa och sätta ägare

        private string reg;
        private double owner;

        public Vehicle (string r)
        {
            reg = r;
        }

        public string Reg
        {
            get
            {
                return reg;
            }
        }

        public double Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }

        }

        public int CompareTo([AllowNull] Vehicle other)
        {
            // Metoden CompareTo behövs för att implementera interfacet IComparable.
            // Denna metod används sedan när listan sorteras.
            // Sorteras på score. Störst kommer först.
            // Metoden returnerar -1 om detta (this) objektet är större än det andra objektet (other)
            // och annars returneras 1
            // null-värde hamnar sist i listan. Vi bör dock inte ha null-värden i listan.

            if (other == null)
            {
                // this is first
                return -1;
            }
            else if (Owner < other.Owner)
            {
                // this is first
                return -1;
            }
            else
            {
                // other is first
                return 1;
            }
        }
    }
}
