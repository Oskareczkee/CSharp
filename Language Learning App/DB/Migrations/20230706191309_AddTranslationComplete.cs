using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Language_Learning_App.DB.Migrations
{
    /// <inheritdoc />
    public partial class AddTranslationComplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Translations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "ID",
                keyValue: 1,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "ID",
                keyValue: 2,
                column: "Completed",
                value: false);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "ID",
                keyValue: 3,
                column: "Completed",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Translations");
        }
    }
}
