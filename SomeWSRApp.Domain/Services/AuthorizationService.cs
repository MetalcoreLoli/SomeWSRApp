using System;
using System.Threading.Tasks;
using SomeWSRApp.Domain.Layer.Entities;
using SomeWSRApp.EF.Layer;

namespace SomeWSRApp.Domain.Layer.Services
{
    public class DefaultAuthorizationService : AuthorizationService
    {

        public DefaultAuthorizationService(IEntitiesContext context)
            : base (context)
        {
        }

        public override async Task<Entity> AuthorizeAsync(string login, string password)
        {
            var user = await _entitiesContext.SelectEntityOfAsync<UserEntity>(u => u.Login == login && u.Password == password);
            
            return user;
        }
    }
}