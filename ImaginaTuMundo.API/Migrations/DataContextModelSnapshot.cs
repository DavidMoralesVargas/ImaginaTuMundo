﻿// <auto-generated />
using System;
using ImaginaTuMundo.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ImaginaTuMundo.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Inscripcion");
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
