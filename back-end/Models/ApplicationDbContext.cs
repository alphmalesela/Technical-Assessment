using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        base(options)
    { }

    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Subscription> Subscriptions { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Subscription>()
            .HasKey(s => s.Id);

        builder.Entity<Subscription>()
        .HasOne(s => s.User)
        .WithMany(s => s.Subscriptions)
        .HasForeignKey(s => s.UserId);

        builder.Entity<Subscription>()
        .HasOne(s => s.Book)
        .WithMany(s => s.Subscriptions)
        .HasForeignKey(s => s.BookId);

        builder.Entity<Subscription>()
        .Property(s => s.Id)
        .ValueGeneratedOnAdd();

        using var reader = new StreamReader("Data/books.json");
        var json = reader.ReadToEnd();
        var books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();

        builder.Entity<Book>().HasData(books);

    }
}