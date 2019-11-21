using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharityData.Migrations
{
    public partial class FixedmigrationforPostReactionnotextwhencommentingandUserGender : Migration
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

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "Id", "imageId", "isUser", "password", "username" },
                values: new object[,]
                {
                    { new Guid("3a3c754a-07e2-4c14-96db-45cee559a474"), new Guid("a66bf0c0-2c93-492b-9513-186d9644eaf4"), true, "samplepass1", "sampleUser1" },
                    { new Guid("547a73f9-362d-4ca2-ad7c-65d7cb14d0d7"), new Guid("f58b66d5-fd23-4ff4-9023-f6b79a03f3b2"), true, "samplepass2", "sampleUser2" },
                    { new Guid("57aec4ab-79d6-4ca5-9a56-10e833d48921"), new Guid("e1960e5b-5c37-40b1-ba14-0af2ad8662cb"), true, "samplepass3", "sampleUser3" },
                    { new Guid("3534935d-6ed3-4736-9bc7-b21a1417cae1"), new Guid("d8f9fffb-e10b-4356-a12b-f24b4db5d937"), false, "samplepass4", "sampleUser4" },
                    { new Guid("e4400f56-a926-4d86-b3e9-9ac201f7eca7"), new Guid("0d689427-18d9-4c32-a72c-00155ac31fcf"), false, "samplepass5", "sampleUser5" }
                });

            migrationBuilder.InsertData(
                table: "action",
                columns: new[] { "Id", "actionType", "description", "name", "organizationId" },
                values: new object[,]
                {
                    { new Guid("a0a29966-1c47-49bd-9f69-5eb5cd367472"), false, "This is a generic action where you sign up to participate", "Race for cure", new Guid("9d339f07-7548-4d66-ad39-4886de3033dd") },
                    { new Guid("3af982da-a061-4cfc-84b9-1ecb6d929342"), true, "This is a generic action where people donate stuff", "Fundraising for children without parents", new Guid("9d339f07-7548-4d66-ad39-4886de3033dd") },
                    { new Guid("ef83bf0b-fea0-411b-8fdd-1293aee8adb4"), true, "This is another action where people donate stuff", "Another fundraising", new Guid("bade659a-e76d-4bba-bb59-358f293ed262") }
                });

            migrationBuilder.InsertData(
                table: "card",
                columns: new[] { "Id", "bankName", "dateOfExpiry" },
                values: new object[,]
                {
                    { new Guid("d89dcfaf-29cf-40a8-b627-5f62a1d507a2"), "Austria Bank", new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a333c0b5-ed74-48b9-905e-7f958ca55dfc"), "Austria Bank", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0511a552-89cd-41a3-a581-ea931327682d"), "Karntner Ladesbank Raiffeisen", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f6efe01-ecba-4b20-a9ed-6049ae82b776"), "Karntner Sparkasse", new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0fc952ae-13f6-4161-aeb1-b9e040d8dce3"), "Karntner Sparkasse", new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "image",
                columns: new[] { "Id", "Path" },
                values: new object[,]
                {
                    { new Guid("a66bf0c0-2c93-492b-9513-186d9644eaf4"), "https://i.pinimg.com/originals/df/bd/df/dfbddf7c530ab5f4cd70154409651f9d.jpg" },
                    { new Guid("f58b66d5-fd23-4ff4-9023-f6b79a03f3b2"), "http://bestdayevereducation.com/uploads/images/FreeVector-Spongebob-Squarepants-Vector.jpg" },
                    { new Guid("e1960e5b-5c37-40b1-ba14-0af2ad8662cb"), "https://arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/AVA6IKPJNBAS7JZ3CREUNY64K4.jpg" },
                    { new Guid("d8f9fffb-e10b-4356-a12b-f24b4db5d937"), "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Cartoon_Network_2010_logo.svg/2000px-Cartoon_Network_2010_logo.svg.png" },
                    { new Guid("0d689427-18d9-4c32-a72c-00155ac31fcf"), "https://cdn.vox-cdn.com/thumbor/m6_h4h6uHuJeZCnWTCz7anTlVJA=/0x0:1920x1080/1200x800/filters:focal(807x387:1113x693)/cdn.vox-cdn.com/uploads/chorus_image/image/60720529/disneyplus.0.4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "item",
                columns: new[] { "Id", "description", "name", "userDonatedId", "value" },
                values: new object[,]
                {
                    { new Guid("0d8c0f93-93a0-424a-9330-97be4bfd636b"), "A ball for playing basketball", "Basketball", new Guid("02eefb58-88d5-466d-af8b-12faa98aecd1"), 50 },
                    { new Guid("4cc52e84-307c-454c-bf48-d2e44f042e61"), "Some spare makeup I donate", "Makeup", new Guid("34a35df2-22c7-40f6-b302-caa4af4fece8"), 150 }
                });

            migrationBuilder.InsertData(
                table: "itemInAction",
                columns: new[] { "Id", "actionId", "itemId" },
                values: new object[,]
                {
                    { new Guid("bd4faa4b-ad4f-4bb4-9740-6c8369c6bff3"), new Guid("3af982da-a061-4cfc-84b9-1ecb6d929342"), new Guid("0d8c0f93-93a0-424a-9330-97be4bfd636b") },
                    { new Guid("aec3727b-f38f-4f00-ae47-16e359ce7f94"), new Guid("ef83bf0b-fea0-411b-8fdd-1293aee8adb4"), new Guid("4cc52e84-307c-454c-bf48-d2e44f042e61") },
                    { new Guid("fbb21596-b09d-409c-812b-785912d57d33"), new Guid("3af982da-a061-4cfc-84b9-1ecb6d929342"), new Guid("0d8c0f93-93a0-424a-9330-97be4bfd636b") }
                });

            migrationBuilder.InsertData(
                table: "message",
                columns: new[] { "Id", "message", "organizationReceiverId", "organizationSenderId", "sendingTime", "userReceiverId", "userSenderId" },
                values: new object[,]
                {
                    { new Guid("5129e70f-d6bc-48a4-bc18-2ae38d449f0c"), "May I participate in your action :)", new Guid("9d339f07-7548-4d66-ad39-4886de3033dd"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 11, 20, 22, 24, 30, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("02eefb58-88d5-466d-af8b-12faa98aecd1") },
                    { new Guid("32a708be-c99e-4f2f-8d43-d15ecb9e5c10"), "Of course you can. All the best.", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9d339f07-7548-4d66-ad39-4886de3033dd"), new DateTime(2019, 11, 20, 23, 25, 30, 0, DateTimeKind.Unspecified), new Guid("02eefb58-88d5-466d-af8b-12faa98aecd1"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2fd75fd0-bc70-4d5e-b220-55420de49466"), "How are you my friend?", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new Guid("26482449-1b84-44ab-8ac5-27f8f1634f8c"), new Guid("34a35df2-22c7-40f6-b302-caa4af4fece8") },
                    { new Guid("44497540-08e1-4c82-bf00-fdb5fe07af53"), "All is well, thank you, and you?", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), new Guid("34a35df2-22c7-40f6-b302-caa4af4fece8"), new Guid("26482449-1b84-44ab-8ac5-27f8f1634f8c") },
                    { new Guid("1b790cd1-13bd-4c3e-b3b2-b36af8f479c2"), "I am fine, thanks", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2019, 10, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new Guid("26482449-1b84-44ab-8ac5-27f8f1634f8c"), new Guid("34a35df2-22c7-40f6-b302-caa4af4fece8") }
                });

            migrationBuilder.InsertData(
                table: "organization",
                columns: new[] { "Id", "UserAccount", "creditCardNumber", "dateOfFounding", "description", "name" },
                values: new object[,]
                {
                    { new Guid("9d339f07-7548-4d66-ad39-4886de3033dd"), new Guid("3534935d-6ed3-4736-9bc7-b21a1417cae1"), new Guid("a333c0b5-ed74-48b9-905e-7f958ca55dfc"), new DateTime(2015, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is a sample organization for doing something which is good", "CharityOrg1" },
                    { new Guid("bade659a-e76d-4bba-bb59-358f293ed262"), new Guid("e4400f56-a926-4d86-b3e9-9ac201f7eca7"), new Guid("d89dcfaf-29cf-40a8-b627-5f62a1d507a2"), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "This organization does charity actions which are great!", "CharityOrg2" }
                });

            migrationBuilder.InsertData(
                table: "payment",
                columns: new[] { "Id", "amount", "organizationReceiverId", "userSenderId" },
                values: new object[,]
                {
                    { new Guid("22a6c3d0-0682-43b8-b226-bfb92ab9a816"), 100.0, new Guid("bade659a-e76d-4bba-bb59-358f293ed262"), new Guid("02eefb58-88d5-466d-af8b-12faa98aecd1") },
                    { new Guid("31a2ce51-5f23-4981-a89f-dbae81664e9e"), 100.0, new Guid("9d339f07-7548-4d66-ad39-4886de3033dd"), new Guid("02eefb58-88d5-466d-af8b-12faa98aecd1") },
                    { new Guid("9026f6cb-3f73-4d1e-ac83-75625a4f1a65"), 100.0, new Guid("9d339f07-7548-4d66-ad39-4886de3033dd"), new Guid("34a35df2-22c7-40f6-b302-caa4af4fece8") }
                });

            migrationBuilder.InsertData(
                table: "profilePosts",
                columns: new[] { "Id", "actionId", "message", "userId" },
                values: new object[,]
                {
                    { new Guid("fb1c3b7c-35b0-425e-9622-6e3d353b29be"), new Guid("ef83bf0b-fea0-411b-8fdd-1293aee8adb4"), "Normally, I did as well.", new Guid("26482449-1b84-44ab-8ac5-27f8f1634f8c") },
                    { new Guid("8316ddae-d339-48a1-93e7-20f006e4b343"), new Guid("a0a29966-1c47-49bd-9f69-5eb5cd367472"), "I just did something in this action", new Guid("02eefb58-88d5-466d-af8b-12faa98aecd1") },
                    { new Guid("001a3141-0756-4cf2-aab0-d5b4a22ce612"), new Guid("3af982da-a061-4cfc-84b9-1ecb6d929342"), "I did something too", new Guid("34a35df2-22c7-40f6-b302-caa4af4fece8") }
                });

            migrationBuilder.InsertData(
                table: "reactionsToPosts",
                columns: new[] { "Id", "commentText", "commented", "liked", "postId", "userReactedId" },
                values: new object[,]
                {
                    { new Guid("534659c1-ef47-40c4-bd96-7697eda707cd"), null, false, true, new Guid("8316ddae-d339-48a1-93e7-20f006e4b343"), new Guid("26482449-1b84-44ab-8ac5-27f8f1634f8c") },
                    { new Guid("df747e26-b7aa-408d-8079-3014fd5cddef"), "Glad you did that!", true, true, new Guid("001a3141-0756-4cf2-aab0-d5b4a22ce612"), new Guid("02eefb58-88d5-466d-af8b-12faa98aecd1") },
                    { new Guid("22f78e7a-0d0d-4cc3-939b-352e4666c848"), null, false, true, new Guid("fb1c3b7c-35b0-425e-9622-6e3d353b29be"), new Guid("34a35df2-22c7-40f6-b302-caa4af4fece8") }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "UserAccount", "creditCardId", "dateOfBirth", "firstName", "gender", "lastName" },
                values: new object[,]
                {
                    { new Guid("34a35df2-22c7-40f6-b302-caa4af4fece8"), new Guid("547a73f9-362d-4ca2-ad7c-65d7cb14d0d7"), new Guid("5f6efe01-ecba-4b20-a9ed-6049ae82b776"), new DateTime(1980, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "F", "Doe" },
                    { new Guid("02eefb58-88d5-466d-af8b-12faa98aecd1"), new Guid("3a3c754a-07e2-4c14-96db-45cee559a474"), new Guid("0fc952ae-13f6-4161-aeb1-b9e040d8dce3"), new DateTime(1997, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foo", "M", "Bar" },
                    { new Guid("26482449-1b84-44ab-8ac5-27f8f1634f8c"), new Guid("57aec4ab-79d6-4ca5-9a56-10e833d48921"), new Guid("0511a552-89cd-41a3-a581-ea931327682d"), new DateTime(1970, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicholas", "M", "Cage" }
                });

            migrationBuilder.InsertData(
                table: "userParticipatingInAction",
                columns: new[] { "Id", "actionId", "userId" },
                values: new object[,]
                {
                    { new Guid("d0581979-1450-4d2b-9807-e54ef106416a"), new Guid("3af982da-a061-4cfc-84b9-1ecb6d929342"), new Guid("34a35df2-22c7-40f6-b302-caa4af4fece8") },
                    { new Guid("e5c3548c-2dfe-4faa-b4bc-05997e874bde"), new Guid("a0a29966-1c47-49bd-9f69-5eb5cd367472"), new Guid("02eefb58-88d5-466d-af8b-12faa98aecd1") },
                    { new Guid("a9b7835d-1d6e-4823-8010-a120eecafd9d"), new Guid("ef83bf0b-fea0-411b-8fdd-1293aee8adb4"), new Guid("26482449-1b84-44ab-8ac5-27f8f1634f8c") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("3534935d-6ed3-4736-9bc7-b21a1417cae1"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("3a3c754a-07e2-4c14-96db-45cee559a474"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("547a73f9-362d-4ca2-ad7c-65d7cb14d0d7"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("57aec4ab-79d6-4ca5-9a56-10e833d48921"));

            migrationBuilder.DeleteData(
                table: "account",
                keyColumn: "Id",
                keyValue: new Guid("e4400f56-a926-4d86-b3e9-9ac201f7eca7"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("3af982da-a061-4cfc-84b9-1ecb6d929342"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("a0a29966-1c47-49bd-9f69-5eb5cd367472"));

            migrationBuilder.DeleteData(
                table: "action",
                keyColumn: "Id",
                keyValue: new Guid("ef83bf0b-fea0-411b-8fdd-1293aee8adb4"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("0511a552-89cd-41a3-a581-ea931327682d"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("0fc952ae-13f6-4161-aeb1-b9e040d8dce3"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("5f6efe01-ecba-4b20-a9ed-6049ae82b776"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("a333c0b5-ed74-48b9-905e-7f958ca55dfc"));

            migrationBuilder.DeleteData(
                table: "card",
                keyColumn: "Id",
                keyValue: new Guid("d89dcfaf-29cf-40a8-b627-5f62a1d507a2"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("0d689427-18d9-4c32-a72c-00155ac31fcf"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("a66bf0c0-2c93-492b-9513-186d9644eaf4"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("d8f9fffb-e10b-4356-a12b-f24b4db5d937"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("e1960e5b-5c37-40b1-ba14-0af2ad8662cb"));

            migrationBuilder.DeleteData(
                table: "image",
                keyColumn: "Id",
                keyValue: new Guid("f58b66d5-fd23-4ff4-9023-f6b79a03f3b2"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "Id",
                keyValue: new Guid("0d8c0f93-93a0-424a-9330-97be4bfd636b"));

            migrationBuilder.DeleteData(
                table: "item",
                keyColumn: "Id",
                keyValue: new Guid("4cc52e84-307c-454c-bf48-d2e44f042e61"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("aec3727b-f38f-4f00-ae47-16e359ce7f94"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("bd4faa4b-ad4f-4bb4-9740-6c8369c6bff3"));

            migrationBuilder.DeleteData(
                table: "itemInAction",
                keyColumn: "Id",
                keyValue: new Guid("fbb21596-b09d-409c-812b-785912d57d33"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("1b790cd1-13bd-4c3e-b3b2-b36af8f479c2"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("2fd75fd0-bc70-4d5e-b220-55420de49466"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("32a708be-c99e-4f2f-8d43-d15ecb9e5c10"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("44497540-08e1-4c82-bf00-fdb5fe07af53"));

            migrationBuilder.DeleteData(
                table: "message",
                keyColumn: "Id",
                keyValue: new Guid("5129e70f-d6bc-48a4-bc18-2ae38d449f0c"));

            migrationBuilder.DeleteData(
                table: "organization",
                keyColumn: "Id",
                keyValue: new Guid("9d339f07-7548-4d66-ad39-4886de3033dd"));

            migrationBuilder.DeleteData(
                table: "organization",
                keyColumn: "Id",
                keyValue: new Guid("bade659a-e76d-4bba-bb59-358f293ed262"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("22a6c3d0-0682-43b8-b226-bfb92ab9a816"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("31a2ce51-5f23-4981-a89f-dbae81664e9e"));

            migrationBuilder.DeleteData(
                table: "payment",
                keyColumn: "Id",
                keyValue: new Guid("9026f6cb-3f73-4d1e-ac83-75625a4f1a65"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("001a3141-0756-4cf2-aab0-d5b4a22ce612"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("8316ddae-d339-48a1-93e7-20f006e4b343"));

            migrationBuilder.DeleteData(
                table: "profilePosts",
                keyColumn: "Id",
                keyValue: new Guid("fb1c3b7c-35b0-425e-9622-6e3d353b29be"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("22f78e7a-0d0d-4cc3-939b-352e4666c848"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("534659c1-ef47-40c4-bd96-7697eda707cd"));

            migrationBuilder.DeleteData(
                table: "reactionsToPosts",
                keyColumn: "Id",
                keyValue: new Guid("df747e26-b7aa-408d-8079-3014fd5cddef"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("02eefb58-88d5-466d-af8b-12faa98aecd1"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("26482449-1b84-44ab-8ac5-27f8f1634f8c"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("34a35df2-22c7-40f6-b302-caa4af4fece8"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("a9b7835d-1d6e-4823-8010-a120eecafd9d"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("d0581979-1450-4d2b-9807-e54ef106416a"));

            migrationBuilder.DeleteData(
                table: "userParticipatingInAction",
                keyColumn: "Id",
                keyValue: new Guid("e5c3548c-2dfe-4faa-b4bc-05997e874bde"));

            migrationBuilder.DropColumn(
                name: "gender",
                table: "user");

            migrationBuilder.DropColumn(
                name: "commentText",
                table: "reactionsToPosts");

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
