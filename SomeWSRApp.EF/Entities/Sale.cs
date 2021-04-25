using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWSRApp.EF.Layer.Entities
{
    [Table("Sale")]
    public partial class Sale
    {
        public Sale()
        {
            HistoryOfSaleStatusModification = new HashSet<HistoryOfSaleStatusModification>();
            SaleHasProduct = new HashSet<SaleHasProduct>();
        }

        public int Id { get; set; }

        public int ClientId { get; set; }

        public int? StatusOfSaleId { get; set; }

        public DateTime DataOfCreation { get; set; }

        public DateTime DateOfModification { get; set; }

        public decimal Sum { get; set; }

        public bool IsDelete { get; set; }

        public virtual Client Client { get; set; }

        public virtual ICollection<HistoryOfSaleStatusModification> HistoryOfSaleStatusModification { get; set; }

        public virtual StatusOfSale StatusOfSale { get; set; }

        public virtual ICollection<SaleHasProduct> SaleHasProduct { get; set; }
    }
}
