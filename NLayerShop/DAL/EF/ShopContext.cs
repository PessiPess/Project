using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL.EF
{
    class ShopContext : DbContext
    {
       
        public DbSet<Shop> Shops { get; set; }
        

        
        public ShopContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}
