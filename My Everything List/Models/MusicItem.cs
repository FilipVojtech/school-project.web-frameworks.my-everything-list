using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("music_items")]
public abstract class MusicItem : IEquatable<MusicItem>, IComparable<MusicItem>, IComparable
{
    protected MusicItem(string name, string? image)
    {
        Name = name;
        Image = image;
    }

    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("name")] public string Name { get; set; }

    [Column("mbid")] public Guid Mbid { get; set; }

    [Column("item_type")] public abstract MusicItemType ItemType { get; set; }

    [Column("image")]
    [DataType(DataType.Url)]
    public string? Image { get; set; }

    public List<User> SavedBy { get; } = default!;

    public List<UsersMusic> UsersMusic { get; } = default!;

    #region Equals & HashCode

    public bool Equals(MusicItem? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name && ItemType == other.ItemType;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((MusicItem)obj);
    }

    public static bool operator ==(MusicItem left, MusicItem right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(MusicItem left, MusicItem right)
    {
        return !left.Equals(right);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, (int)ItemType);
    }

    #endregion

    #region Comparators

    public int CompareTo(MusicItem? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (other is null) return 1;
        return string.Compare(Name, other.Name, StringComparison.Ordinal);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is MusicItem other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(MusicItem)}");
    }

    #endregion
}
