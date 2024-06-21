using BookRecommendationSystemAI.Domain.Model.Entities;
using BookRecommendationSystemAI.Infra.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BookRecommendationSystemAI.Infra.Context;

public class PostgresDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    
    public DbSet<Book> Books { get; set; }
    
    public PostgresDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
        {
            return;
        }
        
        var connectionString = _configuration.GetConnectionString("DefaultConnectionString");
        optionsBuilder.UseNpgsql(connectionString);
        optionsBuilder.UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(x => x.Id).IsUnique();
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id)
                .HasValueGenerator<UlidValueGenerator>()
                .IsRequired()
                .ValueGeneratedOnAdd();

            entity.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(x => x.Author)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(x => x.PublicationYear)
                .IsRequired();
        });
    }
}