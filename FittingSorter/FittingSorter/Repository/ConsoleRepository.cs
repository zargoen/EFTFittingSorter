using System;
using FittingSorter.EFT;

namespace FittingSorter.Repository
{
    public class ConsoleRepository : FitRepository
    {
        public override FitCollection Load(string path)
        {
            throw new NotImplementedException("Reading Console for Fits, really?");
        }

        public override void Save(FitCollection input)
        {
            input.Fittings.ForEach(x => Console.WriteLine(x.Name));
        }
    }
}