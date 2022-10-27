using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ToDoEF.Models
{
    public partial class ToDoContext : DbContext
    {
        public ToDoContext()
        {
        }

        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("SERVER=.\\SQLEXPRESS;User=sa;Password=123456;Database=ToDo");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_100_CI_AS");

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("dateModified");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tasks_Users1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UQ__Users__C9F28456FB05C8E0")
                    .IsUnique();

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("dateModified");

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
