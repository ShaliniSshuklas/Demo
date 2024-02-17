using Capex.DAL.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using User.Domain.Context;

namespace User.DAL.Repository
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly CAPEXContext _userCapexContext;
       
        public GenericRepository(CAPEXContext userCapexContext)
        {
            this._userCapexContext = userCapexContext;
            this.Entity = this._userCapexContext.Set<T>();
        }
        private DbSet<T> Entity;
        public async Task<T> AddAsync(T entity)
        {
            this.Entity.Add(entity);
            return entity;
        }

        public Task<List<T>> AddRangeAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync
            (Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, 
                IOrderedQueryable<T>> orderBy = null, string includeProperties = "",
            int skip = -1, int take = 0)
        {
            IQueryable<T> query = this.Entity;

            if(filter != null)
            {
                query = query.Where(filter);
            }
            if(orderBy != null)
            {
                return await orderBy.Invoke(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }
    }
}
