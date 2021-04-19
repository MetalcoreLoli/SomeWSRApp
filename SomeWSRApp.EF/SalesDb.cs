using System;
using System.Collections.Generic;
using System.Linq;
using SomeWSRApp.EF.Layer.Entities;

namespace SomeWSRApp.EF.Layer
{
    public class SalesDb : IEntitiesContext
    {
        private static readonly Lazy<SalesDb> _instance = new(() => new SalesDb());
        private static Lazy<EntityContext> _entity => new Lazy<EntityContext>(() => new EntityContext());
        private static Lazy<Dictionary<Type, IList<object>>> _dbCache 
            => new(() => new Dictionary<Type, IList<object>>()); 
        private SalesDb()
        {
        }
        
        public static SalesDb Instance => _instance.Value;


        public IEntitiesContext RegistryEntity<TTable>()
        {
            var type = typeof(TTable);
            if (!_dbCache.Value.ContainsKey(type)) 
                _dbCache.Value.Add(type, new List<object>());
            return this;
        }

        public IEntitiesContext FillEntity<TTable>()
        {
            throw new NotImplementedException();
        }

        public IEntitiesContext FillEntityAsync<TTable>()
        {
            throw new NotImplementedException();
        }

        public TEntity SelectEntityOf<TEntity>(Func<TEntity, bool> selector) where TEntity : class
        {
            return _entity.Value.Set<TEntity>().Local.FirstOrDefault(selector);
        }

        public TEntity SelectEntityFirstOf<TEntity>() where TEntity : class
        {
            return _entity.Value.Set<TEntity>().Local.FirstOrDefault();
        }
    }
}
