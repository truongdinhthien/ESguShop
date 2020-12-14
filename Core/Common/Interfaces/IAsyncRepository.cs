using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Interfaces
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync<TKey>(TKey id);
        Task<List<T>> ListAsync(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? page = null,
            int? pageSize = null);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
