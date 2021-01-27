using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 552, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 549, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 550, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 550, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 550, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2021, 1, 23, 1, 7, 37, 550, DateTimeKind.Local).AddTicks(127));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 2 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 4 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 1, 5 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 1 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 2 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 2, 5 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 1 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 2 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 3, 3 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 1 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 4 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 4, 5 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 4 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 5, 5 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 1 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 2 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 3 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 6, 4 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 1 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 2 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 3 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 4 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "DisciplinaId" },
                keyValues: new object[] { 7, 5 },
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 376, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 372, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 373, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 373, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 373, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataIni",
                value: new DateTime(2021, 1, 8, 15, 34, 37, 373, DateTimeKind.Local).AddTicks(3281));
        }
    }
}
