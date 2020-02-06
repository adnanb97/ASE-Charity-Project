using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharityData.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    username = table.Column<string>(maxLength: 50, nullable: false),
                    password = table.Column<string>(maxLength: 80, nullable: false),
                    email = table.Column<string>(nullable: true),
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
                    organizationId = table.Column<Guid>(nullable: false),
                    creationDateTime = table.Column<DateTime>(nullable: false),
                    startDateTime = table.Column<DateTime>(nullable: false),
                    endDateTime = table.Column<DateTime>(nullable: false)
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
                    bankName = table.Column<string>(maxLength: 50, nullable: false),
                    amount = table.Column<double>(nullable: false),
                    creditCardNumber = table.Column<string>(maxLength: 16, nullable: false)
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
                    userReactedId = table.Column<Guid>(nullable: false),
                    commentText = table.Column<string>(nullable: true)
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
                    gender = table.Column<string>(nullable: false),
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
                columns: new[] { "Id", "email", "imageId", "isUser", "password", "username" },
                values: new object[,]
                {
                    { new Guid("95fdb517-78c3-4665-8b8b-babbb789c50f"), "sampleUser1@mail.com", new Guid("dfb13851-efce-4964-920a-3ac71ebc8316"), true, "c72a944b810cb996c3107ae0a774980f1e4ec1232990a3c62a73c750675bcd5d", "sampleUser1" },
                    { new Guid("377107d9-f1da-425e-8aba-32f52f337531"), "sampleUser2@mail.com", new Guid("7d265c6c-87ac-44fd-88d5-6f20838020bb"), true, "defd7d850c9632421ba1244bc22642facdc2115c60dbd0d2663b1117ba4f50a9", "sampleUser2" },
                    { new Guid("3c06972a-bbe2-4587-a9b8-d50376d3a7c2"), "sampleUser3@mail.com", new Guid("7723e728-4866-48e6-99a8-9d01376bb051"), true, "d4481413102ca87dc30943994469caad1ab2de1b869514348b003553bde4d3b1", "sampleUser3" },
                    { new Guid("faa2ec27-abb7-4ee7-b527-25210c5ef046"), "sampleUser4@mail.com", new Guid("ab2500e6-bda6-410e-85d1-23faaad6c169"), false, "4d5c81c22882ff79cc1c45031acd9afcd1cf063f9b6d664adb1d33cf4c681807", "sampleUser4" },
                    { new Guid("78edd9de-d5f2-4374-8644-0c6af464ea2d"), "sampleUser5@mail.com", new Guid("efc91466-1507-4221-a871-73862e028fb2"), false, "cc6b98042e62e0c4da7110a42dcd7aaf20ec2bbc250b89923353d39483ef46a4", "sampleUser5" }
                });

            migrationBuilder.InsertData(
                table: "action",
                columns: new[] { "Id", "actionType", "creationDateTime", "description", "endDateTime", "name", "organizationId", "startDateTime" },
                values: new object[,]
                {
                    { new Guid("82c15e08-5e3b-40b6-92e8-1ae6a6a43620"), true, new DateTime(2020, 2, 6, 2, 2, 44, 0, DateTimeKind.Unspecified), "This is another action where people donate stuff", new DateTime(2020, 2, 5, 2, 2, 44, 0, DateTimeKind.Unspecified), "Another fundraising", new Guid("0013da1b-377a-4fc5-8fb4-5db51d14659e"), new DateTime(2020, 2, 6, 2, 2, 44, 0, DateTimeKind.Unspecified) },
                    { new Guid("f417fcf9-35a0-4b2f-8403-4aa6606335df"), true, new DateTime(2020, 2, 6, 2, 2, 44, 0, DateTimeKind.Unspecified), "This is a generic action where people donate stuff", new DateTime(2020, 2, 5, 2, 2, 44, 0, DateTimeKind.Unspecified), "Fundraising for children without parents", new Guid("43631509-6931-4542-ae13-69a676a7b94d"), new DateTime(2020, 2, 6, 2, 2, 44, 0, DateTimeKind.Unspecified) },
                    { new Guid("04df63a9-f8b9-4b3e-9be9-39d67a138ad2"), false, new DateTime(2020, 2, 6, 2, 2, 44, 0, DateTimeKind.Unspecified), "This is a generic action where you sign up to participate", new DateTime(2020, 2, 5, 2, 2, 44, 0, DateTimeKind.Unspecified), "Race for cure", new Guid("43631509-6931-4542-ae13-69a676a7b94d"), new DateTime(2020, 2, 6, 2, 2, 44, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "card",
                columns: new[] { "Id", "amount", "bankName", "creditCardNumber", "dateOfExpiry" },
                values: new object[,]
                {
                    { new Guid("85546222-5128-4bdf-beff-225b93bff9d5"), 200.0, "Austria Bank", "9303132333435363", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb89c01a-98b9-42fa-8f73-9472ece01f08"), 55.0, "Austria Bank", "7383940414243444", new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a506e081-3b81-46bc-86c1-c4c9c0205d79"), 50.0, "Karntner Sparkasse", "3141516171819202", new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f69ff571-7ffd-4759-89c6-e06b3eb1af52"), 100.0, "Karntner Sparkasse", "1234567891011121", new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e52bb81d-1739-487e-8ea2-24e0fca1fd85"), 150.0, "Karntner Ladesbank Raiffeisen", "1222324252627282", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "image",
                columns: new[] { "Id", "Path" },
                values: new object[,]
                {
                    { new Guid("dfb13851-efce-4964-920a-3ac71ebc8316"), "https://i.pinimg.com/originals/df/bd/df/dfbddf7c530ab5f4cd70154409651f9d.jpg" },
                    { new Guid("7d265c6c-87ac-44fd-88d5-6f20838020bb"), "http://bestdayevereducation.com/uploads/images/FreeVector-Spongebob-Squarepants-Vector.jpg" },
                    { new Guid("7723e728-4866-48e6-99a8-9d01376bb051"), "https://arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/AVA6IKPJNBAS7JZ3CREUNY64K4.jpg" },
                    { new Guid("ab2500e6-bda6-410e-85d1-23faaad6c169"), "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Cartoon_Network_2010_logo.svg/2000px-Cartoon_Network_2010_logo.svg.png" },
                    { new Guid("efc91466-1507-4221-a871-73862e028fb2"), "https://cdn.vox-cdn.com/thumbor/m6_h4h6uHuJeZCnWTCz7anTlVJA=/0x0:1920x1080/1200x800/filters:focal(807x387:1113x693)/cdn.vox-cdn.com/uploads/chorus_image/image/60720529/disneyplus.0.4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "Id", "description", "name", "userDonatedId", "value" },
                values: new object[,]
                {
                    { new Guid("d16b79f7-9bf5-4210-9998-331b725c771c"), "Some spare makeup I donate", "Makeup", new Guid("efca8335-bb04-49fe-ae33-7ca973b11cc4"), 150 },
                    { new Guid("7ccf604e-227f-4451-afb0-6f21855a9af2"), "A ball for playing basketball", "Basketball", new Guid("22cf0ccf-1511-435b-b1a8-1bd4a4361149"), 50 }
                });

            migrationBuilder.InsertData(
                table: "itemInAction",
                columns: new[] { "Id", "actionId", "itemId" },
                values: new object[,]
                {
                    { new Guid("19f8fcc7-f09d-4e63-aaa5-08a8cea6ee82"), new Guid("f417fcf9-35a0-4b2f-8403-4aa6606335df"), new Guid("7ccf604e-227f-4451-afb0-6f21855a9af2") },
                    { new Guid("a605b1dd-8801-4dd0-b0c8-058e05458cf3"), new Guid("82c15e08-5e3b-40b6-92e8-1ae6a6a43620"), new Guid("d16b79f7-9bf5-4210-9998-331b725c771c") },
                    { new Guid("f581c6e0-05b5-4c38-8ca7-55476085e7bd"), new Guid("f417fcf9-35a0-4b2f-8403-4aa6606335df"), new Guid("7ccf604e-227f-4451-afb0-6f21855a9af2") }
                });

            migrationBuilder.InsertData(
                table: "message",
                columns: new[] { "Id", "message", "organizationReceiverId", "organizationSenderId", "sendingTime", "userReceiverId", "userSenderId" },
                values: new object[,]
                {
                    { new Guid("7fc96dce-a070-469e-a5a4-8a0ea3a15fad"), "May I participate in your action :)", new Guid("43631509-6931-4542-ae13-69a676a7b94d"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 11, 20, 22, 24, 30, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("22cf0ccf-1511-435b-b1a8-1bd4a4361149") },
                    { new Guid("944dd5be-a0c3-4bb0-857f-4fca5f94c16f"), "Of course you can. All the best.", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("43631509-6931-4542-ae13-69a676a7b94d"), new DateTime(2019, 11, 20, 23, 25, 30, 0, DateTimeKind.Unspecified), new Guid("22cf0ccf-1511-435b-b1a8-1bd4a4361149"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("80043bdc-3e41-4a17-af55-b02d0d57d179"), "How are you my friend?", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7e783f5b-290d-4247-a206-2ae626d5c664"), new Guid("efca8335-bb04-49fe-ae33-7ca973b11cc4") },
                    { new Guid("5e3fc4b2-1c10-4e26-b793-a27fb4a387aa"), "All is well, thank you, and you?", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), new Guid("efca8335-bb04-49fe-ae33-7ca973b11cc4"), new Guid("7e783f5b-290d-4247-a206-2ae626d5c664") },
                    { new Guid("1abf5a23-bcb8-46cd-a509-f6dd64e28e66"), "I am fine, thanks", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7e783f5b-290d-4247-a206-2ae626d5c664"), new Guid("efca8335-bb04-49fe-ae33-7ca973b11cc4") }
                });

            migrationBuilder.InsertData(
                table: "organization",
                columns: new[] { "Id", "UserAccount", "creditCardNumber", "dateOfFounding", "description", "name" },
                values: new object[,]
                {
                    { new Guid("43631509-6931-4542-ae13-69a676a7b94d"), new Guid("faa2ec27-abb7-4ee7-b527-25210c5ef046"), new Guid("85546222-5128-4bdf-beff-225b93bff9d5"), new DateTime(2015, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a sample organization for doing something which is good", "CharityOrg1" },
                    { new Guid("0013da1b-377a-4fc5-8fb4-5db51d14659e"), new Guid("78edd9de-d5f2-4374-8644-0c6af464ea2d"), new Guid("eb89c01a-98b9-42fa-8f73-9472ece01f08"), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "This organization does charity actions which are great!", "CharityOrg2" }
                });

            migrationBuilder.InsertData(
                table: "payment",
                columns: new[] { "Id", "amount", "organizationReceiverId", "userSenderId" },
                values: new object[,]
                {
                    { new Guid("2c227ab7-7e35-4ee7-a718-844e35e1f94d"), 100.0, new Guid("0013da1b-377a-4fc5-8fb4-5db51d14659e"), new Guid("22cf0ccf-1511-435b-b1a8-1bd4a4361149") },
                    { new Guid("a3d0629d-b4bf-4a2d-a722-518fa2de1028"), 100.0, new Guid("43631509-6931-4542-ae13-69a676a7b94d"), new Guid("22cf0ccf-1511-435b-b1a8-1bd4a4361149") },
                    { new Guid("306a3887-431c-4bc6-a551-b13de03d83ac"), 100.0, new Guid("43631509-6931-4542-ae13-69a676a7b94d"), new Guid("efca8335-bb04-49fe-ae33-7ca973b11cc4") }
                });

            migrationBuilder.InsertData(
                table: "profilePosts",
                columns: new[] { "Id", "actionId", "message", "userId" },
                values: new object[,]
                {
                    { new Guid("79787603-0835-4224-afc0-6776b2ab9b9d"), new Guid("82c15e08-5e3b-40b6-92e8-1ae6a6a43620"), "Normally, I did as well.", new Guid("7e783f5b-290d-4247-a206-2ae626d5c664") },
                    { new Guid("5b44ef62-3476-4d60-84d5-d8b9f0ceab64"), new Guid("04df63a9-f8b9-4b3e-9be9-39d67a138ad2"), "I just did something in this action", new Guid("22cf0ccf-1511-435b-b1a8-1bd4a4361149") },
                    { new Guid("06f26859-e235-422f-aa64-47de45ccaaf0"), new Guid("f417fcf9-35a0-4b2f-8403-4aa6606335df"), "I did something too", new Guid("efca8335-bb04-49fe-ae33-7ca973b11cc4") }
                });

            migrationBuilder.InsertData(
                table: "reactionsToPosts",
                columns: new[] { "Id", "commentText", "commented", "liked", "postId", "userReactedId" },
                values: new object[,]
                {
                    { new Guid("9a0a8808-6c5a-45ec-b167-f69b21211ad6"), null, false, true, new Guid("5b44ef62-3476-4d60-84d5-d8b9f0ceab64"), new Guid("7e783f5b-290d-4247-a206-2ae626d5c664") },
                    { new Guid("0434b8f8-ef72-4680-b01a-caec95ee8d21"), "Glad you did that!", true, true, new Guid("06f26859-e235-422f-aa64-47de45ccaaf0"), new Guid("22cf0ccf-1511-435b-b1a8-1bd4a4361149") },
                    { new Guid("2587b2a0-97d5-48d2-b1fd-8cbdfd44ff33"), null, false, true, new Guid("79787603-0835-4224-afc0-6776b2ab9b9d"), new Guid("efca8335-bb04-49fe-ae33-7ca973b11cc4") }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "UserAccount", "creditCardId", "dateOfBirth", "firstName", "gender", "lastName" },
                values: new object[,]
                {
                    { new Guid("efca8335-bb04-49fe-ae33-7ca973b11cc4"), new Guid("377107d9-f1da-425e-8aba-32f52f337531"), new Guid("a506e081-3b81-46bc-86c1-c4c9c0205d79"), new DateTime(1980, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "F", "Doe" },
                    { new Guid("22cf0ccf-1511-435b-b1a8-1bd4a4361149"), new Guid("95fdb517-78c3-4665-8b8b-babbb789c50f"), new Guid("f69ff571-7ffd-4759-89c6-e06b3eb1af52"), new DateTime(1997, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foo", "M", "Bar" },
                    { new Guid("7e783f5b-290d-4247-a206-2ae626d5c664"), new Guid("3c06972a-bbe2-4587-a9b8-d50376d3a7c2"), new Guid("e52bb81d-1739-487e-8ea2-24e0fca1fd85"), new DateTime(1970, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", "M", "Cage" }
                });

            migrationBuilder.InsertData(
                table: "userParticipatingInAction",
                columns: new[] { "Id", "actionId", "userId" },
                values: new object[,]
                {
                    { new Guid("5673522e-4e5b-43b9-b3e0-aa08979b2ced"), new Guid("f417fcf9-35a0-4b2f-8403-4aa6606335df"), new Guid("efca8335-bb04-49fe-ae33-7ca973b11cc4") },
                    { new Guid("e61f381c-8e5e-48a1-929b-4996f71d6999"), new Guid("04df63a9-f8b9-4b3e-9be9-39d67a138ad2"), new Guid("22cf0ccf-1511-435b-b1a8-1bd4a4361149") },
                    { new Guid("717c9b4e-c63c-4007-93af-223d5e5b6393"), new Guid("82c15e08-5e3b-40b6-92e8-1ae6a6a43620"), new Guid("7e783f5b-290d-4247-a206-2ae626d5c664") }
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
