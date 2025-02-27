﻿// <auto-generated />
using System;
using ImaginaTuMundo.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ImaginaTuMundo.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240529001858_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.AsignacionMadreNinio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaAsignacionMadre")
                        .HasColumnType("datetime2");

                    b.Property<int>("MadreComunitariaId")
                        .HasColumnType("int");

                    b.Property<int>("NiniosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MadreComunitariaId");

                    b.HasIndex("NiniosId");

                    b.ToTable("AsignacionesMadresNinios");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.Asociacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RepresentacionJuridica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rut")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Asociaciones");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.Evidencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActividadesMensuales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asistencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cronograma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EscalaEvaluacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvaluacionDiaria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeEnvio")
                        .HasColumnType("datetime2");

                    b.Property<int>("MadreComunitariaId")
                        .HasColumnType("int");

                    b.Property<string>("Novedades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RepresentanteLegalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MadreComunitariaId");

                    b.HasIndex("RepresentanteLegalId");

                    b.ToTable("Evidencias");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.ICBF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NombreEntidad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ICBFs");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.Inscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarneVacunas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CedulaMama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CedulaPapa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CremientoYDesarrollo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CuentaServicios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fosyga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ICBFId")
                        .HasColumnType("int");

                    b.Property<int>("NiniosId")
                        .HasColumnType("int");

                    b.Property<string>("RegistroCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sisben")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ICBFId");

                    b.HasIndex("NiniosId");

                    b.ToTable("Inscripciones");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.MadreComunitaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("AsociacionId")
                        .HasColumnType("int");

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificadoManipulacionAlimentos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AsociacionId");

                    b.ToTable("MadresComunitarias");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.Ninios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreMadre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombrePadre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Ninios");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.RepresentanteLegal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Barrio")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Rut")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("RepresentantesLegales");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.SeguimientoNinios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActividadesMensuales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asistencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cronograma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EscalaEvaluacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvaluacionDiaria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAsignacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MadreComunitariaId")
                        .HasColumnType("int");

                    b.Property<string>("Novedades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RepresentanteLegalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MadreComunitariaId");

                    b.HasIndex("RepresentanteLegalId");

                    b.ToTable("SeguimientosNinios");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.TareaParaMadre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActividadesMensuales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Asistencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cronograma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EscalaEvaluacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvaluacionDiaria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ICBFId")
                        .HasColumnType("int");

                    b.Property<string>("Novedades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RepresentanteLegalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ICBFId");

                    b.HasIndex("RepresentanteLegalId");

                    b.ToTable("TareasParaMadres");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.AsignacionMadreNinio", b =>
                {
                    b.HasOne("ImaginaTuMundo.Shared.Entidades.MadreComunitaria", "MadresComunitarias")
                        .WithMany("AsignacionesMadresNinios")
                        .HasForeignKey("MadreComunitariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImaginaTuMundo.Shared.Entidades.Ninios", "Ninios")
                        .WithMany("AsignacionesMadresNinios")
                        .HasForeignKey("NiniosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MadresComunitarias");

                    b.Navigation("Ninios");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.Evidencia", b =>
                {
                    b.HasOne("ImaginaTuMundo.Shared.Entidades.MadreComunitaria", "MadresComunitarias")
                        .WithMany("Evidencias")
                        .HasForeignKey("MadreComunitariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImaginaTuMundo.Shared.Entidades.RepresentanteLegal", "RepresentantesLegales")
                        .WithMany("Evidencias")
                        .HasForeignKey("RepresentanteLegalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MadresComunitarias");

                    b.Navigation("RepresentantesLegales");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.Inscripcion", b =>
                {
                    b.HasOne("ImaginaTuMundo.Shared.Entidades.ICBF", "ICBFs")
                        .WithMany("Inscripciones")
                        .HasForeignKey("ICBFId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImaginaTuMundo.Shared.Entidades.Ninios", "Ninios")
                        .WithMany("Inscripciones")
                        .HasForeignKey("NiniosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ICBFs");

                    b.Navigation("Ninios");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.MadreComunitaria", b =>
                {
                    b.HasOne("ImaginaTuMundo.Shared.Entidades.Asociacion", "Asociaciones")
                        .WithMany()
                        .HasForeignKey("AsociacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asociaciones");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.SeguimientoNinios", b =>
                {
                    b.HasOne("ImaginaTuMundo.Shared.Entidades.MadreComunitaria", "MadresComunitarias")
                        .WithMany("SeguimientosNinios")
                        .HasForeignKey("MadreComunitariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImaginaTuMundo.Shared.Entidades.RepresentanteLegal", "RepresentantesLegales")
                        .WithMany("SeguimientosNinios")
                        .HasForeignKey("RepresentanteLegalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MadresComunitarias");

                    b.Navigation("RepresentantesLegales");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.TareaParaMadre", b =>
                {
                    b.HasOne("ImaginaTuMundo.Shared.Entidades.ICBF", "ICBFs")
                        .WithMany("TareasParaMadres")
                        .HasForeignKey("ICBFId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImaginaTuMundo.Shared.Entidades.RepresentanteLegal", "RepresentantesLegales")
                        .WithMany("TareasParaMadres")
                        .HasForeignKey("RepresentanteLegalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ICBFs");

                    b.Navigation("RepresentantesLegales");
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
                    b.HasOne("ImaginaTuMundo.Shared.Entidades.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ImaginaTuMundo.Shared.Entidades.User", null)
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

                    b.HasOne("ImaginaTuMundo.Shared.Entidades.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ImaginaTuMundo.Shared.Entidades.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.ICBF", b =>
                {
                    b.Navigation("Inscripciones");

                    b.Navigation("TareasParaMadres");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.MadreComunitaria", b =>
                {
                    b.Navigation("AsignacionesMadresNinios");

                    b.Navigation("Evidencias");

                    b.Navigation("SeguimientosNinios");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.Ninios", b =>
                {
                    b.Navigation("AsignacionesMadresNinios");

                    b.Navigation("Inscripciones");
                });

            modelBuilder.Entity("ImaginaTuMundo.Shared.Entidades.RepresentanteLegal", b =>
                {
                    b.Navigation("Evidencias");

                    b.Navigation("SeguimientosNinios");

                    b.Navigation("TareasParaMadres");
                });
#pragma warning restore 612, 618
        }
    }
}
