using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("email")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [Column("password")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Column("role")] public string? Role { get; set; } = "User";

    public ICollection<Film> SavedFilms { get; set; } = [];

    public ICollection<Book> SavedBooks { get; set; } = [];

    public ICollection<MusicItem> SavedMusic { get; set; } = [];

    public User()
    {
    }

    public User(string? email, string? password, string? role)
    {
        Email = email;
        Password = password;
        Role = role;
    }
}
