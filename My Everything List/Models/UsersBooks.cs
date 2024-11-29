using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("users_books")]
public class UsersBooks
{
    [Column("user_id")] public int UserId { get; set; }

    [Column("book_id")] public int BookId { get; set; }

    public virtual User User { get; }

    public virtual Book Book { get; }

    [Column("rating")]
    [Range(0, 5)]
    [DefaultValue(0)]
    public int Rating { get; set; } = 0;
}
