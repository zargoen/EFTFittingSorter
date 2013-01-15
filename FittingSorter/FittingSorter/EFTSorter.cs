using System.IO;
using FittingSorter.EFT;
using FittingSorter.Repository;

namespace FittingSorter
{
    public class EFTSorter
    {
        private const string Sourcepath = @".\Setups\";
        private string[] _cfgList;
        private FitRepository Repository { get; set; }

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
                Repository = new FileRepository(file);
                FitCollection fits = Repository.Load(file);
                ProcessFits(fits);
                OutputFits(fits);
            }
        }

        private void OutputFits(FitCollection fits)
        {
            Repository.Save(fits);
        }

        private void ProcessFits(FitCollection fits)
        {
            fits.Fittings.Sort(new AlphaFitComparer());
        }
    }
}