using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FittingSorter
{
    public class FileLoader
    {
        public static void ParseFile(string file)
        {
            TextReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd());
            
        }
    }
}
