using SomeWSRApp.Domain.Layer.Entities;
using SomeWSRApp.EF.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeWSRApp.Domain.Layer.Configurations
{
    public class UserEntityConfiguration : IEntityConfiguration<UserEntity>
    {
        private readonly DataOfUser _user;

        public UserEntityConfiguration(DataOfUser user)
        {
            _user = user;
        }

        public UserEntity Configure(UserEntity value)
        {
            throw new Exception();
        }
    }
}
