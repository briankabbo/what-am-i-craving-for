using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodPickerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSessionIdToFavourite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "Favourites",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Favourites");
        }
    }
}
