// <auto-generated />
using System;
using LeyAbsolutaWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeyAbsolutaWeb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeyAbsolutaWeb.Models.Expediente", b =>
                {
                    b.Property<int>("id_Expediente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abogado_Defensor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("IdMaterialJudicial")
                        .HasColumnType("int");

                    b.Property<int>("Id_Imputado")
                        .HasColumnType("int");

                    b.Property<int>("Id_MaterialJudicial")
                        .HasColumnType("int");

                    b.Property<int?>("ImputadoId")
                        .HasColumnType("int");

                    b.Property<string>("juez_Encargado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("num_Expediente")
                        .HasColumnType("int");

                    b.HasKey("id_Expediente");

                    b.HasIndex("IdMaterialJudicial");

                    b.HasIndex("ImputadoId");

                    b.ToTable("Expedientes");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.ExpedienteDetalle", b =>
                {
                    b.Property<int>("id_ExpedienteDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha_Final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Inicio")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdExpediente")
                        .HasColumnType("int");

                    b.Property<int>("Id_Expediente")
                        .HasColumnType("int");

                    b.HasKey("id_ExpedienteDetalle");

                    b.HasIndex("IdExpediente");

                    b.ToTable("ExpedienteDetalles");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.ExpedienteImputado", b =>
                {
                    b.Property<int>("id_Expediente_Imputado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaExpedienteImputado")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdExpediente")
                        .HasColumnType("int");

                    b.Property<int?>("IdImputado")
                        .HasColumnType("int");

                    b.Property<int>("Id_Imputado")
                        .HasColumnType("int");

                    b.Property<int>("Id_MaterialJudicial")
                        .HasColumnType("int");

                    b.Property<string>("NombreImputado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Expediente_Imputado");

                    b.HasIndex("IdExpediente");

                    b.HasIndex("IdImputado");

                    b.ToTable("ExpedienteImputados");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.ExpedienteImputadoDetalle", b =>
                {
                    b.Property<int>("id_Expediente_Imputado_Detalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdExpedienteImputado")
                        .HasColumnType("int");

                    b.Property<int>("Id_ExpedienteImputado")
                        .HasColumnType("int");

                    b.Property<int>("id_Resolucion")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("tipo_Materia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id_Expediente_Imputado_Detalle");

                    b.HasIndex("IdExpedienteImputado");

                    b.ToTable("ExpedienteImputadoDetalles");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.Imputado", b =>
                {
                    b.Property<int>("id_Imputado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ape1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ape2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_Imputado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("cedula")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id_Imputado");

                    b.ToTable("Imputados");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.MaterialJudicial", b =>
                {
                    b.Property<int>("id_MaterialJudicial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Encargado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_Material")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("cantidad_Expediente")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("id_MaterialJudicial");

                    b.ToTable("MaterialJudiciales");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.Resolucion", b =>
                {
                    b.Property<int>("id_Resolucion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion_Resolucion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id_Expediente_Detalle")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Expediente_Imputado")
                        .HasColumnType("int");

                    b.Property<int>("Id_Expediente_Imputado_Detalle")
                        .HasColumnType("int");

                    b.HasKey("id_Resolucion");

                    b.HasIndex("Id_Expediente_Imputado");

                    b.HasIndex("Id_Expediente_Imputado_Detalle");

                    b.ToTable("Resoluciones");
                });

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.Expediente", b =>
                {
                    b.HasOne("LeyAbsolutaWeb.Models.MaterialJudicial", "MaterialJudicial")
                        .WithMany()
                        .HasForeignKey("IdMaterialJudicial");

                    b.HasOne("LeyAbsolutaWeb.Models.Imputado", "Imputado")
                        .WithMany()
                        .HasForeignKey("ImputadoId");

                    b.Navigation("Imputado");

                    b.Navigation("MaterialJudicial");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.ExpedienteDetalle", b =>
                {
                    b.HasOne("LeyAbsolutaWeb.Models.Expediente", "Expediente")
                        .WithMany()
                        .HasForeignKey("IdExpediente");

                    b.Navigation("Expediente");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.ExpedienteImputado", b =>
                {
                    b.HasOne("LeyAbsolutaWeb.Models.MaterialJudicial", "MaterialJudicial")
                        .WithMany()
                        .HasForeignKey("IdExpediente");

                    b.HasOne("LeyAbsolutaWeb.Models.Imputado", "Imputado")
                        .WithMany()
                        .HasForeignKey("IdImputado");

                    b.Navigation("Imputado");

                    b.Navigation("MaterialJudicial");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.ExpedienteImputadoDetalle", b =>
                {
                    b.HasOne("LeyAbsolutaWeb.Models.ExpedienteImputado", "ExpedienteImputado")
                        .WithMany()
                        .HasForeignKey("IdExpedienteImputado");

                    b.Navigation("ExpedienteImputado");
                });

            modelBuilder.Entity("LeyAbsolutaWeb.Models.Resolucion", b =>
                {
                    b.HasOne("LeyAbsolutaWeb.Models.ExpedienteDetalle", "ExpedienteDetalle")
                        .WithMany()
                        .HasForeignKey("Id_Expediente_Imputado");

                    b.HasOne("LeyAbsolutaWeb.Models.ExpedienteImputadoDetalle", "ExpedienteImputadoDetalle")
                        .WithMany()
                        .HasForeignKey("Id_Expediente_Imputado_Detalle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpedienteDetalle");

                    b.Navigation("ExpedienteImputadoDetalle");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
