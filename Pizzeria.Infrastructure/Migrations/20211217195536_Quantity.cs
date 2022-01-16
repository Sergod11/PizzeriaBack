using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzeria.Infrastructure.Migrations
{
    public partial class Quantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "Name", "Phone" },
                values: new object[] { 1, "DELIVERY ADDRESS", "seed@mail.ru", "Denis", "069353632" });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pizza" },
                    { 3, "Snack" },
                    { 2, "Drink" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Confirmed" },
                    { 3, "Delivered" }
                });

            migrationBuilder.InsertData(
                table: "PromotionalCodes",
                columns: new[] { "Id", "Code", "Discount", "ExpirationDate", "IsActive", "MaximumUses", "Name" },
                values: new object[] { 1, "MP100", 5m, new DateTime(2022, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), true, 1000, "Discount" });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "Description", "FoodCategoryId", "Name", "Price" },
                values: new object[] { 1, "Pizza Margherita (more commonly known in English as Margherita pizza) is a typical Neapolitan pizza, made with San Marzano tomatoes, mozzarella cheese, fresh basil, salt, and extra-virgin olive oil. ", 1, "Margarita", 50m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "DesiredDeliveryDateTime", "Note", "OrderStatusId", "OrderedAt", "PromotionalCodeId", "TotalPrice" },
                values: new object[] { 1, 1, new DateTime(2021, 12, 17, 2, 0, 0, 0, DateTimeKind.Local), "Second floor", 1, new DateTime(2021, 12, 17, 21, 55, 35, 682, DateTimeKind.Local).AddTicks(446), 1, 50m });

            migrationBuilder.InsertData(
                table: "FoodItemExtras",
                columns: new[] { "Id", "Description", "FoodItemId", "Name", "Price" },
                values: new object[] { 1, "Очень вкусно", 1, "Сырный бортик", 10m });

            migrationBuilder.InsertData(
                table: "OrderFoodItem",
                columns: new[] { "Id", "FoodItemId", "OrderId", "Quantity" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderFoodItemExtra",
                columns: new[] { "Id", "FoodItemExtraId", "OrderId" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderFoodItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderFoodItemExtra",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodItemExtras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PromotionalCodes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
