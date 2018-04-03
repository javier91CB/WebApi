using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERPQuala.Crosscutting.Model
{
    public class WebAPIDataContext : DbContext
    {
        public WebAPIDataContext(DbContextOptions<WebAPIDataContext> options):base(options)
        {

        }

        public DbSet<Product> Productos { get; set; }
    }
}
