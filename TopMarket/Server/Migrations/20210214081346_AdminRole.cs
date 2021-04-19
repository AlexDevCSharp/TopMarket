using Microsoft.EntityFrameworkCore.Migrations;

namespace TopMarket.Server.Migrations
{
    public partial class AdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Insert into AspNetRoles (Id, [Name], NormalizedName)
Values('36ae4473-54c5-4063-8489-e0bb67c168ba', 'Admin', 'Admin')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
