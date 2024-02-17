using Capex.DAL.IRepository;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using Capex.Domain.Context;
using Capex.DAL.Repository;

namespace Capex.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly CapexContext _context;
        private bool disposed = false;

        public UnitOfWork()
        {
            this._context = new CapexContext();
        }

        public IGenericRepository<T> GenericRepository<T>() where T : class
        {
            IGenericRepository<T> repo = new GenericReposiitory<T>(_context);
            return repo;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<DataTable> ExecuteStoredProcedure(string command, List<SqlParameter> parameters = null)
        {
            DataTable dt = new DataTable();

            using (DbCommand cmd = this._context.Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandText = command;
                cmd.CommandType = CommandType.StoredProcedure;

                parameters?.ForEach(p => cmd.Parameters.Add(p));

                this._context.Database.OpenConnection();

                using (DbDataReader result = await cmd.ExecuteReaderAsync())
                {
                    dt.Load(result);
                }
            }

            return dt;
        }

        public async Task<DataTable> ExecuteSqlQuery(string sqlQuery)
        {
            DataTable dt = new DataTable();

            using (DbCommand cmd = this._context.Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandText = sqlQuery;
                cmd.CommandType = CommandType.Text;

                this._context.Database.OpenConnection();

                using (DbDataReader result = await cmd.ExecuteReaderAsync())
                {
                    dt.Load(result);
                }
            }

            return dt;
        }

        #region IDisposable
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this._context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

