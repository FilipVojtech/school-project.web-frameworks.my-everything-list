using Microsoft.EntityFrameworkCore;

namespace My_Everything_List.Data
{
    public class My_Everything_ListContext : DbContext
    {
        public My_Everything_ListContext (DbContextOptions<My_Everything_ListContext> options)
            : base(options)
        {
        }

        public DbSet<My_Everything_List.Models.Film> Film { get; set; } = default!;
    }
}
