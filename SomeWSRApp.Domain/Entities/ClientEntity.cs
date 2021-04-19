
using SomeWSRApp.EF.Layer;

namespace SomeWSRApp.Domain.Layer.Entities
{
    public class ClientEntity : Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public SourceEntity Source { get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}