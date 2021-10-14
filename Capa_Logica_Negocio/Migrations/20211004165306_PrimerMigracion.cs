using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Capa_Logica_Negocio.Migrations
{
    public partial class PrimerMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Cliente",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres_Cliente = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Apellidos_Cliente = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefono_Cliente = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Direccion_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Cliente", x => x.Id_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Oftalmologo",
                columns: table => new
                {
                    Id_Oftalmologo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres_Oftalmologo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Apellidos_Oftalmologo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Edad_Oftalmologo = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Telefono_Oftalmologo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Direccion_Oftalmologo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad_Oftalmologo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Oftalmologo", x => x.Id_Oftalmologo);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Paciente",
                columns: table => new
                {
                    Id_Paciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres_Paciente = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Apellidos_Paciente = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Edad_Paciente = table.Column<int>(type: "int", nullable: false),
                    Telefono_Paciente = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Direccion_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Paciente", x => x.Id_Paciente);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Tipo_Consulta",
                columns: table => new
                {
                    Id_Tipo_Consulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion_Tipo_Consulta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio_Tipo_Consulta = table.Column<decimal>(type: "decimal (18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Tipo_Consulta", x => x.Id_Tipo_Consulta);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Cuenta_Cliente",
                columns: table => new
                {
                    Id_Cuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Saldo_Cuenta = table.Column<decimal>(type: "decimal (18,4)", nullable: false),
                    Fecha_Cuenta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Cancelacion_Cuenta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saldada = table.Column<bool>(type: "bit", nullable: false),
                    IdCliente_Cuenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Cuenta_Cliente", x => x.Id_Cuenta);
                    table.ForeignKey(
                        name: "FK_tbl_Cuenta_Cliente_tbl_Cliente_IdCliente_Cuenta",
                        column: x => x.IdCliente_Cuenta,
                        principalTable: "tbl_Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Cita",
                columns: table => new
                {
                    Id_Cita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Cita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPaciente_Cita = table.Column<int>(type: "int", nullable: false),
                    IdOftalmologo_Cita = table.Column<int>(type: "int", nullable: false),
                    IdCliente_Cita = table.Column<int>(type: "int", nullable: false),
                    IdTipoConsulta_Cita = table.Column<int>(type: "int", nullable: false),
                    Estado_Cita = table.Column<bool>(type: "bit", nullable: false),
                    Fecha_Programacion_Cita = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Cita", x => x.Id_Cita);
                    table.ForeignKey(
                        name: "FK_tbl_Cita_tbl_Cliente_IdCliente_Cita",
                        column: x => x.IdCliente_Cita,
                        principalTable: "tbl_Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Cita_tbl_Oftalmologo_IdOftalmologo_Cita",
                        column: x => x.IdOftalmologo_Cita,
                        principalTable: "tbl_Oftalmologo",
                        principalColumn: "Id_Oftalmologo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Cita_tbl_Paciente_IdPaciente_Cita",
                        column: x => x.IdPaciente_Cita,
                        principalTable: "tbl_Paciente",
                        principalColumn: "Id_Paciente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Cita_tbl_Tipo_Consulta_IdTipoConsulta_Cita",
                        column: x => x.IdTipoConsulta_Cita,
                        principalTable: "tbl_Tipo_Consulta",
                        principalColumn: "Id_Tipo_Consulta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Pago",
                columns: table => new
                {
                    Id_Pago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCuenta_Pago = table.Column<int>(type: "int", nullable: false),
                    Fecha_Pago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Concepto_Pago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pagador_Pago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto_Pago = table.Column<decimal>(type: "decimal (18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Pago", x => x.Id_Pago);
                    table.ForeignKey(
                        name: "FK_tbl_Pago_tbl_Cuenta_Cliente_IdCuenta_Pago",
                        column: x => x.IdCuenta_Pago,
                        principalTable: "tbl_Cuenta_Cliente",
                        principalColumn: "Id_Cuenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Consulta",
                columns: table => new
                {
                    Id_Consulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Consulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion_Consulta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPaciente_Consulta = table.Column<int>(type: "int", nullable: false),
                    IdTipoConsulta_Consulta = table.Column<int>(type: "int", nullable: false),
                    Cita_Cita_Previa_Consulta = table.Column<bool>(type: "bit", nullable: false),
                    IdCita_Consulta = table.Column<int>(type: "int", nullable: false),
                    IdOftalmologo_Consulta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Consulta", x => x.Id_Consulta);
                    table.ForeignKey(
                        name: "FK_tbl_Consulta_tbl_Cita_IdCita_Consulta",
                        column: x => x.IdCita_Consulta,
                        principalTable: "tbl_Cita",
                        principalColumn: "Id_Cita",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Consulta_tbl_Oftalmologo_IdOftalmologo_Consulta",
                        column: x => x.IdOftalmologo_Consulta,
                        principalTable: "tbl_Oftalmologo",
                        principalColumn: "Id_Oftalmologo",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_tbl_Consulta_tbl_Paciente_IdPaciente_Consulta",
                        column: x => x.IdPaciente_Consulta,
                        principalTable: "tbl_Paciente",
                        principalColumn: "Id_Paciente",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_tbl_Consulta_tbl_Tipo_Consulta_IdTipoConsulta_Consulta",
                        column: x => x.IdTipoConsulta_Consulta,
                        principalTable: "tbl_Tipo_Consulta",
                        principalColumn: "Id_Tipo_Consulta",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Factura_Consulta",
                columns: table => new
                {
                    Id_Factura_Consulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Factura_Consulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCliente_Factura_Consulta = table.Column<int>(type: "int", nullable: false),
                    IdCita_Factura_Consulta = table.Column<int>(type: "int", nullable: false),
                    IVA_Factura_Consulta = table.Column<decimal>(type: "decimal (18,4)", nullable: false),
                    SubTotal_Factura_Consulta = table.Column<decimal>(type: "decimal (18,4)", nullable: false),
                    Total_Factura_Consulta = table.Column<decimal>(type: "decimal (18,4)", nullable: false),
                    Acreditada_Factura_Consulta = table.Column<bool>(type: "bit", nullable: false),
                    Deposito_Factura_Consulta = table.Column<decimal>(type: "decimal (18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Factura_Consulta", x => x.Id_Factura_Consulta);
                    table.ForeignKey(
                        name: "FK_tbl_Factura_Consulta_tbl_Cita_IdCita_Factura_Consulta",
                        column: x => x.IdCita_Factura_Consulta,
                        principalTable: "tbl_Cita",
                        principalColumn: "Id_Cita",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_tbl_Factura_Consulta_tbl_Cliente_IdCliente_Factura_Consulta",
                        column: x => x.IdCliente_Factura_Consulta,
                        principalTable: "tbl_Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Credito_Consulta",
                columns: table => new
                {
                    Id_Credito_Consulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFacturaConsulta_Credito_Consulta = table.Column<int>(type: "int", nullable: false),
                    Fecha_Credito_Consulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCuentaCliente_Credito_Consulta = table.Column<int>(type: "int", nullable: false),
                    Monto_Credito_Consulta = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    Decripcion_Credito_Consulta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Credito_Consulta", x => x.Id_Credito_Consulta);
                    table.ForeignKey(
                        name: "FK_tbl_Credito_Consulta_tbl_Cuenta_Cliente_IdCuentaCliente_Credito_Consulta",
                        column: x => x.IdCuentaCliente_Credito_Consulta,
                        principalTable: "tbl_Cuenta_Cliente",
                        principalColumn: "Id_Cuenta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Credito_Consulta_tbl_Factura_Consulta_IdFacturaConsulta_Credito_Consulta",
                        column: x => x.IdFacturaConsulta_Credito_Consulta,
                        principalTable: "tbl_Factura_Consulta",
                        principalColumn: "Id_Factura_Consulta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Cita_IdCliente_Cita",
                table: "tbl_Cita",
                column: "IdCliente_Cita");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Cita_IdOftalmologo_Cita",
                table: "tbl_Cita",
                column: "IdOftalmologo_Cita");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Cita_IdPaciente_Cita",
                table: "tbl_Cita",
                column: "IdPaciente_Cita");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Cita_IdTipoConsulta_Cita",
                table: "tbl_Cita",
                column: "IdTipoConsulta_Cita");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Consulta_IdCita_Consulta",
                table: "tbl_Consulta",
                column: "IdCita_Consulta");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Consulta_IdOftalmologo_Consulta",
                table: "tbl_Consulta",
                column: "IdOftalmologo_Consulta");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Consulta_IdPaciente_Consulta",
                table: "tbl_Consulta",
                column: "IdPaciente_Consulta");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Consulta_IdTipoConsulta_Consulta",
                table: "tbl_Consulta",
                column: "IdTipoConsulta_Consulta");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Credito_Consulta_IdCuentaCliente_Credito_Consulta",
                table: "tbl_Credito_Consulta",
                column: "IdCuentaCliente_Credito_Consulta");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Credito_Consulta_IdFacturaConsulta_Credito_Consulta",
                table: "tbl_Credito_Consulta",
                column: "IdFacturaConsulta_Credito_Consulta");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Cuenta_Cliente_IdCliente_Cuenta",
                table: "tbl_Cuenta_Cliente",
                column: "IdCliente_Cuenta");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Factura_Consulta_IdCita_Factura_Consulta",
                table: "tbl_Factura_Consulta",
                column: "IdCita_Factura_Consulta");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Factura_Consulta_IdCliente_Factura_Consulta",
                table: "tbl_Factura_Consulta",
                column: "IdCliente_Factura_Consulta");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Pago_IdCuenta_Pago",
                table: "tbl_Pago",
                column: "IdCuenta_Pago");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Consulta");

            migrationBuilder.DropTable(
                name: "tbl_Credito_Consulta");

            migrationBuilder.DropTable(
                name: "tbl_Pago");

            migrationBuilder.DropTable(
                name: "tbl_Factura_Consulta");

            migrationBuilder.DropTable(
                name: "tbl_Cuenta_Cliente");

            migrationBuilder.DropTable(
                name: "tbl_Cita");

            migrationBuilder.DropTable(
                name: "tbl_Cliente");

            migrationBuilder.DropTable(
                name: "tbl_Oftalmologo");

            migrationBuilder.DropTable(
                name: "tbl_Paciente");

            migrationBuilder.DropTable(
                name: "tbl_Tipo_Consulta");
        }
    }
}
