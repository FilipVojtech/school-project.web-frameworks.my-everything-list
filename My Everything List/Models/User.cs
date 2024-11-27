using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("users")]
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

    public static bool operator ==(User? left, User? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(User? left, User? right)
    {
        return !Equals(left, right);
    }

    public override int GetHashCode()
    {
        return (Email != null ? Email.GetHashCode() : 0);
    }

    #endregion
}
