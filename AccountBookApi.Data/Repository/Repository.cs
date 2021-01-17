using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AccountBookApi.Data;
using AccountBookApi.Domain;
using Microsoft.EntityFrameworkCore;
using AccountBookApi.Data.Repository.Interfaces;

namespace AccountBookApi.Data.Repository
{
    // Summary: EntityFrameworkCore Implementation
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly AccountBookDBContext _context;

        public Repository(AccountBookDBContext context)
        {
            _context = context;
        }






        public virtual async Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var keyValues = new object[] { id };
            return await _context.Set<TEntity>().FindAsync(keyValues, cancellationToken);
        }

        public async Task<IReadOnlyList<TEntity>> ListAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Set<TEntity>().ToListAsync(cancellationToken);
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }

        public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }


        public async Task DeleteAsync(Guid Id, CancellationToken cancellationToken = default)
        {
            var item = await this.GetByIdAsync(Id);
            await this.DeleteAsync(item);
        }
    }

}

