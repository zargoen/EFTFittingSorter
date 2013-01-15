using System;
using System.Collections.Generic;

namespace FittingSorter.EFT
{
    public class FitCollection
    {
        public readonly List<Fitting> Fittings = new List<Fitting>();
        public String ShipName { get; set; }
    }
}