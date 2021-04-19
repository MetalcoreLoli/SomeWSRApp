using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWSRApp.EF.Layer.Entities
{
    [Table("main.SaleHasProduct")]
    public partial class SaleHasProduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaleId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public bool IsDelete { get; set; }

        public virtual Product Product { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
