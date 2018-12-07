using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InvoiceApiVersion2.Models.Context
{
    public partial class InvoiceDatabaseContext : DbContext
    {
        public InvoiceDatabaseContext()
        {
        }

        public InvoiceDatabaseContext(DbContextOptions<InvoiceDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InvoiceMaster> InvoiceMaster { get; set; }
        public virtual DbSet<ParameterMaster> ParameterMaster { get; set; }
        public virtual DbSet<RuleDetails> RuleDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=ATHIRALI\\SQLEXPRESS;Database=InvoiceDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceMaster>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);
            });

            modelBuilder.Entity<ParameterMaster>(entity =>
            {
                entity.HasKey(e => e.ParameterId);
            });

            modelBuilder.Entity<RuleDetails>(entity =>
            {
                entity.HasKey(e => e.RuleId);

                entity.HasIndex(e => e.InvoiceId);

                entity.HasIndex(e => e.ParameterId);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.RuleDetails)
                    .HasForeignKey(d => d.InvoiceId);

                entity.HasOne(d => d.Parameter)
                    .WithMany(p => p.RuleDetails)
                    .HasForeignKey(d => d.ParameterId);
            });
        }
    }
}
