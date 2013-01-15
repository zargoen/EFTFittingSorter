namespace FittingSorter.Repository
{
    internal interface IRepository<T>
    {
        T Load(string path);
        void Save(T input);
    }
}