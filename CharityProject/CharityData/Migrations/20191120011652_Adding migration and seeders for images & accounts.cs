using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharityData.Migrations
{
    public partial class Addingmigrationandseedersforimagesaccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    username = table.Column<string>(maxLength: 50, nullable: false),
                    password = table.Column<string>(maxLength: 50, nullable: false),
                    imageId = table.Column<Guid>(nullable: false),
                    isUser = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "action",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: false),
                    actionType = table.Column<bool>(nullable: false),
                    organizationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_action", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "card",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    dateOfExpiry = table.Column<DateTime>(nullable: false),
                    bankName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_card", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "image",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "item",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "itemInAction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    itemId = table.Column<Guid>(nullable: false),
                    actionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemInAction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "message",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    userSenderId = table.Column<Guid>(nullable: false),
                    userReceiverId = table.Column<Guid>(nullable: false),
                    organizationSenderId = table.Column<Guid>(nullable: false),
                    organizationReceiverId = table.Column<Guid>(nullable: false),
                    message = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    userSenderId = table.Column<Guid>(nullable: false),
                    organizationReceiverId = table.Column<Guid>(nullable: false),
                    amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "profilePosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    message = table.Column<string>(maxLength: 500, nullable: false),
                    userId = table.Column<Guid>(nullable: false),
                    actionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profilePosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reactionsToPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    liked = table.Column<bool>(nullable: false),
                    commented = table.Column<bool>(nullable: false),
                    postId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reactionsToPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserAccount = table.Column<Guid>(nullable: false),
                    firstName = table.Column<string>(maxLength: 50, nullable: false),
                    lastName = table.Column<string>(maxLength: 50, nullable: false),
                    dateOfBirth = table.Column<DateTime>(nullable: false),
                    creditCardId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userParticipatingInAction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    userId = table.Column<Guid>(nullable: false),
                    actionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userParticipatingInAction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organization",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    UserAccount = table.Column<Guid>(nullable: false),
                    dateOfFounding = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    creditCardNumberId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_organization_card_creditCardNumberId",
                        column: x => x.creditCardNumberId,
                        principalTable: "card",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "Id", "imageId", "isUser", "password", "username" },
                values: new object[,]
                {
                    { new Guid("a03f3d14-eef0-4ce2-a83d-128860a1ac48"), new Guid("2805fd38-1045-4599-8be5-7f246c42a139"), true, "samplepass1", "sampleUser1" },
                    { new Guid("5e7b9739-21d8-4280-a732-2dc716257917"), new Guid("9bf24606-4b16-4f1c-ba35-0e44a6907a4e"), true, "samplepass2", "sampleUser2" },
                    { new Guid("f5749f73-21de-49d7-bd67-7dc66279ccc2"), new Guid("7c886424-3f8b-480d-8e14-b4364576bf0f"), true, "samplepass3", "sampleUser3" },
                    { new Guid("bba863a6-a3fc-4567-bda6-619abb15e9c7"), new Guid("22aa4e4c-91e1-4f5c-9c0c-cc48b1500084"), false, "samplepass4", "sampleUser4" },
                    { new Guid("5f3262d0-c5d6-48ec-a946-8acf0159a1cc"), new Guid("e04871da-793f-4089-8cf7-07fe52b112ec"), false, "samplepass5", "sampleUser5" }
                });

            migrationBuilder.InsertData(
                table: "image",
                columns: new[] { "Id", "Path" },
                values: new object[,]
                {
                    { new Guid("2805fd38-1045-4599-8be5-7f246c42a139"), "https://i.pinimg.com/originals/df/bd/df/dfbddf7c530ab5f4cd70154409651f9d.jpg" },
                    { new Guid("9bf24606-4b16-4f1c-ba35-0e44a6907a4e"), "http://bestdayevereducation.com/uploads/images/FreeVector-Spongebob-Squarepants-Vector.jpg" },
                    { new Guid("7c886424-3f8b-480d-8e14-b4364576bf0f"), "https://arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/AVA6IKPJNBAS7JZ3CREUNY64K4.jpg" },
                    { new Guid("22aa4e4c-91e1-4f5c-9c0c-cc48b1500084"), "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Cartoon_Network_2010_logo.svg/2000px-Cartoon_Network_2010_logo.svg.png" },
                    { new Guid("e04871da-793f-4089-8cf7-07fe52b112ec"), "https://cdn.vox-cdn.com/thumbor/m6_h4h6uHuJeZCnWTCz7anTlVJA=/0x0:1920x1080/1200x800/filters:focal(807x387:1113x693)/cdn.vox-cdn.com/uploads/chorus_image/image/60720529/disneyplus.0.4.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_organization_creditCardNumberId",
                table: "organization",
                column: "creditCardNumberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "action");

            migrationBuilder.DropTable(
                name: "image");

            migrationBuilder.DropTable(
                name: "item");

            migrationBuilder.DropTable(
                name: "itemInAction");

            migrationBuilder.DropTable(
                name: "message");

            migrationBuilder.DropTable(
                name: "organization");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropTable(
                name: "profilePosts");

            migrationBuilder.DropTable(
                name: "reactionsToPosts");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "userParticipatingInAction");

            migrationBuilder.DropTable(
                name: "card");
        }
    }
}
