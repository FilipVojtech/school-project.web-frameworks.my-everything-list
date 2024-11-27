using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Everything_List.Models;

[Table("film")]
public class Film
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

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

    public Film(string? title, DateOnly releaseDate, string[] genres, string? description, string? image)
    {
        Title = title;
        ReleaseDate = releaseDate;
        Genres = [..genres];
        Description = description;
        Image = image;
    }

    public Film(Services.TmdbService.Film tmdbFilm)
    {
        Title = tmdbFilm.title;
        ReleaseDate = DateOnly.Parse(tmdbFilm.release_date);
        Genres = tmdbFilm.genres.Select(genre => genre.name).ToList();
        Description = tmdbFilm.tagline;
        Image = tmdbFilm.poster_path;
    }
}
