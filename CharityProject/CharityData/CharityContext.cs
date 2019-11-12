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

        public DbSet<User> Users { get; set; }
        //public DbSet<CatalogItem> CatalogItems { get; set; }

        //public DbSet<CatalogBrand> CatalogBrands { get; set; }

        //public DbSet<CatalogType> CatalogTypes { get; set; }
    }
}
