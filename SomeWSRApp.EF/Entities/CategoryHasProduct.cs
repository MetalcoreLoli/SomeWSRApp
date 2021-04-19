using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWSRApp.EF.Layer.Entities
{
    [Table("main.CategoryHasProduct")]
    public partial class CategoryHasProduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public bool IsDelete { get; set; }

        public virtual Category Category { get; set; }

        public virtual Product Product { get; set; }
    }
}
