using System;

namespace FittingSorter
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var sorter = new EFTSorter();
            sorter.Initialize();
            sorter.Execute();
#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}