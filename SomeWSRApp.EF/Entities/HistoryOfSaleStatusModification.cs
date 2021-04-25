using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeWSRApp.EF.Layer.Entities
{
    [Table("HistoryOfSaleStatusModification")]
    public partial class HistoryOfSaleStatusModification
    {
        public int Id { get; set; }

        public int? SaleId { get; set; }

        public int? StatusOfSaleId { get; set; }

        public DateTime ActiveFrom { get; set; }

        public DateTime ActiveTo { get; set; }

        public bool IsDelete { get; set; }

        public virtual Sale Sale { get; set; }

        public virtual StatusOfSale StatusOfSale { get; set; }
    }
}
