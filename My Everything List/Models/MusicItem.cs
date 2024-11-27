using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("music_items")]
public abstract class MusicItem : IEquatable<MusicItem>
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

    [Column("item_type")] public abstract MusicItemType ItemType { get; set; }

    [Column("image")]
    [DataType(DataType.Url)]
    public string? Image { get; set; }

    public ICollection<User>? SavedBy { get; set; } = default!;

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

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, (int)ItemType);
    }

    public static bool operator ==(MusicItem? left, MusicItem? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(MusicItem? left, MusicItem? right)
    {
        return !Equals(left, right);
    }
}
