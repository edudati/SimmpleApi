﻿using SimpleApi.Model;
using SimpleApi.Repository;
using SimpleApi.Repository.Generic;

namespace SimpleApi.Business.Implementation
{
    public class BookBusinessImplementation : IBookBusiness
    {
        public readonly IRepository<Book> _repository;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

    }
}
