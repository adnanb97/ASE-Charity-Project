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
        public DbSet<Item> item { get; set; }
        public DbSet<ItemInAction> itemInAction { get; set; }
        public DbSet<Messages> message { get; set; }
        public DbSet<Organization> organization { get; set; }
        public DbSet<Payment> payment { get; set; }
        public DbSet<ProfilePosts> profilePosts { get; set; }
        public DbSet<ReactionsToPosts> reactionsToPosts { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<UserParticipatingInAction> userParticipatingInAction { get; set; }
        
    }
}
