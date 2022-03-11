using NorthwindProject.API.Models.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NorthwindProject.API.Models.DB.Repo
{
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(object id);
    }
}
