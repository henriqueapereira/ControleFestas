using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleFestas.Migrations
{
    /// <inheritdoc />
    public partial class rev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Convidado_ConvidadoId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_ConvidadoId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "ConvidadoId",
                table: "Evento");

            migrationBuilder.AddColumn<int>(
                name: "EventoId",
                table: "Convidado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Convidado_EventoId",
                table: "Convidado",
                column: "EventoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Convidado_Evento_EventoId",
                table: "Convidado",
                column: "EventoId",
                principalTable: "Evento",
                principalColumn: "EventoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Convidado_Evento_EventoId",
                table: "Convidado");

            migrationBuilder.DropIndex(
                name: "IX_Convidado_EventoId",
                table: "Convidado");

            migrationBuilder.DropColumn(
                name: "EventoId",
                table: "Convidado");

            migrationBuilder.AddColumn<int>(
                name: "ConvidadoId",
                table: "Evento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Evento_ConvidadoId",
                table: "Evento",
                column: "ConvidadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Convidado_ConvidadoId",
                table: "Evento",
                column: "ConvidadoId",
                principalTable: "Convidado",
                principalColumn: "ConvidadoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
