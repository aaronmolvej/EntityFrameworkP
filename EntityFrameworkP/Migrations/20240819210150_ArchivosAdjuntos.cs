using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkP.Migrations
{
    /// <inheritdoc />
    public partial class ArchivosAdjuntos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pasos_Tareas_TareaId",
                table: "pasos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pasos",
                table: "pasos");

            migrationBuilder.RenameTable(
                name: "pasos",
                newName: "Pasos");

            migrationBuilder.RenameIndex(
                name: "IX_pasos_TareaId",
                table: "Pasos",
                newName: "IX_Pasos_TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pasos",
                table: "Pasos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ArchivosAdjuntos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TareaId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Orden = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchivosAdjuntos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArchivosAdjuntos_Tareas_TareaId",
                        column: x => x.TareaId,
                        principalTable: "Tareas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArchivosAdjuntos_TareaId",
                table: "ArchivosAdjuntos",
                column: "TareaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasos_Tareas_TareaId",
                table: "Pasos",
                column: "TareaId",
                principalTable: "Tareas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pasos_Tareas_TareaId",
                table: "Pasos");

            migrationBuilder.DropTable(
                name: "ArchivosAdjuntos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pasos",
                table: "Pasos");

            migrationBuilder.RenameTable(
                name: "Pasos",
                newName: "pasos");

            migrationBuilder.RenameIndex(
                name: "IX_Pasos_TareaId",
                table: "pasos",
                newName: "IX_pasos_TareaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pasos",
                table: "pasos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_pasos_Tareas_TareaId",
                table: "pasos",
                column: "TareaId",
                principalTable: "Tareas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
