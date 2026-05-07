using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodPickerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCuisineType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mood",
                table: "Foods",
                newName: "TasteProfile");

            migrationBuilder.AddColumn<string>(
                name: "CuisineType",
                table: "Foods",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Moods",
                table: "Foods",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 360, "72g", "Thai", "Asian", "🥭", "8g", "Happy", "Mango Sticky Rice", "5g", "sweet,rich,creamy" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { "75g", "Korean", "Asian", "🍚", "16g", "Happy", "Bibimbap", "25g", "umami,bold,colourful" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 266, "33g", "Italian", "Global", "🍕", "10g", "Happy,Lazy", "Margherita Pizza", "11g", "sweet,cheesy,bold" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CuisineType", "Moods", "TasteProfile" },
                values: new object[] { "Global", "Happy", "bold,spicy,fun" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 436, "60g", "Japanese", "Asian", "🍜", "12g", "Sad,Tired", "Ramen", "22g", "umami,warm,soft" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 210, "38g", "South Asian", "Asian", "🍲", "4g", "Sad,Tired", "Khichdi", "9g", "mild,warm,soft" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 350, "40g", "American", "Global", "🧀", "14g", "Sad,Lazy", "Mac & Cheese", "14g", "sweet,cheesy,carb-rich" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "TasteProfile" },
                values: new object[] { 380, "40g", "French", "Global", "🍫", "22g", "Sad,Romantic", "Chocolate Lava Cake", "bittersweet,warm,rich" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 280, "54g", "Korean", "Asian", "🍢", "4g", "Stressed,Bored", "Tteokbokki", "7g", "spicy,chewy,sweet" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 180, "10g", "Thai", "Asian", "🍲", "5g", "Stressed", "Tom Yum Soup", "20g", "spicy,sour,warm" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 480, "52g", "Mexican", "Global", "24g", "Stressed,Bored", "Nachos", "14g", "salty,crunchy,cheesy" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 320, "40g", "Middle Eastern", "Global", "🥙", "12g", "Stressed", "Hummus & Pita", "11g", "salty,earthy,light" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 400, "48g", "Vietnamese", "Asian", "🍜", "10g", "Tired", "Pho", "27g", "warm,umami,light" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 438, "12g", "South Asian", "Asian", "🍗", "32g", "Tired,Sad", "Butter Chicken", "26g", "warm,rich,soft" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[] { 510, "58g", "Italian", "Global", "🍝", "21g", "Tired,Lazy", "Pasta Carbonara", "22g", "rich,warm,soft" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Carbs", "Cuisine", "CuisineType", "Emoji", "Fat", "Moods", "Name", "Protein", "TasteProfile" },
                values: new object[,]
                {
                    { 16, 180, "20g", "American", "Global", "🥣", "4g", "Tired,Sad", "Chicken Noodle Soup", "14g", "warm,mild,light" },
                    { 17, 350, "42g", "Japanese", "Asian", "🐙", "12g", "Bored", "Takoyaki", "14g", "umami,savoury,fun" },
                    { 18, 490, "28g", "Korean", "Asian", "🍗", "26g", "Bored,Happy", "Korean Fried Chicken", "30g", "salty,crunchy,sweet" },
                    { 19, 520, "58g", "American", "Global", "🍟", "26g", "Bored,Lazy", "Loaded Fries", "12g", "salty,crunchy,cheesy" },
                    { 20, 310, "40g", "Spanish", "Global", "🍩", "15g", "Bored,Happy", "Churros", "4g", "sweet,crunchy,fun" },
                    { 21, 480, "62g", "Japanese", "Asian", "🍣", "14g", "Romantic", "Sushi Platter", "24g", "umami,delicate,elegant" },
                    { 22, 470, "20g", "Chinese", "Asian", "🦆", "30g", "Romantic,Hungry", "Peking Duck", "28g", "rich,crispy,umami" },
                    { 23, 400, "42g", "Italian", "Global", "🍰", "22g", "Romantic,Happy", "Tiramisu", "7g", "bittersweet,rich,creamy" },
                    { 24, 440, "18g", "French", "Global", "🥩", "22g", "Romantic", "Beef Bourguignon", "32g", "rich,umami,hearty" },
                    { 25, 490, "55g", "South Asian", "Asian", "🍛", "14g", "Hungry", "Chicken Biryani", "28g", "spicy,hearty,aromatic" },
                    { 26, 500, "48g", "Malaysian", "Asian", "🍱", "22g", "Hungry", "Nasi Lemak", "22g", "rich,spicy,filling" },
                    { 27, 535, "40g", "American", "Global", "🍔", "29g", "Hungry,Bored", "Cheeseburger", "28g", "savoury,rich,hearty" },
                    { 28, 450, "38g", "Middle Eastern", "Global", "🌯", "18g", "Hungry", "Shawarma", "28g", "spicy,savoury,filling" },
                    { 29, 380, "52g", "Chinese", "Asian", "🍳", "14g", "Lazy,Tired", "Fried Rice", "12g", "savoury,familiar,easy" },
                    { 30, 400, "52g", "Thai", "Asian", "🍜", "11g", "Lazy", "Pad Thai", "20g", "sweet,savoury,familiar" },
                    { 31, 380, "30g", "American", "Global", "🥪", "22g", "Lazy,Sad", "Grilled Cheese Sandwich", "14g", "cheesy,warm,simple" },
                    { 32, 220, "16g", "Middle Eastern", "Global", "🍳", "12g", "Lazy", "Shakshuka", "12g", "savoury,warm,easy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DropColumn(
                name: "CuisineType",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Moods",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "TasteProfile",
                table: "Foods",
                newName: "Mood");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 266, "33g", "Italian", "🍕", "10g", "comfort,cheesy", "Margherita Pizza", "11g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { "55g", "South Asian", "🍛", "14g", "hearty,spicy", "Chicken Biryani", "28g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 200, "38g", "Japanese", "🍣", "2g", "light,fresh", "Sushi Rolls", "9g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "Mood",
                value: "comfort,spicy");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 180, "14g", "American", "🥗", "11g", "light,healthy", "Caesar Salad", "8g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 400, "52g", "Thai", "🍜", "11g", "hearty,sweet", "Pad Thai", "20g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 438, "12g", "South Asian", "🍗", "32g", "comfort,hearty", "Butter Chicken", "26g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name" },
                values: new object[] { 150, "10g", "Mediterranean", "🥙", "11g", "light,fresh", "Greek Salad" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 436, "60g", "Japanese", "🍜", "12g", "comfort,hearty", "Ramen", "22g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 535, "40g", "American", "🍔", "29g", "comfort,cheesy", "Cheeseburger", "28g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 320, "42g", "Mediterranean", "13g", "light,healthy", "Falafel Wrap", "12g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 100, "6g", "Thai", "🍲", "3g", "light,spicy", "Tom Yum Soup", "8g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 510, "58g", "Italian", "🍝", "21g", "comfort,cheesy", "Pasta Carbonara", "22g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 595, "60g", "British", "🐟", "28g", "hearty,comfort", "Fish & Chips", "27g" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Calories", "Carbs", "Cuisine", "Emoji", "Fat", "Mood", "Name", "Protein" },
                values: new object[] { 210, "40g", "American", "🫐", "6g", "fresh,healthy", "Acai Bowl", "5g" });
        }
    }
}
