using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharityData.Migrations
{
    public partial class Addinitialentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "creditCardNumber",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "user");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "user",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "user",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "user",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "user",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstName",
                table: "user",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "creditCardIdId",
                table: "user",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "card",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateOfExpiry = table.Column<DateTime>(nullable: false),
                    bankName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_card", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    username = table.Column<string>(maxLength: 50, nullable: false),
                    password = table.Column<string>(maxLength: 50, nullable: false),
                    dateOfFounding = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true),
                    creditCardNumberId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "action",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: false),
                    actionType = table.Column<bool>(nullable: false),
                    organizationIdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_action", x => x.Id);
                    table.ForeignKey(
                        name: "FK_action_organization_organizationIdId",
                        column: x => x.organizationIdId,
                        principalTable: "organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "message",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userSenderIdId = table.Column<int>(nullable: true),
                    userReceiverIdId = table.Column<int>(nullable: true),
                    organizationSenderIdId = table.Column<int>(nullable: true),
                    organizationReceiverIdId = table.Column<int>(nullable: true),
                    message = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_message_organization_organizationReceiverIdId",
                        column: x => x.organizationReceiverIdId,
                        principalTable: "organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_message_organization_organizationSenderIdId",
                        column: x => x.organizationSenderIdId,
                        principalTable: "organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_message_user_userReceiverIdId",
                        column: x => x.userReceiverIdId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_message_user_userSenderIdId",
                        column: x => x.userSenderIdId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userSenderIdId = table.Column<int>(nullable: false),
                    organizationReceiverIdId = table.Column<int>(nullable: false),
                    amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payment_organization_organizationReceiverIdId",
                        column: x => x.organizationReceiverIdId,
                        principalTable: "organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_payment_user_userSenderIdId",
                        column: x => x.userSenderIdId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "itemInAction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    itemIdId = table.Column<int>(nullable: false),
                    actionIdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemInAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_itemInAction_action_actionIdId",
                        column: x => x.actionIdId,
                        principalTable: "action",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itemInAction_item_itemIdId",
                        column: x => x.itemIdId,
                        principalTable: "item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "profilePosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    message = table.Column<string>(maxLength: 500, nullable: false),
                    userIdId = table.Column<int>(nullable: false),
                    actionIdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profilePosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_profilePosts_action_actionIdId",
                        column: x => x.actionIdId,
                        principalTable: "action",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_profilePosts_user_userIdId",
                        column: x => x.userIdId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userParticipatingInAction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userIdId = table.Column<int>(nullable: true),
                    actionIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userParticipatingInAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userParticipatingInAction_action_actionIdId",
                        column: x => x.actionIdId,
                        principalTable: "action",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_userParticipatingInAction_user_userIdId",
                        column: x => x.userIdId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reactionsToPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    liked = table.Column<bool>(nullable: false),
                    commented = table.Column<bool>(nullable: false),
                    postIdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reactionsToPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reactionsToPosts_profilePosts_postIdId",
                        column: x => x.postIdId,
                        principalTable: "profilePosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_user_creditCardIdId",
                table: "user",
                column: "creditCardIdId");

            migrationBuilder.CreateIndex(
                name: "IX_action_organizationIdId",
                table: "action",
                column: "organizationIdId");

            migrationBuilder.CreateIndex(
                name: "IX_itemInAction_actionIdId",
                table: "itemInAction",
                column: "actionIdId");

            migrationBuilder.CreateIndex(
                name: "IX_itemInAction_itemIdId",
                table: "itemInAction",
                column: "itemIdId");

            migrationBuilder.CreateIndex(
                name: "IX_message_organizationReceiverIdId",
                table: "message",
                column: "organizationReceiverIdId");

            migrationBuilder.CreateIndex(
                name: "IX_message_organizationSenderIdId",
                table: "message",
                column: "organizationSenderIdId");

            migrationBuilder.CreateIndex(
                name: "IX_message_userReceiverIdId",
                table: "message",
                column: "userReceiverIdId");

            migrationBuilder.CreateIndex(
                name: "IX_message_userSenderIdId",
                table: "message",
                column: "userSenderIdId");

            migrationBuilder.CreateIndex(
                name: "IX_organization_creditCardNumberId",
                table: "organization",
                column: "creditCardNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_payment_organizationReceiverIdId",
                table: "payment",
                column: "organizationReceiverIdId");

            migrationBuilder.CreateIndex(
                name: "IX_payment_userSenderIdId",
                table: "payment",
                column: "userSenderIdId");

            migrationBuilder.CreateIndex(
                name: "IX_profilePosts_actionIdId",
                table: "profilePosts",
                column: "actionIdId");

            migrationBuilder.CreateIndex(
                name: "IX_profilePosts_userIdId",
                table: "profilePosts",
                column: "userIdId");

            migrationBuilder.CreateIndex(
                name: "IX_reactionsToPosts_postIdId",
                table: "reactionsToPosts",
                column: "postIdId");

            migrationBuilder.CreateIndex(
                name: "IX_userParticipatingInAction_actionIdId",
                table: "userParticipatingInAction",
                column: "actionIdId");

            migrationBuilder.CreateIndex(
                name: "IX_userParticipatingInAction_userIdId",
                table: "userParticipatingInAction",
                column: "userIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_card_creditCardIdId",
                table: "user",
                column: "creditCardIdId",
                principalTable: "card",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_card_creditCardIdId",
                table: "user");

            migrationBuilder.DropTable(
                name: "itemInAction");

            migrationBuilder.DropTable(
                name: "message");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropTable(
                name: "reactionsToPosts");

            migrationBuilder.DropTable(
                name: "userParticipatingInAction");

            migrationBuilder.DropTable(
                name: "item");

            migrationBuilder.DropTable(
                name: "profilePosts");

            migrationBuilder.DropTable(
                name: "action");

            migrationBuilder.DropTable(
                name: "organization");

            migrationBuilder.DropTable(
                name: "card");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_user_creditCardIdId",
                table: "user");

            migrationBuilder.DropColumn(
                name: "creditCardIdId",
                table: "user");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "firstName",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "creditCardNumber",
                table: "Users",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "id");
        }
    }
}
