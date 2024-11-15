using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

public class Film
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public string? Genre { get; set; }
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}
