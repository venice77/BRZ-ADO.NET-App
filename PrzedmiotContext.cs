using BiuroRzeczyZnalezionych.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiuroRzeczyZnalezionych
{
    public class PrzedmiotContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=BiuroRzeczyZnalezionych;User Id=brz;Password=brz");
            //optBuilder.UseSqlServer(@"Data Source = localhost\SQLEXPRESS;Initial Catalog=BiurzoRzeczyZnalezionych; User Id=brz;Password=brz; ");//Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            
        }
        public DbSet<PrzedmiotModel> Przedmioty { get; set; }
    }
}
