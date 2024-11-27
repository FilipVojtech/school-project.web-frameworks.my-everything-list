using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

public class Song : MusicItem, IEquatable<Song>, IComparable<Song>
{
    public Song(string name, string? image, string artist) : base(name, image)
    {
        Artist = artist;
    }

    public override MusicItemType ItemType { get; set; } = MusicItemType.Track;

    [Column("artist")] public string Artist { get; set; }

    #region Equals & HashCode

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

    public static bool operator ==(Song? left, Song? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Song? left, Song? right)
    {
        return !Equals(left, right);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), Artist);
    }

    #endregion

    #region Comparators

    public int CompareTo(Song? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (other is null) return 1;
        var musicItemComparison = base.CompareTo(other);
        if (musicItemComparison != 0) return musicItemComparison;
        var itemTypeComparison = ItemType.CompareTo(other.ItemType);
        if (itemTypeComparison != 0) return itemTypeComparison;
        return string.Compare(Artist, other.Artist, StringComparison.Ordinal);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is Song other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Song)}");
    }

    #endregion
}
