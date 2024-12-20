namespace My_Everything_List.Models;

public class Artist : MusicItem, IEquatable<Artist>
{
    public Artist(string name, string? image) : base(name, image)
    {
    }

    public override MusicItemType ItemType { get; set; } = MusicItemType.Artist;

    #region Equals & HashCode

    public bool Equals(Artist? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return base.Equals(other);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Artist)obj);
    }

    public static bool operator ==(Artist left, Artist right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Artist left, Artist right)
    {
        return !left.Equals(right);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), (int)ItemType);
    }

    #endregion
}
