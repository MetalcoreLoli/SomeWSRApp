using SomeWSRApp.EF.Layer;

namespace SomeWSRApp.Domain.Layer.Entities
{
    public class UserEntity : Entity
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Login { get; set; }
       public string Password{ get; set; }
    }
}