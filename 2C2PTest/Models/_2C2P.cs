using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _2C2PTest.Models
{
    public partial class _2C2P : DbContext
    {
        public _2C2P()
        {
        }

        public _2C2P(DbContextOptions<_2C2P> options)
            : base(options)
        {
        }

        public virtual DbSet<Transaction2C2p> Transaction2C2ps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=2C2P;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction2C2p>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_Transaction");

                entity.ToTable("Transaction2C2P");

                entity.Property(e => e.TransactionId).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.FileType).HasMaxLength(3);

                entity.Property(e => e.OutputStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Payment).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
