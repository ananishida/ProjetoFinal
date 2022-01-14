using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Usuario_usuarioCpf",
                table: "Agenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_usuarioCpf",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "usuarioCpf",
                table: "Agenda");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CidadaoCpf",
                table: "Usuario",
                type: "nvarchar(11)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dose",
                table: "CarteiraVacina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fabricante",
                table: "CarteiraVacina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Laboratório",
                table: "CarteiraVacina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lote",
                table: "CarteiraVacina",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dtVacina",
                table: "CarteiraVacina",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "usuarioId",
                table: "Agenda",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CidadaoCpf",
                table: "Usuario",
                column: "CidadaoCpf");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_usuarioId",
                table: "Agenda",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Usuario_usuarioId",
                table: "Agenda",
                column: "usuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Cidadao_CidadaoCpf",
                table: "Usuario",
                column: "CidadaoCpf",
                principalTable: "Cidadao",
                principalColumn: "Cpf",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Usuario_usuarioId",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Cidadao_CidadaoCpf",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_CidadaoCpf",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_usuarioId",
                table: "Agenda");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "CidadaoCpf",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Dose",
                table: "CarteiraVacina");

            migrationBuilder.DropColumn(
                name: "Fabricante",
                table: "CarteiraVacina");

            migrationBuilder.DropColumn(
                name: "Laboratório",
                table: "CarteiraVacina");

            migrationBuilder.DropColumn(
                name: "Lote",
                table: "CarteiraVacina");

            migrationBuilder.DropColumn(
                name: "dtVacina",
                table: "CarteiraVacina");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Agenda");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Usuario",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "usuarioCpf",
                table: "Agenda",
                type: "nvarchar(11)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "Cpf");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_usuarioCpf",
                table: "Agenda",
                column: "usuarioCpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Usuario_usuarioCpf",
                table: "Agenda",
                column: "usuarioCpf",
                principalTable: "Usuario",
                principalColumn: "Cpf",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
