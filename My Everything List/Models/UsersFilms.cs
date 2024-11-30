using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("users_films")]
public class UsersFilms
{
    [Column("user_id")] public int UserId { get; set; }

    [Column("film_id")] public int FilmId { get; set; }

    public virtual User User { get; }

    public virtual Film Film { get; }

    [Column("rating")]
    [Range(0, 5)]
    [DefaultValue(0)]
    public int Rating { get; set; } = 0;
}
