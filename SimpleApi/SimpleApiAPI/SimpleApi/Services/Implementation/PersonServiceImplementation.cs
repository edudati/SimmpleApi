using SimpleApi.Model;
using System;

namespace SimpleApi.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        //public Person Delete(long id){}

        public Person Update(Person person)
        {
            return person;
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                Person person = mockperson(1);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person(id, "Person" + id, "Last" + id);
        }

        private Person mockperson(int id)
        {
            return new Person(id, "Person" + id, "Last" + id);
        }
    }
}
