using SimpleApi.Model;

namespace SimpleApi.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person Update(Person person);
        void Delete(long id);
        List<Person> FindAll();
        Person FindById(long id);
    }
}
