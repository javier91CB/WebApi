using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERPQuala.Crosscutting.Model
{
    public class WebAPIDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Orders> Orders { get; set; }


        public WebAPIDataContext(DbContextOptions<WebAPIDataContext> options):base(options)
        {
        }

    }
}
