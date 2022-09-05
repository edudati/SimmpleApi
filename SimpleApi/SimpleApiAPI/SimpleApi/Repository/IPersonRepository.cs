using SimpleApi.Model;

namespace SimpleApi.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person Update(Person person);
        void Delete(long id);
        List<Person> FindAll();
        Person FindById(long id);
        bool Exists(long id);
    }
}
