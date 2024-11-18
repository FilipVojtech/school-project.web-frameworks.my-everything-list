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
}
