using Microsoft.EntityFrameworkCore;
using NorthwindProject.API.Models.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NorthwindProject.API.Models.DB.Repo
{
    public class EfRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public int Add(TEntity entity)
        {
            using (var context=new TContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                return context.SaveChanges();
            }
        }

        public int Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }

        public TEntity Get(object id)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context=new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public int Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
    }
}
