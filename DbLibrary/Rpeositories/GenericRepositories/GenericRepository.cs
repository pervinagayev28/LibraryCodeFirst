using DbLibrary.Contexts;
using DbLibrary.Rpeositories.BaseGenericRepositories;
using DbModels.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp10.Rpeositories.GenericRepositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepositoryy<TEntity, TKey>
                      where TEntity : class, IBaseEntity<TKey>


    {

        internal readonly MyDb context;
        internal readonly DbSet<TEntity> set;
        public GenericRepository()
        {
            context = new MyDb();
            set = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));
            set.Add(entity);
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll() =>
            set.ToList();

        public TEntity? GetById(TKey Id) =>
            set.Find(Id);

        public void Remove(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));
            set.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));
            set.Update(entity);
        }
    }
}
