using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SistemaDeCadenasAlimenticias.Data.Entidades
{
    public partial class SistemaCadenasAlimenticiasParcial2PW3Context : DbContext
    {
        public SistemaCadenasAlimenticiasParcial2PW3Context()
        {
        }

        public SistemaCadenasAlimenticiasParcial2PW3Context(DbContextOptions<SistemaCadenasAlimenticiasParcial2PW3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cadena> Cadenas { get; set; } = null!;
        public virtual DbSet<Sucursal> Sucursals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.; Database=SistemaCadenasAlimenticias-Parcial2-PW3; Trusted_Connection=True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cadena>(entity =>
            {
                entity.ToTable("Cadena");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(50)
                    .HasColumnName("Razon_social");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.ToTable("Sucursal");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ciudad).HasMaxLength(50);

                entity.Property(e => e.Direccion).HasMaxLength(50);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Sucursal)
                    .HasForeignKey<Sucursal>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sucursal_Cadena");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
