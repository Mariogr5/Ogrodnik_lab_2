using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrodnik_lab2
{
    internal class DancersDBContext : DbContext
    {
        public DbSet<DancerDB> Dancerss { get; set; }
        public DancersDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@" Data Source = Danc .db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DancerDB>().HasData(
                new DancerDB() { id = 20, name = "", danceclass = "A", danceClubName = "", dancePartnerName = "" });
        }
    }
}
