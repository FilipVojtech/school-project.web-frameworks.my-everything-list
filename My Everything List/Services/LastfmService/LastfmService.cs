using System.Net;
using System.Xml;
using System.Xml.Serialization;
using My_Everything_List.Models;
using RestSharp;

namespace My_Everything_List.Services.LastfmService;

public class LastfmService : ILastfmService
{
    private const string LastfmUrl = "https://ws.audioscrobbler.com/{api_version}/";
    private readonly RestClient _client = new(LastfmUrl);

    public LastfmService(string lastfmApiKey)
    {
        _client
            .AddDefaultParameter("raw", "on")
            .AddDefaultParameter("api_key", lastfmApiKey)
            .AddDefaultUrlSegment("api_version", "2.0")
            .AddDefaultHeader("Accept", "application/xml");
    }

    private RestRequest BuildRequest(string method, IEnumerable<KeyValuePair<string, string>>? parameters = null)
    {
        var request = new RestRequest();

        request.AddParameter("method", method);

        if (parameters != null)
        {
            foreach (var parameter in parameters)
            {
                request.AddParameter(parameter.Key, parameter.Value);
            }
        }

        return request;
    }

    private string? UnwrapRootNode(string? resultContent)
    {
        if (resultContent == null)
        {
            return null;
        }

        // Add missing xml namespace attribute to results tag
        resultContent = resultContent.Replace("<results",
            "<results xmlns:opensearch=\"https://a9.com/-/spec/opensearch/1.1/\"");

        var doc = new XmlDocument();
        doc.LoadXml(resultContent);

        // Extract results tag and return
        var resultsNode = doc["lfm"]?["results"] ?? null;
        doc.ReplaceChild(resultsNode, doc["lfm"]);
        resultContent = doc.OuterXml;

        // resultContent = resultContent.Replace("<results xmlns:opensearch=\"https://a9.com/-/spec/opensearch/1.1/\"",
        // "<results");
        return resultContent;
    }

    public async Task<ArtistsSearchResults?> SearchArtists(string artist)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("artist", artist)
        };

        var result = await _client.ExecuteAsync(BuildRequest(LastfmMethods.SearchArtist, parameters));

        if (result.StatusCode != HttpStatusCode.OK || result.Content == null)
        {
            return null;
        }

        var content = UnwrapRootNode(result.Content);

        if (string.IsNullOrWhiteSpace(content)) return null;

        var serializer = new XmlSerializer(typeof(ArtistsSearchResults));

        using (StringReader sr = new(content))
        {
            var deserialized = (ArtistsSearchResults?)serializer.Deserialize(sr);
            return deserialized;
        }
    }

    public async Task<LfmArtist?> GetArtist(Artist artist)
    {
        List<KeyValuePair<string, string>> parameters = [];

        if (artist.Mbid is not null) parameters.Add(new("mbid", artist.Mbid.ToString()));
        else parameters.Add(new("artist", artist.Name));

        var result = await _client.ExecuteAsync(BuildRequest(LastfmMethods.GetArtist, parameters));

        if (result.StatusCode != HttpStatusCode.OK || result.Content == null)
        {
            return null;
        }

        var serializer = new XmlSerializer(typeof(LfmForArtist));

        using (StringReader sr = new(result.Content))
        {
            var deserialized = (LfmForArtist?)serializer.Deserialize(sr);
            return deserialized?.artist;
        }
    }

    public async Task<AlbumsSearchResults?> SearchAlbums(string album)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("album", album)
        };

        var result = await _client.ExecuteAsync(BuildRequest(LastfmMethods.SearchAlbum, parameters));

        if (result.StatusCode != HttpStatusCode.OK || result.Content == null)
        {
            return null;
        }

        var content = UnwrapRootNode(result.Content);

        if (string.IsNullOrWhiteSpace(content)) return null;

        var serializer = new XmlSerializer(typeof(AlbumsSearchResults));

        using (StringReader sr = new(content))
        {
            var deserialized = (AlbumsSearchResults?)serializer.Deserialize(sr);
            return deserialized;
        }
    }

    public async Task<LfmAlbum?> GetAlbum(Album album)
    {
        List<KeyValuePair<string, string>> parameters = [];

        if (album.Mbid is not null) parameters.Add(new("mbid", album.Mbid.ToString()));
        else
        {
            parameters.Add(new("artist", album.Artist));
            parameters.Add(new("album", album.Name));
        }

        var result = await _client.ExecuteAsync(BuildRequest(LastfmMethods.GetAlbum, parameters));

        if (result.StatusCode != HttpStatusCode.OK || result.Content == null)
        {
            return null;
        }

        var serializer = new XmlSerializer(typeof(LfmForAlbum));

        using (StringReader sr = new(result.Content))
        {
            var deserialized = (LfmForAlbum?)serializer.Deserialize(sr);
            return deserialized?.album;
        }
    }

    public async Task<SongsSearchResults?> SearchSongs(string song)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("track", song)
        };

        var result = await _client.ExecuteAsync(BuildRequest(LastfmMethods.SearchTrack, parameters));

        if (result.StatusCode != HttpStatusCode.OK || result.Content == null)
        {
            return null;
        }

        var content = UnwrapRootNode(result.Content);

        if (string.IsNullOrWhiteSpace(content)) return null;

        var serializer = new XmlSerializer(typeof(SongsSearchResults));

        using (StringReader sr = new(content))
        {
            var deserialized = (SongsSearchResults?)serializer.Deserialize(sr);
            return deserialized;
        }
    }
}
