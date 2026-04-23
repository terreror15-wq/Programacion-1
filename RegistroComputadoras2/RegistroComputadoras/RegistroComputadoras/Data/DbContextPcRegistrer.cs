using Microsoft.EntityFrameworkCore;
using RegistroComputadoras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroComputadoras.Data
{
    public class DbContextPcRegistrer : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database = SystemPcManagement; Trusted_Connection = True; TrustServerCertificate = True");
        }
        public DbSet<Computer> Computers { get; set; }
    }
}
