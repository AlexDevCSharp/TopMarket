using Microsoft.EntityFrameworkCore.Migrations;

namespace TopMarket.Server.Migrations
{
    public partial class DiscountWeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df4d3070-5e26-4f78-bdd6-f9bb12f55a40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25c40167-4218-4f7e-a63f-bb6a80e2050e", "AQAAAAEAACcQAAAAEH5CyzlL6c1xQSMHgp84WrQOwmTKWaMgojPLcEgXEQSa4XMAkwzYFFh0PHOT5Ojd2Q==", "4129d102-87de-4d55-82d0-5527e0ab2647" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Poster", "Weight" },
                values: new object[] { "https://topmarketstorageaccount.blob.core.windows.net/products/14c5172d-a00f-48ca-9f3b-a642a05e312d.jpg", 500 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Poster", "Weight" },
                values: new object[] { "https://topmarketstorageaccount.blob.core.windows.net/products/18429064-d0a9-4ffa-a24e-1b459964189e.jpg", 500 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Poster", "Weight" },
                values: new object[] { "https://topmarketstorageaccount.blob.core.windows.net/products/8e3bd231-cdcc-4311-9dd7-c9aa1ca5271e.jpg", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Poster", "Weight" },
                values: new object[] { "https://topmarketstorageaccount.blob.core.windows.net/products/04dbca64-0d49-4b7a-8414-ac955e1931da.jpg", 250 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Poster", "Weight" },
                values: new object[] { "https://topmarketstorageaccount.blob.core.windows.net/products/ec4256c5-588e-4aa8-84c6-81114d2807f6.jpg", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Poster", "Weight" },
                values: new object[] { "https://topmarketstorageaccount.blob.core.windows.net/products/3c339ec1-26a6-42de-af6d-86812d7dc140.jpg", 500 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df4d3070-5e26-4f78-bdd6-f9bb12f55a40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43ebeda2-1450-4434-bdab-42efc1fd456d", "AQAAAAEAACcQAAAAEBvUUbqipHmZaRVv1KmgLICoLVXUJ+5wNlvzAnvrMG7QOLz6mhPvY++QR7guq2NulQ==", "d1461cf2-a817-4a1f-81b6-292ca185c20a" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Poster",
                value: "https://topmarket.blob.core.windows.net/products/1d65ccda-c283-4a42-871d-4ea2626acc29.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Poster",
                value: "https://topmarket.blob.core.windows.net/products/55813d0a-84b5-4fc0-98b3-a86ccf584a1f.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Poster",
                value: "https://topmarket.blob.core.windows.net/products/c65beb3d-da42-49f4-888c-ca4115af99e3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Poster",
                value: "https://topmarket.blob.core.windows.net/products/82b5851f-d8b0-4a78-83e6-face8d4b6ae1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Poster",
                value: "https://topmarket.blob.core.windows.net/products/b0a8a90d-9185-4bbd-9655-c33a44381c93.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Poster",
                value: "https://topmarket.blob.core.windows.net/products/8eba94d3-564b-43a5-b772-e9a191b92945.jpg");
        }
    }
}
