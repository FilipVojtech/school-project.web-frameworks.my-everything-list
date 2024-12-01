using My_Everything_List.Models;

namespace My_Everything_List.Services.LastfmService;

public interface ILastfmService
{
    /// <summary>
    /// Search for artists
    /// </summary>
    /// <param name="artist">Query</param>
    /// <returns>List of result artists</returns>
    Task<ArtistsSearchResults?> SearchArtists(string artist);

    /// <summary>
    /// Get artist data
    /// </summary>
    /// <param name="artist">The artist whose data should be returned</param>
    /// <returns>The artist data</returns>
    Task<LfmArtist?> GetArtist(Artist artist);

    /// <summary>
    /// Get currently top artists
    /// </summary>
    /// <returns>List of artists</returns>
    Task<object> GetTopArtists();

    /// <summary>
    /// Search for albums
    /// </summary>
    /// <param name="album">Query</param>
    /// <returns>List of search result albums</returns>
    Task<AlbumsSearchResults?> SearchAlbums(string album);

    /// <summary>
    /// Get album info
    /// </summary>
    /// <param name="album">Album which data should be fetched</param>
    /// <returns></returns>
    Task<LfmAlbum?> GetAlbum(Album album);

    /// <summary>
    /// Search for songs
    /// </summary>
    /// <param name="song">Query</param>
    /// <returns>List of search result tracks</returns>
    Task<TracksSearchResults?> SearchSongs(string song);

    /// <summary>
    /// Get track info
    /// </summary>
    /// <param name="song">Track which data should be fetched</param>
    /// <returns>Song</returns>
    Task<LfmTrack?> GetSong(Song song);

    /// <summary>
    /// Get currently top tracks
    /// </summary>
    /// <returns>List of top tracks</returns>
    Task<object> GetTopTracks();
}
