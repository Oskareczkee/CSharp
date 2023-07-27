using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Language_Learning_App.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordToTranslate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WordTranslation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "ID", "Language", "WordToTranslate", "WordTranslation" },
                values: new object[,]
                {
                    { 1, 0, "Hello", "Cześć" },
                    { 2, 0, "Car", "Samochód" },
                    { 3, 0, "Castle", "Zamek" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Translations");
        }
    }
}
