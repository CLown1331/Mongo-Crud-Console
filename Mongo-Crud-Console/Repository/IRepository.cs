using System;
using System.Collections.Generic;
using System.Text;
using Mongo_Crud_Console.Model;
using System.Linq.Expressions;

namespace Mongo_Crud_Console.Repository
{
    public interface IRepository<T> where T: EntityBase
    {
        T GetById(string id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T enity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
