using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("users_music")]
public class UsersMusic
{
    [Column("user_id")] public int UserId { get; set; }

    [Column("music_id")] public int MusicItemId { get; set; }

    public virtual User User { get; }

    public virtual MusicItem MusicItem { get; }

    [Column("rating")]
    [Range(0, 5)]
    [DefaultValue(0)]
    public int Rating { get; set; } = 0;

    [Column("added_at")]
    [DataType(DataType.DateTime)]
    public DateTime AddedAt { get; } = DateTime.Now;
}
