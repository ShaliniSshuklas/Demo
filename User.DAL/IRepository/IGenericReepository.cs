using System.Linq.Expressions;

namespace Capex.DAL.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "",
            int skip = -1,
            int take = 0
           );

        Task<T> GetAsync(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = ""

           );

        Task<T> GetByIdAsync(object id);

        Task<T> AddAsync(T entity);

        Task<List<T>> AddRangeAsync(List<T> entities);

        void Delete(T entity);

        void DeleteById(int id);

        void DeleteRange(List<T> entities);
    }
}
