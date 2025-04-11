using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Domain;

namespace Infrastructure.Data
{
    public class AppDBContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

    }
}
