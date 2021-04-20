using System;
using System.Threading.Tasks;
using SomeWSRApp.EF.Layer;

namespace SomeWSRApp.Domain.Layer.Services
{
    public abstract class AuthorizationService
    {

        protected readonly IEntitiesContext _entitiesContext;

        protected AuthorizationService(IEntitiesContext entitiesContext)
        {
            _entitiesContext = entitiesContext ?? throw new ArgumentNullException(nameof(entitiesContext));
        }

        public abstract Task<Entity> AuthorizeAsync(string login, string password);
    }
}