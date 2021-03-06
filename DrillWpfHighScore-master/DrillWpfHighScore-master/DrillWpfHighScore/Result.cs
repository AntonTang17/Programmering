using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DrillWpfHighScore
{
    class Result : IComparable<Result>
    {

        private string name;
        private int score;
       
        // lägg till name


        // lägg till konstruktor
        public Result(string n, int s)
        {
            name = n;
            score = s;
           
        }

        // property
        public int Score
        {
            get
            {
                return score;
            }
        }

        // lägg till ToString() eller property Name

        public override string ToString()
        {
            return (" " + name + " " + score + Environment.NewLine);
        }


        public int CompareTo([AllowNull] Result other)
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
            else if (Score > other.Score)
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
