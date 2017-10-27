using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week5_TODO.Models
{
    public class Week5_TODOContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Week5_TODOContext() : base("name=Week5_TODOContext")
        {
        }

        public System.Data.Entity.DbSet<Week5_TODO.Models.Item> Items { get; set; }

        public System.Data.Entity.DbSet<Week5_TODO.Models.List> Lists { get; set; }
    }
}
