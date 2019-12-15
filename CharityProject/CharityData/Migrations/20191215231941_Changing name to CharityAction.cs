using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharityData.Migrations
{
    public partial class ChangingnametoCharityAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("22a187d3-9985-4b5d-bcd7-4f6c8843053a"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("68984eae-1ab5-4c66-8a1d-e0ffb17bda5b"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("888e8504-9287-4ad1-a984-dfe2d91ff32b"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("d2f23741-7b74-4b39-b28d-42172eb04420"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("e7146b70-ad4d-4d28-ba0c-c420b18c14cc"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("08e37fa3-98c0-4220-b632-987e4c37131a"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("cfa621ba-af9a-4841-91c3-faf453759c25"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("dd9e6842-c122-4eec-aa93-c327fb48532b"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("1d391b65-974c-482e-9084-f85272e12765"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("2184a6fe-1ee2-482c-9002-4016fd6375cd"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("b34dea03-3805-424a-95c8-c8c777fa4570"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("bd6cd9f7-cdbc-40e0-a0e8-ebc03309f615"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("bdc3d82a-6616-401a-9050-f908ee557c51"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("1713b227-ffb6-4c8e-8247-84be15928f4c"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("178a0435-7822-42c8-9c7f-9199f9b5a09e"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("833fee49-3a76-47c8-b5cf-40c57611f77f"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("bcf0ffae-1f10-4d24-8baa-84cb11442f52"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("bcf316fa-dc18-4b8b-9090-f08c476ff85c"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "Id",
                keyValue: new Guid("1cf47408-cc50-4162-83be-e27030f44451"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "Id",
                keyValue: new Guid("b5e6b0e9-b052-434e-bef4-04215e9d687a"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("038a7998-a85e-4bb0-9774-e1e9f631cf2b"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("450a2c0f-55e9-4c85-b6f1-02b7e1536b45"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("ba187e42-7178-44f9-a63a-1d57658ae295"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("3ad3d982-1bd7-4a98-9559-e1d45f9846a5"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("51038d49-7362-420b-a04a-279790b454d9"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("803e9b62-4b01-421a-8d3e-963e7c14e9dd"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("d247e17e-f121-49b9-ba31-954a818b3fdc"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("e2b7a97c-8284-4643-bde8-b3f079ccec47"));

            migrationBuilder.DeleteData(
                table: "organization",
                keyColumn: "Id",
                keyValue: new Guid("040fc5b6-f94b-4079-8b98-0298a59ae07f"));

            migrationBuilder.DeleteData(
                table: "organization",
                keyColumn: "Id",
                keyValue: new Guid("f1a17f5b-f1f0-49eb-a3d3-439e72f90702"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("346d4e57-4185-4d20-8315-a487f54bb378"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("af9e127a-329c-4c7b-a28c-bb9c4193d6a0"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("e5e4fbcd-4dce-419b-9f8f-f269fcd1fe3f"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("229379a4-d697-498b-a9af-5bf4e645d88a"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("5c4f4b15-f208-4aa1-8d80-58ea901b10ce"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("fc46cac9-f244-4cd4-a986-8b2a0700680c"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("559053ca-1373-4c63-94a5-f547e0713fb2"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("5f411452-0340-482c-98a2-cbdffd04939e"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("c9d9c4eb-dce3-4867-9932-e3f37b15933f"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("ee1c06e6-7537-4d3a-9084-27e2653e26b8"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("42f92044-967c-4df1-af5d-673fc63c37ae"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("7e58c9db-4f5a-42d4-9c30-4c3508e18b40"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("cc44e437-575a-42eb-ab71-8a4d23991199"));

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "Id", "email", "imageId", "isUser", "password", "username" },
                values: new object[,]
                {
                    { new Guid("87bc4eee-eb63-4dc1-b85e-5ad9d4d31062"), "sampleUser1@mail.com", new Guid("351adfb5-c6c0-441b-a3d7-3397160f301d"), true, "c72a944b810cb996c3107ae0a774980f1e4ec1232990a3c62a73c750675bcd5d", "sampleUser1" },
                    { new Guid("c3c6d77b-83af-44ec-a282-bd2d3d234014"), "sampleUser2@mail.com", new Guid("ddc0e647-ca5a-4379-8ea1-fc803958a760"), true, "defd7d850c9632421ba1244bc22642facdc2115c60dbd0d2663b1117ba4f50a9", "sampleUser2" },
                    { new Guid("a1095b75-9014-4f34-8bae-2278ce3ce3bd"), "sampleUser3@mail.com", new Guid("f6c2228e-fe6e-483a-a41c-6984f8ab06d8"), true, "d4481413102ca87dc30943994469caad1ab2de1b869514348b003553bde4d3b1", "sampleUser3" },
                    { new Guid("40a27398-27f5-43b2-92a3-0de1e11dc3d6"), "sampleUser4@mail.com", new Guid("f4e8fc86-6532-422c-a3a9-2497ff9e0580"), false, "4d5c81c22882ff79cc1c45031acd9afcd1cf063f9b6d664adb1d33cf4c681807", "sampleUser4" },
                    { new Guid("7a509ec5-20ec-4ae9-b5b4-5d92d0acba07"), "sampleUser5@mail.com", new Guid("44d3389a-1a41-4234-bc72-6ed8965790a8"), false, "cc6b98042e62e0c4da7110a42dcd7aaf20ec2bbc250b89923353d39483ef46a4", "sampleUser5" }
                });

            migrationBuilder.InsertData(
                table: "action",
                columns: new[] { "Id", "actionType", "creationDateTime", "description", "endDateTime", "name", "organizationId", "startDateTime" },
                values: new object[,]
                {
                    { new Guid("bac49b04-61e1-4f94-b785-0856cd6b0c69"), true, new DateTime(2019, 12, 16, 0, 19, 40, 0, DateTimeKind.Unspecified), "This is another action where people donate stuff", new DateTime(2020, 2, 5, 0, 19, 40, 0, DateTimeKind.Unspecified), "Another fundraising", new Guid("87603e62-de5f-47ee-8783-297b3d08e78a"), new DateTime(2019, 12, 16, 0, 19, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8b8b854-6c91-40fc-b223-a2584a1136de"), true, new DateTime(2019, 12, 16, 0, 19, 40, 0, DateTimeKind.Unspecified), "This is a generic action where people donate stuff", new DateTime(2020, 2, 5, 0, 19, 40, 0, DateTimeKind.Unspecified), "Fundraising for children without parents", new Guid("9df6c3dc-7b1a-44e5-9abc-fe154632de61"), new DateTime(2019, 12, 16, 0, 19, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("4be49861-6615-4a15-b2fb-c41db15a7844"), false, new DateTime(2019, 12, 16, 0, 19, 40, 0, DateTimeKind.Unspecified), "This is a generic action where you sign up to participate", new DateTime(2020, 2, 5, 0, 19, 40, 0, DateTimeKind.Unspecified), "Race for cure", new Guid("9df6c3dc-7b1a-44e5-9abc-fe154632de61"), new DateTime(2019, 12, 16, 0, 19, 40, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "card",
                columns: new[] { "Id", "amount", "bankName", "creditCardNumber", "dateOfExpiry" },
                values: new object[,]
                {
                    { new Guid("92a94df6-bedd-45f4-9017-bc2f52e3e8be"), 200.0, "Austria Bank", "9303132333435363", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4fd45971-cfbb-45f2-a1ad-0294826cff45"), 55.0, "Austria Bank", "7383940414243444", new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8df97b0c-990d-4bb6-b047-e6824c9aa996"), 50.0, "Karntner Sparkasse", "3141516171819202", new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee7337bd-ba35-4e2f-ac10-facf2364ba42"), 100.0, "Karntner Sparkasse", "1234567891011121", new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1fb4138-3737-44e9-97eb-b23e040a23d2"), 150.0, "Karntner Ladesbank Raiffeisen", "1222324252627282", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "image",
                columns: new[] { "Id", "Path" },
                values: new object[,]
                {
                    { new Guid("351adfb5-c6c0-441b-a3d7-3397160f301d"), "https://i.pinimg.com/originals/df/bd/df/dfbddf7c530ab5f4cd70154409651f9d.jpg" },
                    { new Guid("ddc0e647-ca5a-4379-8ea1-fc803958a760"), "http://bestdayevereducation.com/uploads/images/FreeVector-Spongebob-Squarepants-Vector.jpg" },
                    { new Guid("f6c2228e-fe6e-483a-a41c-6984f8ab06d8"), "https://arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/AVA6IKPJNBAS7JZ3CREUNY64K4.jpg" },
                    { new Guid("f4e8fc86-6532-422c-a3a9-2497ff9e0580"), "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Cartoon_Network_2010_logo.svg/2000px-Cartoon_Network_2010_logo.svg.png" },
                    { new Guid("44d3389a-1a41-4234-bc72-6ed8965790a8"), "https://cdn.vox-cdn.com/thumbor/m6_h4h6uHuJeZCnWTCz7anTlVJA=/0x0:1920x1080/1200x800/filters:focal(807x387:1113x693)/cdn.vox-cdn.com/uploads/chorus_image/image/60720529/disneyplus.0.4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "Id", "description", "name", "userDonatedId", "value" },
                values: new object[,]
                {
                    { new Guid("76fe674f-37ed-4f38-826d-0130ca5eb809"), "Some spare makeup I donate", "Makeup", new Guid("7e1202f8-3b7c-459a-8800-5e56dea8d462"), 150 },
                    { new Guid("78416ab0-88b9-43cb-92db-fc6645c20f38"), "A ball for playing basketball", "Basketball", new Guid("e64a8937-90da-4689-8d55-dc6790765c1b"), 50 }
                });

            migrationBuilder.InsertData(
                table: "itemInAction",
                columns: new[] { "Id", "actionId", "itemId" },
                values: new object[,]
                {
                    { new Guid("9edbde5e-ab90-4e6e-b63b-a95161de3af4"), new Guid("f8b8b854-6c91-40fc-b223-a2584a1136de"), new Guid("78416ab0-88b9-43cb-92db-fc6645c20f38") },
                    { new Guid("20325563-7205-4698-be50-581d003054e1"), new Guid("bac49b04-61e1-4f94-b785-0856cd6b0c69"), new Guid("76fe674f-37ed-4f38-826d-0130ca5eb809") },
                    { new Guid("ad55cef8-0227-4b08-a3da-f03e69ebbbb0"), new Guid("f8b8b854-6c91-40fc-b223-a2584a1136de"), new Guid("78416ab0-88b9-43cb-92db-fc6645c20f38") }
                });

            migrationBuilder.InsertData(
                table: "message",
                columns: new[] { "Id", "message", "organizationReceiverId", "organizationSenderId", "sendingTime", "userReceiverId", "userSenderId" },
                values: new object[,]
                {
                    { new Guid("d89e41a9-c06d-47ac-a03a-e9c66667f622"), "May I participate in your action :)", new Guid("9df6c3dc-7b1a-44e5-9abc-fe154632de61"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 11, 20, 22, 24, 30, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("e64a8937-90da-4689-8d55-dc6790765c1b") },
                    { new Guid("20bffc3e-2bd2-418f-af96-727d7f92f963"), "Of course you can. All the best.", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9df6c3dc-7b1a-44e5-9abc-fe154632de61"), new DateTime(2019, 11, 20, 23, 25, 30, 0, DateTimeKind.Unspecified), new Guid("e64a8937-90da-4689-8d55-dc6790765c1b"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f661044a-c082-4bd4-bbdc-98aa52bdf200"), "How are you my friend?", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6807ffd4-1595-4678-8813-d3308efb2e2f"), new Guid("7e1202f8-3b7c-459a-8800-5e56dea8d462") },
                    { new Guid("7e387e54-0934-481b-a174-f614444cd3c5"), "All is well, thank you, and you?", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7e1202f8-3b7c-459a-8800-5e56dea8d462"), new Guid("6807ffd4-1595-4678-8813-d3308efb2e2f") },
                    { new Guid("d55f331f-648a-411a-8bbf-8d90427e782b"), "I am fine, thanks", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6807ffd4-1595-4678-8813-d3308efb2e2f"), new Guid("7e1202f8-3b7c-459a-8800-5e56dea8d462") }
                });

            migrationBuilder.InsertData(
                table: "organization",
                columns: new[] { "Id", "UserAccount", "creditCardNumber", "dateOfFounding", "description", "name" },
                values: new object[,]
                {
                    { new Guid("9df6c3dc-7b1a-44e5-9abc-fe154632de61"), new Guid("40a27398-27f5-43b2-92a3-0de1e11dc3d6"), new Guid("92a94df6-bedd-45f4-9017-bc2f52e3e8be"), new DateTime(2015, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a sample organization for doing something which is good", "CharityOrg1" },
                    { new Guid("87603e62-de5f-47ee-8783-297b3d08e78a"), new Guid("7a509ec5-20ec-4ae9-b5b4-5d92d0acba07"), new Guid("4fd45971-cfbb-45f2-a1ad-0294826cff45"), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "This organization does charity actions which are great!", "CharityOrg2" }
                });

            migrationBuilder.InsertData(
                table: "payment",
                columns: new[] { "Id", "amount", "organizationReceiverId", "userSenderId" },
                values: new object[,]
                {
                    { new Guid("65fad5c7-f833-4e29-8a94-1a79eaa6320c"), 100.0, new Guid("87603e62-de5f-47ee-8783-297b3d08e78a"), new Guid("e64a8937-90da-4689-8d55-dc6790765c1b") },
                    { new Guid("7291e5b7-f939-4ab2-a93b-9f8e07790c6e"), 100.0, new Guid("9df6c3dc-7b1a-44e5-9abc-fe154632de61"), new Guid("e64a8937-90da-4689-8d55-dc6790765c1b") },
                    { new Guid("28f51d1b-8fc7-4898-b98d-ec50f59497b2"), 100.0, new Guid("9df6c3dc-7b1a-44e5-9abc-fe154632de61"), new Guid("7e1202f8-3b7c-459a-8800-5e56dea8d462") }
                });

            migrationBuilder.InsertData(
                table: "profilePosts",
                columns: new[] { "Id", "actionId", "message", "userId" },
                values: new object[,]
                {
                    { new Guid("a2d14e65-72b0-4190-ae7b-02db8f244d70"), new Guid("bac49b04-61e1-4f94-b785-0856cd6b0c69"), "Normally, I did as well.", new Guid("6807ffd4-1595-4678-8813-d3308efb2e2f") },
                    { new Guid("8ceaeecc-5b92-45ce-9f35-53eb1e9659ad"), new Guid("4be49861-6615-4a15-b2fb-c41db15a7844"), "I just did something in this action", new Guid("e64a8937-90da-4689-8d55-dc6790765c1b") },
                    { new Guid("74cdb43b-e00c-4aeb-8756-45eb4cdf8b0b"), new Guid("f8b8b854-6c91-40fc-b223-a2584a1136de"), "I did something too", new Guid("7e1202f8-3b7c-459a-8800-5e56dea8d462") }
                });

            migrationBuilder.InsertData(
                table: "reactionsToPosts",
                columns: new[] { "Id", "commentText", "commented", "liked", "postId", "userReactedId" },
                values: new object[,]
                {
                    { new Guid("6cd76c62-f915-4e4c-bf81-70fc81694af1"), null, false, true, new Guid("8ceaeecc-5b92-45ce-9f35-53eb1e9659ad"), new Guid("6807ffd4-1595-4678-8813-d3308efb2e2f") },
                    { new Guid("326f27b6-b058-4664-8d77-b7803207ef21"), "Glad you did that!", true, true, new Guid("74cdb43b-e00c-4aeb-8756-45eb4cdf8b0b"), new Guid("e64a8937-90da-4689-8d55-dc6790765c1b") },
                    { new Guid("1639ba9c-83d3-4d19-b30c-0bc3de0d93e2"), null, false, true, new Guid("a2d14e65-72b0-4190-ae7b-02db8f244d70"), new Guid("7e1202f8-3b7c-459a-8800-5e56dea8d462") }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "UserAccount", "creditCardId", "dateOfBirth", "firstName", "gender", "lastName" },
                values: new object[,]
                {
                    { new Guid("7e1202f8-3b7c-459a-8800-5e56dea8d462"), new Guid("c3c6d77b-83af-44ec-a282-bd2d3d234014"), new Guid("8df97b0c-990d-4bb6-b047-e6824c9aa996"), new DateTime(1980, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "F", "Doe" },
                    { new Guid("e64a8937-90da-4689-8d55-dc6790765c1b"), new Guid("87bc4eee-eb63-4dc1-b85e-5ad9d4d31062"), new Guid("ee7337bd-ba35-4e2f-ac10-facf2364ba42"), new DateTime(1997, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foo", "M", "Bar" },
                    { new Guid("6807ffd4-1595-4678-8813-d3308efb2e2f"), new Guid("a1095b75-9014-4f34-8bae-2278ce3ce3bd"), new Guid("b1fb4138-3737-44e9-97eb-b23e040a23d2"), new DateTime(1970, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", "M", "Cage" }
                });

            migrationBuilder.InsertData(
                table: "userParticipatingInAction",
                columns: new[] { "Id", "actionId", "userId" },
                values: new object[,]
                {
                    { new Guid("bad43e16-56b1-4eef-9c0e-af37275e6ee6"), new Guid("f8b8b854-6c91-40fc-b223-a2584a1136de"), new Guid("7e1202f8-3b7c-459a-8800-5e56dea8d462") },
                    { new Guid("a350ee65-9223-412c-85fc-cba4ccfe1c41"), new Guid("4be49861-6615-4a15-b2fb-c41db15a7844"), new Guid("e64a8937-90da-4689-8d55-dc6790765c1b") },
                    { new Guid("b95f63ca-312e-425d-8ae1-7a398bb8df2c"), new Guid("bac49b04-61e1-4f94-b785-0856cd6b0c69"), new Guid("6807ffd4-1595-4678-8813-d3308efb2e2f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("40a27398-27f5-43b2-92a3-0de1e11dc3d6"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("7a509ec5-20ec-4ae9-b5b4-5d92d0acba07"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("87bc4eee-eb63-4dc1-b85e-5ad9d4d31062"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("a1095b75-9014-4f34-8bae-2278ce3ce3bd"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("c3c6d77b-83af-44ec-a282-bd2d3d234014"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("4be49861-6615-4a15-b2fb-c41db15a7844"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("bac49b04-61e1-4f94-b785-0856cd6b0c69"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("f8b8b854-6c91-40fc-b223-a2584a1136de"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("4fd45971-cfbb-45f2-a1ad-0294826cff45"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("8df97b0c-990d-4bb6-b047-e6824c9aa996"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("92a94df6-bedd-45f4-9017-bc2f52e3e8be"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("b1fb4138-3737-44e9-97eb-b23e040a23d2"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("ee7337bd-ba35-4e2f-ac10-facf2364ba42"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("351adfb5-c6c0-441b-a3d7-3397160f301d"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("44d3389a-1a41-4234-bc72-6ed8965790a8"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("ddc0e647-ca5a-4379-8ea1-fc803958a760"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("f4e8fc86-6532-422c-a3a9-2497ff9e0580"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("f6c2228e-fe6e-483a-a41c-6984f8ab06d8"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "Id",
                keyValue: new Guid("76fe674f-37ed-4f38-826d-0130ca5eb809"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "Id",
                keyValue: new Guid("78416ab0-88b9-43cb-92db-fc6645c20f38"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("20325563-7205-4698-be50-581d003054e1"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("9edbde5e-ab90-4e6e-b63b-a95161de3af4"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("ad55cef8-0227-4b08-a3da-f03e69ebbbb0"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("20bffc3e-2bd2-418f-af96-727d7f92f963"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("7e387e54-0934-481b-a174-f614444cd3c5"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("d55f331f-648a-411a-8bbf-8d90427e782b"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("d89e41a9-c06d-47ac-a03a-e9c66667f622"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("f661044a-c082-4bd4-bbdc-98aa52bdf200"));

            migrationBuilder.DeleteData(
                table: "organization",
                keyColumn: "Id",
                keyValue: new Guid("87603e62-de5f-47ee-8783-297b3d08e78a"));

            migrationBuilder.DeleteData(
                table: "organization",
                keyColumn: "Id",
                keyValue: new Guid("9df6c3dc-7b1a-44e5-9abc-fe154632de61"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("28f51d1b-8fc7-4898-b98d-ec50f59497b2"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("65fad5c7-f833-4e29-8a94-1a79eaa6320c"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("7291e5b7-f939-4ab2-a93b-9f8e07790c6e"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("74cdb43b-e00c-4aeb-8756-45eb4cdf8b0b"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("8ceaeecc-5b92-45ce-9f35-53eb1e9659ad"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("a2d14e65-72b0-4190-ae7b-02db8f244d70"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("1639ba9c-83d3-4d19-b30c-0bc3de0d93e2"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("326f27b6-b058-4664-8d77-b7803207ef21"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("6cd76c62-f915-4e4c-bf81-70fc81694af1"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("6807ffd4-1595-4678-8813-d3308efb2e2f"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("7e1202f8-3b7c-459a-8800-5e56dea8d462"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("e64a8937-90da-4689-8d55-dc6790765c1b"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("a350ee65-9223-412c-85fc-cba4ccfe1c41"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("b95f63ca-312e-425d-8ae1-7a398bb8df2c"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("bad43e16-56b1-4eef-9c0e-af37275e6ee6"));

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "Id", "email", "imageId", "isUser", "password", "username" },
                values: new object[,]
                {
                    { new Guid("e7146b70-ad4d-4d28-ba0c-c420b18c14cc"), "sampleUser1@mail.com", new Guid("bcf0ffae-1f10-4d24-8baa-84cb11442f52"), true, "c72a944b810cb996c3107ae0a774980f1e4ec1232990a3c62a73c750675bcd5d", "sampleUser1" },
                    { new Guid("68984eae-1ab5-4c66-8a1d-e0ffb17bda5b"), "sampleUser2@mail.com", new Guid("1713b227-ffb6-4c8e-8247-84be15928f4c"), true, "defd7d850c9632421ba1244bc22642facdc2115c60dbd0d2663b1117ba4f50a9", "sampleUser2" },
                    { new Guid("d2f23741-7b74-4b39-b28d-42172eb04420"), "sampleUser3@mail.com", new Guid("bcf316fa-dc18-4b8b-9090-f08c476ff85c"), true, "d4481413102ca87dc30943994469caad1ab2de1b869514348b003553bde4d3b1", "sampleUser3" },
                    { new Guid("22a187d3-9985-4b5d-bcd7-4f6c8843053a"), "sampleUser4@mail.com", new Guid("833fee49-3a76-47c8-b5cf-40c57611f77f"), false, "4d5c81c22882ff79cc1c45031acd9afcd1cf063f9b6d664adb1d33cf4c681807", "sampleUser4" },
                    { new Guid("888e8504-9287-4ad1-a984-dfe2d91ff32b"), "sampleUser5@mail.com", new Guid("178a0435-7822-42c8-9c7f-9199f9b5a09e"), false, "cc6b98042e62e0c4da7110a42dcd7aaf20ec2bbc250b89923353d39483ef46a4", "sampleUser5" }
                });

            migrationBuilder.InsertData(
                table: "action",
                columns: new[] { "Id", "actionType", "creationDateTime", "description", "endDateTime", "name", "organizationId", "startDateTime" },
                values: new object[,]
                {
                    { new Guid("08e37fa3-98c0-4220-b632-987e4c37131a"), false, new DateTime(2019, 11, 27, 19, 32, 0, 0, DateTimeKind.Unspecified), "This is a generic action where you sign up to participate", new DateTime(2020, 2, 5, 19, 32, 0, 0, DateTimeKind.Unspecified), "Race for cure", new Guid("f1a17f5b-f1f0-49eb-a3d3-439e72f90702"), new DateTime(2019, 11, 27, 19, 32, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cfa621ba-af9a-4841-91c3-faf453759c25"), true, new DateTime(2019, 11, 27, 19, 32, 0, 0, DateTimeKind.Unspecified), "This is a generic action where people donate stuff", new DateTime(2020, 2, 5, 19, 32, 0, 0, DateTimeKind.Unspecified), "Fundraising for children without parents", new Guid("f1a17f5b-f1f0-49eb-a3d3-439e72f90702"), new DateTime(2019, 11, 27, 19, 32, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd9e6842-c122-4eec-aa93-c327fb48532b"), true, new DateTime(2019, 11, 27, 19, 32, 0, 0, DateTimeKind.Unspecified), "This is another action where people donate stuff", new DateTime(2020, 2, 5, 19, 32, 0, 0, DateTimeKind.Unspecified), "Another fundraising", new Guid("040fc5b6-f94b-4079-8b98-0298a59ae07f"), new DateTime(2019, 11, 27, 19, 32, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "card",
                columns: new[] { "Id", "amount", "bankName", "creditCardNumber", "dateOfExpiry" },
                values: new object[,]
                {
                    { new Guid("bdc3d82a-6616-401a-9050-f908ee557c51"), 55.0, "Austria Bank", "7383940414243444", new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd6cd9f7-cdbc-40e0-a0e8-ebc03309f615"), 200.0, "Austria Bank", "9303132333435363", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d391b65-974c-482e-9084-f85272e12765"), 150.0, "Karntner Ladesbank Raiffeisen", "1222324252627282", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b34dea03-3805-424a-95c8-c8c777fa4570"), 50.0, "Karntner Sparkasse", "3141516171819202", new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2184a6fe-1ee2-482c-9002-4016fd6375cd"), 100.0, "Karntner Sparkasse", "1234567891011121", new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "image",
                columns: new[] { "Id", "Path" },
                values: new object[,]
                {
                    { new Guid("bcf0ffae-1f10-4d24-8baa-84cb11442f52"), "https://i.pinimg.com/originals/df/bd/df/dfbddf7c530ab5f4cd70154409651f9d.jpg" },
                    { new Guid("1713b227-ffb6-4c8e-8247-84be15928f4c"), "http://bestdayevereducation.com/uploads/images/FreeVector-Spongebob-Squarepants-Vector.jpg" },
                    { new Guid("bcf316fa-dc18-4b8b-9090-f08c476ff85c"), "https://arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/AVA6IKPJNBAS7JZ3CREUNY64K4.jpg" },
                    { new Guid("833fee49-3a76-47c8-b5cf-40c57611f77f"), "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Cartoon_Network_2010_logo.svg/2000px-Cartoon_Network_2010_logo.svg.png" },
                    { new Guid("178a0435-7822-42c8-9c7f-9199f9b5a09e"), "https://cdn.vox-cdn.com/thumbor/m6_h4h6uHuJeZCnWTCz7anTlVJA=/0x0:1920x1080/1200x800/filters:focal(807x387:1113x693)/cdn.vox-cdn.com/uploads/chorus_image/image/60720529/disneyplus.0.4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "Id", "description", "name", "userDonatedId", "value" },
                values: new object[,]
                {
                    { new Guid("b5e6b0e9-b052-434e-bef4-04215e9d687a"), "A ball for playing basketball", "Basketball", new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af"), 50 },
                    { new Guid("1cf47408-cc50-4162-83be-e27030f44451"), "Some spare makeup I donate", "Makeup", new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09"), 150 }
                });

            migrationBuilder.InsertData(
                table: "itemInAction",
                columns: new[] { "Id", "actionId", "itemId" },
                values: new object[,]
                {
                    { new Guid("ba187e42-7178-44f9-a63a-1d57658ae295"), new Guid("cfa621ba-af9a-4841-91c3-faf453759c25"), new Guid("b5e6b0e9-b052-434e-bef4-04215e9d687a") },
                    { new Guid("038a7998-a85e-4bb0-9774-e1e9f631cf2b"), new Guid("dd9e6842-c122-4eec-aa93-c327fb48532b"), new Guid("1cf47408-cc50-4162-83be-e27030f44451") },
                    { new Guid("450a2c0f-55e9-4c85-b6f1-02b7e1536b45"), new Guid("cfa621ba-af9a-4841-91c3-faf453759c25"), new Guid("b5e6b0e9-b052-434e-bef4-04215e9d687a") }
                });

            migrationBuilder.InsertData(
                table: "message",
                columns: new[] { "Id", "message", "organizationReceiverId", "organizationSenderId", "sendingTime", "userReceiverId", "userSenderId" },
                values: new object[,]
                {
                    { new Guid("803e9b62-4b01-421a-8d3e-963e7c14e9dd"), "May I participate in your action :)", new Guid("f1a17f5b-f1f0-49eb-a3d3-439e72f90702"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 11, 20, 22, 24, 30, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af") },
                    { new Guid("3ad3d982-1bd7-4a98-9559-e1d45f9846a5"), "Of course you can. All the best.", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f1a17f5b-f1f0-49eb-a3d3-439e72f90702"), new DateTime(2019, 11, 20, 23, 25, 30, 0, DateTimeKind.Unspecified), new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e2b7a97c-8284-4643-bde8-b3f079ccec47"), "How are you my friend?", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ee1c06e6-7537-4d3a-9084-27e2653e26b8"), new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09") },
                    { new Guid("51038d49-7362-420b-a04a-279790b454d9"), "All is well, thank you, and you?", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09"), new Guid("ee1c06e6-7537-4d3a-9084-27e2653e26b8") },
                    { new Guid("d247e17e-f121-49b9-ba31-954a818b3fdc"), "I am fine, thanks", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ee1c06e6-7537-4d3a-9084-27e2653e26b8"), new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09") }
                });

            migrationBuilder.InsertData(
                table: "organization",
                columns: new[] { "Id", "UserAccount", "creditCardNumber", "dateOfFounding", "description", "name" },
                values: new object[,]
                {
                    { new Guid("f1a17f5b-f1f0-49eb-a3d3-439e72f90702"), new Guid("22a187d3-9985-4b5d-bcd7-4f6c8843053a"), new Guid("bd6cd9f7-cdbc-40e0-a0e8-ebc03309f615"), new DateTime(2015, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a sample organization for doing something which is good", "CharityOrg1" },
                    { new Guid("040fc5b6-f94b-4079-8b98-0298a59ae07f"), new Guid("888e8504-9287-4ad1-a984-dfe2d91ff32b"), new Guid("bdc3d82a-6616-401a-9050-f908ee557c51"), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "This organization does charity actions which are great!", "CharityOrg2" }
                });

            migrationBuilder.InsertData(
                table: "payment",
                columns: new[] { "Id", "amount", "organizationReceiverId", "userSenderId" },
                values: new object[,]
                {
                    { new Guid("346d4e57-4185-4d20-8315-a487f54bb378"), 100.0, new Guid("040fc5b6-f94b-4079-8b98-0298a59ae07f"), new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af") },
                    { new Guid("af9e127a-329c-4c7b-a28c-bb9c4193d6a0"), 100.0, new Guid("f1a17f5b-f1f0-49eb-a3d3-439e72f90702"), new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af") },
                    { new Guid("e5e4fbcd-4dce-419b-9f8f-f269fcd1fe3f"), 100.0, new Guid("f1a17f5b-f1f0-49eb-a3d3-439e72f90702"), new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09") }
                });

            migrationBuilder.InsertData(
                table: "profilePosts",
                columns: new[] { "Id", "actionId", "message", "userId" },
                values: new object[,]
                {
                    { new Guid("5c4f4b15-f208-4aa1-8d80-58ea901b10ce"), new Guid("dd9e6842-c122-4eec-aa93-c327fb48532b"), "Normally, I did as well.", new Guid("ee1c06e6-7537-4d3a-9084-27e2653e26b8") },
                    { new Guid("fc46cac9-f244-4cd4-a986-8b2a0700680c"), new Guid("08e37fa3-98c0-4220-b632-987e4c37131a"), "I just did something in this action", new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af") },
                    { new Guid("229379a4-d697-498b-a9af-5bf4e645d88a"), new Guid("cfa621ba-af9a-4841-91c3-faf453759c25"), "I did something too", new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09") }
                });

            migrationBuilder.InsertData(
                table: "reactionsToPosts",
                columns: new[] { "Id", "commentText", "commented", "liked", "postId", "userReactedId" },
                values: new object[,]
                {
                    { new Guid("c9d9c4eb-dce3-4867-9932-e3f37b15933f"), null, false, true, new Guid("fc46cac9-f244-4cd4-a986-8b2a0700680c"), new Guid("ee1c06e6-7537-4d3a-9084-27e2653e26b8") },
                    { new Guid("559053ca-1373-4c63-94a5-f547e0713fb2"), "Glad you did that!", true, true, new Guid("229379a4-d697-498b-a9af-5bf4e645d88a"), new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af") },
                    { new Guid("5f411452-0340-482c-98a2-cbdffd04939e"), null, false, true, new Guid("5c4f4b15-f208-4aa1-8d80-58ea901b10ce"), new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09") }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "UserAccount", "creditCardId", "dateOfBirth", "firstName", "gender", "lastName" },
                values: new object[,]
                {
                    { new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09"), new Guid("68984eae-1ab5-4c66-8a1d-e0ffb17bda5b"), new Guid("b34dea03-3805-424a-95c8-c8c777fa4570"), new DateTime(1980, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", null, "Doe" },
                    { new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af"), new Guid("e7146b70-ad4d-4d28-ba0c-c420b18c14cc"), new Guid("2184a6fe-1ee2-482c-9002-4016fd6375cd"), new DateTime(1997, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foo", null, "Bar" },
                    { new Guid("ee1c06e6-7537-4d3a-9084-27e2653e26b8"), new Guid("d2f23741-7b74-4b39-b28d-42172eb04420"), new Guid("1d391b65-974c-482e-9084-f85272e12765"), new DateTime(1970, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", null, "Cage" }
                });

            migrationBuilder.InsertData(
                table: "userParticipatingInAction",
                columns: new[] { "Id", "actionId", "userId" },
                values: new object[,]
                {
                    { new Guid("cc44e437-575a-42eb-ab71-8a4d23991199"), new Guid("cfa621ba-af9a-4841-91c3-faf453759c25"), new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09") },
                    { new Guid("42f92044-967c-4df1-af5d-673fc63c37ae"), new Guid("08e37fa3-98c0-4220-b632-987e4c37131a"), new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af") },
                    { new Guid("7e58c9db-4f5a-42d4-9c30-4c3508e18b40"), new Guid("dd9e6842-c122-4eec-aa93-c327fb48532b"), new Guid("ee1c06e6-7537-4d3a-9084-27e2653e26b8") }
                });
        }
    }
}
