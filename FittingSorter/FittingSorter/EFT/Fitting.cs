namespace FittingSorter.EFT
{
    public class Fitting
    {
        public string[] RawFit;

        public Fitting(string[] inputFitLines)
        {
            RawFit = inputFitLines;
        }

        //private string Rawfit { get; set; }

        public string Name
        {
            get { return RawFit[0]; }
        }

        public string Ship { get; set; }

        public int Length
        {
            get { return RawFit.Length; }
        }
    }
}