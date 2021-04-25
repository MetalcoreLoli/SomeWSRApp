using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWSRApp.EF.Layer.Entities
{
    [Table("Client")]
    public partial class Client
    {
        public Client()
        {
            Sale = new HashSet<Sale>();
        }

        public int Id { get; set; }

        public int? SourceId { get; set; }

        public bool IsDelete { get; set; }

        public int? DataOfUserId { get; set; }

        public virtual DataOfUser DataOfUser { get; set; }

        public virtual Source Source { get; set; }

        public virtual ICollection<Sale> Sale { get; set; }
    }
}
