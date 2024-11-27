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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MusicItem>()
            .HasDiscriminator(e => e.ItemType);

        modelBuilder.Entity<Artist>()
            .HasDiscriminator(a => a.ItemType)
            .HasValue(MusicItemType.Artist);

        modelBuilder.Entity<Album>()
            .HasDiscriminator(a => a.ItemType)
            .HasValue(MusicItemType.Album);
        modelBuilder.Entity<Album>()
            .Property(a => a.Artist)
            .HasColumnName("artist");

        modelBuilder.Entity<Song>()
            .HasDiscriminator(s => s.ItemType)
            .HasValue(MusicItemType.Track);
        modelBuilder.Entity<Song>()
            .Property(s => s.Artist)
            .HasColumnName("artist");
    }
}
