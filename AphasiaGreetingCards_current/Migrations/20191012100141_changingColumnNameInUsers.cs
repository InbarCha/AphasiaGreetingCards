using Microsoft.EntityFrameworkCore.Migrations;

namespace AphasiaGreetingCards.Migrations
{
    public partial class changingColumnNameInUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "recipientUserFullName",
                table: "SentimentSentences",
                newName: "recipientUserFirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "recipientUserFirstName",
                table: "SentimentSentences",
                newName: "recipientUserFullName");
        }
    }
}
