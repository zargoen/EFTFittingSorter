using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
                FileLoader.ParseFile(file);
            }
        }
    }
}
