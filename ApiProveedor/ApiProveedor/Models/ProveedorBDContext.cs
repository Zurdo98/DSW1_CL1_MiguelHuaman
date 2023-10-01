using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiProveedor.Models
{
    public partial class ProveedorBDContext : DbContext
    {
        public ProveedorBDContext()
        {
        }

        public ProveedorBDContext(DbContextOptions<ProveedorBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.ProveedorId)
                    .HasName("PK__Proveedo__61266BB9782982C4");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
