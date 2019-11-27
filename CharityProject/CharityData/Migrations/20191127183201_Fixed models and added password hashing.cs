using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharityData.Migrations
{
    public partial class Fixedmodelsandaddedpasswordhashing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("7aeddfaa-8322-4f4f-9e75-b25ce00c3c8b"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("860a538f-b18b-4ab7-a087-bc5ee9788794"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("8ae15fe9-918f-4c6d-88d3-625ef29b7ba6"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("b4934321-8582-47cf-9efa-bcbeec7dfc33"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("d65bacd6-1cc6-4c28-b156-f2af70e0541d"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("090fdc74-724a-4857-a086-33c4c81f75ad"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("433dfd43-d513-44ed-996b-60b04489183c"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("66f07ce4-d088-43b5-88a8-a421d4868c15"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("53acdc31-facc-40d8-a3e3-3e29faa26725"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("7c238eb6-2fca-43d3-bca0-7dcf0268e92c"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("8db7c482-021d-4a19-af47-a2091f675701"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("8e240754-b08e-4b04-8ece-780e8d58cb1b"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("e722111a-3b2f-410b-8e1b-1874b25e8ed2"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("26c16cbf-9fea-4e72-bd93-3244abdaa772"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("9806d066-c0fe-4251-8517-1f8ce94571c4"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("b79693eb-16b1-4df7-8a8e-de1d9ac4790b"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("bab0b427-eda2-491d-b860-4776a8e7c3a3"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("cc0e125c-9fd8-4b29-ab79-63afab725bf6"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "Id",
                keyValue: new Guid("3f2e29bc-3014-4c1d-b1c2-39b4913af56e"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "Id",
                keyValue: new Guid("bb29bd97-f582-4e23-9d9d-5d3e1ee5b6d3"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("59060235-aa47-4110-acfc-8b99d6fce99a"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("72ef8d6e-c1e7-494e-be93-7c27388f90ab"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("bae3e62c-88c5-4948-8346-bb14a6dc74a7"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("16b9f424-9ac8-4dc7-ae1c-7b0c2faf3318"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("2a0db98a-059f-4db5-b361-dccf46f72706"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("91a39e60-3d64-4211-9558-16202391edff"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("c6c0b429-b345-4b39-baec-fbfb445c8ae9"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("fb57594f-1b62-4614-ae41-813dc0e5de80"));

            migrationBuilder.DeleteData(
                table: "organization",
                keyColumn: "Id",
                keyValue: new Guid("a82fc791-aba1-438d-9edb-5d3bb6f214dc"));

            migrationBuilder.DeleteData(
                table: "organization",
                keyColumn: "Id",
                keyValue: new Guid("b636b6a1-541f-49d0-bdf6-86d3178b0244"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("580fb56e-dcce-4e03-a3d4-f644d3177b90"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("58c6d3ae-be28-4453-8293-90b6fab36532"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("6c94aa1b-4920-478a-bced-c24086ea21b7"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("e61bff5f-626f-4b84-834a-792153336f0e"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("e6b0310b-bd4c-470f-afd6-9502ad864347"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("eee07d64-fcc8-4103-a9d1-dda1350b0f0d"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("18662e95-035f-42e3-8162-8f5266e17a91"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("b2559667-80be-48e3-9eff-8a7e138606c0"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("d306a74a-1524-4c7c-93e0-5df9c40b24ec"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("31a26eb4-4b3c-4b64-b8f8-00986fc35266"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("75da4ab5-1c03-48ed-8bfd-a3b19f9fdda5"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("f5e20a12-5f25-4177-9d3a-e3783319d6a6"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("21365611-7f2f-47b0-8890-5bdd43bcf04a"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("baebd90e-69ef-42c5-8843-55e212008241"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("e6c870d0-8edf-42ba-b58a-346c8e18fb75"));

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "user",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "commentText",
                table: "reactionsToPosts",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "amount",
                table: "card",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "creditCardNumber",
                table: "card",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "creationDateTime",
                table: "action",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "endDateTime",
                table: "action",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "startDateTime",
                table: "action",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "account",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "account",
                nullable: true);

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
                    { new Guid("f2de65ee-3520-47ff-866f-4c4d02e0cc09"), new Guid("68984eae-1ab5-4c66-8a1d-e0ffb17bda5b"), new Guid("b34dea03-3805-424a-95c8-c8c777fa4570"), new DateTime(1980, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "F", "Doe" },
                    { new Guid("3c791c17-e88e-4f49-a287-2e9fc1f802af"), new Guid("e7146b70-ad4d-4d28-ba0c-c420b18c14cc"), new Guid("2184a6fe-1ee2-482c-9002-4016fd6375cd"), new DateTime(1997, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foo", "M", "Bar" },
                    { new Guid("ee1c06e6-7537-4d3a-9084-27e2653e26b8"), new Guid("d2f23741-7b74-4b39-b28d-42172eb04420"), new Guid("1d391b65-974c-482e-9084-f85272e12765"), new DateTime(1970, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", "M", "Cage" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "gender",
                table: "user");

            migrationBuilder.DropColumn(
                name: "commentText",
                table: "reactionsToPosts");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "card");

            migrationBuilder.DropColumn(
                name: "creditCardNumber",
                table: "card");

            migrationBuilder.DropColumn(
                name: "creationDateTime",
                table: "action");

            migrationBuilder.DropColumn(
                name: "endDateTime",
                table: "action");

            migrationBuilder.DropColumn(
                name: "startDateTime",
                table: "action");

            migrationBuilder.DropColumn(
                name: "email",
                table: "account");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "account",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 80);

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
    }
}
