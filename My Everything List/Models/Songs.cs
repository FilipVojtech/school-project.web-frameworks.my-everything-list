using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

public class Songs : MusicItem
{
    public Songs(string name, string? image, string artist) : base(name, image)
    {
        Artist = artist;
    }

    public override MusicItemType ItemType { get; set; } = MusicItemType.Track;

    [Column("artist")]
    public string Artist { get; set; }
}
