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

            

            Image[] arrayOfImages = new Image[5];
            arrayOfImages[0] = new Image { Id = Guid.NewGuid(), Path = "https://i.pinimg.com/originals/df/bd/df/dfbddf7c530ab5f4cd70154409651f9d.jpg" };
            arrayOfImages[1] = new Image { Id = Guid.NewGuid(), Path = "http://bestdayevereducation.com/uploads/images/FreeVector-Spongebob-Squarepants-Vector.jpg" };
            arrayOfImages[2] = new Image { Id = Guid.NewGuid(), Path = "https://arc-anglerfish-arc2-prod-elcomercio.s3.amazonaws.com/public/AVA6IKPJNBAS7JZ3CREUNY64K4.jpg" };
            arrayOfImages[3] = new Image { Id = Guid.NewGuid(), Path = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Cartoon_Network_2010_logo.svg/2000px-Cartoon_Network_2010_logo.svg.png" };
            arrayOfImages[4] = new Image { Id = Guid.NewGuid(), Path = "https://cdn.vox-cdn.com/thumbor/m6_h4h6uHuJeZCnWTCz7anTlVJA=/0x0:1920x1080/1200x800/filters:focal(807x387:1113x693)/cdn.vox-cdn.com/uploads/chorus_image/image/60720529/disneyplus.0.4.jpg" };

            #region ImageSeed
            modelBuilder.Entity<Image>().HasData(arrayOfImages[0]);
            modelBuilder.Entity<Image>().HasData(arrayOfImages[1]);
            modelBuilder.Entity<Image>().HasData(arrayOfImages[2]);
            modelBuilder.Entity<Image>().HasData(arrayOfImages[3]);
            modelBuilder.Entity<Image>().HasData(arrayOfImages[4]);
            #endregion

            #region AccountSeed
            modelBuilder.Entity<Account>().HasData(new { Id = Guid.NewGuid(), username = "sampleUser1", password = "samplepass1", isUser = true, imageId = arrayOfImages[0].Id });
            modelBuilder.Entity<Account>().HasData(new { Id = Guid.NewGuid(), username = "sampleUser2", password = "samplepass2", isUser = true, imageId = arrayOfImages[1].Id });
            modelBuilder.Entity<Account>().HasData(new { Id = Guid.NewGuid(), username = "sampleUser3", password = "samplepass3", isUser = true, imageId = arrayOfImages[2].Id });
            modelBuilder.Entity<Account>().HasData(new { Id = Guid.NewGuid(), username = "sampleUser4", password = "samplepass4", isUser = false, imageId = arrayOfImages[3].Id });
            modelBuilder.Entity<Account>().HasData(new { Id = Guid.NewGuid(), username = "sampleUser5", password = "samplepass5", isUser = false, imageId = arrayOfImages[4].Id });
            #endregion

            
        }


    }
}
