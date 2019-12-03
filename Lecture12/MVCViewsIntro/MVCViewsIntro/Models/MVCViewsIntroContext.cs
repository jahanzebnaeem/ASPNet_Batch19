using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCViewsIntro.Models
{
    public class MVCViewsIntroContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http ://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVCViewsIntroContext() : base("name=MVCViewsIntroContext")
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }
    }
}
