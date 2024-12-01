using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("music_items")]
public abstract class MusicItem : IEquatable<MusicItem>, IComparable<MusicItem>
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

    [Column("mbid")] public Guid? Mbid { get; set; }

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

    #endregion
}
