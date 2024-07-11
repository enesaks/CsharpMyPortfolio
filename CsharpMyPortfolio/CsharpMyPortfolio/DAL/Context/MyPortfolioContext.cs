using System;
using Microsoft.EntityFrameworkCore;
using CsharpMyPortfolio.DAL.Entities;
namespace CsharpMyPortfolio.DAL.Context

{
	public class MyPortfolioContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=MyPortfolioDb;Username=postgres;Password=1234;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Exprience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolıos { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ScoialMedia> ScoialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }

    }
}

