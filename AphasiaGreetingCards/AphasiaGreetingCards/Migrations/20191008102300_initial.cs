using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AphasiaGreetingCards.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GreetingCards",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    theme = table.Column<string>(nullable: true),
                    sendertUserID = table.Column<int>(nullable: false),
                    senderUserFullName = table.Column<string>(nullable: true),
                    recipientUserID = table.Column<int>(nullable: false),
                    recipientUserFullName = table.Column<string>(nullable: true),
                    sentenceID = table.Column<int>(nullable: false),
                    fullSentence = table.Column<string>(nullable: true),
                    imageID = table.Column<int>(nullable: false),
                    image = table.Column<string>(nullable: true),
                    publishedToFacebook = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GreetingCards", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    imagePath = table.Column<string>(nullable: true),
                    theme = table.Column<string>(nullable: true),
                    resolution = table.Column<string>(nullable: true),
                    digitalSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SentimentSentences",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    theme = table.Column<string>(nullable: true),
                    prefix = table.Column<string>(nullable: true),
                    recipientUserID = table.Column<int>(nullable: false),
                    recipientUserFullName = table.Column<string>(nullable: true),
                    suffix = table.Column<string>(nullable: true),
                    complexity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentimentSentences", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false),
                    birthdayDate = table.Column<DateTime>(nullable: false),
                    city = table.Column<string>(nullable: true),
                    isManager = table.Column<bool>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserID",
                table: "Users",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GreetingCards");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "SentimentSentences");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
