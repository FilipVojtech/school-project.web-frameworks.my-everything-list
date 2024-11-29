using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace My_Everything_List.Models;

[Table("users")]
[Index(nameof(Email), IsUnique = true)]
public class User : IEquatable<User>
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

    [Column("role")] [StringLength(5)] public string? Role { get; set; } = "User";

    public List<Film> SavedFilms { get; } = [];

    public List<UsersFilms> UsersFilms { get; } = [];

    public List<Book> SavedBooks { get; } = [];

    public List<UsersBooks> UsersBooks { get; } = [];

    public List<MusicItem> SavedMusic { get; } = [];

    public List<UsersMusic> UsersMusic { get; } = [];

    public User()
    {
    }

    public User(string? email, string? password, string? role)
    {
        Email = email;
        Password = password;
        Role = role;
    }

    #region Equals & HashCode

    public bool Equals(User? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Email == other.Email;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((User)obj);
    }

    public static bool operator ==(User left, User right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(User left, User right)
    {
        return !left.Equals(right);
    }

    public override int GetHashCode()
    {
        return (Email != null ? Email.GetHashCode() : 0);
    }

    #endregion
}
