using Microsoft.EntityFrameworkCore;
using My_Everything_List.Models;

namespace My_Everything_List.Data;

public class MyEverythingListContext : DbContext
{
    public MyEverythingListContext(DbContextOptions<MyEverythingListContext> options)
        : base(options)
    {
    }

    public DbSet<Film> Film { get; set; } = default!;

    public DbSet<User> User { get; set; } = default!;

    public DbSet<Book> Books { get; set; } = default!;

    public DbSet<MusicItem> MusicItems { get; set; } = default!;

    public DbSet<UsersFilms> UsersFilms { get; set; } = default!;

    public DbSet<UsersBooks> UsersBooks { get; set; } = default!;

    public DbSet<UsersMusic> UsersMusic { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Book
        modelBuilder.Entity<Book>()
            .HasMany(b => b.SavedBy)
            .WithMany(u => u.SavedBooks)
            .UsingEntity<UsersBooks>();
        // Film
        modelBuilder.Entity<Film>()
            .HasMany(f => f.SavedBy)
            .WithMany(u => u.SavedFilms)
            .UsingEntity<UsersFilms>();
        // MusicItem
        modelBuilder.Entity<MusicItem>(entity =>
        {
            entity
                .HasDiscriminator(e => e.ItemType);
            entity
                .HasMany(m => m.SavedBy)
                .WithMany(u => u.SavedMusic)
                .UsingEntity<UsersMusic>();
        });

        // Artists
        modelBuilder.Entity<Artist>()
            .HasDiscriminator(a => a.ItemType)
            .HasValue(MusicItemType.Artist);

        // Albums
        modelBuilder.Entity<Album>()
            .HasDiscriminator(a => a.ItemType)
            .HasValue(MusicItemType.Album);
        modelBuilder.Entity<Album>()
            .Property(a => a.Artist)
            .HasColumnName("artist");

        // Songs
        modelBuilder.Entity<Song>()
            .HasDiscriminator(s => s.ItemType)
            .HasValue(MusicItemType.Track);
        modelBuilder.Entity<Song>()
            .Property(s => s.Artist)
            .HasColumnName("artist");

        // User Books
        modelBuilder.Entity<UsersBooks>(entity =>
        {
            entity
                .HasOne(ub => ub.Book)
                .WithMany(b => b.UsersBooks);
            entity
                .HasOne(ub => ub.User)
                .WithMany(u => u.UsersBooks);
        });
        // User Films
        modelBuilder.Entity<UsersFilms>(entity =>
        {
            entity
                .HasOne(uf => uf.Film)
                .WithMany(f => f.UsersFilms);
            entity
                .HasOne(uf => uf.User)
                .WithMany(u => u.UsersFilms);
        });
        // User Music
        modelBuilder.Entity<UsersMusic>(entity =>
        {
            entity
                .HasOne(um => um.MusicItem)
                .WithMany(m => m.UsersMusic);
            entity
                .HasOne(um => um.User)
                .WithMany(u => u.UsersMusic);
        });
    }
}
