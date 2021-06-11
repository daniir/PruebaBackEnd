using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PruebaBachEnd.DBModels
{
    public partial class DBGestionGastosContext : DbContext
    {
        public DBGestionGastosContext()
        {
        }

        public DBGestionGastosContext(DbContextOptions<DBGestionGastosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Gasto> Gastos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-HMOFJD1\\SQLEXPRESS; database=DBGestionGastos; Trusted_Connection=false; User ID=sa; Password=r00tp455");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.HasKey(e => e.IdColaborador)
                    .HasName("PK__Gastos__A6A5C396F2BDE695");

                entity.Property(e => e.IdColaborador).HasColumnName("idColaborador");

                entity.Property(e => e.AprobadoPor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("aprobadoPor");

                entity.Property(e => e.Concepto)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("concepto");

                entity.Property(e => e.Cuenta1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cuenta1");

                entity.Property(e => e.Cuenta2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cuenta2");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("departamento");

                entity.Property(e => e.Descripcion1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descripcion1");

                entity.Property(e => e.Descripcion2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descripcion2");

                entity.Property(e => e.Fecha1)
                    .HasColumnType("date")
                    .HasColumnName("fecha1");

                entity.Property(e => e.Fecha2)
                    .HasColumnType("date")
                    .HasColumnName("fecha2");

                entity.Property(e => e.FechaDesde)
                    .HasColumnType("date")
                    .HasColumnName("fechaDesde");

                entity.Property(e => e.FechaHasta)
                    .HasColumnType("date")
                    .HasColumnName("fechaHasta");

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("montoTotal");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Posicion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("posicion");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("supervisor");

                entity.Property(e => e.Total1)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total1");

                entity.Property(e => e.Total2)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
