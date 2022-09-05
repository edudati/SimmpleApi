using SimpleApi.Model;

namespace SimpleApi.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
        List<Book> FindAll();
        Book FindById(long id);
    }
}
