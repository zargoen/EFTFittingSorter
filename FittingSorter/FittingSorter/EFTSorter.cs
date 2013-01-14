using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FittingSorter
{
    
    public class EFTSorter
    {
        private const string Sourcepath = @".\Setups\";
        private string[] _cfgList;

        public void Initialize()
        {
            if (!Directory.Exists(Sourcepath))
                throw new DirectoryNotFoundException("Could not find Fitting Directory");

            _cfgList = Directory.GetFiles(Sourcepath, "*.cfg", SearchOption.TopDirectoryOnly);
        }

        public void Execute()
        {
            foreach (string file in _cfgList)
            {
                var input = FileLoader.ParseFile(file);
                SplitFileInFittings(input);
            //    SortFits();
            }
        }

        private List<Fitting> SplitFileInFittings(string[] input)
        {
            List<Fitting> fits = new List<Fitting>();

            int startIndex = 0;

            for (int stopIndex = 1; stopIndex < input.Length; stopIndex++){
                if (Regex.IsMatch(input[stopIndex], @"\[.*\]")){
                    fits.Add(new Fitting(input.Skip(startIndex).Take(stopIndex).ToArray()));
                    startIndex = stopIndex;
                }
            }
            fits.Add(new Fitting(input.Skip(startIndex).ToArray()));

            return fits;
        }
    }
}
