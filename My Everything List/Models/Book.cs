using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using My_Everything_List.Services.GoogleBooksService;

namespace My_Everything_List.Models;

[Table("books")]
public class Book : IEquatable<Book>, IComparable<Book>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")] public string Title { get; set; }

    [Column("description")] public string? Description { get; set; }

    [Column("authors")] public string[] Authors { get; set; }

    [Column("image")]
    [DataType(DataType.Url)]
    public string? Image { get; set; }

    [Column("isbn")] public string? Isbn { get; set; }

    public ICollection<User> SavedBy { get; set; } = default!;

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

    #region Equals & HashCode

    public bool Equals(Book? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Title == other.Title && Authors.SequenceEqual(other.Authors) && Isbn == other.Isbn;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Book)obj);
    }

    public static bool operator ==(Book left, Book right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Book left, Book right)
    {
        return !left.Equals(right);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, Authors, Isbn);
    }

    #endregion

    #region Comparators

    public int CompareTo(Book? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (other is null) return 1;
        return string.Compare(Title, other.Title, StringComparison.Ordinal);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is Book other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Book)}");
    }

    #endregion
}
