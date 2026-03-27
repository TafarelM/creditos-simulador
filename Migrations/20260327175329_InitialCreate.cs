using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreditosApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductosCredito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Tea = table.Column<decimal>(type: "TEXT", nullable: false),
                    ComisionPct = table.Column<decimal>(type: "TEXT", nullable: false),
                    MinMeses = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxMeses = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosCredito", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductosCredito");
        }
    }
}
