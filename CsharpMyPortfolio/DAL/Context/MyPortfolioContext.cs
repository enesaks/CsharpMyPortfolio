using CsharpMyPortfolio.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CsharpMyPortfolio.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ENES;initial Catalog=MyPortfolioDb;integrated Security=true;");
        }

        public DbSet<About> Abouts {get; set;}
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}

    }
}
