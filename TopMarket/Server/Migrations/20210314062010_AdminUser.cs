using Microsoft.EntityFrameworkCore.Migrations;

namespace TopMarket.Server.Migrations
{
    public partial class AdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "df4d3070-5e26-4f78-bdd6-f9bb12f55a40", 0, "71d24cc4-d935-4465-84d8-43be5f41af3b", "alexshefer1991@hotmail.com", true, false, null, "alexshefer1991@hotmail.com", "alexshefer1991@hotmail.com", "AQAAAAEAACcQAAAAEFgWoT+F+rJvWytnATylg8miGVW+wE1p+BR+TRDD6rVQJedgDIcNDX0bRlkQV9XfUg==", null, false, "e19c0851-f87f-4164-8f59-a7738b6c5d3e", false, "alexshefer1991@hotmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "df4d3070-5e26-4f78-bdd6-f9bb12f55a40" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df4d3070-5e26-4f78-bdd6-f9bb12f55a40");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "fruit and vegie" },
                    { 2, "meat" },
                    { 3, "bakaley" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dominican Republic" },
                    { 2, "United States" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Poster", "Price", "SubcatId", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "Ukraine", "https://topmarket.blob.core.windows.net/products/1d65ccda-c283-4a42-871d-4ea2626acc29.jpg", 15.5, 1, "Green", "Apple" },
                    { 2, "Juicy", "https://topmarket.blob.core.windows.net/products/55813d0a-84b5-4fc0-98b3-a86ccf584a1f.jpg", 35.0, 1, "Juicy", "Orange" },
                    { 3, "Myasokombinat", "https://topmarket.blob.core.windows.net/products/c65beb3d-da42-49f4-888c-ca4115af99e3.jpg", 350.0, 4, "NY", "Steak" },
                    { 4, "Myasokombinat", "https://topmarket.blob.core.windows.net/products/82b5851f-d8b0-4a78-83e6-face8d4b6ae1.jpg", 180.0, 3, "Frozen", "Ribs" },
                    { 5, "Darnica", "https://topmarket.blob.core.windows.net/products/b0a8a90d-9185-4bbd-9655-c33a44381c93.jpg", 17.300000000000001, 6, "Fresh", "Bagget" },
                    { 6, "Odessa", "https://topmarket.blob.core.windows.net/products/8eba94d3-564b-43a5-b772-e9a191b92945.jpg", 8.9000000000000004, 2, "Big", "Potato" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Santo Domingo" },
                    { 2, 1, "San Cristobal" },
                    { 3, 2, "Vermont" },
                    { 4, 2, "New York" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "fruit" },
                    { 2, 1, "vegi" },
                    { 3, 2, "pork" },
                    { 4, 2, "veal" },
                    { 5, 2, "lamb" },
                    { 6, 3, "bread" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Biography", "DateOfBirth", "Name", "Picture", "StateId" },
                values: new object[,]
                {
                    { 6, null, null, "Person 6", null, 1 },
                    { 7, null, null, "Person 7", null, 1 },
                    { 8, null, null, "Person 8", null, 1 },
                    { 9, null, null, "Person 9", null, 1 },
                    { 10, null, null, "Person 10", null, 1 },
                    { 11, null, null, "Person 11", null, 1 },
                    { 12, null, null, "Person 12", null, 1 },
                    { 13, null, null, "Person 13", null, 1 },
                    { 14, null, null, "Person 14", null, 1 }
                });
        }
    }
}
