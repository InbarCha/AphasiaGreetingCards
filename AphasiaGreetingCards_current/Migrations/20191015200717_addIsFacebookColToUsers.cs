using Microsoft.EntityFrameworkCore.Migrations;

namespace AphasiaGreetingCards.Migrations
{
    public partial class addIsFacebookColToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isFacebook",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isFacebook",
                table: "AspNetUsers");
        }
    }
}
