using eCommerce.Core.Domain.DbEntities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace eCommerce.Data.Context
{
    public class eCommerceContext : DbContext
    {
        public eCommerceContext()
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
