using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeyAbsolutaWeb.Data.Migrations
{
    public partial class migration : Migration
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
                name: "Imputados",
                columns: table => new
                {
                    id_Imputado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Imputado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cedula = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ape1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ape2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imputados", x => x.id_Imputado);
                });

            migrationBuilder.CreateTable(
                name: "MaterialJudiciales",
                columns: table => new
                {
                    id_MaterialJudicial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo_Material = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Encargado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cantidad_Expediente = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialJudiciales", x => x.id_MaterialJudicial);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "ExpedienteImputados",
                columns: table => new
                {
                    id_Expediente_Imputado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaExpedienteImputado = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    NombreImputado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_MaterialJudicial = table.Column<int>(type: "int", nullable: false),
                    IdExpediente = table.Column<int>(type: "int", nullable: true),
                    Id_Imputado = table.Column<int>(type: "int", nullable: false),
                    IdImputado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpedienteImputados", x => x.id_Expediente_Imputado);
                    table.ForeignKey(
                        name: "FK_ExpedienteImputados_Imputados_IdImputado",
                        column: x => x.IdImputado,
                        principalTable: "Imputados",
                        principalColumn: "id_Imputado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpedienteImputados_MaterialJudiciales_IdExpediente",
                        column: x => x.IdExpediente,
                        principalTable: "MaterialJudiciales",
                        principalColumn: "id_MaterialJudicial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expedientes",
                columns: table => new
                {
                    id_Expediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    num_Expediente = table.Column<int>(type: "int", nullable: false),
                    juez_Encargado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Abogado_Defensor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Imputado = table.Column<int>(type: "int", nullable: false),
                    ImputadoId = table.Column<int>(type: "int", nullable: true),
                    Id_MaterialJudicial = table.Column<int>(type: "int", nullable: false),
                    IdMaterialJudicial = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expedientes", x => x.id_Expediente);
                    table.ForeignKey(
                        name: "FK_Expedientes_Imputados_ImputadoId",
                        column: x => x.ImputadoId,
                        principalTable: "Imputados",
                        principalColumn: "id_Imputado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expedientes_MaterialJudiciales_IdMaterialJudicial",
                        column: x => x.IdMaterialJudicial,
                        principalTable: "MaterialJudiciales",
                        principalColumn: "id_MaterialJudicial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpedienteImputadoDetalles",
                columns: table => new
                {
                    id_Expediente_Imputado_Detalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Resolucion = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    tipo_Materia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_ExpedienteImputado = table.Column<int>(type: "int", nullable: false),
                    IdExpedienteImputado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpedienteImputadoDetalles", x => x.id_Expediente_Imputado_Detalle);
                    table.ForeignKey(
                        name: "FK_ExpedienteImputadoDetalles_ExpedienteImputados_IdExpedienteImputado",
                        column: x => x.IdExpedienteImputado,
                        principalTable: "ExpedienteImputados",
                        principalColumn: "id_Expediente_Imputado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpedienteDetalles",
                columns: table => new
                {
                    id_ExpedienteDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Fecha_Final = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Expediente = table.Column<int>(type: "int", nullable: false),
                    IdExpediente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpedienteDetalles", x => x.id_ExpedienteDetalle);
                    table.ForeignKey(
                        name: "FK_ExpedienteDetalles_Expedientes_IdExpediente",
                        column: x => x.IdExpediente,
                        principalTable: "Expedientes",
                        principalColumn: "id_Expediente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resoluciones",
                columns: table => new
                {
                    id_Resolucion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion_Resolucion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id_Expediente_Imputado_Detalle = table.Column<int>(type: "int", nullable: false),
                    Id_Expediente_Detalle = table.Column<int>(type: "int", nullable: false),
                    Id_Expediente_Imputado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resoluciones", x => x.id_Resolucion);
                    table.ForeignKey(
                        name: "FK_Resoluciones_ExpedienteDetalles_Id_Expediente_Imputado",
                        column: x => x.Id_Expediente_Imputado,
                        principalTable: "ExpedienteDetalles",
                        principalColumn: "id_ExpedienteDetalle",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resoluciones_ExpedienteImputadoDetalles_Id_Expediente_Imputado_Detalle",
                        column: x => x.Id_Expediente_Imputado_Detalle,
                        principalTable: "ExpedienteImputadoDetalles",
                        principalColumn: "id_Expediente_Imputado_Detalle",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_ExpedienteDetalles_IdExpediente",
                table: "ExpedienteDetalles",
                column: "IdExpediente");

            migrationBuilder.CreateIndex(
                name: "IX_ExpedienteImputadoDetalles_IdExpedienteImputado",
                table: "ExpedienteImputadoDetalles",
                column: "IdExpedienteImputado");

            migrationBuilder.CreateIndex(
                name: "IX_ExpedienteImputados_IdExpediente",
                table: "ExpedienteImputados",
                column: "IdExpediente");

            migrationBuilder.CreateIndex(
                name: "IX_ExpedienteImputados_IdImputado",
                table: "ExpedienteImputados",
                column: "IdImputado");

            migrationBuilder.CreateIndex(
                name: "IX_Expedientes_IdMaterialJudicial",
                table: "Expedientes",
                column: "IdMaterialJudicial");

            migrationBuilder.CreateIndex(
                name: "IX_Expedientes_ImputadoId",
                table: "Expedientes",
                column: "ImputadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Resoluciones_Id_Expediente_Imputado",
                table: "Resoluciones",
                column: "Id_Expediente_Imputado");

            migrationBuilder.CreateIndex(
                name: "IX_Resoluciones_Id_Expediente_Imputado_Detalle",
                table: "Resoluciones",
                column: "Id_Expediente_Imputado_Detalle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Resoluciones");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ExpedienteDetalles");

            migrationBuilder.DropTable(
                name: "ExpedienteImputadoDetalles");

            migrationBuilder.DropTable(
                name: "Expedientes");

            migrationBuilder.DropTable(
                name: "ExpedienteImputados");

            migrationBuilder.DropTable(
                name: "Imputados");

            migrationBuilder.DropTable(
                name: "MaterialJudiciales");
        }
    }
}
