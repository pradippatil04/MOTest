using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngines.Core.Base.Repositories
{
    /// <summary>
    ///  Genericrepository for basic opertion
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T: class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<T> InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
