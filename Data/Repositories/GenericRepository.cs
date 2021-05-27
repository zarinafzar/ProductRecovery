using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data.Contexts;

namespace Data.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private readonly Context _ctx;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(Context ctx)
        {
            _ctx = ctx;
            this._dbSet = _ctx.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, params Expression<Func<TEntity, Object>>[] includeExps)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }
            if (orderby != null)
            {
                query = orderby(query);
            }

            return query.ToList();
        }

        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            if (_ctx.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _ctx.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_ctx.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbSet.Remove(entity);
        }

        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }
        public virtual void DeleteAllDetails(IEnumerable<TEntity> entity)
        {
            _dbSet.RemoveRange(entity);
        }
        public virtual void DeleteAllDetails(object Id)
        {
            var entity = Get();
            Delete(entity);
        }
        public virtual void DeleteAll(IEnumerable<TEntity> entity)
        {
            _dbSet.RemoveRange(entity);
        }
        public virtual void DeleteAll()
        {
            var entity = Get();
            Delete(entity);
        }

        public virtual void Trash(TEntity entity)
        {
            if (_ctx.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _ctx.Entry(entity).State = EntityState.Modified;
        }

    }
}
