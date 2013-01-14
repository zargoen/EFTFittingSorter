using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FittingSorter
{
    public class FileLoader
    {
        public static string[] ParseFile(string file)
        {
            var inputFits = File.ReadAllLines(file);

            return inputFits;
            
        }
    }
}
