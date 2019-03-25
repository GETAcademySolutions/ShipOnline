using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ShipBaseCore.Interfaces.Repositories;
using ShipBaseCore.RepositoryInterfaces;
using ShipOnline.Persistence;

namespace ShipBaseCore.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ShipBaseDbContext DbContext { get; set; }

        public RepositoryBase(ShipBaseDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public IEnumerable<T> FindAll()
        {
            return DbContext.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return DbContext.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            DbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            DbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
