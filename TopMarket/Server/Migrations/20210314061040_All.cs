using Microsoft.EntityFrameworkCore.Migrations;

namespace TopMarket.Server.Migrations
{
    public partial class All : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df4d3070-5e26-4f78-bdd6-f9bb12f55a40");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "df4d3070-5e26-4f78-bdd6-f9bb12f55a40", 0, "7cea8d8e-6e04-4e60-8a5a-7b8986fcbf81", "alexshefer1991@hotmail.com", true, false, null, "alexshefer1991@hotmail.com", "alexshefer1991@hotmail.com", "AQAAAAEAACcQAAAAEB2UbTGtdWnnIojE8bK9My2SnBSt/bXuu9Ra52efQALExy/hhqfHtf4va8r5i7o5xQ==", null, false, "29fa3674-2080-49e0-8c17-93e22418ab8a", false, "alexshefer1991@hotmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "df4d3070-5e26-4f78-bdd6-f9bb12f55a40" });
        }
    }
}
