using SomeWSRApp.Domain.Layer.Entities;
using SomeWSRApp.EF.Layer;

namespace SomeWSRApp.Domain.Layer.Builders
{
    public interface IEntityBuilder <TEntity> where TEntity: Entity
    {
        IEntityBuilder<TEntity> WithId(int id);
        TEntity Construct();
    }
}