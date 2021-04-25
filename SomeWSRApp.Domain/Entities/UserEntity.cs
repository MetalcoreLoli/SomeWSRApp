using SomeWSRApp.Domain.Layer.Configurations;
using SomeWSRApp.EF.Layer;
using System;

namespace SomeWSRApp.Domain.Layer.Entities
{
    public enum Role
    {
        Admin = 1, Client = 2, Manager = 3
    }
    public class UserEntity : Entity
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Login { get; set; }
       public string Password{ get; set; }

        public Role Role { get; set; }

        public static UserEntity CreateFrom(IEntityConfiguration<UserEntity> configuration)
        {
            var user = new UserEntity();
            return configuration.Configure(user);
        }
    }
}