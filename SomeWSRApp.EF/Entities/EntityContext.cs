using System.Data.Entity;

namespace SomeWSRApp.EF.Layer.Entities
{
    public partial class EntityContext : DbContext
    {
        public EntityContext()
            : base("name=EntityContext")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryHasProduct> CategoryHasProduct { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<DataOfUser> DataOfUser { get; set; }
        public virtual DbSet<HistoryOfSaleStatusModification> HistoryOfSaleStatusModification { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<SaleHasProduct> SaleHasProduct { get; set; }
        public virtual DbSet<Source> Source { get; set; }
        public virtual DbSet<StatusOfSale> StatusOfSale { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.CategoryHasProduct)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CategoryHasProduct)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SaleHasProduct)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.Sum)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Sale>()
                .HasMany(e => e.SaleHasProduct)
                .WithRequired(e => e.Sale)
                .WillCascadeOnDelete(false);
        }
    }
}
