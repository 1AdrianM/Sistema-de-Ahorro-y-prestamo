﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;

#nullable disable

namespace Sistema_De_Ahorro_y_Prestamos_v2.Migrations
{
    [DbContext(typeof(ahorro_prestamoDbContext))]
    [Migration("20240509195550_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("BancoCuenta")
                        .HasColumnType("int");

                    b.Property<string>("Cedula")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("cedula");

                    b.Property<string>("Direccion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("direccion");

                    b.Property<string>("Genre")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IdsCodprestamo")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ids_codprestamo");

                    b.Property<string>("IdsInversiones")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ids_inversiones");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.Property<string>("Telefono")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("telefono");

                    b.Property<string>("TipoCliente")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Tipo_cliente");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BancoCuenta");

                    b.HasIndex("UserId");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.CuentaBanco", b =>
                {
                    b.Property<int>("NumeroCuenta")
                        .HasColumnType("int")
                        .HasColumnName("Numero_cuenta");

                    b.Property<string>("Banco")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("Id_cliente");

                    b.Property<string>("TipoCuenta")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Tipo_cuenta");

                    b.HasKey("NumeroCuenta")
                        .HasName("PK__CuentaBa__C6D03FEACB8710E8");

                    b.HasIndex("IdCliente");

                    b.ToTable("CuentaBanco", (string)null);
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Cuotum", b =>
                {
                    b.Property<int>("IdCuotas")
                        .HasColumnType("int")
                        .HasColumnName("Id_cuotas");

                    b.Property<string>("CodigoComprobante")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Codigo_comprobante");

                    b.Property<DateTime?>("FechaPago")
                        .HasColumnType("date")
                        .HasColumnName("Fecha_pago");

                    b.Property<DateTime?>("FechaPlanificada")
                        .HasColumnType("date")
                        .HasColumnName("Fecha_planificada");

                    b.Property<int?>("IdInversiones")
                        .HasColumnType("int")
                        .HasColumnName("Id_inversiones");

                    b.Property<int?>("IdPrestamo")
                        .HasColumnType("int")
                        .HasColumnName("Id_prestamo");

                    b.Property<decimal?>("Monto")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("TipoPago")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Tipo_pago");

                    b.HasKey("IdCuotas")
                        .HasName("PK__Cuota__C76D30F2061D7C08");

                    b.HasIndex("IdInversiones");

                    b.HasIndex("IdPrestamo");

                    b.ToTable("Cuota");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Garantium", b =>
                {
                    b.Property<int>("IdGarantia")
                        .HasColumnType("int")
                        .HasColumnName("Id_garantia");

                    b.Property<string>("TipoGarantia")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Tipo_garantia");

                    b.Property<string>("Ubicacion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Valor")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdGarantia")
                        .HasName("PK__Garantia__E0F0E7DB3A7C0206");

                    b.ToTable("Garantia");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Inversione", b =>
                {
                    b.Property<int>("IdInversiones")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_inversiones");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInversiones"), 1L, 1);

                    b.Property<DateTime?>("FechaDevolucion")
                        .HasColumnType("date")
                        .HasColumnName("Fecha_devolucion");

                    b.Property<DateTime?>("FechaInversion")
                        .HasColumnType("date")
                        .HasColumnName("Fecha_inversion");

                    b.Property<DateTime?>("FechaTermino")
                        .HasColumnType("date")
                        .HasColumnName("Fecha_termino");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("Id_cliente");

                    b.Property<int?>("IdCuentaBanco")
                        .HasColumnType("int")
                        .HasColumnName("id_cuentaBanco");

                    b.Property<decimal?>("Interes")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("MontoInversion")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("Monto_inversion");

                    b.HasKey("IdInversiones")
                        .HasName("PK__Inversio__C95AAE57FFB9E80D");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdCuentaBanco");

                    b.ToTable("Inversiones");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Prestamo", b =>
                {
                    b.Property<int>("IdPrestamo")
                        .HasColumnType("int")
                        .HasColumnName("Id_prestamo");

                    b.Property<DateTime?>("FechaAppro")
                        .HasColumnType("date")
                        .HasColumnName("Fecha_appro");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("date")
                        .HasColumnName("Fecha_inicio");

                    b.Property<DateTime?>("FechaSolicitud")
                        .HasColumnType("date")
                        .HasColumnName("Fecha_solicitud");

                    b.Property<DateTime?>("FechaTermino")
                        .HasColumnType("date")
                        .HasColumnName("Fecha_termino");

                    b.Property<int?>("IdClientPrestatario")
                        .HasColumnType("int")
                        .HasColumnName("Id_client_prestatario");

                    b.Property<int?>("IdClienteFiador")
                        .HasColumnType("int")
                        .HasColumnName("Id_cliente_Fiador");

                    b.Property<int?>("IdGarantia")
                        .HasColumnType("int")
                        .HasColumnName("Id_Garantia");

                    b.Property<decimal?>("Interes")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal?>("Monto")
                        .HasColumnType("decimal(18,0)");

                    b.HasKey("IdPrestamo")
                        .HasName("PK__Prestamo__7AFBEF26D6FFF503");

                    b.HasIndex("IdClientPrestatario");

                    b.HasIndex("IdClienteFiador");

                    b.HasIndex("IdGarantia");

                    b.ToTable("Prestamo", (string)null);
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Cliente", b =>
                {
                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.CuentaBanco", "BancoCuentaNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("BancoCuenta")
                        .HasConstraintName("FK__Cliente__BancoCu__5DCAEF64");

                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("BancoCuentaNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.CuentaBanco", b =>
                {
                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.Cliente", "IdClienteNavigation")
                        .WithMany("CuentaBancos")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK__CuentaBan__Id_cl__6383C8BA");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Cuotum", b =>
                {
                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.Inversione", "IdInversionesNavigation")
                        .WithMany("Cuota")
                        .HasForeignKey("IdInversiones")
                        .HasConstraintName("FK__Cuota__Id_invers__656C112C");

                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.Prestamo", "IdPrestamoNavigation")
                        .WithMany("Cuota")
                        .HasForeignKey("IdPrestamo")
                        .HasConstraintName("FK__Cuota__Id_presta__6477ECF3");

                    b.Navigation("IdInversionesNavigation");

                    b.Navigation("IdPrestamoNavigation");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Inversione", b =>
                {
                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Inversiones")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK__Inversion__Id_cl__619B8048");

                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.CuentaBanco", "IdCuentaBancoNavigation")
                        .WithMany("Inversiones")
                        .HasForeignKey("IdCuentaBanco")
                        .HasConstraintName("FK__Inversion__id_cu__628FA481");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdCuentaBancoNavigation");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Prestamo", b =>
                {
                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.Cliente", "IdClientPrestatarioNavigation")
                        .WithMany("PrestamoIdClientPrestatarioNavigations")
                        .HasForeignKey("IdClientPrestatario")
                        .HasConstraintName("FK__Prestamo__Id_cli__5FB337D6");

                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.Cliente", "IdClienteFiadorNavigation")
                        .WithMany("PrestamoIdClienteFiadorNavigations")
                        .HasForeignKey("IdClienteFiador")
                        .HasConstraintName("FK__Prestamo__Id_cli__60A75C0F");

                    b.HasOne("Sistema_De_Ahorro_y_Prestamos_v2.Models.Garantium", "IdGarantiaNavigation")
                        .WithMany("Prestamos")
                        .HasForeignKey("IdGarantia")
                        .HasConstraintName("FK__Prestamo__Id_Gar__5EBF139D");

                    b.Navigation("IdClientPrestatarioNavigation");

                    b.Navigation("IdClienteFiadorNavigation");

                    b.Navigation("IdGarantiaNavigation");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Cliente", b =>
                {
                    b.Navigation("CuentaBancos");

                    b.Navigation("Inversiones");

                    b.Navigation("PrestamoIdClientPrestatarioNavigations");

                    b.Navigation("PrestamoIdClienteFiadorNavigations");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.CuentaBanco", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Inversiones");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Garantium", b =>
                {
                    b.Navigation("Prestamos");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Inversione", b =>
                {
                    b.Navigation("Cuota");
                });

            modelBuilder.Entity("Sistema_De_Ahorro_y_Prestamos_v2.Models.Prestamo", b =>
                {
                    b.Navigation("Cuota");
                });
#pragma warning restore 612, 618
        }
    }
}
