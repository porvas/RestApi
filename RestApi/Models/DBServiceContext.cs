using System.Data.Entity;

namespace RestApi.API.Models
{
    public class DBServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx


        public DBServiceContext() : base("name=MyConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new SubcategoryMap());
        }

        public System.Data.Entity.DbSet<RestApi.API.Models.Ad> Ads { get; set; }

        public System.Data.Entity.DbSet<RestApi.API.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<RestApi.API.Models.Subcategory> Subcategories { get; set; }

        public System.Data.Entity.DbSet<RestApi.API.Models.Image> Images { get; set; }
    }
}
