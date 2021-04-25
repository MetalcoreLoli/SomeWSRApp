using SomeWSRApp.EF.Layer;

namespace SomeWSRApp.Domain.Layer.Entities
{
    public sealed class SourceEntity : Entity
    {
        public SourceEntity(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }
    }
}