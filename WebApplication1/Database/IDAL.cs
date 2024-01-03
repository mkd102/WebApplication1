using WebApplication1.UnitOfWork;

namespace WebApplication1.Database
{
    public interface IDAL<T> where T : class
    {
        void Add(T obj);
        void Save();

        void Delete(T obj);

        void Update(T obj);

        void setUOW(IOW oW);
    }
}
