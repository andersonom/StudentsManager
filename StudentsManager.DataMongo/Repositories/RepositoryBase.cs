using System;
using System.Linq;
using System.Collections.Generic;
using StudentManager.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MongoDB.Driver;
using StudentsManager.DataMongo.Context;
using StudentsManager.Domain.Bases;

namespace StudentsManager.DataMongo.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected StudentsManagerContext _context;

        public RepositoryBase(StudentsManagerContext context)
        {
            _context = context;
        }

        public IMongoCollection<TEntity> Get()
        {
            return _context.Database.GetCollection<TEntity>("");
        }

        public void Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedList<TEntity>> GetAllPagedAsync(int? pageSize, int? page)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, TEntity obj)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, TEntity obj)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        private bool _disposed;
        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context = null;
                    // Dispose other managed resources.
                }
                //release unmanaged resources.
            }
            _disposed = true;
        }
    }
}