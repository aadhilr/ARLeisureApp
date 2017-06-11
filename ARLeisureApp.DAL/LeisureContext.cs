using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARLeisureApp.Domain.LocationModels;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ARLeisureApp.DAL
{
   public class LeisureContext : DbContext
    {
        public LeisureContext()
            : base("ARLeisure")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        #region Location Model

        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationCategory> LocationCategories { get; set; }
        public DbSet<LocationArticle> LocationArticles { get; set; }
        public DbSet<LocationImage> LocationImages { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        
    } 
}
