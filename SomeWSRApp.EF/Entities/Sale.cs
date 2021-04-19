using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWSRApp.EF.Layer.Entities
{
    [Table("main.Sale")]
    public partial class Sale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sale()
        {
            HistoryOfSaleStatusModification = new HashSet<HistoryOfSaleStatusModification>();
            SaleHasProduct = new HashSet<SaleHasProduct>();
        }

        public int Id { get; set; }

        public int? ClientId { get; set; }

        public int? StatusOfSaleId { get; set; }

        public DateTime DataOfCreation { get; set; }

        public DateTime DateOfModification { get; set; }

        public decimal Sum { get; set; }

        public bool IsDelete { get; set; }

        public virtual Client Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryOfSaleStatusModification> HistoryOfSaleStatusModification { get; set; }

        public virtual StatusOfSale StatusOfSale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleHasProduct> SaleHasProduct { get; set; }
    }
}
