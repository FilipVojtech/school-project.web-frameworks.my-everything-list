using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using My_Everything_List.Services.GoogleBooksService;

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

    public Book()
    {
        Title = string.Empty;
        Authors = [];
    }

    public Book(string title, string? description, string[] authors, string? image, string? isbn)
    {
        Title = title;
        Description = description;
        Authors = authors;
        Image = image;
        Isbn = isbn;
    }

    public Book(Volume volume)
    {
        var volumeInfo = volume.volumeInfo;
        Title = volumeInfo.title;
        Description = volumeInfo.description;
        Authors = volumeInfo.authors;
        if (volumeInfo.imageLinks != null && volumeInfo.imageLinks.thumbnail != null)
        {
            Image = volumeInfo.imageLinks.thumbnail;
        }
        Isbn = volumeInfo.industryIdentifiers.FirstOrDefault()?.identifier ?? null;
    }
}
