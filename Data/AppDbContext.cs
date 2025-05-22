using BookSpaceApi.Data.Configurations;
using BookSpaceApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookSpaceApi.Data;

public class AppDbContext : DbContext
{
   
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Publisher> Publishers { get; set; } = null!;
  
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var authors = AuthorConfiguration.GetFakerAuthor().ToList();
        var publishers = PublisherConfiguration.GetFakerPublisher().ToList();
        var books = BookConfiguration.GetFakerBook().ToList();

        modelBuilder.Entity<Author>().HasData(authors);
        modelBuilder.Entity<Publisher>().HasData(publishers);
        modelBuilder.Entity<Book>().HasData(books);
    }
}

