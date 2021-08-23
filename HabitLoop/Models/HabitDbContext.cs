using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HabitLoop.Models 
{
    public class HabitDbContext : DbContext
    {
        public DbSet<Habit> Habits { get; set; }

        public HabitDbContext(DbContextOptions<HabitDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Habit>().ToTable("Habit");
        }
    }
}
