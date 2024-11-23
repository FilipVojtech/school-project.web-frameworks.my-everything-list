namespace My_Everything_List.Services.TmdbService;

public interface ITmdbService
{
    /// <summary>
    /// Get film by ID
    /// </summary>
    /// <param name="id">ID of the film</param>
    /// <returns>Film corresponding to the ID</returns>
    Task<Film?> GetFilm(int id);

    /// <summary>
    /// Search for films
    /// </summary>
    /// <param name="query">Search string to look up</param>
    /// <returns>Search results</returns>
    Task<FilmSearchResult?> SearchFilm(string query);

    /// <summary>
    /// Constructs full URL to a film image from TMDB
    /// </summary>
    /// <param name="filePath">The original file path included in the film details</param>
    /// <returns>Full URL to the image</returns>
    string ConstructImageUrl(string filePath);
}
