using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Interfaces.Repository
{
    public interface IBase<TEntity> where TEntity : class
    {
        Boolean Add(TEntity entity);
        Boolean Update(TEntity entity);
        Boolean Remove(TEntity entity);
        TEntity GetById(Guid ID);
        List<TEntity> GetAll();
    }
}
