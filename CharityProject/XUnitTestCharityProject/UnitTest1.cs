using CharityData.Models;
using CharityPayment;
using CharityProject;
using CharityProject.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace XUnitTestCharityProject
{


    public class UnitTest1
    {
        public DbContextOptionsBuilder<CharityContext> optionsBuilder = new DbContextOptionsBuilder<CharityContext>();
        public CharityContext _dbContext;
        public Account[] savedAccounts; 
        public void mockDB()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            optionsBuilder.UseInMemoryDatabase();
#pragma warning restore CS0618 // Type or member is obsolete
            _dbContext = new CharityContext(optionsBuilder.Options);

            #region addingImages
            Image[] arrayOfImages = new Image[5];
            arrayOfImages[0] = new Image { Id = Guid.NewGuid(), Path = "https://i.pinimg.com/originals/df/bd/df/dfbddf7c530ab5f4cd70154409651f9d.jpg" };
            arrayOfImages[1] = new Image { Id = Guid.NewGuid(), Path = "http://bestdayevereducation.com/uploads/images/FreeVector-Spongebob-Squarepants-Vector.jpg" };
            arrayOfImages[2] = new Image { Id = Guid.NewGuid(), Path = "https://arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/AVA6IKPJNBAS7JZ3CREUNY64K4.jpg" };
            arrayOfImages[3] = new Image { Id = Guid.NewGuid(), Path = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Cartoon_Network_2010_logo.svg/2000px-Cartoon_Network_2010_logo.svg.png" };
            arrayOfImages[4] = new Image { Id = Guid.NewGuid(), Path = "https://cdn.vox-cdn.com/thumbor/m6_h4h6uHuJeZCnWTCz7anTlVJA=/0x0:1920x1080/1200x800/filters:focal(807x387:1113x693)/cdn.vox-cdn.com/uploads/chorus_image/image/60720529/disneyplus.0.4.jpg" };
        
            _dbContext.image.Add(arrayOfImages[0]);
            _dbContext.image.Add(arrayOfImages[1]);
            _dbContext.image.Add(arrayOfImages[2]);
            _dbContext.image.Add(arrayOfImages[3]);
            _dbContext.image.Add(arrayOfImages[4]);
            #endregion

            #region addingAccount
            Account[] arrayOfAccounts = new Account[5];
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var pass1 = sha256.ComputeHash(Encoding.UTF8.GetBytes("samplepass1"));
                var pass2 = sha256.ComputeHash(Encoding.UTF8.GetBytes("samplepass2"));
                var pass3 = sha256.ComputeHash(Encoding.UTF8.GetBytes("samplepass3"));
                var pass4 = sha256.ComputeHash(Encoding.UTF8.GetBytes("samplepass4"));
                var pass5 = sha256.ComputeHash(Encoding.UTF8.GetBytes("samplepass5"));
                // Get the hashed string.  
                var hash1 = BitConverter.ToString(pass1).Replace("-", "").ToLower();
                var hash2 = BitConverter.ToString(pass2).Replace("-", "").ToLower();
                var hash3 = BitConverter.ToString(pass3).Replace("-", "").ToLower();
                var hash4 = BitConverter.ToString(pass4).Replace("-", "").ToLower();
                var hash5 = BitConverter.ToString(pass5).Replace("-", "").ToLower();

                // Print the string.   
                // Console.WriteLine(hash);

                arrayOfAccounts[0] = new Account { Id = Guid.NewGuid(), username = "sampleUser1", password = hash1, email = "sampleUser1@mail.com", isUser = true, imageId = arrayOfImages[0].Id };
                arrayOfAccounts[1] = new Account { Id = Guid.NewGuid(), username = "sampleUser2", password = hash2, email = "sampleUser2@mail.com", isUser = true, imageId = arrayOfImages[1].Id };
                arrayOfAccounts[2] = new Account { Id = Guid.NewGuid(), username = "sampleUser3", password = hash3, email = "sampleUser3@mail.com", isUser = true, imageId = arrayOfImages[2].Id };
                arrayOfAccounts[3] = new Account { Id = Guid.NewGuid(), username = "sampleUser4", password = hash4, email = "sampleUser4@mail.com", isUser = false, imageId = arrayOfImages[3].Id };
                arrayOfAccounts[4] = new Account { Id = Guid.NewGuid(), username = "sampleUser5", password = hash5, email = "sampleUser5@mail.com", isUser = false, imageId = arrayOfImages[4].Id };
            }
            savedAccounts = arrayOfAccounts;
            _dbContext.account.Add(arrayOfAccounts[0]);
            _dbContext.account.Add(arrayOfAccounts[1]);
            _dbContext.account.Add(arrayOfAccounts[2]);
            _dbContext.account.Add(arrayOfAccounts[3]);
            _dbContext.account.Add(arrayOfAccounts[4]);
            _dbContext.account.Add(arrayOfAccounts[0]);
            #endregion

            #region addingCards
            Card[] arrayOfCreditCard = new Card[5];
            arrayOfCreditCard[0] = new Card { Id = Guid.NewGuid(), bankName = "Karntner Sparkasse", dateOfExpiry = new DateTime(2020, 5, 15), amount = 100, creditCardNumber = "1234567891011121" };
            arrayOfCreditCard[1] = new Card { Id = Guid.NewGuid(), bankName = "Karntner Sparkasse", dateOfExpiry = new DateTime(2021, 7, 20), amount = 50, creditCardNumber = "3141516171819202" };
            arrayOfCreditCard[2] = new Card { Id = Guid.NewGuid(), bankName = "Karntner Ladesbank Raiffeisen", dateOfExpiry = new DateTime(2020, 2, 20), amount = 150, creditCardNumber = "1222324252627282" };
            arrayOfCreditCard[3] = new Card { Id = Guid.NewGuid(), bankName = "Austria Bank", dateOfExpiry = new DateTime(2021, 1, 15), amount = 200, creditCardNumber = "9303132333435363" };
            arrayOfCreditCard[4] = new Card { Id = Guid.NewGuid(), bankName = "Austria Bank", dateOfExpiry = new DateTime(2020, 3, 14), amount = 55, creditCardNumber = "7383940414243444" };

            _dbContext.card.Add(arrayOfCreditCard[0]);
            _dbContext.card.Add(arrayOfCreditCard[1]);
            _dbContext.card.Add(arrayOfCreditCard[2]);
            _dbContext.card.Add(arrayOfCreditCard[3]);
            _dbContext.card.Add(arrayOfCreditCard[4]);
            #endregion

            #region addingUsers
            User[] arrayOfUsers = new User[3];
            arrayOfUsers[0] = new User { Id = Guid.NewGuid(), firstName = "Foo", lastName = "Bar", gender = 'M', dateOfBirth = new DateTime(1997, 1, 5), creditCardId = arrayOfCreditCard[0].Id, UserAccount = arrayOfAccounts[0].Id };
            arrayOfUsers[1] = new User { Id = Guid.NewGuid(), firstName = "John", lastName = "Doe", gender = 'F', dateOfBirth = new DateTime(1980, 11, 10), creditCardId = arrayOfCreditCard[1].Id, UserAccount = arrayOfAccounts[1].Id };
            arrayOfUsers[2] = new User { Id = Guid.NewGuid(), firstName = "Nicholas", lastName = "Cage", gender = 'M', dateOfBirth = new DateTime(1970, 5, 15), creditCardId = arrayOfCreditCard[2].Id, UserAccount = arrayOfAccounts[2].Id };

            _dbContext.user.Add(arrayOfUsers[0]);
            _dbContext.user.Add(arrayOfUsers[1]);
            _dbContext.user.Add(arrayOfUsers[2]);
            #endregion

            #region addingOrganizations
            Organization[] arrayOfOrganizations = new Organization[2];
            arrayOfOrganizations[0] = new Organization { Id = Guid.NewGuid(), dateOfFounding = new DateTime(2015, 5, 3), name = "CharityOrg1", description = "This is a sample organization for doing something which is good", UserAccount = arrayOfAccounts[3].Id, creditCardNumber = arrayOfCreditCard[3].Id };
            arrayOfOrganizations[1] = new Organization { Id = Guid.NewGuid(), dateOfFounding = new DateTime(2019, 10, 10), name = "CharityOrg2", description = "This organization does charity actions which are great!", UserAccount = arrayOfAccounts[4].Id, creditCardNumber = arrayOfCreditCard[4].Id };

            _dbContext.organization.Add(arrayOfOrganizations[0]);
            _dbContext.organization.Add(arrayOfOrganizations[1]);
            #endregion

            #region adddingItems
            Item[] arrayOfItems = new Item[2];
            arrayOfItems[0] = new Item { Id = Guid.NewGuid(), name = "Basketball", description = "A ball for playing basketball", value = 50, userDonatedId = arrayOfUsers[0].Id };
            arrayOfItems[1] = new Item { Id = Guid.NewGuid(), name = "Makeup", description = "Some spare makeup I donate", value = 150, userDonatedId = arrayOfUsers[1].Id };

            _dbContext.item.Add(arrayOfItems[0]);
            _dbContext.item.Add(arrayOfItems[1]);
            #endregion

            #region addingActions
            CharityAction[] arrayOfActions = new CharityAction[3];
            arrayOfActions[0] = new CharityAction { Id = Guid.NewGuid(), actionType = false, description = "This is a generic action where you sign up to participate", name = "Race for cure", organizationId = arrayOfOrganizations[0].Id, creationDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second), startDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second), endDateTime = new DateTime(2020, 1, 5, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second) };
            arrayOfActions[1] = new CharityAction { Id = Guid.NewGuid(), actionType = true, description = "This is a generic action where people donate stuff", name = "Fundraising for children without parents", organizationId = arrayOfOrganizations[0].Id, creationDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second), startDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second), endDateTime = new DateTime(2020, 2, 5, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second) };
            arrayOfActions[2] = new CharityAction { Id = Guid.NewGuid(), actionType = true, description = "This is another action where people donate stuff", name = "Another fundraising", organizationId = arrayOfOrganizations[1].Id, creationDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second), startDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second), endDateTime = new DateTime(2020, 3, 5, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second) };

            _dbContext.action.Add(arrayOfActions[0]);
            _dbContext.action.Add(arrayOfActions[1]);
            _dbContext.action.Add(arrayOfActions[2]);
            #endregion

            #region addingItemInAction
            ItemInAction[] arrayOfItemsInActions = new ItemInAction[3];
            arrayOfItemsInActions[0] = new ItemInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[1].Id, itemId = arrayOfItems[0].Id };
            arrayOfItemsInActions[1] = new ItemInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[1].Id, itemId = arrayOfItems[0].Id };
            arrayOfItemsInActions[2] = new ItemInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[2].Id, itemId = arrayOfItems[1].Id };

            _dbContext.itemInAction.Add(arrayOfItemsInActions[0]);
            _dbContext.itemInAction.Add(arrayOfItemsInActions[1]);
            _dbContext.itemInAction.Add(arrayOfItemsInActions[2
]);
            #endregion

            #region addingMessages
            Messages[] arrayOfMessages = new Messages[5];
            arrayOfMessages[0] = new Messages { Id = Guid.NewGuid(), sendingTime = new DateTime(2019, 11, 20, 22, 24, 30), message = "May I participate in your action :)", userSenderId = arrayOfUsers[0].Id, organizationReceiverId = arrayOfOrganizations[0].Id };
            arrayOfMessages[1] = new Messages { Id = Guid.NewGuid(), sendingTime = new DateTime(2019, 11, 20, 23, 25, 30), message = "Of course you can. All the best.", organizationSenderId = arrayOfOrganizations[0].Id, userReceiverId = arrayOfUsers[0].Id };
            arrayOfMessages[2] = new Messages { Id = Guid.NewGuid(), sendingTime = new DateTime(2019, 10, 15, 20, 00, 00), message = "How are you my friend?", userSenderId = arrayOfUsers[1].Id, userReceiverId = arrayOfUsers[2].Id };
            arrayOfMessages[3] = new Messages { Id = Guid.NewGuid(), sendingTime = new DateTime(2019, 10, 15, 21, 00, 00), message = "All is well, thank you, and you?", userSenderId = arrayOfUsers[2].Id, userReceiverId = arrayOfUsers[1].Id };
            arrayOfMessages[4] = new Messages { Id = Guid.NewGuid(), sendingTime = new DateTime(2019, 10, 15, 22, 00, 00), message = "I am fine, thanks", userSenderId = arrayOfUsers[1].Id, userReceiverId = arrayOfUsers[2].Id };

            _dbContext.message.Add(arrayOfMessages[0]);
            _dbContext.message.Add(arrayOfMessages[1]);
            _dbContext.message.Add(arrayOfMessages[2]);
            _dbContext.message.Add(arrayOfMessages[3]);
            _dbContext.message.Add(arrayOfMessages[4]);
            #endregion
            
            #region addingPayments
            Payment[] arrayOfPayments = new Payment[3];
            arrayOfPayments[0] = new Payment { Id = Guid.NewGuid(), amount = 100, organizationReceiverId = arrayOfOrganizations[0].Id, userSenderId = arrayOfUsers[0].Id };
            arrayOfPayments[1] = new Payment { Id = Guid.NewGuid(), amount = 100, organizationReceiverId = arrayOfOrganizations[1].Id, userSenderId = arrayOfUsers[0].Id };
            arrayOfPayments[2] = new Payment { Id = Guid.NewGuid(), amount = 100, organizationReceiverId = arrayOfOrganizations[0].Id, userSenderId = arrayOfUsers[1].Id };

            _dbContext.payment.Add(arrayOfPayments[0]);
            _dbContext.payment.Add(arrayOfPayments[1 ]);
            _dbContext.payment.Add(arrayOfPayments[2]);
            #endregion

            #region addingProfilePosts
            ProfilePosts[] arrayOfProfilePosts = new ProfilePosts[3];
            arrayOfProfilePosts[0] = new ProfilePosts { Id = Guid.NewGuid(), actionId = arrayOfActions[0].Id, userId = arrayOfUsers[0].Id, message = "I just did something in this action" };
            arrayOfProfilePosts[1] = new ProfilePosts { Id = Guid.NewGuid(), actionId = arrayOfActions[1].Id, userId = arrayOfUsers[1].Id, message = "I did something too" };
            arrayOfProfilePosts[2] = new ProfilePosts { Id = Guid.NewGuid(), actionId = arrayOfActions[2].Id, userId = arrayOfUsers[2].Id, message = "Normally, I did as well." };

            _dbContext.profilePosts.Add(arrayOfProfilePosts[0]);
            _dbContext.profilePosts.Add(arrayOfProfilePosts[1]);
            _dbContext.profilePosts.Add(arrayOfProfilePosts[2]);
            #endregion 

            #region addingReactionsToPosts
            ReactionsToPosts[] arrayOfReactionsToPosts = new ReactionsToPosts[3];
            arrayOfReactionsToPosts[0] = new ReactionsToPosts { Id = Guid.NewGuid(), postId = arrayOfProfilePosts[0].Id, liked = true, commented = false, userReactedId = arrayOfUsers[2].Id };
            arrayOfReactionsToPosts[1] = new ReactionsToPosts { Id = Guid.NewGuid(), postId = arrayOfProfilePosts[1].Id, liked = true, commented = true, userReactedId = arrayOfUsers[0].Id, commentText = "Glad you did that!" };
            arrayOfReactionsToPosts[2] = new ReactionsToPosts { Id = Guid.NewGuid(), postId = arrayOfProfilePosts[2].Id, liked = true, commented = false, userReactedId = arrayOfUsers[1].Id };

            _dbContext.reactionsToPosts.Add(arrayOfReactionsToPosts[0]);
            _dbContext.reactionsToPosts.Add(arrayOfReactionsToPosts[1]);
            _dbContext.reactionsToPosts.Add(arrayOfReactionsToPosts[2]);
            #endregion

            #region addingUserParticipatingInAction
            UserParticipatingInAction[] arrayOfUsersParticipating = new UserParticipatingInAction[3];
            arrayOfUsersParticipating[0] = new UserParticipatingInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[0].Id, userId = arrayOfUsers[0].Id };
            arrayOfUsersParticipating[1] = new UserParticipatingInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[1].Id, userId = arrayOfUsers[1].Id };
            arrayOfUsersParticipating[2] = new UserParticipatingInAction { Id = Guid.NewGuid(), actionId = arrayOfActions[2].Id, userId = arrayOfUsers[2].Id };

            _dbContext.userParticipatingInAction.Add(arrayOfUsersParticipating[0]);
            _dbContext.userParticipatingInAction.Add(arrayOfUsersParticipating[1]);
            _dbContext.userParticipatingInAction.Add(arrayOfUsersParticipating[2]);
            #endregion

            _dbContext.SaveChanges();
        }
        
        #region Tests
        //TESTS
        [Fact]
        public async void UnitTest_addUser()
        {
            mockDB();
            var controller = new AccountsController(_dbContext);
            int counter = _dbContext.user.Count();

            var result = await controller.CreateUserAccount(new Account { username = "newTestUser", email = "test@email.com", password = "testpass"}, userFirstNameParam: "testing");
            
            Assert.Equal(counter + 1, _dbContext.user.Count());
        }
        
        [Fact]
        public async void UnitTest_addAccount()
        {
            mockDB();
            var controller = new AccountsController(_dbContext);
            int counter = _dbContext.account.Count();

            var result = await controller.CreateUserAccount(new Account { username = "newTestUser1", email = "test1@email.com", password = "testpass" }, userFirstNameParam: "testing");

            Assert.Equal(counter + 1, _dbContext.account.Count());
        }
        
        [Fact]
        public async void UnitTest_addOrganization()
        {
            mockDB();
            var controller = new AccountsController(_dbContext);
            int counter = _dbContext.organization.Count();

            var result = await controller.CreateOrganizationAccount(new Account { username = "newTestUser2", email = "test2@email.com", password = "testpass" }, userFirstNameParam: "testing");

            Assert.Equal(counter + 1, _dbContext.organization.Count());
        }
        
        [Fact]
        public async void UnitTest_addAction()
        {
            mockDB();
            var controller = new CharityActionsController(_dbContext);
            int counter = _dbContext.action.Count();
            var org = _dbContext.organization.FirstOrDefault();
            string loggedOrg = (org.Id).ToString();

            var result = await controller.Create(new CharityAction { name = "newAction", description = "description of new action", actionType = true, startDateTime = new DateTime(2020, 2, 5, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second), endDateTime = new DateTime(2020, 4, 5, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second) }, loggedOrg);

            Assert.Equal(counter + 1, _dbContext.action.Count());
        }
        
        [Fact]
        public async void UnitTest_addItem()
        {
            mockDB();
            var controller = new ItemsController(_dbContext);
            int counter = _dbContext.item.Count();
            string loggedUser = "sampleUser1";
            
            var result = await controller.Create(new Item { name = "newItem", description = "description of new item", value = 50 }, loggedUser);
           
            Assert.Equal(counter + 1, _dbContext.item.Count());
        }
        
        [Fact]
        public async void UnitTest_CurrentlyActiveActions()
        {
            mockDB();
            var controller = new CharityActionsController(_dbContext);

            var result = await controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<CharityAction>>(viewResult.ViewData.Model);

            Assert.Equal(_dbContext.action.Where(a => a.endDateTime >= DateTime.Now).Count(), model.Count());
        }

        [Fact]
        public async void UnitTest_HistoryOfDonatedItems()
        {
            mockDB();
            var controller = new UsersController(_dbContext);
            var user = _dbContext.user.FirstOrDefault();
            var donated = await _dbContext.itemInAction.ToListAsync();
            List<Item> donatedItems = new List<Item>();
            foreach (var item in donated)
            {
                var it = await _dbContext.item.Where(i => i.userDonatedId == user.Id && i.Id == item.itemId).FirstOrDefaultAsync();

                if (it != null)
                {
                    donatedItems.Add(it);
                }
            }

            var result = await controller.Details(user.Id, userFirstNameParam: "testing");

            Assert.Equal(donatedItems.Count, controller.ViewBag.items.Count);
        }

        [Fact]
        public async void UnitTest_HistoryOfPayments()
        {
            mockDB();
            var controller = new UsersController(_dbContext);
            var user = _dbContext.user.FirstOrDefault();
            var payments = await _dbContext.payment.Where(p => p.userSenderId == user.Id).ToListAsync();

            var result = await controller.Details(user.Id, userFirstNameParam: "testing");

            Assert.Equal(payments.Count, controller.ViewBag.payments.Count);
        }

        [Fact]
        public async void UnitTest_HistoryOfParticipatedActions()
        {
            mockDB();
            var controller = new UsersController(_dbContext);
            var user = _dbContext.user.FirstOrDefault();
            var participatedActions = await _dbContext.userParticipatingInAction.Where(p => p.userId == user.Id).ToListAsync();
            List<CharityAction> actions = new List<CharityAction>();
            foreach (var part in participatedActions)
            {
                var action = await _dbContext.action.Where(a => a.Id == part.actionId).FirstOrDefaultAsync();
                if (action != null)
                {
                    actions.Add(action);
                }
            }

            var result = await controller.Details(user.Id, userFirstNameParam: "testing");

            Assert.Equal(actions.Count, controller.ViewBag.myActions.Count);
        }

        [Fact]
        public void UnitTest_differentViewsForDifferentRoles_User_CheckControllerRedirection()
        {
            mockDB();
            var controller = new AccountsController(_dbContext);
            var user = savedAccounts[0];
            user.password = "samplepass1";

            IActionResult res = controller.Login(user, false);
            var redirectToActionResult =
            Assert.IsType<RedirectToActionResult>(res);
            Assert.Equal("Home", redirectToActionResult.ControllerName);
        }
        [Fact]
        public void UnitTest_differentViewsForDifferentRoles_User_CheckViewRedirection()
        {
            mockDB();
            var controller = new AccountsController(_dbContext);
            var user = savedAccounts[0];
            user.password = "samplepass1";

            IActionResult res = controller.Login(user, false);
            var redirectToActionResult =
            Assert.IsType<RedirectToActionResult>(res);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }
        [Fact]
        public void UnitTest_differentViewsForDifferentRoles_Organization_CheckControllerRedirection()
        {
            mockDB();
            var controller = new AccountsController(_dbContext);
            var user = savedAccounts[3];
            user.password = "samplepass4";

            IActionResult res = controller.Login(user, false);
            var redirectToActionResult =
            Assert.IsType<RedirectToActionResult>(res);
            Assert.Equal("Organizations", redirectToActionResult.ControllerName);
        }
        [Fact]
        public void UnitTest_differentViewsForDifferentRoles_Organization_CheckViewRedirection()
        {
            mockDB();
            var controller = new AccountsController(_dbContext);
            var user = savedAccounts[3];
            user.password = "samplepass4";

            IActionResult res = controller.Login(user, false);
            var redirectToActionResult =
            Assert.IsType<RedirectToActionResult>(res);
            Assert.Equal("Details", redirectToActionResult.ActionName);
        }
        [Fact]
        public async void UnitTest_PastActions()
        {
            mockDB();
            var controller = new HomeController(_dbContext);
            var user = _dbContext.user.FirstOrDefault();
            var account = _dbContext.account.Where(a => a.Id.ToString().Equals(user.UserAccount.ToString())).First();
            var result = await controller.Index(account.username);
            
            Assert.Equal(_dbContext.action.Where(a => a.endDateTime < DateTime.Now).Count(), controller.ViewBag.pastActions.Count);
        }
        [Fact]
        public async void UnitTest_FutureActions()
        {
            mockDB();
            var controller = new HomeController(_dbContext);
            var user = _dbContext.user.FirstOrDefault();
            var account = _dbContext.account.Where(a => a.Id.ToString().Equals(user.UserAccount.ToString())).First();
            var result = await controller.Index(account.username);

            Assert.Equal(_dbContext.action.Where(a => a.startDateTime > DateTime.Now).Count(), controller.ViewBag.futureActions.Count);
        }
        [Fact]
        public void UnitTest_MoneyTransferringNormal_CheckTransactionValidity()
        {
            mockDB();
            var userTransferring = _dbContext.user.FirstOrDefault();
            var hisCard = _dbContext.card.Where(c => c.Id.ToString().Equals(userTransferring.creditCardId.ToString())).First();
            var organizationReceiving = _dbContext.organization.FirstOrDefault();
            var theirCard = _dbContext.card.Where(c => c.Id.ToString().Equals(organizationReceiving.creditCardNumber.ToString())).First();
            var amountBeforeUser = hisCard.amount;
            var amountBeforeOrga = theirCard.amount;
            Payment payment = new Payment();
            payment.amount = 10;
            payment.organizationReceiverId = organizationReceiving.Id;
            payment.userSenderId = userTransferring.Id;
            ProcessPayment p = new ProcessPayment();
            var possible = p.DoPayment(payment, _dbContext);

            Assert.True(possible);
        }
        [Fact]
        public void UnitTest_MoneyTransferringNormal_CheckUserAmount()
        {
            mockDB();
            var userTransferring = _dbContext.user.FirstOrDefault();
            var hisCard = _dbContext.card.Where(c => c.Id.ToString().Equals(userTransferring.creditCardId.ToString())).First();
            var organizationReceiving = _dbContext.organization.FirstOrDefault();
            var theirCard = _dbContext.card.Where(c => c.Id.ToString().Equals(organizationReceiving.creditCardNumber.ToString())).First();
            var amountBeforeUser = hisCard.amount;
            var amountBeforeOrga = theirCard.amount;
            Payment payment = new Payment();
            payment.amount = 10;
            payment.organizationReceiverId = organizationReceiving.Id;
            payment.userSenderId = userTransferring.Id;
            ProcessPayment p = new ProcessPayment();
            var possible = p.DoPayment(payment, _dbContext);

            Assert.Equal(amountBeforeUser - 10, hisCard.amount);
        }
        [Fact]
        public void UnitTest_MoneyTransferringNormal_CheckOrganizationAmount()
        {
            mockDB();
            var userTransferring = _dbContext.user.FirstOrDefault();
            var hisCard = _dbContext.card.Where(c => c.Id.ToString().Equals(userTransferring.creditCardId.ToString())).First();
            var organizationReceiving = _dbContext.organization.FirstOrDefault();
            var theirCard = _dbContext.card.Where(c => c.Id.ToString().Equals(organizationReceiving.creditCardNumber.ToString())).First();
            var amountBeforeUser = hisCard.amount;
            var amountBeforeOrga = theirCard.amount;
            Payment payment = new Payment();
            payment.amount = 10;
            payment.organizationReceiverId = organizationReceiving.Id;
            payment.userSenderId = userTransferring.Id;
            ProcessPayment p = new ProcessPayment();
            var possible = p.DoPayment(payment, _dbContext);

            Assert.Equal(amountBeforeOrga + 10, theirCard.amount);
        }
        [Fact]
        public void UnitTest_MoneyTransferringInvalid_CheckTransactionValidity()
        {
            mockDB();
            var userTransferring = _dbContext.user.FirstOrDefault();
            var hisCard = _dbContext.card.Where(c => c.Id.ToString().Equals(userTransferring.creditCardId.ToString())).First();
            var organizationReceiving = _dbContext.organization.FirstOrDefault();
            var theirCard = _dbContext.card.Where(c => c.Id.ToString().Equals(organizationReceiving.creditCardNumber.ToString())).First();
            var amountBeforeUser = hisCard.amount;
            var amountBeforeOrga = theirCard.amount;
            Payment payment = new Payment();
            payment.amount = 99999;
            payment.organizationReceiverId = organizationReceiving.Id;
            payment.userSenderId = userTransferring.Id;
            ProcessPayment p = new ProcessPayment();
            var possible = p.DoPayment(payment, _dbContext);

            Assert.False(possible);
        }
        [Fact]
        public void UnitTest_MoneyTransferringInvalid_CheckUserAmount()
        {
            mockDB();
            var userTransferring = _dbContext.user.FirstOrDefault();
            var hisCard = _dbContext.card.Where(c => c.Id.ToString().Equals(userTransferring.creditCardId.ToString())).First();
            var organizationReceiving = _dbContext.organization.FirstOrDefault();
            var theirCard = _dbContext.card.Where(c => c.Id.ToString().Equals(organizationReceiving.creditCardNumber.ToString())).First();
            var amountBeforeUser = hisCard.amount;
            var amountBeforeOrga = theirCard.amount;
            Payment payment = new Payment();
            payment.amount = 99999;
            payment.organizationReceiverId = organizationReceiving.Id;
            payment.userSenderId = userTransferring.Id;
            ProcessPayment p = new ProcessPayment();
            var possible = p.DoPayment(payment, _dbContext);

            Assert.Equal(amountBeforeUser, hisCard.amount);
        }
        [Fact]
        public void UnitTest_MoneyTransferringInvalid_CheckOrganizationAmount()
        {
            mockDB();
            var userTransferring = _dbContext.user.FirstOrDefault();
            var hisCard = _dbContext.card.Where(c => c.Id.ToString().Equals(userTransferring.creditCardId.ToString())).First();
            var organizationReceiving = _dbContext.organization.FirstOrDefault();
            var theirCard = _dbContext.card.Where(c => c.Id.ToString().Equals(organizationReceiving.creditCardNumber.ToString())).First();
            var amountBeforeUser = hisCard.amount;
            var amountBeforeOrga = theirCard.amount;
            Payment payment = new Payment();
            payment.amount = 99999;
            payment.organizationReceiverId = organizationReceiving.Id;
            payment.userSenderId = userTransferring.Id;
            ProcessPayment p = new ProcessPayment();
            var possible = p.DoPayment(payment, _dbContext);

            Assert.Equal(amountBeforeOrga, theirCard.amount);
        }
        [Fact]
        public void UnitTest_AddingCardToUser_CheckCardCreation()
        {
            mockDB();
            int countCards = _dbContext.card.Count();
            CardsController c = new CardsController(_dbContext);
            var userCreatingCard = _dbContext.user.FirstOrDefault();
            Card newCard = new Card()
            {
                Id = Guid.NewGuid(),
                dateOfExpiry = new DateTime(2020, 10, 10),
                bankName = "Some test bank",
                amount = 100,
                creditCardNumber = "1111222233334444"
            };
            var result = c.Create(newCard, userCreatingCard.Id.ToString());

            Assert.Equal(countCards + 1, _dbContext.card.Count());
        }
        [Fact]
        public void UnitTest_AddingCardToUser_CheckCardAssignment()
        {
            mockDB();
            int countCards = _dbContext.card.Count();
            CardsController c = new CardsController(_dbContext);
            var userCreatingCard = _dbContext.user.FirstOrDefault();
            Card newCard = new Card()
            {
                Id = Guid.NewGuid(),
                dateOfExpiry = new DateTime(2020, 10, 10),
                bankName = "Some test bank",
                amount = 100,
                creditCardNumber = "1111222233334444"
            };
            var result = c.Create(newCard, userCreatingCard.Id.ToString());

            Assert.Equal(newCard.Id.ToString(), userCreatingCard.creditCardId.ToString());
        }
        #endregion
        
    }

}
