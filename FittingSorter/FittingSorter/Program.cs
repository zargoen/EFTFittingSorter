using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FittingSorter
{
    public class Program
    {
        static void Main(string[] args)
        {
            EFTSorter sorter = new EFTSorter();
            sorter.Initialize();
            sorter.Execute();
            Console.ReadLine();
        }
    }
}
