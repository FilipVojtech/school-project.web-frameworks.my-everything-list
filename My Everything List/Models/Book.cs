using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("books")]
public class Book
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    public string Title { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("authors")]
    public string[] Authors { get; set; }

    [Column("image")]
    [DataType(DataType.Url)]
    public string? Image { get; set; }

    [Column("isbn")]
    public string? Isbn { get; set; }
}
