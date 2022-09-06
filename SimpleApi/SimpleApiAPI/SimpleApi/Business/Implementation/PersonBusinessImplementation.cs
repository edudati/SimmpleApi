using SimpleApi.Business;
using SimpleApi.Model;
using SimpleApi.Model.Context;
using SimpleApi.Repository;
using SimpleApi.Repository.Generic;
using System;

namespace SimpleApi.Business.Implementation
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
        }
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }
    }
}
