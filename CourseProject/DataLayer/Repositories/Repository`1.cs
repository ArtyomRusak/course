﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Exceptions;
using Core.InterfaceRepository;
using DataLayer.DBContext;
using Infrastructure.Guard.Validation;

namespace DataLayer.Repositories
{
    public class Repository<TEntity> : Repository, IRepository<TEntity> where TEntity : Entity
    {
        #region [Private members]

        private readonly DbSet<TEntity> _entities;

        #endregion


        #region [Ctor's]

        public Repository(BankContext context)
            : base(context)
        {
            _entities = Context.Set<TEntity>();
        }

        #endregion


        #region Implementation of IRepository<TEntity>

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

        public TEntity GetEntityById(int id)
        {
            Guard.AgainstNullReference(id, "id");

            try
            {
                return _entities.Find(id);
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message);
            }
        }

        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            Guard.AgainstNullReference(predicate, "predicate");

            try
            {
                return _entities.Where(predicate).SingleOrDefault();
            }
            catch (Exception e)
            {
                throw new RepositoryException(e.Message);
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

        #endregion
    }
}
