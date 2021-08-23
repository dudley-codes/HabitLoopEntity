using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HabitLoop.Models
{
    public class HabitCountDbContext : DbContext
    {
        public DbSet<HabitCount> HabitCount { get; set; }

        public HabitCountDbContext(DbContextOptions<HabitCountDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HabitCount>().ToTable("HabitCount");
        }
    }
}
