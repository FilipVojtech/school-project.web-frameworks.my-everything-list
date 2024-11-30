using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("film")]
public class Film : IEquatable<Film>, IComparable<Film>, IComparable
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    [Column("tmdb_id")]
    public int TmdbId { get; set; }

    [Column("title")] [StringLength(64)] public string? Title { get; set; }

    [Column("release_date")] public DateOnly ReleaseDate { get; set; }

    [Column("genres")] public List<string> Genres { get; set; }

    [Column("description")]
    [StringLength(512)]
    public string? Description { get; set; }

    [Column("image")]
    [DataType(DataType.Url)]
    [StringLength(32)]
    public string? Image { get; set; }

    public List<User> SavedBy { get; } = default!;

    public List<UsersFilms> UsersFilms { get; } = default!;

    public Film(int tmdbId, string? title, DateOnly releaseDate, string[] genres, string? description, string? image)
    {
        TmdbId = tmdbId;
        Title = title;
        ReleaseDate = releaseDate;
        Genres = [..genres];
        Description = description;
        Image = image;
    }

    public Film(Services.TmdbService.Film tmdbFilm)
    {
        TmdbId = tmdbFilm.id;
        Title = tmdbFilm.title;
        ReleaseDate = DateOnly.Parse(tmdbFilm.release_date);
        Genres = tmdbFilm.genres?.Select(genre => genre.name).ToList() ?? [];
        Description = tmdbFilm.overview;
        Image = tmdbFilm.poster_path;
    }

    public Film()
    {
        Genres = [];
    }

    #region Equals & Hashcode

    public bool Equals(Film? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Title == other.Title && ReleaseDate.Equals(other.ReleaseDate);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Film)obj);
    }

    public static bool operator ==(Film left, Film right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Film left, Film right)
    {
        return !left.Equals(right);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, ReleaseDate, Genres);
    }

    #endregion

    #region Coparators

    public int CompareTo(Film? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (other is null) return 1;
        var titleComparison = string.Compare(Title, other.Title, StringComparison.Ordinal);
        if (titleComparison != 0) return titleComparison;
        return ReleaseDate.CompareTo(other.ReleaseDate);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is Film other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Film)}");
    }

    #endregion
}
