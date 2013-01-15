using System;
using System.Globalization;
using FittingSorter.EFT;

namespace FittingSorter
{
    public class AlphaFitComparer : IFitComparer
    {
        public int Compare(Fitting x, Fitting y)
        {
            return String.Compare(x.Name, y.Name, true, CultureInfo.CurrentCulture);
        }
    }
}