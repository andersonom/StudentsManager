
using StudentsManager.Domain.Bases;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManager.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
         
        TEntity GetById(int id);

        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<PaginatedList<TEntity>> GetAllPagedAsync(int? pageSize = 1, int? page = 1);

        IEnumerable<TEntity> GetAll();

        void Update(int id, TEntity obj);
         
        void Remove(int id); 
    }
}