using Microsoft.EntityFrameworkCore.Migrations;

namespace AphasiaGreetingCards.Migrations
{
    public partial class addingThemeCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThemeCount",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
