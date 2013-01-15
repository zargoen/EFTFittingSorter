using System.IO;

namespace FittingSorter.Repository
{
    public class FileLoader
    {
        public static string[] ParseFile(string file)
        {
            string[] inputFits = File.ReadAllLines(file);

            return inputFits;
        }
    }
}