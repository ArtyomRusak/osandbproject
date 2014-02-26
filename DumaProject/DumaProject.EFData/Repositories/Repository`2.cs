using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DumaProject.Core;
using DumaProject.Core.Exceptions;
using DumaProject.DALInterfaces;
using DumaProject.EFData.EFContext;
using DumaProject.Infrastructure.Guard;

namespace DumaProject.EFData.Repositories
{
    public class Repository<TEntity, TKey> : Repository, IRepository<TEntity, TKey> where TEntity : Entity
    {
        private readonly DbSet<TEntity> _entities;

        public Repository(DumaContext context)
            : base(context)
        {
            Guard.AgainstNullReference(context, "context");

            _entities = context.Set<TEntity>();
        }

        public void Create(TEntity value)
        {
            Guard.AgainstNullReference(value, "value");

            _entities.Add(value);
        }

        public void Update(TEntity value)
        {
            Guard.AgainstNullReference(value, "value");

            _entities.Attach(value);
            Context.Entry(value).State = EntityState.Modified;
        }

        public void Remove(TEntity value)
        {
            Guard.AgainstNullReference(value, "value");

            _entities.Remove(value);
        }

        public TEntity GetEntityById(TKey id)
        {
            try
            {
                return _entities.Find(id);
            }
            catch (Exception e)
            {
                throw new RepositoryException(e.Message);
            }
        }

        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            Guard.AgainstNullReference(predicate, "predicate");

            try
            {
                return _entities.Where(predicate).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message);
            }
        }

        public IQueryable<TEntity> All()
        {
            return _entities;
        }

        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
        {
            Guard.AgainstNullReference(predicate, "predicate");

            return _entities.Where(predicate);
        }
    }
}
