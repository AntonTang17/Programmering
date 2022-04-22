using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfObject
{
    class Result
    {
        private int distance;
        private string runner;
        private double time;
        

        public Result(int d, string r, double t)
        {
            distance = d;
            runner = r;
            time = t;
        }

        public override string ToString()
        {
            return (" " + distance + " m" + Environment.NewLine + " " + runner + Environment.NewLine + " " + time + " s" + Environment.NewLine + Environment.NewLine);
        }

    }
}
