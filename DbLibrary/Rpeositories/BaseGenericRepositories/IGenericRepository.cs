using DbModels.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Rpeositories.BaseGenericRepositories
{
    public interface IGenericRepositoryy<TEntity, TKey>
        where TEntity : class, IBaseEntity<TKey>
    {


        IEnumerable<TEntity> GetAll();
        TEntity GetById(TKey Id);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        void Commit();

    }
}
