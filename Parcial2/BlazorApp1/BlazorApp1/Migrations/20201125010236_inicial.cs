using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Vencimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Estimacion = table.Column<string>(type: "TEXT", nullable: true),
                    ResponsableId = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_ResponsableId",
                        column: x => x.ResponsableId,
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<string>(type: "TEXT", nullable: true),
                    RecursoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tareaid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_RecursoId",
                        column: x => x.RecursoId,
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalle_Tarea_Tareaid",
                        column: x => x.Tareaid,
                        principalTable: "Tarea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_RecursoId",
                table: "Detalle",
                column: "RecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Tareaid",
                table: "Detalle",
                column: "Tareaid");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_UsuarioId",
                table: "Recurso",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_ResponsableId",
                table: "Tarea",
                column: "ResponsableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
