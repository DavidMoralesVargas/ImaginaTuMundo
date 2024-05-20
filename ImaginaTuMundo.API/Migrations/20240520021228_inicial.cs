using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImaginaTuMundo.API.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asociaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nit = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RepresentacionJuridica = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asociaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ICBFs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEntidad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nit = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ICBFs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ninios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreMadre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombrePadre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ninios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepresentantesLegales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentantesLegales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MadresComunitarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CertificadoManipulacionAlimentos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AsociacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MadresComunitarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MadresComunitarias_Asociaciones_AsociacionId",
                        column: x => x.AsociacionId,
                        principalTable: "Asociaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistroCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarneVacunas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CremientoYDesarrollo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CuentaServicios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CedulaMama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CedulaPapa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sisben = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fosyga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICBFId = table.Column<int>(type: "int", nullable: false),
                    NiniosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscripcion_ICBFs_ICBFId",
                        column: x => x.ICBFId,
                        principalTable: "ICBFs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscripcion_Ninios_NiniosId",
                        column: x => x.NiniosId,
                        principalTable: "Ninios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TareasParaMadres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cronograma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asistencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Novedades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluacionDiaria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActividadesMensuales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EscalaEvaluacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICBFId = table.Column<int>(type: "int", nullable: false),
                    RepresentanteLegalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TareasParaMadres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TareasParaMadres_ICBFs_ICBFId",
                        column: x => x.ICBFId,
                        principalTable: "ICBFs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TareasParaMadres_RepresentantesLegales_RepresentanteLegalId",
                        column: x => x.RepresentanteLegalId,
                        principalTable: "RepresentantesLegales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionesMadresNinios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MadreComunitariaId = table.Column<int>(type: "int", nullable: false),
                    NiniosId = table.Column<int>(type: "int", nullable: false),
                    FechaAsignacionMadre = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionesMadresNinios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsignacionesMadresNinios_MadresComunitarias_MadreComunitariaId",
                        column: x => x.MadreComunitariaId,
                        principalTable: "MadresComunitarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignacionesMadresNinios_Ninios_NiniosId",
                        column: x => x.NiniosId,
                        principalTable: "Ninios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evidencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cronograma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asistencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Novedades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluacionDiaria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActividadesMensuales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EscalaEvaluacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDeEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RepresentanteLegalId = table.Column<int>(type: "int", nullable: false),
                    MadreComunitariaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evidencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evidencias_MadresComunitarias_MadreComunitariaId",
                        column: x => x.MadreComunitariaId,
                        principalTable: "MadresComunitarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evidencias_RepresentantesLegales_RepresentanteLegalId",
                        column: x => x.RepresentanteLegalId,
                        principalTable: "RepresentantesLegales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeguimientosNinios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cronograma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Asistencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Novedades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluacionDiaria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActividadesMensuales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EscalaEvaluacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAsignacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RepresentanteLegalId = table.Column<int>(type: "int", nullable: false),
                    MadreComunitariaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguimientosNinios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeguimientosNinios_MadresComunitarias_MadreComunitariaId",
                        column: x => x.MadreComunitariaId,
                        principalTable: "MadresComunitarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeguimientosNinios_RepresentantesLegales_RepresentanteLegalId",
                        column: x => x.RepresentanteLegalId,
                        principalTable: "RepresentantesLegales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesMadresNinios_MadreComunitariaId",
                table: "AsignacionesMadresNinios",
                column: "MadreComunitariaId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesMadresNinios_NiniosId",
                table: "AsignacionesMadresNinios",
                column: "NiniosId");

            migrationBuilder.CreateIndex(
                name: "IX_Evidencias_MadreComunitariaId",
                table: "Evidencias",
                column: "MadreComunitariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Evidencias_RepresentanteLegalId",
                table: "Evidencias",
                column: "RepresentanteLegalId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_ICBFId",
                table: "Inscripcion",
                column: "ICBFId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_NiniosId",
                table: "Inscripcion",
                column: "NiniosId");

            migrationBuilder.CreateIndex(
                name: "IX_MadresComunitarias_AsociacionId",
                table: "MadresComunitarias",
                column: "AsociacionId");

            migrationBuilder.CreateIndex(
                name: "IX_SeguimientosNinios_MadreComunitariaId",
                table: "SeguimientosNinios",
                column: "MadreComunitariaId");

            migrationBuilder.CreateIndex(
                name: "IX_SeguimientosNinios_RepresentanteLegalId",
                table: "SeguimientosNinios",
                column: "RepresentanteLegalId");

            migrationBuilder.CreateIndex(
                name: "IX_TareasParaMadres_ICBFId",
                table: "TareasParaMadres",
                column: "ICBFId");

            migrationBuilder.CreateIndex(
                name: "IX_TareasParaMadres_RepresentanteLegalId",
                table: "TareasParaMadres",
                column: "RepresentanteLegalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignacionesMadresNinios");

            migrationBuilder.DropTable(
                name: "Evidencias");

            migrationBuilder.DropTable(
                name: "Inscripcion");

            migrationBuilder.DropTable(
                name: "SeguimientosNinios");

            migrationBuilder.DropTable(
                name: "TareasParaMadres");

            migrationBuilder.DropTable(
                name: "Ninios");

            migrationBuilder.DropTable(
                name: "MadresComunitarias");

            migrationBuilder.DropTable(
                name: "ICBFs");

            migrationBuilder.DropTable(
                name: "RepresentantesLegales");

            migrationBuilder.DropTable(
                name: "Asociaciones");
        }
    }
}
