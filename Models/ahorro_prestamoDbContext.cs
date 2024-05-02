using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Models
{
    public partial class ahorro_prestamoDbContext : IdentityDbContext<User>
    {
        public ahorro_prestamoDbContext()
        {
        }

        public ahorro_prestamoDbContext(DbContextOptions<ahorro_prestamoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<CuentaBanco> CuentaBancos { get; set; } = null!;
        public virtual DbSet<Cuotum> Cuota { get; set; } = null!;
        public virtual DbSet<Garantium> Garantia { get; set; } = null!;
        public virtual DbSet<Inversione> Inversiones { get; set; } = null!;
        public virtual DbSet<Prestamo> Prestamos { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Genre)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdsCodprestamo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ids_codprestamo");

                entity.Property(e => e.IdsInversiones)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ids_inversiones");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.TipoCliente)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_cliente");

                entity.HasOne(d => d.BancoCuentaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.BancoCuenta)
                    .HasConstraintName("FK__Cliente__BancoCu__5DCAEF64");
            });

            modelBuilder.Entity<CuentaBanco>(entity =>
            {
                entity.HasKey(e => e.NumeroCuenta)
                    .HasName("PK__CuentaBa__C6D03FEACB8710E8");

                entity.ToTable("CuentaBanco");

                entity.Property(e => e.NumeroCuenta)
                    .ValueGeneratedNever()
                    .HasColumnName("Numero_cuenta");

                entity.Property(e => e.Banco)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("Id_cliente");

                entity.Property(e => e.TipoCuenta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_cuenta");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CuentaBancos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__CuentaBan__Id_cl__6383C8BA");
            });

            modelBuilder.Entity<Cuotum>(entity =>
            {
                entity.HasKey(e => e.IdCuotas)
                    .HasName("PK__Cuota__C76D30F2061D7C08");

                entity.Property(e => e.IdCuotas)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_cuotas");

                entity.Property(e => e.CodigoComprobante)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_comprobante");

                entity.Property(e => e.FechaPago)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_pago");

                entity.Property(e => e.FechaPlanificada)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_planificada");

                entity.Property(e => e.IdInversiones).HasColumnName("Id_inversiones");

                entity.Property(e => e.IdPrestamo).HasColumnName("Id_prestamo");

                entity.Property(e => e.Monto).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_pago");

                entity.HasOne(d => d.IdInversionesNavigation)
                    .WithMany(p => p.Cuota)
                    .HasForeignKey(d => d.IdInversiones)
                    .HasConstraintName("FK__Cuota__Id_invers__656C112C");

                entity.HasOne(d => d.IdPrestamoNavigation)
                    .WithMany(p => p.Cuota)
                    .HasForeignKey(d => d.IdPrestamo)
                    .HasConstraintName("FK__Cuota__Id_presta__6477ECF3");
            });

            modelBuilder.Entity<Garantium>(entity =>
            {
                entity.HasKey(e => e.IdGarantia)
                    .HasName("PK__Garantia__E0F0E7DB3A7C0206");

                entity.Property(e => e.IdGarantia)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_garantia");

                entity.Property(e => e.TipoGarantia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_garantia");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inversione>(entity =>
            {
                entity.HasKey(e => e.IdInversiones)
                    .HasName("PK__Inversio__C95AAE57FFB9E80D");

                entity.Property(e => e.IdInversiones).HasColumnName("Id_inversiones");

                entity.Property(e => e.FechaDevolucion)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_devolucion");

                entity.Property(e => e.FechaInversion)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_inversion");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_termino");

                entity.Property(e => e.IdCliente).HasColumnName("Id_cliente");

                entity.Property(e => e.IdCuentaBanco).HasColumnName("id_cuentaBanco");

                entity.Property(e => e.Interes).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MontoInversion)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Monto_inversion");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Inversiones)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__Inversion__Id_cl__619B8048");

                entity.HasOne(d => d.IdCuentaBancoNavigation)
                    .WithMany(p => p.Inversiones)
                    .HasForeignKey(d => d.IdCuentaBanco)
                    .HasConstraintName("FK__Inversion__id_cu__628FA481");
            });

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.HasKey(e => e.IdPrestamo)
                    .HasName("PK__Prestamo__7AFBEF26D6FFF503");

                entity.ToTable("Prestamo");

                entity.Property(e => e.IdPrestamo)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_prestamo");

                entity.Property(e => e.FechaAppro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_appro");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_inicio");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_solicitud");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_termino");

                entity.Property(e => e.IdClientPrestatario).HasColumnName("Id_client_prestatario");

                entity.Property(e => e.IdClienteFiador).HasColumnName("Id_cliente_Fiador");

                entity.Property(e => e.IdGarantia).HasColumnName("Id_Garantia");

                entity.Property(e => e.Interes).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdClientPrestatarioNavigation)
                    .WithMany(p => p.PrestamoIdClientPrestatarioNavigations)
                    .HasForeignKey(d => d.IdClientPrestatario)
                    .HasConstraintName("FK__Prestamo__Id_cli__5FB337D6");

                entity.HasOne(d => d.IdClienteFiadorNavigation)
                    .WithMany(p => p.PrestamoIdClienteFiadorNavigations)
                    .HasForeignKey(d => d.IdClienteFiador)
                    .HasConstraintName("FK__Prestamo__Id_cli__60A75C0F");

                entity.HasOne(d => d.IdGarantiaNavigation)
                    .WithMany(p => p.Prestamos)
                    .HasForeignKey(d => d.IdGarantia)
                    .HasConstraintName("FK__Prestamo__Id_Gar__5EBF139D");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__password__6EF57B66");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
