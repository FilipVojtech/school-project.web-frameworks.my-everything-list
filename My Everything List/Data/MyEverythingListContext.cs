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

    public DbSet<Artist> Artists { get; set; } = default!;

    public DbSet<Album> Albums { get; set; } = default!;

    public DbSet<Song> Songs { get; set; } = default!;
}
