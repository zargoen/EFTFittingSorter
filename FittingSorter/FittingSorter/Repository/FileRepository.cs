using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using FittingSorter.EFT;

namespace FittingSorter.Repository
{
    public class FileRepository : FitRepository
    {
        public FileRepository(string path)
        {
            Path = path;
        }

        private string Path { get; set; }

        public override FitCollection Load(string path)
        {
            string[] input = FileLoader.ParseFile(path);
            return SplitIntoFittings(input);
        }

        public override void Save(FitCollection input)
        {
            IEnumerable<string> concatenatedFits = input.Fittings.SelectMany(x => x.RawFit);
            string newfilename = Path;

#if DEBUG
    //var T = new Regex(@".*?<Name>([^\\]*)\.cfg");
    //var MatchResult = T.Match(Path);
    //var r = MatchResult.Groups["Name"].Value;

    //newfilename = newfilename.Replace(r + ".cfg", r + " - Sorted.cfg");
#endif
            Console.WriteLine(String.Format("Sorted File : {0}", newfilename));


            File.WriteAllLines(newfilename, concatenatedFits);
        }

        private FitCollection SplitIntoFittings(string[] input)
        {
            var fits = new FitCollection();

            int startIndex = 0;

            for (int stopIndex = 1; stopIndex < input.Length; stopIndex++)
            {
                if (Regex.IsMatch(input[stopIndex], @"\[.*\]"))
                {
                    fits.Fittings.Add(new Fitting(input.Skip(startIndex).Take(stopIndex - startIndex).ToArray()));
                    startIndex = stopIndex;
                }
            }
            fits.Fittings.Add(new Fitting(input.Skip(startIndex).ToArray()));

            return fits;
        }
    }
}