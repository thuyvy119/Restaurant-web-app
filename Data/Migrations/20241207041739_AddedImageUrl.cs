using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_RestaurantWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 7, "Cheese" },
                    { 8, "Bacon" },
                    { 9, "Onion" },
                    { 10, "Garlic" },
                    { 11, "Cucumber" },
                    { 12, "Croutons" },
                    { 13, "Egg" },
                    { 14, "Mayo" },
                    { 15, "Avocado" },
                    { 16, "Rice" },
                    { 17, "Soy Sauce" },
                    { 18, "Taco Shell" },
                    { 19, "Lime" },
                    { 20, "Chicken Breast" },
                    { 21, "Salsa" }
                });

            migrationBuilder.InsertData(
                table: "ProductIngredients",
                columns: new[] { "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 3 },
                    { 1, 4 },
                    { 3, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "Juicy beef patty with cheddar cheese, lettuce, tomato, and bacon on a toasted bun.", "https://littlesunnykitchen.com/shredded-chicken-tacos/", "Cheeseburger", 12m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "Soft corn tortillas with seasoned pulled pork, onions, cilantro, and salsa.", "https://littlesunnykitchen.com/shredded-chicken-tacos/", "Pork Tacos", 10m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { 1, "Grilled chicken breast served on romaine lettuce with Caesar dressing and croutons.", "https://littlesunnykitchen.com/shredded-chicken-tacos/", "Chicken Caesar Salad", 14m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { 2, "Stir-fried beef with vegetables like bell peppers, onions, and soy sauce, served with steamed rice.", "https://littlesunnykitchen.com/shredded-chicken-tacos/", "Beef Stir Fry", 16m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { 2, "Flour tortilla wrapped around seasoned chicken, rice, beans, and guacamole.", "https://littlesunnykitchen.com/shredded-chicken-tacos/", "Chicken Burrito", 12m, 20 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 6, 1, "Sliced avocado with a poached egg on toasted sourdough bread, topped with a sprinkle of chili flakes.", "https://littlesunnykitchen.com/shredded-chicken-tacos/", "Avocado Toast", 8m, 18 },
                    { 7, 4, "A tart lemon filling with a fluffy meringue top, baked in a buttery pie crust.", "https://littlesunnykitchen.com/shredded-chicken-tacos/", "Lemon Meringue Pie", 6m, 8 },
                    { 8, 5, "Tequila, lime juice, and triple sec served with a salted rim.", "https://littlesunnykitchen.com/shredded-chicken-tacos/", "Classic Margarita", 7m, 30 },
                    { 9, 3, "Ground beef with lettuce, tomato, cheese, and taco shell chips, topped with salsa and sour cream.", "https://littlesunnykitchen.com/shredded-chicken-tacos/", "Beef Taco Salad", 13m, 25 },
                    { 10, 2, "Slow-cooked ribs coated in BBQ sauce, served with mashed potatoes and coleslaw.", "https://littlesunnykitchen.com/shredded-chicken-tacos/", "Pork Ribs", 20m, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductIngredients",
                columns: new[] { "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 2 },
                    { 21, 2 },
                    { 12, 3 },
                    { 9, 4 },
                    { 10, 4 },
                    { 16, 4 },
                    { 17, 4 },
                    { 14, 5 },
                    { 15, 5 },
                    { 16, 5 },
                    { 13, 6 },
                    { 15, 6 },
                    { 19, 7 },
                    { 19, 8 },
                    { 1, 9 },
                    { 4, 9 },
                    { 6, 9 },
                    { 18, 9 },
                    { 2, 10 },
                    { 5, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ProductIngredients",
                keyColumns: new[] { "IngredientId", "ProductId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.InsertData(
                table: "ProductIngredients",
                columns: new[] { "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 5, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "", "Beef", 18m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "", "Pork", 18m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "Stock" },
                values: new object[] { 3, "", "Chicken salad", 16m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "Stock" },
                values: new object[] { 1, "", "", 20m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "Stock" },
                values: new object[] { 1, "", "Beef", 18m, 10 });
        }
    }
}
