using System;
using System.Threading.Tasks;
using SomeWSRApp.Domain.Layer.Entities;
using SomeWSRApp.Domain.Layer.Services;
using SomeWSRApp.EF.Layer;

namespace SomeWSRApp.Domain.Layer.Queries
{
    public class UserAuthorizationQuery<TAuthorizationService> : IQueryAsync<UserEntity> 
        where TAuthorizationService : AuthorizationService
    {
        private TAuthorizationService _authorizationService;
        private readonly IEntitiesContext _entitiesContext;

        public UserAuthorizationQuery(IEntitiesContext entitiesContext)
        {
            _entitiesContext = entitiesContext ?? throw new ArgumentNullException(nameof(entitiesContext));
        }

        public async Task<UserEntity> ExecuteAsync()
        {
            _authorizationService =  Activator.CreateInstance(typeof(TAuthorizationService), _entitiesContext) as TAuthorizationService;
            return await _authorizationService.AuthorizeAsync("", "") as UserEntity;
        }
    }
}