using fondabTestShop.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace fondabTestShop.DAL
{
    public class fondabContext : DbContext
    {
        public fondabContext() : base("fondabContext")
        {
        }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}