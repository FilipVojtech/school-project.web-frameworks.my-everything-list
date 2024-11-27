namespace My_Everything_List.Models;

public class Artist : MusicItem
{
    public Artist(string name, string? image) : base(name, image)
    {
    }

    public override MusicItemType ItemType { get; set; } = MusicItemType.Artist;
}
