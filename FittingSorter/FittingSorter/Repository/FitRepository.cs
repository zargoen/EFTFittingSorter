using FittingSorter.EFT;

namespace FittingSorter.Repository
{
    public abstract class FitRepository : IRepository<FitCollection>
    {
        public abstract FitCollection Load(string path);
        public abstract void Save(FitCollection input);
    }
}