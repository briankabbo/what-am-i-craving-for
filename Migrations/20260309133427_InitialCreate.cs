using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodPickerAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cuisine = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mood = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Carbs = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fat = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Emoji = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favourites_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[,]
                {
                    { 1, 266, "33g", "Italian", "🍕", "10g", "comfort,cheesy", "Margherita Pizza", "11g" },
                    { 2, 490, "55g", "South Asian", "🍛", "14g", "hearty,spicy", "Chicken Biryani", "28g" },
                    { 3, 200, "38g", "Japanese", "🍣", "2g", "light,fresh", "Sushi Rolls", "9g" },
                    { 4, 350, "28g", "Mexican", "🌮", "16g", "comfort,spicy", "Beef Tacos", "21g" },
                    { 5, 180, "14g", "American", "🥗", "11g", "light,healthy", "Caesar Salad", "8g" },
                    { 6, 400, "52g", "Thai", "🍜", "11g", "hearty,sweet", "Pad Thai", "20g" },
                    { 7, 438, "12g", "South Asian", "🍗", "32g", "comfort,hearty", "Butter Chicken", "26g" },
                    { 8, 150, "10g", "Mediterranean", "🥙", "11g", "light,fresh", "Greek Salad", "5g" },
                    { 9, 436, "60g", "Japanese", "🍜", "12g", "comfort,hearty", "Ramen", "22g" },
                    { 10, 535, "40g", "American", "🍔", "29g", "comfort,cheesy", "Cheeseburger", "28g" },
                    { 11, 320, "42g", "Mediterranean", "🧆", "13g", "light,healthy", "Falafel Wrap", "12g" },
                    { 12, 100, "6g", "Thai", "🍲", "3g", "light,spicy", "Tom Yum Soup", "8g" },
                    { 13, 510, "58g", "Italian", "🍝", "21g", "comfort,cheesy", "Pasta Carbonara", "22g" },
                    { 14, 595, "60g", "British", "🐟", "28g", "hearty,comfort", "Fish & Chips", "27g" },
                    { 15, 210, "40g", "American", "🫐", "6g", "fresh,healthy", "Acai Bowl", "5g" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_FoodId",
                table: "Favourites",
                column: "FoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
