using System.Net;
using System.Text.Json;
using RestSharp;

namespace My_Everything_List.Services.GoogleBooksService;

public class GoogleBooksService : IGoogleBooksService
{
    private const string GBooksUrl = "https://www.googleapis.com";
    private readonly RestClient _client = new(GBooksUrl);

    public GoogleBooksService()
    {
        _client.AddDefaultHeader("Accept", "application/json");
    }

    /// <summary>
    /// Builds the request and adds parameters
    /// </summary>
    /// <param name="endpoint">The endpoint to request the data from</param>
    /// <param name="parameters">Optional parameters to add to the request</param>
    /// <returns>Request to the TMDB API.</returns>
    private RestRequest BuildRequest(string endpoint, IEnumerable<KeyValuePair<string, string>>? parameters = null)
    {
        var request = new RestRequest($"{endpoint}");

        if (parameters != null)
        {
            foreach (var parameter in parameters)
            {
                request.AddParameter(parameter.Key, parameter.Value);
            }
        }

        return request;
    }

    public async Task<Volume?> GetBook(string id)
    {
        var result = await _client.ExecuteAsync(BuildRequest(GoogleBooksEndpoint.GetBook(id)));

        if (result.StatusCode != HttpStatusCode.OK || result.Content == null)
        {
            return null;
        }

        var book = JsonSerializer.Deserialize<Volume>(result.Content);

        return book;
    }

    public async Task<BookSearchResult?> Search(string query)
    {
        var parameters = new List<KeyValuePair<string, string>> { new("q", query) };
        var result = await _client.ExecuteAsync(BuildRequest(GoogleBooksEndpoint.SearchBook, parameters));

        if (result.StatusCode != HttpStatusCode.OK || result.Content == null)
        {
            return null;
        }

        var books = JsonSerializer.Deserialize<BookSearchResult>(result.Content);

        return books;
    }
}
