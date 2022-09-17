using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    public class IpAddressDataBase : DbContext
    {
        public DbSet<DataByIPAddress> IpAddress { get; set; } = null!;

        private string _connectionString;

        public IpAddressDataBase(string сonnectionString)
        {
            _connectionString = сonnectionString;

            // Гарантируем, что БД создана.

            Database.EnsureCreated(); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }
    }
}
