using System;
using System.Threading.Tasks;

namespace SomeWSRApp.EF.Layer
{
    public interface IEntitiesContext
    {
        IEntitiesContext RegistryEntity<TTable>();
        IEntitiesContext FillEntity<TTable>();
        IEntitiesContext FillEntityAsync<TTable>();
        TEntity SelectEntityOf<TEntity>(Func<TEntity, bool> selector) where TEntity : class;
        Task<TEntity> SelectEntityOfAsync<TEntity>(Func<TEntity, bool> selector) where TEntity : class;
        TEntity SelectEntityFirstOf<TEntity>() where TEntity : class;
        Task<TEntity> SelectEntityFirstOfAsync<TEntity>() where TEntity : class;
        
    }
}