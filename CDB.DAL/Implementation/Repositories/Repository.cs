﻿using CDB.Dal.DbContext;
using CDB.DAL.Abstraction.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CDB.DAL.Implementation.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext _db;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _db.Set<TEntity>().ToList();
        }

        public TEntity Get(object Id)
        {
            return _db.Set<TEntity>().Find(Id);
        }

        public void Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _db.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _db.Set<TEntity>().RemoveRange(entities);
        }

        public void Remove(object Id)
        {
            TEntity entity = _db.Set<TEntity>().Find(Id);
            this.Remove(entity);
        }

        public void Update(TEntity entity)
        {
        }
    }
}

