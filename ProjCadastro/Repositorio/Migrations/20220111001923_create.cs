using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidadao",
                columns: table => new
                {
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    NomeMae = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidadao", x => x.Cpf);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeAtendimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeAtendimento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Cpf);
                });

            migrationBuilder.CreateTable(
                name: "Vacina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioCpf = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    unidadeAtendimentoId = table.Column<int>(type: "int", nullable: true),
                    vacinaId = table.Column<int>(type: "int", nullable: true),
                    dataagendamento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenda_UnidadeAtendimento_unidadeAtendimentoId",
                        column: x => x.unidadeAtendimentoId,
                        principalTable: "UnidadeAtendimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agenda_Usuario_usuarioCpf",
                        column: x => x.usuarioCpf,
                        principalTable: "Usuario",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agenda_Vacina_vacinaId",
                        column: x => x.vacinaId,
                        principalTable: "Vacina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarteiraVacina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vacinaId = table.Column<int>(type: "int", nullable: true),
                    cidadaoCpf = table.Column<string>(type: "nvarchar(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarteiraVacina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarteiraVacina_Cidadao_cidadaoCpf",
                        column: x => x.cidadaoCpf,
                        principalTable: "Cidadao",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarteiraVacina_Vacina_vacinaId",
                        column: x => x.vacinaId,
                        principalTable: "Vacina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_unidadeAtendimentoId",
                table: "Agenda",
                column: "unidadeAtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_usuarioCpf",
                table: "Agenda",
                column: "usuarioCpf");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_vacinaId",
                table: "Agenda",
                column: "vacinaId");

            migrationBuilder.CreateIndex(
                name: "IX_CarteiraVacina_cidadaoCpf",
                table: "CarteiraVacina",
                column: "cidadaoCpf");

            migrationBuilder.CreateIndex(
                name: "IX_CarteiraVacina_vacinaId",
                table: "CarteiraVacina",
                column: "vacinaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "CarteiraVacina");

            migrationBuilder.DropTable(
                name: "UnidadeAtendimento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cidadao");

            migrationBuilder.DropTable(
                name: "Vacina");
        }
    }
}
