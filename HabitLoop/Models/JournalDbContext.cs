using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HabitLoop.Models
{
    public class JournalDbContext : DbContext
    {
        public DbSet<Journal> Journals { get; set; }

        public JournalDbContext(DbContextOptions<JournalDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Journal>().ToTable("Journal");
        }
    }
}
