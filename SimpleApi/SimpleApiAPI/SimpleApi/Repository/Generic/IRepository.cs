using SimpleApi.Model;

namespace SimpleApi.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        void Delete(long id);
        List<T> FindAll();
        T FindById(long id);
        bool Exists(long id);
    }
}
