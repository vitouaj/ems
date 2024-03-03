using EventAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventAPI.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : DbContext(options)
{
    private readonly IConfiguration _configuration = configuration;
    public DbSet<Event> Events { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Venue> Venues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>()
            .HasMany(c => c.Events)
            .WithOne(e => e.Category)
            .HasForeignKey(e => e.CategoryId);

        modelBuilder.Entity<Event>()
            .HasMany(e => e.Sessions)
            .WithOne(s => s.Event)
            .HasForeignKey(s => s.EventId);

        modelBuilder.Entity<Venue>()
            .HasMany(e => e.Events)
            .WithOne(v => v.Venue)
            .HasForeignKey(e => e.VenueId);


        modelBuilder.Entity<Category>()
            .HasData([
                new Category(Guid.Parse("3a65b394-607d-4cf6-bdf7-01d1e28f4b6f"), "Education", null, Guid.NewGuid(), Guid.NewGuid()),
                new Category(Guid.Parse("f6edd33c-70f0-4dc3-82ac-9f4ce0d0eba4"), "Community", null, Guid.NewGuid(), Guid.NewGuid()),
                new Category(Guid.Parse("4ea0e2fc-6264-4116-81de-01b29b8c14cb"),"Entrepreneurship", null, Guid.NewGuid(), Guid.NewGuid()),
                new Category(Guid.Parse("322f5cca-291e-4bdc-9ae4-cd11317f2712"), "Technology", null, Guid.NewGuid(), Guid.NewGuid()),
                new Category(Guid.Parse("30ac51bd-6470-4801-9a9d-960b80af2ae6"), "Health Care", null, Guid.NewGuid(), Guid.NewGuid()),
                new Category(Guid.Parse("25babb0e-0c88-4af7-99ad-5df9339cbf25"), "NGO", null, Guid.NewGuid(), Guid.NewGuid()),
            ]);

        modelBuilder.Entity<Venue>()
            .HasData([
                new Venue(
                    Guid.Parse("d370967c-3da8-45f5-8890-bff9669c8a1d"),
                    "OCIC wedding hall",
                    null,
                    "ocic 591 street",
                    "chroy chongva",
                    "phnom penh",
                    "OCIC HALL F",
                    "https://maps.app.goo.gl/Z7g5m2JLUGncbZtJ8",
                    Guid.NewGuid(),
                    Guid.NewGuid()),
            ]);

        modelBuilder.Entity<Event>()
            .HasData([
                new Event(
                    Guid.Parse("bc66aaec-36f2-4207-9962-45a2dadd93a3"),
                    "AWS 2024 Cambodia Conference",
                    "a public event to gather aws users in cambodia to connect and share experience working in the industry. many session are hosted by professional which available for free. any one can join.",
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    50,
                    new DateOnly(2024, 3, 21),
                    new DateOnly(2024, 3, 21),
                    Guid.Parse("322f5cca-291e-4bdc-9ae4-cd11317f2712"),
                    Guid.Parse("d370967c-3da8-45f5-8890-bff9669c8a1d")
                ),

                // new Event(
                //     Guid.NewGuid(),
                //     "Cambodia Tech Summit 2024",
                //     "An annual tech summit aimed at bringing together tech enthusiasts, startups, and industry experts to discuss the latest trends and innovations in the Cambodian tech ecosystem.",
                //     Guid.NewGuid(),
                //     Guid.NewGuid(),
                //     100,
                //     new DateOnly(2024, 6, 15),
                //     new DateOnly(2024, 6, 16),
                //     Guid.Parse("822f5cca-291e-4bdc-9ae4-cd11317f2712"),
                //     Guid.Parse("d370967c-3da8-45f5-8890-bff9669c8a1d")
                // ),
            ]);

        modelBuilder.Entity<Session>()
            .HasData([
                new Session(
                    "Warm up session",
                    null,
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    Guid.Parse("bc66aaec-36f2-4207-9962-45a2dadd93a3"),
                    new DateOnly(2024, 3, 21),
                    new TimeOnly(9, 0),
                    new TimeOnly(11, 0)
                ),
                new Session(
                    "Cambodia development | AWS annual report",
                    null,
                    Guid.NewGuid(),
                    Guid.NewGuid(),
                    Guid.Parse("bc66aaec-36f2-4207-9962-45a2dadd93a3"),
                    new DateOnly(2024, 3, 21),
                    new TimeOnly(14, 0),
                    new TimeOnly(16, 0)
                ),
            ]);
    }
}
