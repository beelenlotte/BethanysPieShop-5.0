using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop_5._0.Migrations
{
    public partial class UpdateSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Apple Pie" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription", "Name" },
                values: new object[] { 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Blueberry Cheese Cake" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription", "ShortDescription" },
                values: new object[] { 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Plain cheese cake. Plain pleasure." });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies." });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription" },
                values: new object[] { 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg", false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies." });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription", "ShortDescription" },
                values: new object[] { 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "A Christmas favorite" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "InStock", "IsPieOfTheWeek", "LongDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", false, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies." });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription", "Price", "ShortDescription" },
                values: new object[] { 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", 12.95m, "Our Halloween favorite" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "LongDescription", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "My God, so sweet!" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies." });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "InStock", "IsPieOfTheWeek", "LongDescription" },
                values: new object[] { 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", false, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "InStock", "LongDescription", "Name" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg ", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg ", false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Applie Pie" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription", "Name" },
                values: new object[] { 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Blueberry Cheese cake" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription", "ShortDescription" },
                values: new object[] { 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "Plain cake, Plain pleasure" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow." });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription" },
                values: new object[] { 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow." });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription", "ShortDescription" },
                values: new object[] { 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "A christmas favorite" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "InStock", "IsPieOfTheWeek", "LongDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow." });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription", "Price", "ShortDescription" },
                values: new object[] { 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", 18.95m, "Our Halloween favorite!" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "LongDescription", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow.", "My god, so sweet!" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "IsPieOfTheWeek", "LongDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow." });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "InStock", "IsPieOfTheWeek", "LongDescription" },
                values: new object[] { 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmellow." });
        }
    }
}
