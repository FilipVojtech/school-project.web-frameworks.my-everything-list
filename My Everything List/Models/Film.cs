using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("film")]
public class Film
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("title")] public string? Title { get; set; }
    [Column("release_date")] public DateOnly ReleaseDate { get; set; }
    [Column("genre")] public string? Genre { get; set; }

    [DataType(DataType.Currency)]
    [Column("price", TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}
