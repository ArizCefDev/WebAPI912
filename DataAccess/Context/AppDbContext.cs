using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Valyuta> Valyutas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-VD08C7OPT8H\\SQLEXPRESS; Database=ValAPIDBS; Trusted_Connection=true; Encrypt=false;");
        }
    }
}
