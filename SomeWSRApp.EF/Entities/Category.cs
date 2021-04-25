using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWSRApp.EF.Layer.Entities
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            CategoryHasProduct = new HashSet<CategoryHasProduct>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public bool IsDelete { get; set; }

        public virtual ICollection<CategoryHasProduct> CategoryHasProduct { get; set; }
    }
}
