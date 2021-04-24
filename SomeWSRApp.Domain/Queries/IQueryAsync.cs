using System.Threading.Tasks;

namespace SomeWSRApp.Domain.Layer.Queries
{
    public interface IQueryAsync<TResult>
    {
        Task<TResult> ExecuteAsync();
    }
}