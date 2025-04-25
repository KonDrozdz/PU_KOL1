using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class ThirdOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "History",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "ActionType",
                table: "History",
                newName: "TypAkcji");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypAkcji",
                table: "History",
                newName: "ActionType");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "History",
                newName: "Date");
        }
    }
}
