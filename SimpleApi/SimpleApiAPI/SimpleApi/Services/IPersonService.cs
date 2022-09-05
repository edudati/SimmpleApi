using SimpleApi.Model;

namespace SimpleApi.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        //void Delete(long id);
        List<Person> FindAll();
        Person FindById(long id);
    }
}
