using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharityData.Migrations
{
    public partial class Addingmigrationandseedersforallmodels : Migration
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
                    value = table.Column<int>(nullable: false),
                    userDonatedId = table.Column<Guid>(nullable: false)
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
                    message = table.Column<string>(maxLength: 500, nullable: false),
                    sendingTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_message", x => x.Id);
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
                    creditCardNumber = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organization", x => x.Id);
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
                    postId = table.Column<Guid>(nullable: false),
                    userReactedId = table.Column<Guid>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "Id", "imageId", "isUser", "password", "username" },
                values: new object[,]
                {
                    { new Guid("8ae15fe9-918f-4c6d-88d3-625ef29b7ba6"), new Guid("b79693eb-16b1-4df7-8a8e-de1d9ac4790b"), true, "samplepass1", "sampleUser1" },
                    { new Guid("860a538f-b18b-4ab7-a087-bc5ee9788794"), new Guid("26c16cbf-9fea-4e72-bd93-3244abdaa772"), true, "samplepass2", "sampleUser2" },
                    { new Guid("b4934321-8582-47cf-9efa-bcbeec7dfc33"), new Guid("cc0e125c-9fd8-4b29-ab79-63afab725bf6"), true, "samplepass3", "sampleUser3" },
                    { new Guid("7aeddfaa-8322-4f4f-9e75-b25ce00c3c8b"), new Guid("bab0b427-eda2-491d-b860-4776a8e7c3a3"), false, "samplepass4", "sampleUser4" },
                    { new Guid("d65bacd6-1cc6-4c28-b156-f2af70e0541d"), new Guid("9806d066-c0fe-4251-8517-1f8ce94571c4"), false, "samplepass5", "sampleUser5" }
                });

            migrationBuilder.InsertData(
                table: "action",
                columns: new[] { "Id", "actionType", "description", "name", "organizationId" },
                values: new object[,]
                {
                    { new Guid("66f07ce4-d088-43b5-88a8-a421d4868c15"), false, "This is a generic action where you sign up to participate", "Race for cure", new Guid("b636b6a1-541f-49d0-bdf6-86d3178b0244") },
                    { new Guid("090fdc74-724a-4857-a086-33c4c81f75ad"), true, "This is a generic action where people donate stuff", "Fundraising for children without parents", new Guid("b636b6a1-541f-49d0-bdf6-86d3178b0244") },
                    { new Guid("433dfd43-d513-44ed-996b-60b04489183c"), true, "This is another action where people donate stuff", "Another fundraising", new Guid("a82fc791-aba1-438d-9edb-5d3bb6f214dc") }
                });

            migrationBuilder.InsertData(
                table: "card",
                columns: new[] { "Id", "bankName", "dateOfExpiry" },
                values: new object[,]
                {
                    { new Guid("e722111a-3b2f-410b-8e1b-1874b25e8ed2"), "Austria Bank", new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53acdc31-facc-40d8-a3e3-3e29faa26725"), "Austria Bank", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c238eb6-2fca-43d3-bca0-7dcf0268e92c"), "Karntner Ladesbank Raiffeisen", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e240754-b08e-4b04-8ece-780e8d58cb1b"), "Karntner Sparkasse", new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8db7c482-021d-4a19-af47-a2091f675701"), "Karntner Sparkasse", new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "image",
                columns: new[] { "Id", "Path" },
                values: new object[,]
                {
                    { new Guid("b79693eb-16b1-4df7-8a8e-de1d9ac4790b"), "https://i.pinimg.com/originals/df/bd/df/dfbddf7c530ab5f4cd70154409651f9d.jpg" },
                    { new Guid("26c16cbf-9fea-4e72-bd93-3244abdaa772"), "http://bestdayevereducation.com/uploads/images/FreeVector-Spongebob-Squarepants-Vector.jpg" },
                    { new Guid("cc0e125c-9fd8-4b29-ab79-63afab725bf6"), "https://arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/AVA6IKPJNBAS7JZ3CREUNY64K4.jpg" },
                    { new Guid("bab0b427-eda2-491d-b860-4776a8e7c3a3"), "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Cartoon_Network_2010_logo.svg/2000px-Cartoon_Network_2010_logo.svg.png" },
                    { new Guid("9806d066-c0fe-4251-8517-1f8ce94571c4"), "https://cdn.vox-cdn.com/thumbor/m6_h4h6uHuJeZCnWTCz7anTlVJA=/0x0:1920x1080/1200x800/filters:focal(807x387:1113x693)/cdn.vox-cdn.com/uploads/chorus_image/image/60720529/disneyplus.0.4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "Id", "description", "name", "userDonatedId", "value" },
                values: new object[,]
                {
                    { new Guid("bb29bd97-f582-4e23-9d9d-5d3e1ee5b6d3"), "A ball for playing basketball", "Basketball", new Guid("f5e20a12-5f25-4177-9d3a-e3783319d6a6"), 50 },
                    { new Guid("3f2e29bc-3014-4c1d-b1c2-39b4913af56e"), "Some spare makeup I donate", "Makeup", new Guid("75da4ab5-1c03-48ed-8bfd-a3b19f9fdda5"), 150 }
                });

            migrationBuilder.InsertData(
                table: "itemInAction",
                columns: new[] { "Id", "actionId", "itemId" },
                values: new object[,]
                {
                    { new Guid("72ef8d6e-c1e7-494e-be93-7c27388f90ab"), new Guid("090fdc74-724a-4857-a086-33c4c81f75ad"), new Guid("bb29bd97-f582-4e23-9d9d-5d3e1ee5b6d3") },
                    { new Guid("59060235-aa47-4110-acfc-8b99d6fce99a"), new Guid("433dfd43-d513-44ed-996b-60b04489183c"), new Guid("3f2e29bc-3014-4c1d-b1c2-39b4913af56e") },
                    { new Guid("bae3e62c-88c5-4948-8346-bb14a6dc74a7"), new Guid("090fdc74-724a-4857-a086-33c4c81f75ad"), new Guid("bb29bd97-f582-4e23-9d9d-5d3e1ee5b6d3") }
                });

            migrationBuilder.InsertData(
                table: "message",
                columns: new[] { "Id", "message", "organizationReceiverId", "organizationSenderId", "sendingTime", "userReceiverId", "userSenderId" },
                values: new object[,]
                {
                    { new Guid("fb57594f-1b62-4614-ae41-813dc0e5de80"), "May I participate in your action :)", new Guid("b636b6a1-541f-49d0-bdf6-86d3178b0244"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 11, 20, 22, 24, 30, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f5e20a12-5f25-4177-9d3a-e3783319d6a6") },
                    { new Guid("c6c0b429-b345-4b39-baec-fbfb445c8ae9"), "Of course you can. All the best.", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("b636b6a1-541f-49d0-bdf6-86d3178b0244"), new DateTime(2019, 11, 20, 23, 25, 30, 0, DateTimeKind.Unspecified), new Guid("f5e20a12-5f25-4177-9d3a-e3783319d6a6"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2a0db98a-059f-4db5-b361-dccf46f72706"), "How are you my friend?", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new Guid("31a26eb4-4b3c-4b64-b8f8-00986fc35266"), new Guid("75da4ab5-1c03-48ed-8bfd-a3b19f9fdda5") },
                    { new Guid("91a39e60-3d64-4211-9558-16202391edff"), "All is well, thank you, and you?", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), new Guid("75da4ab5-1c03-48ed-8bfd-a3b19f9fdda5"), new Guid("31a26eb4-4b3c-4b64-b8f8-00986fc35266") },
                    { new Guid("16b9f424-9ac8-4dc7-ae1c-7b0c2faf3318"), "I am fine, thanks", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new Guid("31a26eb4-4b3c-4b64-b8f8-00986fc35266"), new Guid("75da4ab5-1c03-48ed-8bfd-a3b19f9fdda5") }
                });

            migrationBuilder.InsertData(
                table: "organization",
                columns: new[] { "Id", "UserAccount", "creditCardNumber", "dateOfFounding", "description", "name" },
                values: new object[,]
                {
                    { new Guid("b636b6a1-541f-49d0-bdf6-86d3178b0244"), new Guid("7aeddfaa-8322-4f4f-9e75-b25ce00c3c8b"), new Guid("53acdc31-facc-40d8-a3e3-3e29faa26725"), new DateTime(2015, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a sample organization for doing something which is good", "CharityOrg1" },
                    { new Guid("a82fc791-aba1-438d-9edb-5d3bb6f214dc"), new Guid("d65bacd6-1cc6-4c28-b156-f2af70e0541d"), new Guid("e722111a-3b2f-410b-8e1b-1874b25e8ed2"), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "This organization does charity actions which are great!", "CharityOrg2" }
                });

            migrationBuilder.InsertData(
                table: "payment",
                columns: new[] { "Id", "amount", "organizationReceiverId", "userSenderId" },
                values: new object[,]
                {
                    { new Guid("58c6d3ae-be28-4453-8293-90b6fab36532"), 100.0, new Guid("a82fc791-aba1-438d-9edb-5d3bb6f214dc"), new Guid("f5e20a12-5f25-4177-9d3a-e3783319d6a6") },
                    { new Guid("580fb56e-dcce-4e03-a3d4-f644d3177b90"), 100.0, new Guid("b636b6a1-541f-49d0-bdf6-86d3178b0244"), new Guid("f5e20a12-5f25-4177-9d3a-e3783319d6a6") },
                    { new Guid("6c94aa1b-4920-478a-bced-c24086ea21b7"), 100.0, new Guid("b636b6a1-541f-49d0-bdf6-86d3178b0244"), new Guid("75da4ab5-1c03-48ed-8bfd-a3b19f9fdda5") }
                });

            migrationBuilder.InsertData(
                table: "profilePosts",
                columns: new[] { "Id", "actionId", "message", "userId" },
                values: new object[,]
                {
                    { new Guid("e6b0310b-bd4c-470f-afd6-9502ad864347"), new Guid("433dfd43-d513-44ed-996b-60b04489183c"), "Normally, I did as well.", new Guid("31a26eb4-4b3c-4b64-b8f8-00986fc35266") },
                    { new Guid("eee07d64-fcc8-4103-a9d1-dda1350b0f0d"), new Guid("66f07ce4-d088-43b5-88a8-a421d4868c15"), "I just did something in this action", new Guid("f5e20a12-5f25-4177-9d3a-e3783319d6a6") },
                    { new Guid("e61bff5f-626f-4b84-834a-792153336f0e"), new Guid("090fdc74-724a-4857-a086-33c4c81f75ad"), "I did something too", new Guid("75da4ab5-1c03-48ed-8bfd-a3b19f9fdda5") }
                });

            migrationBuilder.InsertData(
                table: "reactionsToPosts",
                columns: new[] { "Id", "commented", "liked", "postId", "userReactedId" },
                values: new object[,]
                {
                    { new Guid("18662e95-035f-42e3-8162-8f5266e17a91"), false, true, new Guid("eee07d64-fcc8-4103-a9d1-dda1350b0f0d"), new Guid("31a26eb4-4b3c-4b64-b8f8-00986fc35266") },
                    { new Guid("d306a74a-1524-4c7c-93e0-5df9c40b24ec"), true, true, new Guid("e61bff5f-626f-4b84-834a-792153336f0e"), new Guid("f5e20a12-5f25-4177-9d3a-e3783319d6a6") },
                    { new Guid("b2559667-80be-48e3-9eff-8a7e138606c0"), false, true, new Guid("e6b0310b-bd4c-470f-afd6-9502ad864347"), new Guid("75da4ab5-1c03-48ed-8bfd-a3b19f9fdda5") }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "UserAccount", "creditCardId", "dateOfBirth", "firstName", "lastName" },
                values: new object[,]
                {
                    { new Guid("75da4ab5-1c03-48ed-8bfd-a3b19f9fdda5"), new Guid("860a538f-b18b-4ab7-a087-bc5ee9788794"), new Guid("8e240754-b08e-4b04-8ece-780e8d58cb1b"), new DateTime(1980, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe" },
                    { new Guid("f5e20a12-5f25-4177-9d3a-e3783319d6a6"), new Guid("8ae15fe9-918f-4c6d-88d3-625ef29b7ba6"), new Guid("8db7c482-021d-4a19-af47-a2091f675701"), new DateTime(1997, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foo", "Bar" },
                    { new Guid("31a26eb4-4b3c-4b64-b8f8-00986fc35266"), new Guid("b4934321-8582-47cf-9efa-bcbeec7dfc33"), new Guid("7c238eb6-2fca-43d3-bca0-7dcf0268e92c"), new DateTime(1970, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", "Cage" }
                });

            migrationBuilder.InsertData(
                table: "userParticipatingInAction",
                columns: new[] { "Id", "actionId", "userId" },
                values: new object[,]
                {
                    { new Guid("baebd90e-69ef-42c5-8843-55e212008241"), new Guid("090fdc74-724a-4857-a086-33c4c81f75ad"), new Guid("75da4ab5-1c03-48ed-8bfd-a3b19f9fdda5") },
                    { new Guid("21365611-7f2f-47b0-8890-5bdd43bcf04a"), new Guid("66f07ce4-d088-43b5-88a8-a421d4868c15"), new Guid("f5e20a12-5f25-4177-9d3a-e3783319d6a6") },
                    { new Guid("e6c870d0-8edf-42ba-b58a-346c8e18fb75"), new Guid("433dfd43-d513-44ed-996b-60b04489183c"), new Guid("31a26eb4-4b3c-4b64-b8f8-00986fc35266") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "action");

            migrationBuilder.DropTable(
                name: "card");

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
        }
    }
}
