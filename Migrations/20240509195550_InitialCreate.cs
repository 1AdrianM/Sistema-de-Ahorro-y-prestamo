using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_De_Ahorro_y_Prestamos_v2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Garantia",
                columns: table => new
                {
                    Id_garantia = table.Column<int>(type: "int", nullable: false),
                    Tipo_garantia = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Valor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ubicacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Garantia__E0F0E7DB3A7C0206", x => x.Id_garantia);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_cliente = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    cedula = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    BancoCuenta = table.Column<int>(type: "int", nullable: true),
                    direccion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    telefono = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ids_codprestamo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ids_inversiones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Genre = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cliente_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CuentaBanco",
                columns: table => new
                {
                    Numero_cuenta = table.Column<int>(type: "int", nullable: false),
                    Id_cliente = table.Column<int>(type: "int", nullable: true),
                    Banco = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tipo_cuenta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CuentaBa__C6D03FEACB8710E8", x => x.Numero_cuenta);
                    table.ForeignKey(
                        name: "FK__CuentaBan__Id_cl__6383C8BA",
                        column: x => x.Id_cliente,
                        principalTable: "Cliente",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    Id_prestamo = table.Column<int>(type: "int", nullable: false),
                    Fecha_solicitud = table.Column<DateTime>(type: "date", nullable: true),
                    Fecha_appro = table.Column<DateTime>(type: "date", nullable: true),
                    Fecha_inicio = table.Column<DateTime>(type: "date", nullable: true),
                    Fecha_termino = table.Column<DateTime>(type: "date", nullable: true),
                    Id_cliente_Fiador = table.Column<int>(type: "int", nullable: true),
                    Id_client_prestatario = table.Column<int>(type: "int", nullable: true),
                    Id_Garantia = table.Column<int>(type: "int", nullable: true),
                    Monto = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Interes = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prestamo__7AFBEF26D6FFF503", x => x.Id_prestamo);
                    table.ForeignKey(
                        name: "FK__Prestamo__Id_cli__5FB337D6",
                        column: x => x.Id_client_prestatario,
                        principalTable: "Cliente",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Prestamo__Id_cli__60A75C0F",
                        column: x => x.Id_cliente_Fiador,
                        principalTable: "Cliente",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Prestamo__Id_Gar__5EBF139D",
                        column: x => x.Id_Garantia,
                        principalTable: "Garantia",
                        principalColumn: "Id_garantia");
                });

            migrationBuilder.CreateTable(
                name: "Inversiones",
                columns: table => new
                {
                    Id_inversiones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monto_inversion = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Interes = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    Fecha_inversion = table.Column<DateTime>(type: "date", nullable: true),
                    Fecha_termino = table.Column<DateTime>(type: "date", nullable: true),
                    Fecha_devolucion = table.Column<DateTime>(type: "date", nullable: true),
                    Id_cliente = table.Column<int>(type: "int", nullable: true),
                    id_cuentaBanco = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Inversio__C95AAE57FFB9E80D", x => x.Id_inversiones);
                    table.ForeignKey(
                        name: "FK__Inversion__Id_cl__619B8048",
                        column: x => x.Id_cliente,
                        principalTable: "Cliente",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Inversion__id_cu__628FA481",
                        column: x => x.id_cuentaBanco,
                        principalTable: "CuentaBanco",
                        principalColumn: "Numero_cuenta");
                });

            migrationBuilder.CreateTable(
                name: "Cuota",
                columns: table => new
                {
                    Id_cuotas = table.Column<int>(type: "int", nullable: false),
                    Id_prestamo = table.Column<int>(type: "int", nullable: true),
                    Id_inversiones = table.Column<int>(type: "int", nullable: true),
                    Fecha_planificada = table.Column<DateTime>(type: "date", nullable: true),
                    Monto = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Fecha_pago = table.Column<DateTime>(type: "date", nullable: true),
                    Tipo_pago = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Codigo_comprobante = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cuota__C76D30F2061D7C08", x => x.Id_cuotas);
                    table.ForeignKey(
                        name: "FK__Cuota__Id_invers__656C112C",
                        column: x => x.Id_inversiones,
                        principalTable: "Inversiones",
                        principalColumn: "Id_inversiones");
                    table.ForeignKey(
                        name: "FK__Cuota__Id_presta__6477ECF3",
                        column: x => x.Id_prestamo,
                        principalTable: "Prestamo",
                        principalColumn: "Id_prestamo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_BancoCuenta",
                table: "Cliente",
                column: "BancoCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_UserId",
                table: "Cliente",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaBanco_Id_cliente",
                table: "CuentaBanco",
                column: "Id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Cuota_Id_inversiones",
                table: "Cuota",
                column: "Id_inversiones");

            migrationBuilder.CreateIndex(
                name: "IX_Cuota_Id_prestamo",
                table: "Cuota",
                column: "Id_prestamo");

            migrationBuilder.CreateIndex(
                name: "IX_Inversiones_Id_cliente",
                table: "Inversiones",
                column: "Id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Inversiones_id_cuentaBanco",
                table: "Inversiones",
                column: "id_cuentaBanco");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_Id_client_prestatario",
                table: "Prestamo",
                column: "Id_client_prestatario");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_Id_cliente_Fiador",
                table: "Prestamo",
                column: "Id_cliente_Fiador");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_Id_Garantia",
                table: "Prestamo",
                column: "Id_Garantia");

            migrationBuilder.AddForeignKey(
                name: "FK__Cliente__BancoCu__5DCAEF64",
                table: "Cliente",
                column: "BancoCuenta",
                principalTable: "CuentaBanco",
                principalColumn: "Numero_cuenta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_AspNetUsers_UserId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK__Cliente__BancoCu__5DCAEF64",
                table: "Cliente");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cuota");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Inversiones");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "Garantia");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CuentaBanco");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
