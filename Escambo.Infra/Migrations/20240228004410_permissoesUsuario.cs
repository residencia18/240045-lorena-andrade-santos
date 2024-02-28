using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escambo.Infra.Migrations
{
    /// <inheritdoc />
    public partial class permissoesUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Permissoes",
                table: "Usuarios",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permissoes",
                table: "Usuarios");
        }
    }
}
