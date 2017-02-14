using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLogic.Infrastructure
{
    public interface IEntityServiceBase<TEntity>
    {
        List<TEntity> GetAll();

        List<TEntity> GetAll(Expression<Func<TEntity, bool>> query);

        TEntity GetById(int id);

        void Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);

        void AddRange(IEnumerable<TEntity> entities);

        void Add(TEntity entity);

        void Delete(TEntity entity);
    }

    public abstract class EntityServiceBase<TEntity> : IEntityServiceBase<TEntity>
        
    {
        private readonly IRepository<TEntity> _repository;

        protected EntityServiceBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public IRepository<TEntity> Repository => _repository;

        public virtual List<TEntity> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public virtual List<TEntity> GetAll(Expression<Func<TEntity, bool>> query)
        {
            return _repository.GetAll().Where(query).ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<TEntity> entities)
        {
            _repository.UpdateRange(entities);
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            _repository.AddRange(entities);
        }

        public virtual void Add(TEntity entity) 
        {
            _repository.Add(entity);
        }

        public virtual void Delete(TEntity entity) 
        {
            _repository.Delete(entity);
        }
    }
}
