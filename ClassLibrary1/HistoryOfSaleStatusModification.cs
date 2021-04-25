namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
