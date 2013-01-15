using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FittingSorter.EFT
{
    public class FitLibrary : KeyedCollection<string, FitCollection>
    {
        public readonly List<FitCollection> ShipCollection = new List<FitCollection>();

        protected override string GetKeyForItem(FitCollection item)
        {
            return item.ShipName;
        }
    }
}

/*
    public class PiPropertyBag : KeyedCollection<string, PiProperty>
    {
        protected override string GetKeyForItem(PiProperty item)
        {
            return item.Name;
        }
    }
*/