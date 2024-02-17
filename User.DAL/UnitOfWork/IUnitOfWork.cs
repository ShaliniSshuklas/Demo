using Capex.DAL.IRepository;
using System.Data;
using System.Data.SqlClient;

namespace Capex.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> GenericRepository<T>() where T : class;

        Task SaveAsync();

      //  Task<DataTable> ExecuteStoredProcedure(string command, List<SqlParameter> parameters = null);

        Task<DataTable> ExecuteSqlQuery(string sqlQuery);
    }
}
