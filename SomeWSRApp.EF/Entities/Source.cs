using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWSRApp.EF.Layer.Entities
{
    [Table("Source")]
    public partial class Source
    {
        public Source()
        {
            Client = new HashSet<Client>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsDelete { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
