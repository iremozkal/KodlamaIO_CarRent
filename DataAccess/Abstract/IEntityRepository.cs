﻿using CarRent.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        T Get(Expression<Func<T, bool>> filter);
        int GetCount();
        bool IsExists(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}