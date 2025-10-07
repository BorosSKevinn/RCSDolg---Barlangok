using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RCSDolg.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_656 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barlangok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nev = table.Column<string>(type: "TEXT", nullable: false),
                    Hossz = table.Column<double>(type: "REAL", nullable: false),
                    Kiterjedes = table.Column<double>(type: "REAL", nullable: false),
                    Melyseg = table.Column<double>(type: "REAL", nullable: false),
                    Magassag = table.Column<double>(type: "REAL", nullable: false),
                    Telepules = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barlangok", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barlangok");
        }
    }
}
