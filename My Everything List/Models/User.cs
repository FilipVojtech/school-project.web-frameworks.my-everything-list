using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Column("email")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [Column("password")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Column("role")] public UserRole? Role { get; set; } = UserRole.User;

    public enum UserRole
    {
        User,
        Admin
    }
}
