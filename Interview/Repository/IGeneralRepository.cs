namespace Interview.Repository
{
    public interface IGeneralRepository<T>
    {
        Task<List<T>> GetAll();
        T GetByID(int id);
        Task Add(T obj);
        void Update(T obj);
        void Delete(int id);
        void Save();
    }
}
