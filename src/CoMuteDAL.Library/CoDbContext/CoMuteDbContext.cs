using CoMuteDAL.Library.CoMuteEntities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMuteDAL.Library.CoDbContext
{
    public class CoMuteDbContext : DbContext
    {
        public CoMuteDbContext(DbContextOptions options) : base(options)
        {

        }

        public CoMuteDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MDUMISENI\SQLEXPRESS;DATABASE=CoMuteDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<CarPool> CarPool { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<JoinCarPool> JoinCarPool { get; set; }
    }
}
