using Abp.EntityFrameworkCore;
using Biblioteka.Models;
using Biblioteka.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Biblioteka.EntityFrameworkCore
{
    public class BibliotekaDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Book> Books { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<CodeSnippet> CodeSnippets { get; set; }
        public DbSet<BookPublisher> BookPublishers { get; set; }
        public DbSet<Videocourse> Videocourses { get; set; }
        public DbSet<MyFileInfo> MyFileInfo { get; set; }
        public DbSet<Webinar> Webinars { get; set; }
        public BibliotekaDbContext(DbContextOptions<BibliotekaDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>().OwnsOne(b => b.Publisher);
            // Entity "Blog" has a relationship with entity "Article" "one to many" 
            modelBuilder.Entity<Blog>().HasMany(b => b.Articles).WithOne(a => a.Blog);

            modelBuilder.Entity<Videocourse>().OwnsMany(o => o.Series, a =>
            {
                a.WithOwner().HasForeignKey("VideocourseId");
                a.Property<int>("Id");
                a.HasKey("Id");
                a.OwnsOne(o => o.Webinar);
            }
            );

        }
    }
}
