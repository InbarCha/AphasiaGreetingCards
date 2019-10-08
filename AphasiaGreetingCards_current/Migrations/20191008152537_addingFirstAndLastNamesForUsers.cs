using Microsoft.EntityFrameworkCore.Migrations;

namespace AphasiaGreetingCards.Migrations
{
    public partial class addingFirstAndLastNamesForUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
               name: "FirstName",
               table: "AspNetUsers",
               nullable: false,
               defaultValue: false);

            migrationBuilder.AddColumn<string>(
              name: "LastName",
              table: "AspNetUsers",
              nullable: false,
              defaultValue: false);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
