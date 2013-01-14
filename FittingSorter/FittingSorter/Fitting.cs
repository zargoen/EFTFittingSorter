using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FittingSorter
{
    public class Fitting
    {
        private string p;
        private string[] inputFitLines;

        public Fitting(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        public Fitting(string[] inputFitLines)
        {
            // TODO: Complete member initialization
            this.inputFitLines = inputFitLines;
            Console.WriteLine(inputFitLines[0]);
        }
        private string Rawfit { get; set; }

        public string Name { get; set; }
        public string Ship { get; set; }



    }
}
