using SimpleApi.Model;

namespace SimpleApi.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
        List<Book> FindAll();
        Book FindById(long id);
        bool Exists(long id);
    }
}
