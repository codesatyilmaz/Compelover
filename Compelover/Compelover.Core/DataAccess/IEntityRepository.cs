﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Compelover.Core.Entities;

namespace Compelover.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> fiLter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);

    }
}