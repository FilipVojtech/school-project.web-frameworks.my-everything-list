using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("music_items")]
public abstract class MusicItem
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

    [Column("name")]
    public string Name { get; set; }

    [Column("item_type")]
    public abstract MusicItemType ItemType { get; set; }

    [Column("image")]
    [DataType(DataType.Url)]
    public string? Image { get; set; }
}
