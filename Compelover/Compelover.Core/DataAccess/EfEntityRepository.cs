using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Compelover.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Compelover.Core.DataAccess
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = new TContext();
            return context.Set<TEntity>().ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public void Add(TEntity entity)
        {
            using var context = new TContext();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using var context = new TContext();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            using var context=new TContext();
            return context.Set<TEntity>().Find(id);
        }
    }
}