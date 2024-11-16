using Microsoft.EntityFrameworkCore;

namespace My_Everything_List.Data;

public class MyEverythingListContext : DbContext
{
    public MyEverythingListContext (DbContextOptions<MyEverythingListContext> options)
        : base(options)
    {
    }

    public DbSet<Models.Film> Film { get; set; } = default!;
}
