using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWSRApp.EF.Layer.Entities
{
    [Table("StatusOfSale")]
    public partial class StatusOfSale
    {
        public StatusOfSale()
        {
            HistoryOfSaleStatusModification = new HashSet<HistoryOfSaleStatusModification>();
            Sale = new HashSet<Sale>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public bool IsDelete { get; set; }

        public virtual ICollection<HistoryOfSaleStatusModification> HistoryOfSaleStatusModification { get; set; }

        public virtual ICollection<Sale> Sale { get; set; }
    }
}
