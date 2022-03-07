using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop_5._0.Migrations
{
    public partial class AddSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Fruit pies", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cheese cakes", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Seasonal pies", null });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg ", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg ", false, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Applie Pie", 12.95m, "Our famous apple pies!" },
                    { 2, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Blueberry Cheese cake", 18.95m, "You'll love it!" },
                    { 3, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Cheese Cake", 18.95m, "Plain cake, Plain pleasure" },
                    { 4, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Cherry Pie", 15.95m, "A summer classic!" },
                    { 5, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Christmas Apple Pie", 13.95m, "Happy holidays with this pie!" },
                    { 6, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Cranberry Pie", 17.95m, "A christmas favorite" },
                    { 7, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Peach Pie", 15.95m, "Sweet as peach" },
                    { 9, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Rhubarb Pie", 15.95m, "My god, so sweet!" },
                    { 10, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Strawberry Pie", 15.95m, "Our delicious strawberry pie!" },
                    { 11, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Strawberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 8, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Pumpkin Pie", 18.95m, "Our Halloween favorite!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
