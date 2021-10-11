using SearchEngines.Core.Base.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchEngines.Core.Entities;
using SearchEngines.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace SearchEngines.Infrastructure.Base.Repositories
{
    /// <summary>
    /// Genericrepository for basic opertion
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _dbContext;
        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            //TODO
            // dummy output return
            return await _dbContext.Set<T>().ToListAsync();
        }

        public Task<T> GetAsync(int id)
        {
            //TODO
            //dummy output return
            return  null;
        }

        public Task<T> InsertAsync(T entity)
        {
            //TODO
            // dummy output return
            return null;
        }

        public Task UpdateAsync(T entity)
        {
            //TODO
            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            //TODO
            return Task.CompletedTask;
        }

    }
}
