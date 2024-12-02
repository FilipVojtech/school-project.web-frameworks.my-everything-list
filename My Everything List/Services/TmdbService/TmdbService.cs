using System.Net;
using System.Text.Json;
using RestSharp;

namespace My_Everything_List.Services.TmdbService;

public class TmdbService : ITmdbService
{
    private readonly int _apiVersion = 3;
    private static readonly string TmdbUrl = "https://api.themoviedb.org/";
    private readonly RestClient _client = new(TmdbUrl);

    private readonly string _imageBaseUrl;

    public TmdbService(string apiKey)
    {
        _client
            .AddDefaultHeader("Authorization", $"Bearer {apiKey}")
            .AddDefaultHeader("Accept", "application/json");

        var result = _client.ExecuteAsync<Configuration>(BuildRequest(TmdbEndpoint.Config));
        result.Wait();
        _imageBaseUrl = result.Result.Data!.images.secure_base_url;
    }

    /// <summary>
    /// Builds the request and adds parameters
    /// </summary>
    /// <param name="endpoint">The endpoint to request the data from</param>
    /// <param name="parameters">Optional parameters to add to the request</param>
    /// <returns>Request to the TMDB API.</returns>
    private RestRequest BuildRequest(string endpoint, IEnumerable<KeyValuePair<string, string>>? parameters = null)
    {
        var request = new RestRequest($"{_apiVersion}/{endpoint}");

        if (parameters != null)
        {
            foreach (var parameter in parameters)
            {
                request.AddParameter(parameter.Key, parameter.Value);
            }
        }

        return request;
    }

    /// <inheritdoc cref="ITmdbService.GetFilm"/>
    public async Task<Film?> GetFilm(int id)
    {
        List<KeyValuePair<string, string>> parms = [new("append_to_response", "credits")];
        var result = await _client.ExecuteAsync(BuildRequest(TmdbEndpoint.GetFilm(id), parms));

        if (result.StatusCode != HttpStatusCode.OK || result.Content == null)
        {
            Console.WriteLine("Request did not return status code 200 or result is null");
            return null;
        }

        return JsonSerializer.Deserialize<Film>(result.Content);
    }

    /// <inheritdoc cref="ITmdbService.SearchFilm"/>
    public async Task<FilmSearchResult?> SearchFilm(string query)
    {
        var result = await _client.ExecuteAsync(BuildRequest(TmdbEndpoint.SearchFilm(query)));

        if (result.StatusCode != HttpStatusCode.OK || result.Content == null)
        {
            return null;
        }

        var films = JsonSerializer.Deserialize<FilmSearchResult>(result.Content);
        if (films?.results != null)
        {
            Array.Sort(films.results, (film, film1) => film1.popularity.CompareTo(film.popularity));
        }

        return films;
    }

    /// <inheritdoc cref="ITmdbService.ConstructImageUrl"/>
    public string ConstructImageUrl(string filePath)
    {
        return $"{_imageBaseUrl}original{filePath}";
    }
}
