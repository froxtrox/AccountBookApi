// namespace AccountBookApi.Data.Repository
// {
//     public interface IRepository<TEntity> where TEntity : class, new()
//     {
//         IQueryable<TEntity> FindAll();
//         IQueryable<TEntity> FindByCondition(Expression<Func<T, bool>> expression);
//         Task<IEnumerable<TEntity>> GetAll();
//         Task<TEntity> Get();
//         Task<TEntity> AddAsync(TEntity entity);
//         Task<TEntity> AddRangeAsync(IEnumerable<TEntity> entities);
//         Task<TEntity> UpdateAsync(TEntity entity);
//         Task UpdateRangeAsync(IEnumerable<TEntity> entities);
//         Task Delete(TEntity entity);
//     }
// }

// using Ardalis.Specification;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AccountBookApi.Data.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<TEntity>> ListAllAsync(CancellationToken cancellationToken = default);
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(Guid Id, CancellationToken cancellationToken = default);
    }
}