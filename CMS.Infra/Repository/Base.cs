using CMS.Dominio.Interfaces.Repository;
using CMS.Infra.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Infra.Repository
{
    public class Base<TEntity> : IDisposable, IBase<TEntity> where TEntity : class
    {
        private readonly Context Db = new Context();

        public bool Add(TEntity entity)
        {
            Db.Set<TEntity>().Add(entity);
            Db.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public List<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid ID)
        {
            return Db.Set<TEntity>().Find(ID);
        }

        public bool Remove(TEntity entity)
        {
            Db.Set<TEntity>().Remove(entity);
            Db.SaveChanges();
            return true;
        }

        public bool Update(TEntity entity)
        {
            Db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Db.SaveChanges();
            return true;
        }
    }
}
