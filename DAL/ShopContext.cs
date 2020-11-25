using QuestAspMvc.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace QuestAspMvc.DAL
{
    public class ShopContext : DbContext
	{
        public ShopContext() : base("ShopContext")
        {
        }
		public DbSet<Article> Articles { get; set; }

        //Pour éviter que les noms des tables soient au "pluriel"
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}