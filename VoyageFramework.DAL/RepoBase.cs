﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework.DAL
{
    public class RepoBase<T> : IRepo<T>, IDisposable where T : class
    {
        private BusAutomation db;
        public RepoBase(DbContext gymCtx)
        {
            db = (BusAutomation)gymCtx;
        }
        public T Add(T item)
        {
            return db.Set<T>().Add(item);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>().Where(predicate);
        }

        public ICollection<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            var propinfo = GetIdPropInfo();
            return db.Set<T>().SingleOrDefault(x => (int)propinfo.GetValue(x) == Id);
        }

        public void Remove(T item)
        {
            db.Set<T>().Remove(item);
        }

        public void Update(T item)
        {
            db.Entry<T>(item).State = EntityState.Modified;
        }
        private PropertyInfo GetIdPropInfo()
        {
            var tip = typeof(T);
            var className = tip.Name;
            var IdPropName = $"{className}Id";
            return tip.GetProperty(IdPropName);
        }
    }
}
