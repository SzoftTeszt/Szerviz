using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class SzervizContext : DbContext
    {
       
        public DbSet<Models.Szerelo> Szerelok { get; set; }
        public DbSet<Models.Javitas> Javitasok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SzervizDb261111;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
