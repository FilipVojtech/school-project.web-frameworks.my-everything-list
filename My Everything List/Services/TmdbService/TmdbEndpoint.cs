namespace My_Everything_List.Services.TmdbService;

internal static class TmdbEndpoint
{
    public static string GetFilm(int movieId) => $"movie/{movieId}";
    public static string SearchFilm(string query) => $"search/movie?query={query}";
    public static string Config = "configuration";
}
