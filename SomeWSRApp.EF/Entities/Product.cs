using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWSRApp.EF.Layer.Entities
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            CategoryHasProduct = new HashSet<CategoryHasProduct>();
            SaleHasProduct = new HashSet<SaleHasProduct>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool IsDelete { get; set; }

        public virtual ICollection<CategoryHasProduct> CategoryHasProduct { get; set; }

        public virtual ICollection<SaleHasProduct> SaleHasProduct { get; set; }
    }
}
