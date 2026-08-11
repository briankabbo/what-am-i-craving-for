using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodPickerAPI.Migrations
{
    /// <inheritdoc />
    public partial class OptimizeSessionIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SessionId",
                table: "Favourites",
                type: "varchar(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_SessionId",
                table: "Favourites",
                column: "SessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Favourites_SessionId",
                table: "Favourites");

            migrationBuilder.AlterColumn<string>(
                name: "SessionId",
                table: "Favourites",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(36)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
