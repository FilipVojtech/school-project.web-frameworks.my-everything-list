using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

public class Song : MusicItem, IEquatable<Song>
{
    public Song(string name, string? image, string artist) : base(name, image)
    {
        Artist = artist;
    }

    public override MusicItemType ItemType { get; set; } = MusicItemType.Track;

    [Column("artist")] public string Artist { get; set; }

    public bool Equals(Song? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return base.Equals(other) && Artist == other.Artist;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Song)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), Artist);
    }

    public static bool operator ==(Song? left, Song? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Song? left, Song? right)
    {
        return !Equals(left, right);
    }
}
