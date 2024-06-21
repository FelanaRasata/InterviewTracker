using BackOffice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BackOffice.Databases
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Interview> Interviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Interview>()
                .HasOne(i => i.Job)
                .WithMany()
                .HasForeignKey(i => i.JobId);

            modelBuilder.Entity<Interview>()
                .HasOne(i => i.Applicant)
                .WithMany()
                .HasForeignKey(i => i.ApplicantId);
        }
    }
}
