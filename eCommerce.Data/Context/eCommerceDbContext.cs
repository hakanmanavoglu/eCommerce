using eCommerce.Core.Domain.DbEntities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace eCommerce.Data.Context
{
    public class eCommerceDbContext : DbContext
    {
        public eCommerceDbContext()
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
