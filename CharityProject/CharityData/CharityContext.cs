using CharityData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityProject
{
    public class CharityContext : DbContext
    {
        public CharityContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CharityData.Models.Action> action { get; set; }
        public DbSet<Card> card { get; set; }
        public DbSet<Account> account { get; set; }
        public DbSet<Image> image { get; set; }
        public DbSet<Item> item { get; set; }
        public DbSet<ItemInAction> itemInAction { get; set; }
        public DbSet<Messages> message { get; set; }
        public DbSet<Organization> organization { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<ProfilePosts> profilePosts { get; set; }
        public DbSet<ReactionsToPosts> reactionsToPosts { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<UserParticipatingInAction> userParticipatingInAction { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Account>(account =>
            {
                account.Property(e => e.username).IsRequired();
                account.Property(e => e.password).IsRequired();
                account.Property(e => e.isUser).IsRequired();
            });


            #region ArrayOfImages
            Image[] arrayOfImages = new Image[5];
            arrayOfImages[0] = new Image { Id = Guid.NewGuid(), Path = "https://i.pinimg.com/originals/df/bd/df/dfbddf7c530ab5f4cd70154409651f9d.jpg" };
            arrayOfImages[1] = new Image { Id = Guid.NewGuid(), Path = "http://bestdayevereducation.com/uploads/images/FreeVector-Spongebob-Squarepants-Vector.jpg" };
            arrayOfImages[2] = new Image { Id = Guid.NewGuid(), Path = "https://arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/AVA6IKPJNBAS7JZ3CREUNY64K4.jpg" };
            arrayOfImages[3] = new Image { Id = Guid.NewGuid(), Path = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Cartoon_Network_2010_logo.svg/2000px-Cartoon_Network_2010_logo.svg.png" };
            arrayOfImages[4] = new Image { Id = Guid.NewGuid(), Path = "https://cdn.vox-cdn.com/thumbor/m6_h4h6uHuJeZCnWTCz7anTlVJA=/0x0:1920x1080/1200x800/filters:focal(807x387:1113x693)/cdn.vox-cdn.com/uploads/chorus_image/image/60720529/disneyplus.0.4.jpg" };
            #endregion

            #region ArrayOfAccounts
            Account[] arrayOfAccounts = new Account[5];
            arrayOfAccounts[0] = new Account { Id = Guid.NewGuid(), username = "sampleUser1", password = "samplepass1", isUser = true, imageId = arrayOfImages[0].Id };
            arrayOfAccounts[1] = new Account { Id = Guid.NewGuid(), username = "sampleUser2", password = "samplepass2", isUser = true, imageId = arrayOfImages[1].Id };
            arrayOfAccounts[2] = new Account { Id = Guid.NewGuid(), username = "sampleUser3", password = "samplepass3", isUser = true, imageId = arrayOfImages[2].Id };
            arrayOfAccounts[3] = new Account { Id = Guid.NewGuid(), username = "sampleUser4", password = "samplepass4", isUser = false, imageId = arrayOfImages[3].Id };
            arrayOfAccounts[4] = new Account { Id = Guid.NewGuid(), username = "sampleUser5", password = "samplepass5", isUser = false, imageId = arrayOfImages[4].Id };
            #endregion

            #region ArrayOfCards
            Card[] arrayOfCreditCard = new Card[5];
            arrayOfCreditCard[0] = new Card { Id = Guid.NewGuid(), bankName = "Karntner Sparkasse", dateOfExpiry = new DateTime(2020, 5, 15) };
            arrayOfCreditCard[1] = new Card { Id = Guid.NewGuid(), bankName = "Karntner Sparkasse", dateOfExpiry = new DateTime(2021, 7, 20) };
            arrayOfCreditCard[2] = new Card { Id = Guid.NewGuid(), bankName = "Karntner Ladesbank Raiffeisen", dateOfExpiry = new DateTime(2020, 2, 20) };
            arrayOfCreditCard[3] = new Card { Id = Guid.NewGuid(), bankName = "Austria Bank", dateOfExpiry = new DateTime(2021, 1, 15) };
            arrayOfCreditCard[4] = new Card { Id = Guid.NewGuid(), bankName = "Austria Bank", dateOfExpiry = new DateTime(2020, 3, 14) };
            #endregion

            #region ArrayOfUsers
            User[] arrayOfUsers = new User[3];
            arrayOfUsers[0] = new User { Id = Guid.NewGuid(), firstName = "Foo", lastName = "Bar", dateOfBirth = new DateTime(1997, 1, 5), creditCardId = arrayOfCreditCard[0].Id, UserAccount = arrayOfAccounts[0].Id };
            arrayOfUsers[1] = new User { Id = Guid.NewGuid(), firstName = "John", lastName = "Doe", dateOfBirth = new DateTime(1980, 11, 10), creditCardId = arrayOfCreditCard[1].Id, UserAccount = arrayOfAccounts[1].Id };
            arrayOfUsers[2] = new User { Id = Guid.NewGuid(), firstName = "Nicholas", lastName = "Cage", dateOfBirth = new DateTime(1970, 5, 15), creditCardId = arrayOfCreditCard[2].Id, UserAccount = arrayOfAccounts[2].Id };
            #endregion

            #region ArrayOfOrganizations
            Organization[] arrayOfOrganizations = new Organization[2];
            arrayOfOrganizations[0] = new Organization { Id = Guid.NewGuid(), dateOfFounding = new DateTime(2015, 5, 3), name = "CharityOrg1", description = "This is a sample organization for doing something which is good",  UserAccount = arrayOfAccounts[3].Id, creditCardNumber = arrayOfCreditCard[3].Id };
            arrayOfOrganizations[1] = new Organization { Id = Guid.NewGuid(), dateOfFounding = new DateTime(2019, 10, 10), name = "CharityOrg2", description = "This organization does charity actions which are great!", UserAccount = arrayOfAccounts[4].Id, creditCardNumber = arrayOfCreditCard[4].Id };
            #endregion

            #region ArrayOfActions
            CharityData.Models.Action[] arrayOfActions = new CharityData.Models.Action[3];
            arrayOfActions[0] = new CharityData.Models.Action { Id = Guid.NewGuid(), actionType = false, description = "This is a generic action where you sign up to participate", name = "Race for cure", organizationId = arrayOfOrganizations[0].Id };
            arrayOfActions[1] = new CharityData.Models.Action { Id = Guid.NewGuid(), actionType = true, description = "This is a generic action where people donate stuff", name = "Fundraising for children without parents", organizationId = arrayOfOrganizations[0].Id };
            arrayOfActions[2] = new CharityData.Models.Action { Id = Guid.NewGuid(), actionType = true, description = "This is another action where people donate stuff", name = "Another fundraising", organizationId = arrayOfOrganizations[1].Id };
            #endregion

            #region ArrayOfItems
            Item[] arrayOfItems = new Item[2];
            arrayOfItems[0] = new Item { Id = Guid.NewGuid(), name = "Basketball", description = "A ball for playing basketball", value = 50, userDonatedId = arrayOfUsers[0].Id };
            arrayOfItems[1] = new Item { Id = Guid.NewGuid(), name = "Makeup", description = "Some spare makeup I donate", value = 150, userDonatedId = arrayOfUsers[1].Id };
            #endregion

            #region ArrayOfItemInAction
            ItemInAction[] arrayOfItemsInActions = new ItemInAction[3];
            arrayOfItemsInActions[0] = new ItemInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[1].Id, itemId = arrayOfItems[0].Id };
            arrayOfItemsInActions[1] = new ItemInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[1].Id, itemId = arrayOfItems[0].Id };
            arrayOfItemsInActions[2] = new ItemInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[2].Id, itemId = arrayOfItems[1].Id };
            #endregion

            #region ArrayOfMessages
            Messages[] arrayOfMessages = new Messages[5];
            arrayOfMessages[0] = new Messages { Id = Guid.NewGuid(), sendingTime = new DateTime(2019, 11, 20, 22, 24, 30), message = "May I participate in your action :)", userSenderId = arrayOfUsers[0].Id, organizationReceiverId = arrayOfOrganizations[0].Id };
            arrayOfMessages[1] = new Messages { Id = Guid.NewGuid(), sendingTime = new DateTime(2019, 11, 20, 23, 25, 30), message = "Of course you can. All the best.", organizationSenderId = arrayOfOrganizations[0].Id, userReceiverId = arrayOfUsers[0].Id };
            arrayOfMessages[2] = new Messages { Id = Guid.NewGuid(), sendingTime = new DateTime(2019, 10, 15, 20, 00, 00), message = "How are you my friend?", userSenderId = arrayOfUsers[1].Id, userReceiverId = arrayOfUsers[2].Id };
            arrayOfMessages[3] = new Messages { Id = Guid.NewGuid(), sendingTime = new DateTime(2019, 10, 15, 21, 00, 00), message = "All is well, thank you, and you?", userSenderId = arrayOfUsers[2].Id, userReceiverId = arrayOfUsers[1].Id };
            arrayOfMessages[4] = new Messages { Id = Guid.NewGuid(), sendingTime = new DateTime(2019, 10, 15, 22, 00, 00), message = "I am fine, thanks", userSenderId = arrayOfUsers[1].Id, userReceiverId = arrayOfUsers[2].Id };
            #endregion

            #region ArrayOfPayments
            Payment[] arrayOfPayments = new Payment[3];
            arrayOfPayments[0] = new Payment { Id = Guid.NewGuid(), amount = 100, organizationReceiverId = arrayOfOrganizations[0].Id, userSenderId = arrayOfUsers[0].Id };
            arrayOfPayments[1] = new Payment { Id = Guid.NewGuid(), amount = 100, organizationReceiverId = arrayOfOrganizations[1].Id, userSenderId = arrayOfUsers[0].Id };
            arrayOfPayments[2] = new Payment { Id = Guid.NewGuid(), amount = 100, organizationReceiverId = arrayOfOrganizations[0].Id, userSenderId = arrayOfUsers[1].Id };
            #endregion

            #region ArrayOfProfilePosts
            ProfilePosts[] arrayOfProfilePosts = new ProfilePosts[3];
            arrayOfProfilePosts[0] = new ProfilePosts { Id = Guid.NewGuid(), actionId = arrayOfActions[0].Id, userId = arrayOfUsers[0].Id, message = "I just did something in this action" };
            arrayOfProfilePosts[1] = new ProfilePosts { Id = Guid.NewGuid(), actionId = arrayOfActions[1].Id, userId = arrayOfUsers[1].Id, message = "I did something too" };
            arrayOfProfilePosts[2] = new ProfilePosts { Id = Guid.NewGuid(), actionId = arrayOfActions[2].Id, userId = arrayOfUsers[2].Id, message = "Normally, I did as well." };
            #endregion

            #region ArrayOfReactionsToPosts
            ReactionsToPosts[] arrayOfReactionsToPosts = new ReactionsToPosts[3];
            arrayOfReactionsToPosts[0] = new ReactionsToPosts { Id = Guid.NewGuid(), postId = arrayOfProfilePosts[0].Id, liked = true, commented = false, userReactedId = arrayOfUsers[2].Id };
            arrayOfReactionsToPosts[1] = new ReactionsToPosts { Id = Guid.NewGuid(), postId = arrayOfProfilePosts[1].Id, liked = true, commented = true, userReactedId = arrayOfUsers[0].Id };
            arrayOfReactionsToPosts[2] = new ReactionsToPosts { Id = Guid.NewGuid(), postId = arrayOfProfilePosts[2].Id, liked = true, commented = false, userReactedId = arrayOfUsers[1].Id };
            #endregion

            #region ArrayOfUserParticipatingInAction
            UserParticipatingInAction[] arrayOfUsersParticipating = new UserParticipatingInAction[3];
            arrayOfUsersParticipating[0] = new UserParticipatingInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[0].Id, userId = arrayOfUsers[0].Id };
            arrayOfUsersParticipating[1] = new UserParticipatingInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[1].Id, userId = arrayOfUsers[1].Id };
            arrayOfUsersParticipating[2] = new UserParticipatingInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[2].Id, userId = arrayOfUsers[2].Id };
            #endregion

            #region ImageSeed
            modelBuilder.Entity<Image>().HasData(arrayOfImages[0]);
            modelBuilder.Entity<Image>().HasData(arrayOfImages[1]);
            modelBuilder.Entity<Image>().HasData(arrayOfImages[2]);
            modelBuilder.Entity<Image>().HasData(arrayOfImages[3]);
            modelBuilder.Entity<Image>().HasData(arrayOfImages[4]);
            #endregion

            #region AccountSeed
            modelBuilder.Entity<Account>().HasData(arrayOfAccounts[0]);
            modelBuilder.Entity<Account>().HasData(arrayOfAccounts[1]);
            modelBuilder.Entity<Account>().HasData(arrayOfAccounts[2]);
            modelBuilder.Entity<Account>().HasData(arrayOfAccounts[3]);
            modelBuilder.Entity<Account>().HasData(arrayOfAccounts[4]);
            #endregion

            #region CardSeed
            modelBuilder.Entity<Card>().HasData(arrayOfCreditCard[0]);
            modelBuilder.Entity<Card>().HasData(arrayOfCreditCard[1]);
            modelBuilder.Entity<Card>().HasData(arrayOfCreditCard[2]);
            modelBuilder.Entity<Card>().HasData(arrayOfCreditCard[3]);
            modelBuilder.Entity<Card>().HasData(arrayOfCreditCard[4]);
            #endregion

            #region UserSeed
            modelBuilder.Entity<User>().HasData(arrayOfUsers[0]);
            modelBuilder.Entity<User>().HasData(arrayOfUsers[1]);
            modelBuilder.Entity<User>().HasData(arrayOfUsers[2]);
            #endregion

            #region OrganizationSeed
            modelBuilder.Entity<Organization>().HasData(arrayOfOrganizations[0]);
            modelBuilder.Entity<Organization>().HasData(arrayOfOrganizations[1]);
            #endregion

            #region ActionSeed
            modelBuilder.Entity<CharityData.Models.Action>().HasData(arrayOfActions[0]);
            modelBuilder.Entity<CharityData.Models.Action>().HasData(arrayOfActions[1]);
            modelBuilder.Entity<CharityData.Models.Action>().HasData(arrayOfActions[2]);
            #endregion

            #region ItemSeed
            modelBuilder.Entity<Item>().HasData(arrayOfItems[0]);
            modelBuilder.Entity<Item>().HasData(arrayOfItems[1]);
            #endregion

            #region ItemInActionSeed
            modelBuilder.Entity<ItemInAction>().HasData(arrayOfItemsInActions[0]);
            modelBuilder.Entity<ItemInAction>().HasData(arrayOfItemsInActions[1]);
            modelBuilder.Entity<ItemInAction>().HasData(arrayOfItemsInActions[2]);
            #endregion

            #region MessagesSeed
            modelBuilder.Entity<Messages>().HasData(arrayOfMessages[0]);
            modelBuilder.Entity<Messages>().HasData(arrayOfMessages[1]);
            modelBuilder.Entity<Messages>().HasData(arrayOfMessages[2]);
            modelBuilder.Entity<Messages>().HasData(arrayOfMessages[3]);
            modelBuilder.Entity<Messages>().HasData(arrayOfMessages[4]);
            #endregion

            #region PaymentSeed
            modelBuilder.Entity<Payment>().HasData(arrayOfPayments[0]);
            modelBuilder.Entity<Payment>().HasData(arrayOfPayments[1]);
            modelBuilder.Entity<Payment>().HasData(arrayOfPayments[2]);
            #endregion

            #region ProfilePostsSeed
            modelBuilder.Entity<ProfilePosts>().HasData(arrayOfProfilePosts[0]);
            modelBuilder.Entity<ProfilePosts>().HasData(arrayOfProfilePosts[1]);
            modelBuilder.Entity<ProfilePosts>().HasData(arrayOfProfilePosts[2]);
            #endregion

            #region ReactionsToPostsSeed
            modelBuilder.Entity<ReactionsToPosts>().HasData(arrayOfReactionsToPosts[0]);
            modelBuilder.Entity<ReactionsToPosts>().HasData(arrayOfReactionsToPosts[1]);
            modelBuilder.Entity<ReactionsToPosts>().HasData(arrayOfReactionsToPosts[2]);
            #endregion

            #region UserParticipatingInActionSeed
            modelBuilder.Entity<UserParticipatingInAction>().HasData(arrayOfUsersParticipating[0]);
            modelBuilder.Entity<UserParticipatingInAction>().HasData(arrayOfUsersParticipating[1]);
            modelBuilder.Entity<UserParticipatingInAction>().HasData(arrayOfUsersParticipating[2]);
            #endregion
        }


    }
}
